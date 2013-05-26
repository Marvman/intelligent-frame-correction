using MediaPortal.GUI.Library;

namespace IntelligentFrameCorrection
{
    public class Screen16To9 : Screen, IScreenBehavior
    {
        public Screen16To9()
        {
            screenBehavior = this;
        }

        public void performIntelligentFrameCorrection()
        {
            Utils.log(Preferences.getInstance().verboselogging, "Stop Counter: {0}, Stop Counter End: {1}",
                      Preferences.getInstance().stopCounter, Preferences.getInstance().stopCounterEnd);
            scanForBlackBars();
            boundsToCropSettings();

            if (Preferences.getInstance().stopCounter == Preferences.getInstance().stopCounterEnd - 1)
            {
                //set best matched view mode
                setViewMode(getBestViewModeMatch());
            }
        }

        /// <summary>
        /// Scans each side for black bars
        /// </summary>
        /// <returns>isTopSingleBlackBar, isTopDoubleBlackBar, isBottomSingleBlackBar, isBottomDoubleBlackBar, isLeftSingleBlackBar, isRightSingleBlackBar</returns>
        public bool[] scanForBlackBars()
        {
            var isTopSingleBlackBar = false;
            var isBottomSingleBlackBar = false;
            var isTopDoubleBlackBar = false;
            var isBottomDoubleBlackBar = false;
            var isLeftSingleBlackBar = false;
            var isRightSingleBlackBar = false;

            switch (frameAnalyzer.getAspectRatio())
            {
                case AspectRatios.AR_4_3:
                    {
                        //for faster ViewMode change
                        switch (lastAspectRatio)
                        {
                            case AspectRatios.AR_4_3:
                                {
                                    break;
                                }
                            case AspectRatios.AR_4_3_LETTERBOX:
                                {
                                    break;
                                }
                            default:
                                {
                                    Events.DoRestart();
                                    break;
                                }
                        }

                        if (frameAnalyzer.FindBounds(true, true, true, true, ref bounds))
                        {
                            if (Preferences.getInstance().correctAR)
                            {
                                #region check for black bars

                                isTopSingleBlackBar = FrameAnalyzer.isSingleBlackBar(bounds.Y,
                                                                                     frameAnalyzer.getVideoSize().Height);
                                isBottomSingleBlackBar = FrameAnalyzer.isSingleBlackBar(bounds.Height,
                                                                                        frameAnalyzer.getVideoSize().
                                                                                            Height);
                                isTopDoubleBlackBar = FrameAnalyzer.isDoubleBlackBar(bounds.Y,
                                                                                     frameAnalyzer.getVideoSize().Height);
                                isBottomDoubleBlackBar = FrameAnalyzer.isDoubleBlackBar(bounds.Height,
                                                                                        frameAnalyzer.getVideoSize().
                                                                                            Height);

                                #endregion

                                #region Top and bottom is more than a single black bar

                                if (isTopDoubleBlackBar && isBottomDoubleBlackBar)
                                {
                                    TopAndBottomDoubleBarsPattern();
                                    Utils.log(Preferences.getInstance().verboselogging,
                                              "Pattern found (Top and bottom is more than a single black bar)!");
                                    addViewModeForBestMatch(AspectRatios.AR_4_3_LETTERBOX);
                                    break;
                                }

                                #endregion

                                #region Top and Bottom are single bars

                                if (isTopSingleBlackBar && isBottomSingleBlackBar)
                                {
                                    TopAndBottomSingleBarsNoSideBarsPattern();
                                    addViewModeForBestMatch(AspectRatios.AR_4_3_LETTERBOX);
                                    Utils.log(Preferences.getInstance().verboselogging,
                                              "Pattern found (Top and Bottom are single bars)!");
                                    break;
                                }

                                addViewModeForBestMatch(AspectRatios.AR_4_3);

                                #endregion

                                Utils.log(Preferences.getInstance().verboselogging,
                                          "No Pattern found!");
                                addViewModeForBestMatch(AspectRatios.AR_4_3);

                                //only if no black bars were found, then crop the endges
                                if (!isTopSingleBlackBar && !isBottomSingleBlackBar && !isTopDoubleBlackBar &&
                                    !isBottomDoubleBlackBar)
                                {
                                    //set found bounds and adjust
                                    setAdjustedBounds();
                                }
                                else
                                {
                                    interruptScan();
                                }
                            }
                            else //no AR correction
                            {
                                //setAdjustedBounds(ref bounds);
                                addViewModeForBestMatch(AspectRatios.AR_4_3);
                            }
                            Utils.log(Preferences.getInstance().verboselogging, "Found bounds!");
                        }
                        else
                        {
                            Utils.log(Preferences.getInstance().verboselogging, "Found no bounds!");
                        }

                        break;
                    }
                case AspectRatios.AR_16_9:
                    {
                        switch (lastAspectRatio)
                        {
                            case AspectRatios.AR_16_9:
                                {
                                    break;
                                }
                            case AspectRatios.AR_16_9_LETTERBOX:
                                {
                                    break;
                                }
                            case AspectRatios.AR_16_9_WITH_SIDEBARS:
                                {
                                    break;
                                }
                            default:
                                {
                                    Events.DoRestart();
                                    break;
                                }
                        }

                        if (frameAnalyzer.FindBounds(true, true, true, true, ref bounds))
                        {
                            if (Preferences.getInstance().correctAR)
                            {
                                #region check for black bars

                                isTopSingleBlackBar = FrameAnalyzer.isSingleBlackBar(bounds.Y,
                                                                                     frameAnalyzer.getVideoSize().Height);
                                isBottomSingleBlackBar = FrameAnalyzer.isSingleBlackBar(bounds.Height,
                                                                                        frameAnalyzer.getVideoSize().
                                                                                            Height);
                                isLeftSingleBlackBar = FrameAnalyzer.isSideBlackBar(bounds.X,
                                                                                    frameAnalyzer.getVideoSize().Width);
                                isRightSingleBlackBar = FrameAnalyzer.isSideBlackBar(bounds.Width,
                                                                                     frameAnalyzer.getVideoSize().Width);
                                isTopDoubleBlackBar = FrameAnalyzer.isDoubleBlackBar(bounds.Y,
                                                                                     frameAnalyzer.getVideoSize().Height);
                                isBottomDoubleBlackBar = FrameAnalyzer.isDoubleBlackBar(bounds.Height,
                                                                                        frameAnalyzer.getVideoSize().
                                                                                            Height);

                                #endregion

                                #region Top and bottom is more than a single black bar and side bars found

                                if ((isTopDoubleBlackBar && isBottomDoubleBlackBar) &&
                                    (isLeftSingleBlackBar && isRightSingleBlackBar))
                                {
                                    TopAndBottomDoubleBarsPattern();
                                    Utils.log(Preferences.getInstance().verboselogging,
                                              "Pattern found (Top and bottom is more than a single black bar and side bars were found)!");
                                    addViewModeForBestMatch(AspectRatios.AR_16_9_LETTERBOX);
                                    break;
                                }

                                #endregion

                                #region Single black bars Top found / Black bars left not found -> no cropping cause we want correct AR

                                if ((isTopSingleBlackBar && isBottomSingleBlackBar) &&
                                    (!isLeftSingleBlackBar && !isRightSingleBlackBar))
                                {
                                    TopAndBottomSingleBarsNoSideBarsPattern16To9();
                                    Utils.log(Preferences.getInstance().verboselogging,
                                              "Pattern found (Top and bottom are a single black bar with no side black bars)!");
                                    addViewModeForBestMatch(AspectRatios.AR_16_9_LETTERBOX);
                                    break;
                                }

                                #endregion

                                #region Top and bottom black bars not found but left and right black bars

                                if ((!isTopSingleBlackBar && !isBottomSingleBlackBar) &&
                                    (isLeftSingleBlackBar && isRightSingleBlackBar))
                                {
                                    setAdjustedBounds();
                                    addViewModeForBestMatch(AspectRatios.AR_16_9_WITH_SIDEBARS);
                                    Utils.log(Preferences.getInstance().verboselogging,
                                              "Pattern found (No top and bottom single black bar, but side black bars)!");
                                    break;
                                }

                                #endregion

                                #region Single black bars and side black bars found

                                if ((isTopSingleBlackBar && isBottomSingleBlackBar) &&
                                    (isLeftSingleBlackBar && isRightSingleBlackBar))
                                {
                                    setAdjustedBounds();
                                    Utils.log(Preferences.getInstance().verboselogging,
                                              "Pattern found (Top, bottom, left and right single black bars)!");
                                    addViewModeForBestMatch(AspectRatios.AR_16_9_LETTERBOX);
                                    break;
                                }

                                #endregion

                                Utils.log(Preferences.getInstance().verboselogging,
                                          "No Pattern found!");
                                addViewModeForBestMatch(AspectRatios.AR_16_9);

                                //only if no black bars were found, then crop the endges
                                if (!isTopSingleBlackBar && !isBottomSingleBlackBar && !isLeftSingleBlackBar &&
                                    !isRightSingleBlackBar && !isTopDoubleBlackBar && !isBottomDoubleBlackBar)
                                {
                                    //set found bounds and adjust
                                    setAdjustedBounds();
                                }
                                else
                                {
                                    interruptScan();
                                }
                            }
                            else
                            {
                                //setAdjustedBounds(ref bounds);
                                addViewModeForBestMatch(AspectRatios.AR_16_9);
                            }

                            break;
                        }
                        Utils.log(Preferences.getInstance().verboselogging, "Found no bounds!");
                        break;
                    }
                case AspectRatios.AR_21_9:
                    {
                        switch (lastAspectRatio)
                        {
                            case AspectRatios.AR_21_9:
                                {
                                    break;
                                }
                            default:
                                {
                                    Events.DoRestart();
                                    break;
                                }
                        }

                        //set found bounds and adjust
                        setAdjustedBounds();

                        addViewModeForBestMatch(AspectRatios.AR_21_9);
                        break;
                    }
                case AspectRatios.AR_DEFAULT:
                    {
                        addViewModeForBestMatch(AspectRatios.AR_DEFAULT);
                        break;
                    }
            }

            return new[]
                       {
                           isTopSingleBlackBar, isTopDoubleBlackBar, isBottomSingleBlackBar, isBottomDoubleBlackBar,
                           isLeftSingleBlackBar, isRightSingleBlackBar
                       };
        }

