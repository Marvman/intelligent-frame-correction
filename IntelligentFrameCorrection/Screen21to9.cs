using MediaPortal.GUI.Library;

namespace IntelligentFrameCorrection
{
    internal class Screen21To9 : Screen, IScreenBehavior
    {
        public Screen21To9()
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

        private void scanForBlackBars()
        {
            switch (frameAnalyzer.getAspectRatio())
            {
                case AspectRatios.AR_4_3:
                    {
                        if (frameAnalyzer.FindBounds(true, true, true, true, ref bounds))
                        {
                            //setAdjustedBounds();
                            addViewModeForBestMatch(AspectRatios.AR_4_3);

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
                        if (frameAnalyzer.FindBounds(true, true, true, true, ref bounds))
                        {
                            //setAdjustedBounds();
                            addViewModeForBestMatch(AspectRatios.AR_16_9);
                        }
                        else
                        {
                            Utils.log(Preferences.getInstance().verboselogging, "Found no bounds!");
                        }
                        break;
                    }
                case AspectRatios.AR_21_9:
                    {
                        adjustedbounds.Y = 0;
                        adjustedbounds.Height = 0;
                        adjustedbounds.X = 0;
                        adjustedbounds.Width = 0;

                        addViewModeForBestMatch(AspectRatios.AR_21_9);
                        break;
                    }
            }
        }

        public override bool screenSetup()
        {
            Log.Debug("I.F.C.: screen setup starting...");
            bool isSetupDone = baseScreenSetup();
            Utils.log(Preferences.getInstance().verboselogging, "Screen Setup done!");
            return isSetupDone;
        }
    }
}