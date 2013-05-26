using System;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using MediaPortal;
using MediaPortal.Player;
using System.Drawing;
using Microsoft.DirectX.Direct3D;


namespace IntelligentFrameCorrection
{
    public class FrameAnalyzer: IFrameAnalyzer
    {
        //private static Bitmap sourceImage;

        private static readonly int HDHEIGHT = Preferences.getInstance().HDHeight;
        private static readonly int HDWIDTH = Preferences.getInstance().HDWidth;

        private bool foundTopBar;
        private bool foundBottomBar;
        private bool foundLeftBar;
        private bool foundRightBar;

        public virtual float getCurrentFrameAspectRatio()
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> getCurrentFrameAspectRatio");
                float currentFrameAspectRatio = 0;

                if (isPlaying())
                {
                   currentFrameAspectRatio = (float)VMR9Util.g_vmr9.VideoAspectRatioX / VMR9Util.g_vmr9.VideoAspectRatioY;
                }

            Utils.log(Preferences.getInstance().verboselogging, "<-- getCurrentFrameAspectRatio");
            return currentFrameAspectRatio;
        }

        public static bool isHDContent()
        {
            int videoHeight = VMR9Util.g_vmr9.VideoHeight;
            int videoWidth = VMR9Util.g_vmr9.VideoWidth;

            Utils.log(Preferences.getInstance().verboselogging, "VMR9: videoHeight: {0} videoWidth {1}", videoHeight, videoWidth);
        
            {
                switch (Preferences.getInstance().HDOperator)
                {
                    case "or":
                        {
                            if (videoHeight >= HDHEIGHT || videoWidth >= HDWIDTH)
                            {
                                return true;
                            }
                            break;
                        }
                    case "and":
                        {
                            if (videoHeight >= HDHEIGHT && videoWidth >= HDWIDTH)
                            {
                                return true;
                            }
                            break;
                        }
                    case "multiply":
                        {
                            if ((videoHeight * videoWidth) >= (HDHEIGHT * HDWIDTH))
                            {
                                return true;
                            }
                            break;
                        }
                }
            }
            return false;
        }

        public static bool isVideo()
        {
            if (g_Player.IsVideo || g_Player.IsDVD)
            {
                return true;
            }
            return false;
        }

        public static bool isTV()
        {
            if (g_Player.IsTV || g_Player.IsTVRecording)
            {
                return true;
            }
            return false;
        }

        public virtual bool FindBounds(bool top, bool bottom, bool left, bool right, ref Rectangle bounds)
        {
            //var height = getVideoSize().Height;
            //var width = getVideoSize().Width;

            Utils.log(Preferences.getInstance().verboselogging, "before grabbing");
            //Image grabbedImage = FrameGrabber.GetInstance().GetCurrentImage((int)(getVideoSize().Width * (Preferences.getInstance().frameCaptureSize / 100f)), (int)(getVideoSize().Height * (Preferences.getInstance().frameCaptureSize / 100f)));
            Image grabbedImage = FrameGrabber.GetInstance().GetCurrentImage();
            Utils.log(Preferences.getInstance().verboselogging, "after grabbing");
            if (null == grabbedImage)
            {
                Utils.log(Preferences.getInstance().verboselogging, "no frame were grabbed");
                Preferences.getInstance().stopCounter = Preferences.getInstance().stopCounterEnd;
                return false;
            }
            //grabbedImage.Save("C:\\grabbedImage.bmp", ImageFormat.Bmp);
            //if (Preferences.getInstance().frameCaptureSize < 100 && Preferences.getInstance().frameCaptureSize > 0)
            //{
                //var memStream = new MemoryStream();

                //saves the image to the stream
                //grabbedImage.Save(memStream, ImageFormat.Bmp);

                //Image scaledSourceImage = Image.FromStream(memStream);
                //scaledSourceImage.Save("C:\\scaledSourceImage.bmp", ImageFormat.Bmp);
                //memStream.Close();

                //Image scaledSourceImage = grabbedImage;
                //using (Graphics g = Graphics.FromImage(sourceImage))
                //{
                //    g.InterpolationMode = InterpolationMode.NearestNeighbor;
                //    g.PixelOffsetMode = PixelOffsetMode.None;

                //    //upscaling
                //    g.DrawImage(scaledSourceImage, 0, 0, width, height);
                //    g.Dispose();
                //}
                

                //sourceImage.Save("C:\\sourceImage_" + DateTime.Now.Second + ".bmp", ImageFormat.Bmp);
                //Utils.log(Preferences.getInstance().verboselogging, "after rescaling");
                //Utils.log(Preferences.getInstance().verboselogging, "grabbed frame: width: {0}, height: {1}",
                //          grabbedImage.Width, grabbedImage.Height);
            //}
            //else
            //{
                var sourceImage = (Bitmap)grabbedImage;
            //}
            
            return FindBounds(top, bottom, left, right, ref bounds, ref sourceImage);
        }

