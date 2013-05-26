using System.Drawing;
using MediaPortal.Player;

namespace IntelligentFrameCorrection
{
   public class MockFrameAnalyzer: FrameAnalyzer
    {
        private static float currentFrameAspectRatio;
        private Size currentVideoSize;
        private Bitmap sourceImage;

        public override float getCurrentFrameAspectRatio()
        {
            return currentFrameAspectRatio;
        }

        public override Size getVideoSize()
        {
            return currentVideoSize;
        }

        public override bool FindBounds(bool top, bool bottom, bool left, bool right, ref Rectangle bounds)
        {
            return FindBounds(top, bottom, left, right, ref bounds, ref sourceImage);
        }

        public override CropSettings getToCropSettings(CustomViewMode viewmode, CropSettings cropSettings)
        {
            return new CropSettings();
        }

        public void setVideoSize(Size dimention)
        {
            currentVideoSize = dimention;
        }

        public void setCurrentFrameAspectRatio(float pFrameAspectRatio)
        {
            currentFrameAspectRatio = pFrameAspectRatio;
        }

        internal Bitmap getSourceImage()
        {
            return sourceImage;
        }

        public void setSourceImage(Bitmap image)
        {
            sourceImage = image;
        }
    }
}
