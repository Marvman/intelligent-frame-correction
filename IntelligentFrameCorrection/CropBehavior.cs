using System.Drawing;

namespace IntelligentFrameCorrection
{
    internal interface CropBehavior
    {
        void performCrop(Bitmap sourceImage, float cropFactor);
    }
}