        public bool FindBounds(bool top, bool bottom, bool left, bool right, ref Rectangle bounds, ref Bitmap testImage)
        {
            bounds.Y = 0;
            bounds.Height = testImage.Height;
            bounds.X = 0;
            bounds.Width = testImage.Width;

            //scanned lines
            int topLine = 0;
            int bottomLine = testImage.Height;
            int leftLine = 0;
            int rightLine = testImage.Width;

            int topStart = (int) (((float) Preferences.getInstance().topScanArea.X/100)*testImage.Width);
            int topEnd =
                (int)
                (((float) (Preferences.getInstance().topScanArea.Width + Preferences.getInstance().topScanArea.X)/100)*
                 testImage.Width);

            //Utils.log(Preferences.getInstance().verboselogging, "X {0}, image Width {1} ", Preferences.getInstance().topScanArea.X, sourceImage.Width);
            //Utils.log(Preferences.getInstance().verboselogging, "TopStart {0}, TopEnd {1} ", topStart, topEnd);

            int bottomStart = (int) (((float) Preferences.getInstance().bottomScanArea.X/100)*testImage.Width);
            int bottomEnd =
                (int)
                (((float) (Preferences.getInstance().bottomScanArea.Width + Preferences.getInstance().bottomScanArea.X)/
                  100)*testImage.Width);


            //Utils.log(Preferences.getInstance().verboselogging, "bottomStart {0}, bottomEnd {1} ", bottomStart, bottomEnd);

            int leftStart = (int) (((float) Preferences.getInstance().leftScanArea.Y/100)*testImage.Height);
            int leftEnd =
                (int)
                (((float) (Preferences.getInstance().leftScanArea.Height + Preferences.getInstance().leftScanArea.Y)/100)*
                 testImage.Height);


            //Utils.log(Preferences.getInstance().verboselogging, "leftStart {0}, leftEnd {1} ", leftStart, leftEnd);

            int rightStart = (int) (((float) Preferences.getInstance().rightScanArea.Y/100)*testImage.Height);
            int rightEnd =
                (int)
                (((float) (Preferences.getInstance().rightScanArea.Height + Preferences.getInstance().rightScanArea.Y)/
                  100)*testImage.Height);


            //Utils.log(Preferences.getInstance().verboselogging, "rightStart {0}, rightEnd {1} ", rightStart, rightEnd);

            //DrawLine(this.testImage.Height / 2, 0, this.testImage.Width - 1, Color.Red, true);

            int mid;
            int low = (int) (((float) Preferences.getInstance().topScanArea.Y/100)*testImage.Height);
            int high =
                (int)
                (((float) (Preferences.getInstance().topScanArea.Height + Preferences.getInstance().topScanArea.Y)/100)*
                 testImage.Height);

            //Top black bar binary search scan
            if (top)
            {
                while (low <= high)
                {
                    mid = (low + high)/2;
                    ScanLine(mid, topStart, topEnd, true, ref testImage);
                    if (IsContent(topStart, topEnd))
                    {
                        high = mid - 1;
                        topLine = mid;
                        foundTopBar = true;
                    }
                    else
                    {
                        topLine = mid;
                        //DrawLine(topLine, topStart, topEnd, Color.Green, true);
                        low = mid + 1;
                    }
                }
                //Utils.log(Preferences.getInstance().verboselogging, "Found top line: {0}", topLine);
                //DrawLine(topLine, topStart, topEnd, Color.LimeGreen, true, ref testImage);
            }

            if (isFrameToDark(top, foundTopBar))
            {
                return false;
            }

            //Bottom black bar binary search scan
            if (bottom)
            {
                //mid = 0;
                low = (int) (((float) Preferences.getInstance().bottomScanArea.Y/100)*testImage.Height);
                high =
                    (int)
                    (((float)
                      (Preferences.getInstance().bottomScanArea.Height + Preferences.getInstance().bottomScanArea.Y)/100)*
                     testImage.Height) - 1;

                while (low <= high)
                {
                    mid = (low + high)/2;
                    ScanLine(mid, bottomStart, bottomEnd, true, ref testImage);
                    if (IsContent(bottomStart, bottomEnd))
                    {
                        low = mid + 1;
                        bottomLine = mid;
                        foundBottomBar = true;
                        //if (verboseLog)
                        //{
                        //Utils.log(Preferences.getInstance().verboselogging, "Found bottom line: {0}", bottomLine);
                        //DrawLine(bottomLine, bottomStart, bottomEnd, Color.Red, true);
                        //}
                    }
                    else
                    {
                        bottomLine = mid;
                        //DrawLine(bottomLine, bottomStart, bottomEnd, Color.Magenta, true);
                        high = mid - 1;
                    }
                }
                //Utils.log(Preferences.getInstance().verboselogging, "Found bottom line: {0}", bottomLine);
                //DrawLine(bottomLine, bottomStart, bottomEnd, Color.LimeGreen, true, ref testImage);

            }

            if (isFrameToDark(bottom, foundBottomBar))
            {
                return false;
            }

            //leftscan
            if (left)
            {
                low = (int) (((float) Preferences.getInstance().leftScanArea.X/100)*testImage.Width);
                high =
                    (int)
                    (((float) (Preferences.getInstance().leftScanArea.Width + Preferences.getInstance().leftScanArea.X)/
                      100)*testImage.Width);

                while (low <= high)
                {
                    mid = (low + high)/2;
                    ScanLine(mid, leftStart, leftEnd, false, ref testImage);
                    if (IsContent(leftStart, leftEnd))
                    {
                        high = mid - 1;
                        leftLine = mid;
                        foundLeftBar = true;
                        //Utils.log(Preferences.getInstance().verboselogging, "Found left line: {0}", leftLine);
                    }
                    else
                    {
                        leftLine = mid;
                        //DrawLine(leftLine, Preferences.getInstance().leftStart, Preferences.getInstance().leftEnd, Color.Green, false);
                        //this.testImage.Save("C:\\analyzed_frame.bmp", ImageFormat.Bmp); // for debug purposes
                        low = mid + 1;
                    }
                }
                //Utils.log(Preferences.getInstance().verboselogging, "Found left line: {0}", leftLine);
                //DrawLine(leftLine, leftStart, leftEnd, Color.LimeGreen, false, ref testImage);
            }

            if (isFrameToDark(left, foundLeftBar))
            {
                return false;
            }

            //rightscan
            if (right)
            {
                low = (int) (((float) Preferences.getInstance().rightScanArea.X/100)*testImage.Width);
                high =
                    (int)
                    (((float)
                      (Preferences.getInstance().rightScanArea.Width + Preferences.getInstance().rightScanArea.X)/100)*
                     testImage.Width) - 1;

                while (low <= high)
                {
                    mid = (low + high)/2;
                    ScanLine(mid, rightStart, rightEnd, false, ref testImage);
                    if (IsContent(rightStart, rightEnd))
                    {
                        low = mid + 1;
                        rightLine = mid;
                        foundRightBar = true;
                        //Utils.log(Preferences.getInstance().verboselogging, "Found right line: {0}", rightLine);
                    }
                    else
                    {
                        rightLine = mid;
                        //DrawLine(rightLine, Preferences.getInstance().rightStart, Preferences.getInstance().rightEnd, Color.Green, false);
                        //testImage.Save("C:\\analyzed_frame.bmp", ImageFormat.Bmp); // for debug purposes
                        high = mid - 1;
                    }
                }
                //Utils.log(Preferences.getInstance().verboselogging, "Found right line: {0}", rightLine);
                //DrawLine(rightLine, rightStart, rightEnd, Color.LimeGreen, false, ref testImage);
            }
            //testImage.Save("C:\\analyzed_frame_"+ DateTime.Now.Second + ".bmp", ImageFormat.Bmp); // for debug purposes

            if (isFrameToDark(right, foundRightBar))
            {
                return false;
            }

            bounds.Y = topLine; // * (100 / Preferences.getInstance().frameCaptureSize);
            bounds.X = leftLine; // * (100 / Preferences.getInstance().frameCaptureSize);
            bounds.Height = (testImage.Height - (bottomLine + 1)); // * (100 / Preferences.getInstance().frameCaptureSize);
            bounds.Width = (testImage.Width - (rightLine + 1)); // *(100 / Preferences.getInstance().frameCaptureSize);

            Utils.log(Preferences.getInstance().verboselogging,
                      "Bounds: " + bounds.Y + " , " + bounds.Height + " , " + bounds.X + " , " + bounds.Width);

            foundTopBar = false;
            foundBottomBar = false;
            foundLeftBar = false;
            foundRightBar = false;
            return true;
        }

