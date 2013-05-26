using System.Drawing;


namespace IntelligentFrameCorrection
{
    internal interface IScanBehavior
    {
        bool performScan(Bitmap sourceImage, string scanArea);
    }
}