        private void setAdjustedBounds()
        {
            adjustedbounds.Y = bounds.Y;
            adjustedbounds.Height = bounds.Height;
            adjustedbounds.X = bounds.X;
            adjustedbounds.Width = bounds.Width;
        }

        private void interruptScan()
        {
            Utils.log(Preferences.getInstance().verboselogging, "Scan interrupted!");
            Preferences.getInstance().stopCounter = Preferences.getInstance().stopCounterEnd;
            bestMatchedAspectRatio.Clear();
            clearBestMatchedCropSettings();
        }

        private void TopAndBottomSingleBarsNoSideBarsPattern()
        {
            adjustedbounds.Y = bounds.Y;
            adjustedbounds.Height = bounds.Height;
            adjustedbounds.X = bounds.X;
            adjustedbounds.Width = bounds.Width;
        }

        private void TopAndBottomSingleBarsNoSideBarsPattern16To9()
        {
            adjustedbounds.Y = 0;
            adjustedbounds.Height = 0;
            adjustedbounds.X = bounds.X;
            adjustedbounds.Width = bounds.Width;
        }

        private void TopAndBottomDoubleBarsPattern()
        {
            //Top Black Bar
            adjustedbounds.Y = bounds.Y -
                               (int) (frameAnalyzer.getVideoSize().Height*Preferences.ADD_SINGLE_BLACK_BAR);

            //Bottom Black Bar
            adjustedbounds.Height = bounds.Height -
                                    (int) (frameAnalyzer.getVideoSize().Height*Preferences.ADD_SINGLE_BLACK_BAR);

            adjustedbounds.X = bounds.X;
            adjustedbounds.Width = bounds.Width;
        }

        public override bool screenSetup()
        {
            Log.Debug("I.F.C.: screen setup starting...");

            //if a 4:3 resolution was detected, set a PixelRatio of 1,33
            if (((float) currentFullscreenAdapterInfo.CurrentDisplayMode.Width/
                 currentFullscreenAdapterInfo.CurrentDisplayMode.Height).Equals(4f/3f))
            {
                GUIGraphicsContext.PixelRatio = 1.333333f;
                Utils.log(Preferences.getInstance().verboselogging,
                          "4:3 resolution detected");
            }

            bool isSetupDone = baseScreenSetup();

            Utils.log(Preferences.getInstance().verboselogging, "Screen Setup done!");

            return isSetupDone;
        }
    }
}