        private static bool isFrameToDark(bool side, bool foundContent)
        {
            if ((side && !foundContent))
            {
                Utils.log(Preferences.getInstance().verboselogging, "frame is to dark!");
                Preferences.getInstance().stopCounter = Preferences.getInstance().stopCounterEnd;
                return true;
            }
            return false;
        }

        private void ScanLine(int line, int start, int end, bool horizontal, ref Bitmap sourceImage)
        {
            //Utils.log(Preferences.getInstance().verboselogging, "Scanning line " + line);
            ResetHistograms();
            Color c;

            for (int p = start; p <= end; p++)
            {
                if (horizontal) //horizontal line scan
                {
                    
                    c = sourceImage.GetPixel(p, line);
                    //Utils.log(true, "color G: {0}", c.G);
                    //Utils.log(true, "color R: {0}", c.R);
                    //Utils.log(true, "color B: {0}", c.B);
                }
                else //vertical line scan
                {
                    //Utils.log(true, "scan line start {0}, end {1}, line {2}, sourceImage.width {3}", p, end, line, sourceImage.Width);
                    c = sourceImage.GetPixel(line, p);
                }

                Preferences.getInstance().histG[c.G]++;
                Preferences.getInstance().histR[c.R]++;
                Preferences.getInstance().histB[c.B]++;
            }
        }

