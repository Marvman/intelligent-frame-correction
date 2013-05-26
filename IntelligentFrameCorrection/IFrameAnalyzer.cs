using System.Drawing;
using MediaPortal.Player;


namespace IntelligentFrameCorrection
{
    public interface IFrameAnalyzer
    {
        float getCurrentFrameAspectRatio();
        Size getVideoSize();
        AspectRatios getAspectRatio();
        bool FindBounds(bool top, bool bottom, bool left, bool right, ref Rectangle bounds);
        CropSettings getToCropSettings(CustomViewMode viewmode, CropSettings cropSettings);
    }
}