using System.Collections.Generic;
using System.Drawing;
using MediaPortal.Configuration;
using MediaPortal.Player;
using MediaPortal.GUI.Library;
using MediaPortal.Profile;
using Microsoft.DirectX.Direct3D;
using System.Threading;

namespace IntelligentFrameCorrection
{
    public abstract class Screen
    {
        protected IScreenBehavior screenBehavior;
        protected IFrameAnalyzer frameAnalyzer = new FrameAnalyzer();

        /// <summary>
        /// original found bounds
        /// </summary>
        protected Rectangle bounds;

        /// <summary>
        /// adjusted bounds, converted from bounds to cropsettings
        /// </summary>
        protected Rectangle adjustedbounds;

        /// <summary>
        /// actual crop settings (fade to)
        /// </summary>
        protected CropSettings cropsettings = new CropSettings();

        protected Dictionary<AspectRatios, int> bestMatchedAspectRatio = new Dictionary<AspectRatios, int>();

        private readonly Dictionary<int, int> bestMatchedCropSettingTop = new Dictionary<int, int>();
        private readonly Dictionary<int, int> bestMatchedCropSettingBottom = new Dictionary<int, int>();
        private readonly Dictionary<int, int> bestMatchedCropSettingLeft = new Dictionary<int, int>();
        private readonly Dictionary<int, int> bestMatchedCropSettingRight = new Dictionary<int, int>();

        protected CustomViewMode lastCustomViewMode { get; set; }
        protected AspectRatios lastAspectRatio { get; set; }

        protected AdapterInformation currentFullscreenAdapterInfo = GUIGraphicsContext.currentFullscreenAdapterInfo;

        public void setFrameAnalyzer(IFrameAnalyzer pFrameAnalyzer)
        {
            frameAnalyzer = pFrameAnalyzer;
        }

        internal void performIfc()
        {
            if (Preferences.getInstance().isBlackBarScannerEnabled)
            {
                screenBehavior.performIntelligentFrameCorrection();
            }
            else
            {
                setViewMode(frameAnalyzer.getAspectRatio());
            }
        }

        public abstract bool screenSetup();

        protected bool baseScreenSetup()
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> baseScreenSetup");
            if (FrameAnalyzer.isTV())
            {
                cropsettings.Top = Preferences.getInstance().tvCropSettings.Top;
                cropsettings.Bottom = Preferences.getInstance().tvCropSettings.Bottom;
                cropsettings.Left = Preferences.getInstance().tvCropSettings.Left;
                cropsettings.Right = Preferences.getInstance().tvCropSettings.Right;
            }
            else
            {
                cropsettings.Top = Preferences.getInstance().videoCropSettings.Top;
                cropsettings.Bottom = Preferences.getInstance().videoCropSettings.Bottom;
                cropsettings.Left = Preferences.getInstance().videoCropSettings.Left;
                cropsettings.Right = Preferences.getInstance().videoCropSettings.Right;
            }
            Utils.log(Preferences.getInstance().verboselogging, "RenderBlackImage: {0}",
                      GUIGraphicsContext.RenderBlackImage);

            while (GUIGraphicsContext.RenderBlackImage)
            {
                if (IntelligentFrameCorrection.getInstance.processingThread.CancellationPending)
                {
                    Utils.log(Preferences.getInstance().verboselogging, "Screen Setup stopped");
                    return false;
                }
                Thread.Sleep(1);
            }

            //Don't start processing, if HD content is present
            if (!Preferences.getInstance().isHDSupportEnabled && FrameAnalyzer.isHDContent())
            {
                return false;
            }

            setViewMode(frameAnalyzer.getAspectRatio());
            Utils.log(Preferences.getInstance().verboselogging, "<-- baseScreenSetup");
            return true;
        }