        private static void ResetHistograms()
        {
            for (int i = 0; i < Preferences.getInstance().histR.Length; i++)
            {
                Preferences.getInstance().histR[i] = 0;
                Preferences.getInstance().histG[i] = 0;
                Preferences.getInstance().histB[i] = 0;
            }
        }

        private static bool IsContent(int start, int end)
        {
            int maxR = 0;
            int maxG = 0;
            int maxB = 0;
            int sumR = 0;
            int sumG = 0;
            int sumB = 0;

            //Check for brightest pixel value
            for (int i = 0; i <= 255; i++)
            {
                if (Preferences.getInstance().histR[i] > 0 && i >= maxR)
                {
                    maxR = i;
                }
                if (Preferences.getInstance().histG[i] > 0 && i >= maxG)
                {
                    maxG = i;
                }
                if (Preferences.getInstance().histB[i] > 0 && i >= maxB)
                {
                    maxB = i;
                }
            }
            //if (verboseLog) Log.Debug("Max : {0}, {1}, {2}", maxR, maxG, maxB);
            //Utils.log(true, "Max : {0}, {1}, {2}", maxR, maxG, maxB);
            //At least one pixel with brightness level over 40 is found
            if (maxR > Preferences.getInstance().maxBrightnessTreshold ||
                maxG > Preferences.getInstance().maxBrightnessTreshold ||
                maxB > Preferences.getInstance().maxBrightnessTreshold)
            {
                //Utils.log(Preferences.getInstance().verboselogging, "maxBrightnessTreshold reached");
                return true;
            }

            //Check number of pixels above brightness treshold
            for (int j = Preferences.getInstance().minBrightnessTreshold; j <= 255; j++)
            {
                sumR = sumR + Preferences.getInstance().histR[j];
                sumG = sumG + Preferences.getInstance().histG[j];
                sumB = sumB + Preferences.getInstance().histB[j];
            }
            //if (verboseLog) Log.Debug("Number of pixel above treshold : {0}, {1}, {2}", sumR, sumG, sumB);
            //Utils.log(true, "Number of pixel above treshold : {0}, {1}, {2}", sumR, sumG, sumB);
            //Over half of the number of pixels are above the brightness treshold
            //Utils.log(true, "Start: {0}, End: {1}, End-Start/2: {2}", start, end, ((end - start) / 2));
            if (sumR > ((end - start)/2) || sumG > ((end - start)/2) || sumB > ((end - start)/2))
            {
                //Utils.log(Preferences.getInstance().verboselogging,
                //          "Over half of the number of pixels are above the min brightness treshold");
                return true;
            }

            //No content detected
            //Utils.log(Preferences.getInstance().verboselogging, "no content detected");
            return false;
        }

