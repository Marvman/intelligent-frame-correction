using MediaPortal.GUI.Library;
using MediaPortal.Player;

namespace IntelligentFrameCorrection
{
    public class CustomViewMode
    {
        private readonly Geometry.Type viewMode;
        private readonly CropSettings cropSettings;
        private CropSettings calcedCropSettings;
        private readonly IFrameAnalyzer frameAnalyzer= new FrameAnalyzer();

        public CustomViewMode(Geometry.Type viewMode, int top, int bottom, int left, int right)
        {
            this.viewMode = viewMode;
            cropSettings = new CropSettings(top, bottom, left, right);
        }

        public Geometry.Type ViewMode
        {
            get { return viewMode; }
        }

        public CropSettings CropSettings
        {
            get
            {
                calcedCropSettings = new CropSettings(frameAnalyzer.getVideoSize().Height/100*cropSettings.Top,
                                                      frameAnalyzer.getVideoSize().Height/100*cropSettings.Bottom,
                                                      frameAnalyzer.getVideoSize().Width/100*cropSettings.Left,
                                                      frameAnalyzer.getVideoSize().Width/100*cropSettings.Right);

                return calcedCropSettings;
            }
        }

        public CropSettings Zoom
        {
            get { return cropSettings; }
        }
    }
}