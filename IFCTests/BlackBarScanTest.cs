using System;
using System.Drawing;
using System.Drawing.Imaging;
using IntelligentFrameCorrection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IFCTests
{
    [TestClass]
    public class BlackBarScanTest
    {
        [TestMethod]
        public void TestBlackBarScanner()
        {
            #region 4:3 single black bars

            var screen = new Screen16To9();
            Image loadedImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\4to3wSingleBlackBars.bmp");

            var testImage = new Bitmap(loadedImage, (Int32)(loadedImage.Width * (Preferences.getInstance().frameCaptureSize / 100f)), (Int32)(loadedImage.Height * (Preferences.getInstance().frameCaptureSize / 100f)));

            var mockFrameAnalyzer = new MockFrameAnalyzer();

            mockFrameAnalyzer.setSourceImage(testImage);
            mockFrameAnalyzer.setCurrentFrameAspectRatio(1.33f);
            mockFrameAnalyzer.setVideoSize(new Size(testImage.Width, testImage.Height));
            screen.setFrameAnalyzer(mockFrameAnalyzer);

            new IntelligentFrameCorrection.IntelligentFrameCorrection();
            Preferences.getInstance().stopCounterEnd = 1;

            bool[] blackbars = screen.scanForBlackBars();
            Assert.IsTrue(blackbars[0]);
            Assert.IsTrue(blackbars[2]);
            Assert.IsFalse(blackbars[1]);
            Assert.IsFalse(blackbars[3]);
            Assert.IsFalse(blackbars[4]);
            Assert.IsFalse(blackbars[5]);

            var cropsettings = screen.boundsToCropSettings();

            Assert.AreEqual(44, cropsettings.Top);
            Assert.AreEqual(45, cropsettings.Bottom);
            Assert.AreEqual(0, cropsettings.Left);
            Assert.AreEqual(1, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_4_3_LETTERBOX, screen.getBestViewModeMatch());

            #endregion

            #region 4:3 double black bars

            screen = new Screen16To9();
            screen.setFrameAnalyzer(mockFrameAnalyzer);
            testImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\4to3wDoubleBlackBars.bmp");
            mockFrameAnalyzer.setSourceImage(testImage);
            mockFrameAnalyzer.setCurrentFrameAspectRatio(1.33f);
            mockFrameAnalyzer.setVideoSize(new Size(testImage.Width, testImage.Height));

            blackbars = screen.scanForBlackBars();
            Assert.IsFalse(blackbars[0]);
            Assert.IsFalse(blackbars[2]);
            Assert.IsTrue(blackbars[1]);
            Assert.IsTrue(blackbars[3]);
            Assert.IsFalse(blackbars[4]);
            Assert.IsFalse(blackbars[5]);

            cropsettings = screen.boundsToCropSettings();

            Assert.AreEqual(46, cropsettings.Top);
            Assert.AreEqual(46, cropsettings.Bottom);
            Assert.AreEqual(0, cropsettings.Left);
            Assert.AreEqual(1, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_4_3_LETTERBOX, screen.getBestViewModeMatch());

            #endregion

            #region 4:3 white picture no bars

            screen = new Screen16To9();
            screen.setFrameAnalyzer(mockFrameAnalyzer);
            testImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\whitetest.bmp");
            mockFrameAnalyzer.setSourceImage(testImage);
            mockFrameAnalyzer.setCurrentFrameAspectRatio(1.33f);
            mockFrameAnalyzer.setVideoSize(new Size(testImage.Width, testImage.Height));

            blackbars = screen.scanForBlackBars();
            Assert.IsFalse(blackbars[0]);
            Assert.IsFalse(blackbars[2]);
            Assert.IsFalse(blackbars[1]);
            Assert.IsFalse(blackbars[3]);
            Assert.IsFalse(blackbars[4]);
            Assert.IsFalse(blackbars[5]);

            cropsettings = screen.boundsToCropSettings();

            Assert.AreEqual(0, cropsettings.Top);
            Assert.AreEqual(1, cropsettings.Bottom);
            Assert.AreEqual(0, cropsettings.Left);
            Assert.AreEqual(1, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_4_3, screen.getBestViewModeMatch());

            #endregion

            #region 16:9 single black bars

            screen = new Screen16To9();
            screen.setFrameAnalyzer(mockFrameAnalyzer);
            testImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\16to9wSingleBlackBars.bmp");
            mockFrameAnalyzer.setSourceImage(testImage);
            mockFrameAnalyzer.setCurrentFrameAspectRatio(1.78f);
            mockFrameAnalyzer.setVideoSize(new Size(testImage.Width, testImage.Height));

            blackbars = screen.scanForBlackBars();
            Assert.IsTrue(blackbars[0]);
            Assert.IsTrue(blackbars[2]);
            Assert.IsFalse(blackbars[1]);
            Assert.IsFalse(blackbars[3]);
            Assert.IsFalse(blackbars[4]);
            Assert.IsFalse(blackbars[5]);

            cropsettings = screen.boundsToCropSettings();

            Assert.AreEqual(0, cropsettings.Top);
            Assert.AreEqual(0, cropsettings.Bottom);
            Assert.AreEqual(0, cropsettings.Left);
            Assert.AreEqual(1, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_16_9_LETTERBOX, screen.getBestViewModeMatch());

            #endregion

            #region 16:9 side black bars

            screen = new Screen16To9();
            screen.setFrameAnalyzer(mockFrameAnalyzer);
            testImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\16to9wSideBlackBars.bmp");
            mockFrameAnalyzer.setSourceImage(testImage);
            mockFrameAnalyzer.setCurrentFrameAspectRatio(1.78f);
            mockFrameAnalyzer.setVideoSize(new Size(testImage.Width, testImage.Height));

            blackbars = screen.scanForBlackBars();
            Assert.IsFalse(blackbars[0]);
            Assert.IsFalse(blackbars[2]);
            Assert.IsFalse(blackbars[1]);
            Assert.IsFalse(blackbars[3]);
            Assert.IsTrue(blackbars[4]);
            Assert.IsTrue(blackbars[5]);

            cropsettings = screen.boundsToCropSettings();

            Assert.AreEqual(0, cropsettings.Top);
            Assert.AreEqual(1, cropsettings.Bottom);
            Assert.AreEqual(79, cropsettings.Left);
            Assert.AreEqual(80, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_16_9_WITH_SIDEBARS, screen.getBestViewModeMatch());

            #endregion

            #region 16:9 double black bars and side bars

            screen = new Screen16To9();
            screen.setFrameAnalyzer(mockFrameAnalyzer);
            testImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\16to9wDoubleBlackBarsAndSideBlackBars.bmp");
            mockFrameAnalyzer.setSourceImage(testImage);
            mockFrameAnalyzer.setCurrentFrameAspectRatio(1.78f);
            mockFrameAnalyzer.setVideoSize(new Size(testImage.Width, testImage.Height));

            blackbars = screen.scanForBlackBars();
            Assert.IsFalse(blackbars[0]);
            Assert.IsFalse(blackbars[2]);
            Assert.IsTrue(blackbars[1]);
            Assert.IsTrue(blackbars[3]);
            Assert.IsTrue(blackbars[4]);
            Assert.IsTrue(blackbars[5]);

            cropsettings = screen.boundsToCropSettings();

            Assert.AreEqual(46, cropsettings.Top);
            Assert.AreEqual(46, cropsettings.Bottom);
            Assert.AreEqual(79, cropsettings.Left);
            Assert.AreEqual(80, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_16_9_LETTERBOX, screen.getBestViewModeMatch());

            #endregion

            #region 16:9 single black bars and side bars

            screen = new Screen16To9();
            screen.setFrameAnalyzer(mockFrameAnalyzer);
            testImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\16to9wSingleBlackBarsAndSideBlackBars.bmp");
            mockFrameAnalyzer.setSourceImage(testImage);
            mockFrameAnalyzer.setCurrentFrameAspectRatio(1.78f);
            mockFrameAnalyzer.setVideoSize(new Size(testImage.Width, testImage.Height));

            blackbars = screen.scanForBlackBars();
            Assert.IsTrue(blackbars[0]);
            Assert.IsTrue(blackbars[2]);
            Assert.IsFalse(blackbars[1]);
            Assert.IsFalse(blackbars[3]);
            Assert.IsTrue(blackbars[4]);
            Assert.IsTrue(blackbars[5]);

            cropsettings = screen.boundsToCropSettings();

            Assert.AreEqual(44, cropsettings.Top);
            Assert.AreEqual(45, cropsettings.Bottom);
            Assert.AreEqual(79, cropsettings.Left);
            Assert.AreEqual(80, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_16_9_LETTERBOX, screen.getBestViewModeMatch());

            #endregion

            #region 16:9 white picture no bars

            screen = new Screen16To9();
            screen.setFrameAnalyzer(mockFrameAnalyzer);
            testImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\whitetest.bmp");
            mockFrameAnalyzer.setSourceImage(testImage);
            mockFrameAnalyzer.setCurrentFrameAspectRatio(1.78f);
            mockFrameAnalyzer.setVideoSize(new Size(testImage.Width, testImage.Height));

            blackbars = screen.scanForBlackBars();
            Assert.IsFalse(blackbars[0]);
            Assert.IsFalse(blackbars[2]);
            Assert.IsFalse(blackbars[1]);
            Assert.IsFalse(blackbars[3]);
            Assert.IsFalse(blackbars[4]);
            Assert.IsFalse(blackbars[5]);

            cropsettings = screen.boundsToCropSettings();

            Assert.AreEqual(0, cropsettings.Top);
            Assert.AreEqual(1, cropsettings.Bottom);
            Assert.AreEqual(0, cropsettings.Left);
            Assert.AreEqual(1, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_16_9, screen.getBestViewModeMatch());

            #endregion

            #region transient from 16:9 single black bars and side bars to 16:9 single black bars

            screen = new Screen16To9();
            screen.setFrameAnalyzer(mockFrameAnalyzer);
            testImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\16to9wSingleBlackBarsAndSideBlackBars.bmp");
            mockFrameAnalyzer.setSourceImage(testImage);
            mockFrameAnalyzer.setCurrentFrameAspectRatio(1.78f);
            mockFrameAnalyzer.setVideoSize(new Size(testImage.Width, testImage.Height));

            blackbars = screen.scanForBlackBars();
            Assert.IsTrue(blackbars[0]);
            Assert.IsTrue(blackbars[2]);
            Assert.IsFalse(blackbars[1]);
            Assert.IsFalse(blackbars[3]);
            Assert.IsTrue(blackbars[4]);
            Assert.IsTrue(blackbars[5]);

            cropsettings = screen.boundsToCropSettings();

            Assert.AreEqual(44, cropsettings.Top);
            Assert.AreEqual(45, cropsettings.Bottom);
            Assert.AreEqual(79, cropsettings.Left);
            Assert.AreEqual(80, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_16_9_LETTERBOX, screen.getBestViewModeMatch());

            screen.setFrameAnalyzer(mockFrameAnalyzer);
            testImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\16to9wSingleBlackBars.bmp");
            mockFrameAnalyzer.setSourceImage(testImage);
            mockFrameAnalyzer.setCurrentFrameAspectRatio(1.78f);
            mockFrameAnalyzer.setVideoSize(new Size(testImage.Width, testImage.Height));

            blackbars = screen.scanForBlackBars();
            Assert.IsTrue(blackbars[0]);
            Assert.IsTrue(blackbars[2]);
            Assert.IsFalse(blackbars[1]);
            Assert.IsFalse(blackbars[3]);
            Assert.IsFalse(blackbars[4]);
            Assert.IsFalse(blackbars[5]);

            cropsettings = screen.boundsToCropSettings();

            Assert.AreEqual(0, cropsettings.Top);
            Assert.AreEqual(0, cropsettings.Bottom);
            Assert.AreEqual(0, cropsettings.Left);
            Assert.AreEqual(1, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_16_9_LETTERBOX, screen.getBestViewModeMatch());

            #endregion
        }
    }
}