        public void DrawLine(int line, int start, int end, Color c, bool horizontal, ref Bitmap sourceImage)
        {
            for (int p = start; p <= end; p++)
            {
                if (horizontal) //horizontal line scan
                {
                    sourceImage.SetPixel(p, line, c);
                }
                else //vertical line scan
                {
                    sourceImage.SetPixel(line, p, c);
                }
            }
        }

        public virtual AspectRatios getAspectRatio()
        {
            Utils.log(Preferences.getInstance().verboselogging, "--> getAspectRatio>");
            float currentAspectRatio = getCurrentFrameAspectRatio();
            Utils.log(Preferences.getInstance().verboselogging, "curent Aspect Ratio detected: {0}", currentAspectRatio);

            if (currentAspectRatio == 0)
            {
                Utils.log(Preferences.getInstance().verboselogging, "<-- getAspectRatio");
                return AspectRatios.AR_DEFAULT;
            }

            //4:3
            if (currentAspectRatio < 1.6)
            {
                Utils.log(Preferences.getInstance().verboselogging, "<-- getAspectRatio");
                return AspectRatios.AR_4_3;
            }

            //16:9
            if (currentAspectRatio < 2)
            {
                Utils.log(Preferences.getInstance().verboselogging, "<-- getAspectRatio");
                return AspectRatios.AR_16_9;
            }

            //21:9
            if (currentAspectRatio >= 2)
            {
                Utils.log(Preferences.getInstance().verboselogging, "<-- getAspectRatio");
                return AspectRatios.AR_21_9;
            }

            Utils.log(Preferences.getInstance().verboselogging, "<-- getAspectRatio");
            return AspectRatios.AR_DEFAULT;
        }

