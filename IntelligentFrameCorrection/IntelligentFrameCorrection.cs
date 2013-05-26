using System;
using System.Collections.Generic;
using System.Threading;
using MediaPortal;
using MediaPortal.GUI.Library;
using MediaPortal.Player;
using MediaPortal.Configuration;
using System.ComponentModel;
using MediaPortal.Profile;

namespace IntelligentFrameCorrection
{
    [PluginIcons("IntelligentFrameCorrection.Enabled.png", "IntelligentFrameCorrection.Disabled.png")]
    public class IntelligentFrameCorrection : ISetupForm, IPlugin, IAutoCrop
    {
        #region member variables

        internal BackgroundWorker processingThread;
        private BackgroundWorker timeoutThread;
        private BackgroundWorker restartThread;

        private static readonly EventWaitHandle Finished = new AutoResetEvent(false);
        private static readonly EventWaitHandle Sleep = new AutoResetEvent(false);

        private const int TIMEOUT = 1500;
        private DateTime startTimout;
        private int pressToggleButtonCounter;
        private FrameGrabber fg;
        private int fileLoadCounter;

        internal bool isAspectRatio16To9, isAspectRatio21To9, isAspectRatio4To3;

        private ToggleModes selectedMode;

        private static IntelligentFrameCorrection instance;

        private Screen screen;
        private String currentChannel = "";

        #endregion

        public IntelligentFrameCorrection()
        {
            Log.Debug("--> IntelligentFrameCorrection");
            if (instance != null)
            {
                Log.Debug("Another instance of IntelligentFrameCorrection is already running");
                return;
            }
            
            instance = this;
            var success =
                Preferences.getInstance().loadSettings(Config.GetFile(Config.Dir.Config,
                                                                      "IntelligentFrameCorrection.xml"));

            if (success)
            {
                g_Player.PlayBackStarted += onStarted;
                g_Player.PlayBackStopped += onStopped;
                g_Player.PlayBackEnded += onPlayBackEnded;
                g_Player.PlayBackChanged += onChanged;
                Events.Restart += onRestart;
                GUIPropertyManager.OnPropertyChanged += onPropertyChange;
                GUIGraphicsContext.autoCropper = instance;
            }
            Log.Debug("<-- IntelligentFrameCorrection");
        }

        #region ISetupForm Members

        public string Author()
        {
            return "Martin Rogas a.k.a Marvman";
        }

        public bool CanEnable()
        {
            return true;
        }

        public bool DefaultEnabled()
        {
            return true;
        }

        public string Description()
        {
            return "";
        }

        public bool GetHome(out string strButtonText, out string strButtonImage, out string strButtonImageFocus,
                            out string strPictureImage)
        {
            strButtonText = String.Empty;
            strButtonImage = String.Empty;
            strButtonImageFocus = String.Empty;
            strPictureImage = String.Empty;

            return false;
        }

        public int GetWindowId()
        {
            return 24071982;
        }

        public bool HasSetup()
        {
            return true;
        }

        public string PluginName()
        {
            return "Intelligent Frame Correction";
        }

        public void ShowPlugin()
        {
            var form = new IntelligentFrameCorrectionSetup();
            form.ShowDialog();
        }

        #endregion

        #region IPlugin Members

        public void Start()
        {
        }

        public void Stop()
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> Stop");
            g_Player.PlayBackStarted -= onStarted;
            g_Player.PlayBackStopped -= onStopped;
            g_Player.PlayBackEnded -= onPlayBackEnded;
            g_Player.PlayBackChanged -= onChanged;
            Events.Restart -= onRestart;
            GUIPropertyManager.OnPropertyChanged -= onPropertyChange;
            resetSettings();
            Utils.log(Preferences.getInstance().verboselogging, "<-- Stop");
        }

        #endregion

        private void onStarted(g_Player.MediaType mediaType, String filename)
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> onStarted");
            //resetSettings();

            //Don't start processing, if player plays video content
            if (!Preferences.getInstance().isVideoSupportEnabled && FrameAnalyzer.isVideo())
            {
                return;
            }

