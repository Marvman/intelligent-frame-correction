
namespace IntelligentFrameCorrection
{
    public class Events
    {
        public delegate void RestartHandler();
        public static event RestartHandler Restart;

        public static void DoRestart()
        {
            RestartHandler handler = Restart;
            if (handler != null) handler();
        }
    }
}