        protected void setViewMode(AspectRatios ar)
        {
            switch (ar)
            {
                case AspectRatios.AR_4_3:
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "4:3 detected");
                        setViewMode(Preferences.getInstance().ViewMode43.ViewMode, Preferences.getInstance().ViewMode43);
                        break;
                    }
                case AspectRatios.AR_4_3_LETTERBOX:
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "4:3 Letterbox detected");
                        setViewMode(Preferences.getInstance().ViewMode43Letterbox.ViewMode,
                                    Preferences.getInstance().ViewMode43Letterbox);
                        break;
                    }
                case AspectRatios.AR_16_9_WITH_SIDEBARS:
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "16:9 with sidebars detected");
                        setViewMode(Preferences.getInstance().ViewMode169WithSidebars.ViewMode,
                                    Preferences.getInstance().ViewMode169WithSidebars);
                        break;
                    }
                case AspectRatios.AR_16_9_LETTERBOX:
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "16:9 Letterbox detected");
                        setViewMode(Preferences.getInstance().ViewMode169Letterbox.ViewMode,
                                    Preferences.getInstance().ViewMode169Letterbox);
                        break;
                    }
                case AspectRatios.AR_16_9:
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "16:9 detected");
                        setViewMode(Preferences.getInstance().ViewMode169.ViewMode,
                                    Preferences.getInstance().ViewMode169);
                        break;
                    }
                case AspectRatios.AR_21_9:
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "21:9 detected");
                        setViewMode(Preferences.getInstance().ViewMode219.ViewMode,
                                    Preferences.getInstance().ViewMode219);
                        break;
                    }
                default:
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "Default view mode used");
                        setViewMode(Preferences.getInstance().ViewModeDefault.ViewMode,
                                    Preferences.getInstance().ViewModeDefault);
                        break;
                    }
            }
            lastAspectRatio = ar;
        }

        private void setViewMode(Geometry.Type arType, CustomViewMode customViewMode)
        {
            if (lastCustomViewMode != customViewMode)
            {
                Utils.log(Preferences.getInstance().verboselogging, "set default view mode: {0}", arType);
                using (var xmlwriter = new Settings(Config.GetFile(Config.Dir.Config, "MediaPortal.xml"), true))
                {
                    string aspectRatio = MediaPortal.Util.Utils.GetAspectRatio(arType);

                    xmlwriter.SetValue("mytv", "defaultar", aspectRatio);
                    xmlwriter.SetValue("movieplayer", "defaultar", aspectRatio);
                    xmlwriter.SetValue("dvdplayer", "defaultar", aspectRatio);
                }

                GUIGraphicsContext.ARType = arType;

                lastCustomViewMode = customViewMode;
            }
            fade();
        }

        public CropSettings boundsToCropSettings()
        {
            if (Preferences.getInstance().stopCounter < Preferences.getInstance().stopCounterEnd)
            {
                addCropSettingTopForBestMatch(bounds.Y);
                addCropSettingBottomForBestMatch(bounds.Height);
                addCropSettingLeftForBestMatch(bounds.X);
                addCropSettingRightForBestMatch(bounds.Width);
            }
            if (Preferences.getInstance().stopCounter == Preferences.getInstance().stopCounterEnd - 1)
            {
                cropsettings.Top = getBestMatchedCropSettingTop();
                cropsettings.Bottom = getBestMatchedCropSettingBottom();
                cropsettings.Left = getBestMatchedCropSettingLeft();
                cropsettings.Right = getBestMatchedCropSettingRight();

                clearBestMatchedCropSettings();
            }

            return cropsettings;
        }

        protected void clearBestMatchedCropSettings()
        {
            bestMatchedCropSettingTop.Clear();
            bestMatchedCropSettingBottom.Clear();
            bestMatchedCropSettingLeft.Clear();
            bestMatchedCropSettingRight.Clear();
        }

        protected void fade()
        {
            //boundsToCropSettings();
            fade(Preferences.getInstance().lastCalcedCropSettings,
                 frameAnalyzer.getToCropSettings(lastCustomViewMode, cropsettings));

            //All done here, so we can clear the Dictionary
            bestMatchedAspectRatio.Clear();
        }

        /// <summary>
        /// Fade between two set CropSettings Objects
        /// </summary>
        /// <param name="from">CropSettings</param>
        /// <param name="to">CropSettings</param>
        private static void fade(CropSettings from, CropSettings to)
        {
            var msg = new GUIMessage
                          {
                              Message = GUIMessage.MessageType.GUI_MSG_PLANESCENE_CROP
                          };
            Utils.log(Preferences.getInstance().verboselogging,
                      "Last faded crop settings: Top: {0}, Bottom: {1}, Left: {2}, Right: {3}",
                      Preferences.getInstance().lastCalcedCropSettings.Top,
                      Preferences.getInstance().lastCalcedCropSettings.Bottom,
                      Preferences.getInstance().lastCalcedCropSettings.Left,
                      Preferences.getInstance().lastCalcedCropSettings.Right);

            while (from.Top != to.Top || from.Bottom != to.Bottom || from.Left != to.Left || from.Right != to.Right)
            {
                if (from.Top > to.Top)
                {
                    from.Top--;
                }
                else if (from.Top < to.Top)
                {
                    from.Top++;
                }

                if (from.Bottom > to.Bottom)
                {
                    from.Bottom--;
                }
                else if (from.Bottom < to.Bottom)
                {
                    from.Bottom++;
                }

                if (from.Left > to.Left)
                {
                    from.Left--;
                }
                else if (from.Left < to.Left)
                {
                    from.Left++;
                }

                if (from.Right > to.Right)
                {
                    from.Right--;
                }
                else if (from.Right < to.Right)
                {
                    from.Right++;
                }

                if (IntelligentFrameCorrection.getInstance.processingThread.CancellationPending)
                {
                    Utils.log(Preferences.getInstance().verboselogging, "fading stopped");
                    return;
                }

                //Send message to planescene with cropsettings
                msg.Object = from;
                GUIWindowManager.SendMessage(msg);
                Thread.Sleep(10);
            }
        }

        protected void addViewModeForBestMatch(AspectRatios aspectRatios)
        {
            if (!bestMatchedAspectRatio.ContainsKey(aspectRatios))
            {
                bestMatchedAspectRatio.Add(aspectRatios, 0);
            }
        }

        public AspectRatios getBestViewModeMatch()
        {
            AspectRatios bestmatchedAr = lastAspectRatio;

            if (bestMatchedAspectRatio.Count > 1)
            {
                Utils.log(Preferences.getInstance().verboselogging, "no best match found, choose the last aspect ratio");
            }
            else
            {
                foreach (var mode in bestMatchedAspectRatio)
                {
                    bestmatchedAr = mode.Key;
                }
            }

            return bestmatchedAr;
        }

        protected void addCropSettingTopForBestMatch(int top)
        {
            if (!bestMatchedCropSettingTop.ContainsKey(top) && bestMatchedCropSettingTop.Count < 2)
            {
                if (bestMatchedCropSettingTop.Count < 1)
                {
                    bestMatchedCropSettingTop.Add(top, top);
                }
                else
                {
                    var tempBestMatchedCropSettingTop = new Dictionary<int, int>(bestMatchedCropSettingTop);

                    foreach (int temp in tempBestMatchedCropSettingTop.Values)
                    {
                        int edgeDetectorTolerance = Preferences.getInstance().edgeDetectorTolerance;

                        if (top > temp + edgeDetectorTolerance || top < temp - edgeDetectorTolerance)
                        {
                            bestMatchedCropSettingTop.Add(top, top);
                        }
                    }
                }
            }
        }

        protected void addCropSettingBottomForBestMatch(int bottom)
        {
            if (!bestMatchedCropSettingBottom.ContainsKey(bottom) && bestMatchedCropSettingBottom.Count < 2)
            {
                if (bestMatchedCropSettingBottom.Count < 1)
                {
                    bestMatchedCropSettingBottom.Add(bottom, bottom);
                }
                else
                {
                    var tempBestMatchedCropSettingBottom = new Dictionary<int, int>(bestMatchedCropSettingBottom);

                    foreach (int temp in tempBestMatchedCropSettingBottom.Values)
                    {
                        int edgeDetectorTolerance = Preferences.getInstance().edgeDetectorTolerance;

                        if (bottom > temp + edgeDetectorTolerance || bottom < temp - edgeDetectorTolerance)
                        {
                            bestMatchedCropSettingBottom.Add(bottom, bottom);
                        }
                    }
                }
            }
        }

        protected void addCropSettingLeftForBestMatch(int left)
        {
            if (!bestMatchedCropSettingLeft.ContainsKey(left) && bestMatchedCropSettingLeft.Count < 2)
            {
                if (bestMatchedCropSettingLeft.Count < 1)
                {
                    bestMatchedCropSettingLeft.Add(left, left);
                }
                else
                {
                    var tempBestMatchedCropSettingLeft = new Dictionary<int, int>(bestMatchedCropSettingLeft);

                    foreach (int temp in tempBestMatchedCropSettingLeft.Values)
                    {
                        int edgeDetectorTolerance = Preferences.getInstance().edgeDetectorTolerance;

                        if (left > temp + edgeDetectorTolerance || left < temp - edgeDetectorTolerance)
                        {
                            bestMatchedCropSettingLeft.Add(left, left);
                        }
                    }
                }
            }
        }

        protected void addCropSettingRightForBestMatch(int right)
        {
            if (!bestMatchedCropSettingRight.ContainsKey(right) && bestMatchedCropSettingRight.Count < 2)
            {
                if (bestMatchedCropSettingRight.Count < 1)
                {
                    bestMatchedCropSettingRight.Add(right, right);
                }
                else
                {
                    var tempBestMatchedCropSettingRight = new Dictionary<int, int>(bestMatchedCropSettingRight);

                    foreach (int temp in tempBestMatchedCropSettingRight.Values)
                    {
                        int edgeDetectorTolerance = Preferences.getInstance().edgeDetectorTolerance;

                        if (right > temp + edgeDetectorTolerance || right < temp - edgeDetectorTolerance)
                        {
                            bestMatchedCropSettingRight.Add(right, right);
                        }
                    }
                }
            }
        }

        protected int getBestMatchedCropSettingTop()
        {
            int bestMatchedTop = Preferences.getInstance().lastCropSettings.Top;

            if (bestMatchedCropSettingTop.Count > 1)
            {
                Utils.log(Preferences.getInstance().verboselogging,
                          "no best match found, choose the last top cropsetting");
            }
            else
            {
                bestMatchedTop = adjustedbounds.Y;
            }


            return bestMatchedTop;
        }

        protected int getBestMatchedCropSettingBottom()
        {
            int bestMatchedBottom = Preferences.getInstance().lastCropSettings.Bottom;

            if (bestMatchedCropSettingBottom.Count > 1)
            {
                Utils.log(Preferences.getInstance().verboselogging,
                          "no best match found, choose the last bottom cropsetting");
            }
            else
            {
                bestMatchedBottom = adjustedbounds.Height;
            }

            return bestMatchedBottom;
        }

        protected int getBestMatchedCropSettingLeft()
        {
            int bestMatchedLeft = Preferences.getInstance().lastCropSettings.Left;

            if (bestMatchedCropSettingLeft.Count > 1)
            {
                Utils.log(Preferences.getInstance().verboselogging,
                          "no best match found, choose the last left cropsetting");
            }
            else
            {
                bestMatchedLeft = adjustedbounds.X;
            }


            return bestMatchedLeft;
        }

        protected int getBestMatchedCropSettingRight()
        {
            int bestMatchedRight = Preferences.getInstance().lastCropSettings.Right;

            if (bestMatchedCropSettingRight.Count > 1)
            {
                Utils.log(Preferences.getInstance().verboselogging,
                          "no best match found, choose the last right cropsetting");
            }
            else
            {
                bestMatchedRight = adjustedbounds.Width;
            }

            return bestMatchedRight;
        }
    }
}