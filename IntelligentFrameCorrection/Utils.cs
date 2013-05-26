using System;
using MediaPortal.GUI.Library;

namespace IntelligentFrameCorrection
{
    public class Utils
    {
        private const string PREFIX = "I.F.C.: ";

        public static void log(bool verboselogging, string msg, params object[] param)
        {
            if (verboselogging)
            {
                Log.Debug(PREFIX + msg, param);
            }
        }

        public static CustomViewMode stringToCustomViewMode(string stringViewMode)
        {
            String[] tokens = stringViewMode.Split(',');
            var viewMode = (Geometry.Type) Enum.Parse(typeof (Geometry.Type), tokens[0], true);

            return new CustomViewMode(viewMode, int.Parse(tokens[1].Trim()), int.Parse(tokens[2].Trim()),
                                      int.Parse(tokens[3].Trim()), int.Parse(tokens[4].Trim()));
        }
    }
}