        /// <summary>
        /// Get the final calced cropsetting
        /// </summary>
        /// <param name="viewmode"></param>
        /// <param name="cropSettings"></param>
        /// <returns></returns>
        public virtual CropSettings getToCropSettings(CustomViewMode viewmode, CropSettings cropSettings)
        {
            var calcCropSetting = new CropSettings();

            //Use only the set zoom factors            
            if(Preferences.getInstance().isUseFixedZoomFactor)
            {
                if (isTV())
                {
                    calcCropSetting.Top += Preferences.getInstance().tvCropSettings.Top;
                    calcCropSetting.Bottom += Preferences.getInstance().tvCropSettings.Bottom;
                    calcCropSetting.Left += Preferences.getInstance().tvCropSettings.Left;
                    calcCropSetting.Right += Preferences.getInstance().tvCropSettings.Right;
                }
                else
                {
                    calcCropSetting.Top += Preferences.getInstance().videoCropSettings.Top;
                    calcCropSetting.Bottom += Preferences.getInstance().videoCropSettings.Bottom;
                    calcCropSetting.Left += Preferences.getInstance().videoCropSettings.Left;
                    calcCropSetting.Right += Preferences.getInstance().videoCropSettings.Right;
                }
            }
            else
            {
                pictureStabilizer(cropSettings);

                Utils.log(Preferences.getInstance().verboselogging, "Stabilized CropSettings Top {0}, Bottom {1}, Left {2}, Right {3}",
                          cropSettings.Top, cropSettings.Bottom, cropSettings.Left, cropSettings.Right);

                //add found bounds
                calcCropSetting.Top += cropSettings.Top;
                calcCropSetting.Bottom += cropSettings.Bottom;
                calcCropSetting.Left += cropSettings.Left;
                calcCropSetting.Right += cropSettings.Right;  
            }
           
            //add custom view mode cropsettings (zoom factor)
            calcCropSetting.Top += viewmode.CropSettings.Top;
            calcCropSetting.Bottom += viewmode.CropSettings.Bottom;
            calcCropSetting.Left += viewmode.CropSettings.Left;
            calcCropSetting.Right += viewmode.CropSettings.Right;

            //add global overscan cropsettings
            calcCropSetting.Top += Preferences.getInstance().overscanCropSettings.Top;
            calcCropSetting.Bottom += Preferences.getInstance().overscanCropSettings.Bottom;      
            calcCropSetting.Left += Preferences.getInstance().overscanCropSettings.Left;  
            calcCropSetting.Right += Preferences.getInstance().overscanCropSettings.Right;

            Utils.log(Preferences.getInstance().verboselogging, "Final calced CropSettings Top {0}, Bottom {1}, Left {2}, Right {3}",
                      calcCropSetting.Top, calcCropSetting.Bottom, calcCropSetting.Left, calcCropSetting.Right);
            return calcCropSetting;
        }

        public static void pictureStabilizer(CropSettings cropSettings)
        {
            Utils.log(Preferences.getInstance().verboselogging,
                      "CropSettings before stabilizing Top: {0}, Bottom: {1}, Left: {2}, Right: {3}", cropSettings.Top, cropSettings.Bottom,
                      cropSettings.Left, cropSettings.Right);

            var lastCropSettings = new CropSettings
                                       {
                                           Top = cropSettings.Top,
                                           Bottom = cropSettings.Bottom,
                                           Left = cropSettings.Left,
                                           Right = cropSettings.Right
                                       };

            cropSettings.Top = calculateStabilizer(cropSettings.Top, Preferences.getInstance().lastCropSettings.Top, Preferences.getInstance().lastStabilizer.Top);
            cropSettings.Bottom = calculateStabilizer(cropSettings.Bottom, Preferences.getInstance().lastCropSettings.Bottom, Preferences.getInstance().lastStabilizer.Bottom);
            cropSettings.Left = calculateStabilizer(cropSettings.Left, Preferences.getInstance().lastCropSettings.Left, Preferences.getInstance().lastStabilizer.Left);
            cropSettings.Right = calculateStabilizer(cropSettings.Right, Preferences.getInstance().lastCropSettings.Right, Preferences.getInstance().lastStabilizer.Right);

            //Remember the last cropsettings before the final calculation is done
            Preferences.getInstance().lastCropSettings = lastCropSettings;
            
            Preferences.getInstance().lastStabilizer.Top = cropSettings.Top;
            Preferences.getInstance().lastStabilizer.Bottom = cropSettings.Bottom;
            Preferences.getInstance().lastStabilizer.Left = cropSettings.Left;
            Preferences.getInstance().lastStabilizer.Right = cropSettings.Right;
            
        }

