using MediaPortal.GUI.Library;

namespace IntelligentFrameCorrection
{
    internal class Screen4To3 : Screen, IScreenBehavior
    {
        public Screen4To3()
        {
            screenBehavior = this;
        }

        public override bool screenSetup()
        {
            Log.Debug("I.F.C.: screen setup starting...");
            bool isSetupDone = baseScreenSetup();
            Utils.log(Preferences.getInstance().verboselogging, "Screen Setup done!");
            return isSetupDone;
        }

        public void performIntelligentFrameCorrection()
        {
            if (Preferences.getInstance().stopCounter == Preferences.getInstance().stopCounterEnd - 1)
            {
                setViewMode(frameAnalyzer.getAspectRatio());
            }
        }
    }
}