            if (Preferences.getInstance().autoStart)
            {
                selectedMode = ToggleModes.AUTO;
                Monitor.Enter(getInstance);
                Utils.log(Preferences.getInstance().verboselogging, "filename: {0}", filename);
                startThread();
                Monitor.Exit(getInstance);
            }
            Utils.log(Preferences.getInstance().verboselogging, "<-- onStarted");
        }

        private void run(object sender, DoWorkEventArgs doworkevent)
        {
            
            if (isAspectRatio16To9)
            {
                screen = new Screen16To9();
            }
            else if (isAspectRatio21To9)
            {
                screen = new Screen21To9();
            }
            else if (isAspectRatio4To3)
            {
                screen = new Screen4To3();
            }

            waitForPlayer(doworkevent);
            fileLoadCounter = 1;

            if (!screen.screenSetup())
            {
                Finished.Set();
                return;
            }

            switch (selectedMode)
            {
                case ToggleModes.AUTO:
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "ToggleMode: Auto");
                        while (true)
                        {
                            for (;
                                Preferences.getInstance().stopCounter < (Preferences.getInstance().stopCounterEnd);
                                Preferences.getInstance().stopCounter++)
                            {
                                try
                                {
                                    if (getInstance.processingThread.CancellationPending)
                                    {
                                        doworkevent.Cancel = true;
                                        Utils.log(Preferences.getInstance().verboselogging,
                                                  "stopped by cancel the thread - perform processing");
                                        Finished.Set();
                                        return;
                                    }

                                    screen.performIfc();
                                    Sleep.WaitOne(Preferences.getInstance().scanInterval);
                                }
                                catch (Exception e)
                                {
                                    fg.Clean();
                                    Utils.log(Preferences.getInstance().verboselogging, e.StackTrace);
                                    return;
                                }
                            }
                            Preferences.getInstance().stopCounter = 0;
                        }
                    }
                case ToggleModes.SNAPSHOT:
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "ToggleMode: Snapshot");

                        if (getInstance.processingThread.CancellationPending)
                        {
                            doworkevent.Cancel = true;
                            Utils.log(Preferences.getInstance().verboselogging,
                                      "stopped by cancel the thread - Snapshot");
                            Finished.Set();
                            return;
                        }

                        int tempEndcounter = Preferences.getInstance().stopCounterEnd;
                        Preferences.getInstance().stopCounterEnd = 1;
                        screen.performIfc();
                        Preferences.getInstance().stopCounterEnd = tempEndcounter;

                        if (getInstance.processingThread.CancellationPending)
                        {
                            doworkevent.Cancel = true;
                            Utils.log(Preferences.getInstance().verboselogging,
                                      "stopped by cancel the thread - perform processing");
                            Finished.Set();
                            return;
                        }
                        // to avoid that the processingThread is stopped again
                        getInstance.processingThread = null;
                        break;
                    }
                case ToggleModes.RESET:
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "ToggleMode: Reset");

                        if (getInstance.processingThread.CancellationPending)
                        {
                            doworkevent.Cancel = true;
                            Utils.log(Preferences.getInstance().verboselogging,
                                      "stopped by cancel the thread - Reset");
                            Finished.Set();
                            return;
                        }
                        // to avoid that the processingThread is stopped again
                        getInstance.processingThread = null;
                        break;
                    }
                    //case ToggleModes.SETTINGS:
                    //    {
                    //        Utils.log(Preferences.getInstance().verboselogging, "ToggleMode: Settings");
                    //        if (getInstance.processingThread.CancellationPending)
                    //        {
                    //            doworkevent.Cancel = true;
                    //            Utils.log(Preferences.getInstance().verboselogging,
                    //                      "stopped by cancel the thread - Default");
                    //            finished.Set();
                    //            return;
                    //        }
                    //        // to avoid that the processingThread is stopped again
                    //        getInstance.processingThread = null;
                    //        break;
                    //    }
                default:
                    {
                        if (getInstance.processingThread.CancellationPending)
                        {
                            doworkevent.Cancel = true;
                            Utils.log(Preferences.getInstance().verboselogging,
                                      "stopped by cancel the thread - Default");
                            Finished.Set();
                            return;
                        }
                        // to avoid that the processingThread is stopped again
                        getInstance.processingThread = null;
                        break;
                    }
            }
        }

        private static void waitForPlayer(DoWorkEventArgs doworkevent)
        {
            Utils.log(Preferences.getInstance().verboselogging, "waitForPlayer -->");
            try
            {
                Utils.log(Preferences.getInstance().verboselogging, "Wait for player...");
                do
                {
                    if (getInstance.processingThread.CancellationPending)
                    {
                        doworkevent.Cancel = true;
                        Utils.log(Preferences.getInstance().verboselogging,
                                  "stopped by cancel the thread - wait for the player");
                        Finished.Set();
                        return;
                    }

                    Thread.Sleep(1);
                } while (!FrameAnalyzer.isPlaying());
            }
            catch (Exception e)
            {
                Utils.log(Preferences.getInstance().verboselogging, e.StackTrace);
            }

            Utils.log(Preferences.getInstance().verboselogging, "<-- waitForPlayer");
        }

        private void onStopped(g_Player.MediaType mediaType, int stoptime, string filename)
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> onStopped");
            Monitor.Enter(getInstance);
            stopThread();
            resetSettings();
            Monitor.Exit(getInstance);
            Utils.log(Preferences.getInstance().verboselogging, "<-- onStopped");

            //we have to reset the current channel, cause for the next start of TV
            currentChannel = "";
        }

        private void onPlayBackEnded(g_Player.MediaType mediaType, string filename)
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> onPlayBackEnded");
            Utils.log(Preferences.getInstance().verboselogging, "filename: {0}", filename);
            //Moving Picture workaround:
            //When the file was changed (CD1 -> CD2) the stop thread is already fired (onChanged) and the start thread triggered (onStart), 
            //after those 2 events the playbackEnded event is fired from MP so we need not to stop the active thread of IFC.
            if (fileLoadCounter > 0)
            {
                Monitor.Enter(getInstance);
                stopThread();
                resetSettings();
                Monitor.Exit(getInstance);
            }


            Utils.log(Preferences.getInstance().verboselogging, "<-- onPlayBackEnded");
        }

        private void onChanged(g_Player.MediaType type, int stoptime, string filename)
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> onChanged");
            Utils.log(Preferences.getInstance().verboselogging, "filename: {0}", filename);

            if (fileLoadCounter > 0)
            {
                Monitor.Enter(getInstance);
                stopThread();
                resetSettings();
                Monitor.Exit(getInstance);
            }

            Utils.log(Preferences.getInstance().verboselogging, "<-- onChanged");
        }

        private void onPropertyChange(String property, String value)
        {
            switch (property)
            {
                case "#TV.View.channel":
                    {
                        Utils.log(Preferences.getInstance().verboselogging, "--> onPropertyChange");
                        if (!value.Equals("") && currentChannel != value && g_Player.IsTimeShifting && g_Player.IsTV)
                        {
                            Utils.log(Preferences.getInstance().verboselogging, "tv channel changed: {0}", value);
                            currentChannel = value;

                            Monitor.Enter(getInstance);
                            //we have to reset the mode

                            stopThread();
                            resetSettings();
                            if (Preferences.getInstance().autoStart)
                            {
                                selectedMode = ToggleModes.AUTO;
                                startThread();
                            }

                            Monitor.Exit(getInstance);
                        }
                        Utils.log(Preferences.getInstance().verboselogging, "<-- onPropertyChange");
                        break;
                    }
            }
 }

        private void onRestart()
        {
            if (restartThread == null)
            {
                Utils.log(Preferences.getInstance().verboselogging, "restarting...");
                restartThread = new BackgroundWorker();
                restartThread.DoWork += restart;
                restartThread.RunWorkerAsync();
            }
        }

        private void restart(object sender, DoWorkEventArgs doworkevent)
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> restart");
            Monitor.Enter(getInstance);
            stopThread();
            startThread();
            Utils.log(Preferences.getInstance().verboselogging, "restarted");
            restartThread = null;
            Monitor.Exit(getInstance);
            Utils.log(Preferences.getInstance().verboselogging, "<-- restart");
        }

        private void startThread()
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> startThread");
            if (!(FrameAnalyzer.isTV() || FrameAnalyzer.isVideo()))
            {
                return;
            }

            Preferences.getInstance().stopCounter = 0;
            if (getInstance.processingThread == null)
            {
                Utils.log(Preferences.getInstance().verboselogging, "Thread starting...");
                fg = FrameGrabber.GetInstance();
                getInstance.processingThread = new BackgroundWorker
                                                   {
                                                       WorkerSupportsCancellation = true
                                                   };
                getInstance.processingThread.DoWork += run;
                getInstance.processingThread.RunWorkerAsync();
                Utils.log(Preferences.getInstance().verboselogging, "Thread started!");
                Utils.log(Preferences.getInstance().verboselogging, "<-- startThread");
            }
        }

        private void stopThread()
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> stopThread");
            if (processingThread == null)
            {
                Utils.log(Preferences.getInstance().verboselogging, "Thread already stopped!");
                return;
            }

            Utils.log(Preferences.getInstance().verboselogging, "Thread stopping...");
            getInstance.processingThread.CancelAsync();
            Utils.log(Preferences.getInstance().verboselogging,
                      "processingThread.IsBusy {0}, processingThread.CancellationPending {1}", processingThread.IsBusy,
                      processingThread.CancellationPending);
            Sleep.Set();
            Finished.WaitOne();

            Utils.log(Preferences.getInstance().verboselogging, "Thread stopped!");
            getInstance.processingThread = null;
            Utils.log(Preferences.getInstance().verboselogging, "<-- stopThread");
        }

        public static IntelligentFrameCorrection getInstance
        {
            get { return instance; }
        }

        /// <summary>
        /// Timeout thread for toggeling through the modes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="doworkevent"></param>
        private void timeoutForSelectedMode(object sender, DoWorkEventArgs doworkevent)
        {
            while ((DateTime.Now.Subtract(startTimout).TotalMilliseconds) < TIMEOUT)
            {
                Thread.Sleep(1);
            }

            Utils.log(Preferences.getInstance().verboselogging, "Timeout reached!");
            pressToggleButtonCounter = 0;

            Monitor.Enter(getInstance);
            stopThread();
            startThread();
            Monitor.Exit(getInstance);

            timeoutThread = null;
            Utils.log(Preferences.getInstance().verboselogging, "Timeout thread stopped!");
        }

        public string ToggleMode()
        {
            Utils.log(Preferences.getInstance().verboselogging, "Reset timeout!");
            startTimout = DateTime.Now;
            pressToggleButtonCounter++;

            if (timeoutThread == null)
            {
                timeoutThread = new BackgroundWorker();
                timeoutThread.DoWork += timeoutForSelectedMode;
                timeoutThread.RunWorkerAsync();
            }

            if (pressToggleButtonCounter == 1)
            {
                selectedMode = ToggleModes.SNAPSHOT;
            }
            else if (pressToggleButtonCounter == 2)
            {
                selectedMode = ToggleModes.RESET;
            }
            else if (pressToggleButtonCounter == 3)
            {
                selectedMode = ToggleModes.AUTO;
                pressToggleButtonCounter = 0;
            }
            //else
            //{
            //    selectedMode = ToggleModes.SETTINGS;

            //    pressToggleButtonCounter = 0;
            //}

            switch (selectedMode)
            {
                case ToggleModes.AUTO:
                    {
                        return "I.F.C. auto";
                    }
                case ToggleModes.SNAPSHOT:
                    {
                        return "I.F.C. snapshot";
                    }
                case ToggleModes.RESET:
                    {
                        return "I.F.C. reset";
                    }
                    //case ToggleModes.SETTINGS:
                    //    {
                    //        return "I.F.C. settings";
                    //    }
                default:
                    {
                        return "this should never happend";
                    }
            }
        }

        public string Crop()
        {
            return "not implemented";
        }

        //private void onWindowOpen()
        //{
        //    var window = (FrontendGUI)GUIWindowManager.GetWindow(240782);
        //    Utils.log(Preferences.getInstance().verboselogging, "ActiveWindow: " + GUIWindowManager.GetPreviousActiveWindow());
        //    window.DoModal(GUIWindowManager.ActiveWindow);
        //}

        private void resetSettings()
        {
            //Reset some settings
            Preferences.getInstance().stopCounter = 0;

            Preferences.getInstance().lastCalcedCropSettings.Top = 0;
            Preferences.getInstance().lastCalcedCropSettings.Bottom = 0;
            Preferences.getInstance().lastCalcedCropSettings.Left = 0;
            Preferences.getInstance().lastCalcedCropSettings.Right = 0;

            Preferences.getInstance().lastCropSettings.Top = 0;
            Preferences.getInstance().lastCropSettings.Bottom = 0;
            Preferences.getInstance().lastCropSettings.Left = 0;
            Preferences.getInstance().lastCropSettings.Right = 0;

            Preferences.getInstance().lastStabilizer.Top = 0;
            Preferences.getInstance().lastStabilizer.Bottom = 0;
            Preferences.getInstance().lastStabilizer.Left = 0;
            Preferences.getInstance().lastStabilizer.Right = 0;

            fileLoadCounter = 0;
            setBackDefaultViewMode();
        }

        private static void setBackDefaultViewMode()
        {
            using (var xmlwriter = new Settings(Config.GetFile(Config.Dir.Config, "MediaPortal.xml"), true))
            {
                Geometry.Type aspectRatioText = Preferences.getInstance().ViewModeDefault.ViewMode;

                Utils.log(Preferences.getInstance().verboselogging, "reset default view mode to: {0}", aspectRatioText);
                string aspectRatio = MediaPortal.Util.Utils.GetAspectRatio(aspectRatioText);

                xmlwriter.SetValue("mytv", "defaultar", aspectRatio);
                xmlwriter.SetValue("movieplayer", "defaultar", aspectRatio);
                xmlwriter.SetValue("dvdplayer", "defaultar", aspectRatio);
            }
        }
    }
}