        private static int calculateStabilizer(int cropSetting, int lastCropSetting, int lastStabilizer)
        {
            int result = 0;
            bool backwards = lastCropSetting > cropSetting;
            int rest = (cropSetting % Preferences.getInstance().stabilizationFactor) != 0 ? 1 : 0;
            int stabilizer = Preferences.getInstance().stabilizationFactor *
                                 (cropSetting / Preferences.getInstance().stabilizationFactor + rest);

            if ((cropSetting / Preferences.getInstance().stabilizationFactor) > 0)
            {

                if (cropSetting > stabilizer - Preferences.getInstance().stabilizationTolerance && (backwards && lastStabilizer > stabilizer))
                {
                    result = Preferences.getInstance().stabilizationFactor *
                                         (cropSetting / Preferences.getInstance().stabilizationFactor +
                                          rest + 1);
                }
                else
                {
                    if (!backwards && lastStabilizer > stabilizer)
                    {
                        result = Preferences.getInstance().stabilizationFactor *
                                  (cropSetting /
                                   Preferences.getInstance().stabilizationFactor +
                                   rest + 1);
                    }
                    else
                    {
                        result = stabilizer;
                    }
                }
            }
            //cropsetting is lower than the stabilizerFactor
            else
            {
                if (cropSetting != 0)
                {
                    if (cropSetting > stabilizer - Preferences.getInstance().stabilizationTolerance && (backwards && lastStabilizer > stabilizer))
                    {
                        result = Preferences.getInstance().stabilizationFactor*
                                      (cropSetting/
                                       Preferences.getInstance().stabilizationFactor +
                                       rest + 1);
                    }
                    else
                    {
                        if (!backwards && lastStabilizer > stabilizer)
                        {
                            result = Preferences.getInstance().stabilizationFactor *
                                      (cropSetting /
                                       Preferences.getInstance().stabilizationFactor +
                                       rest + 1);
                        }
                        else
                        {
                            result = Preferences.getInstance().stabilizationFactor;
                        }
                        
                    }
                }
                //CropSetting = 0
                else if (lastStabilizer > stabilizer)
                {
                    result = Preferences.getInstance().stabilizationFactor;
                }
            }

            Utils.log(Preferences.getInstance().verboselogging, "Stabilizer: {0}", result);
            return result;
            
        }

        public virtual Size getVideoSize()
        {
            var videoSize = new Size(0, 0);
            if (VMR9Util.g_vmr9 != null)
            {
                videoSize.Width = VMR9Util.g_vmr9.VideoWidth;
                videoSize.Height = VMR9Util.g_vmr9.VideoHeight;
            }
            return videoSize;
        }

        public static bool isPlaying()
        {
            return VMR9Util.g_vmr9 != null && VMR9Util.g_vmr9.VideoHeight > 0;
        }

        public static bool isSingleBlackBar(int line, int imageLine)
        {
            bool result = line > imageLine*(Preferences.getInstance().singleBlackBarHeight) &&
                          line < imageLine*(Preferences.getInstance().doubleBlackBarHeight);
            Utils.log(Preferences.getInstance().verboselogging,
                      "isSingleBlackBar: " + result);
            return result;
        }

        public static bool isDoubleBlackBar(int line, int imageLine)
        {
            bool result = line > imageLine*(Preferences.getInstance().doubleBlackBarHeight);
            Utils.log(Preferences.getInstance().verboselogging,
                      "isDoubleBlackBar: " + result);
            return result;
        }

        public static bool isSideBlackBar(int line, int imageWidth)
        {
            bool result = line > imageWidth*(Preferences.getInstance().singleBlackBarHeight);
            Utils.log(Preferences.getInstance().verboselogging,
                      "isSideBlackBar: {0}", result);

            return result;
        }
   }
}