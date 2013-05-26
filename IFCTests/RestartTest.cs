using System.Drawing;
using IntelligentFrameCorrection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IFCTests
{
    [TestClass]
    public class RestartTest
    {
        [TestMethod]
        public void TestRestart()
        {
            var screen = new Screen16To9();
            var testImage =
                new Bitmap(
                    @"D:\Eigene Dateien\Visual Studio 2010\Projects\IntelligentFrameCorrection\IFCTests\TestImages\4to3wSingleBlackBars.bmp");
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
            Assert.AreEqual(0, cropsettings.Right);
            Assert.AreEqual(AspectRatios.AR_16_9_LETTERBOX, screen.getBestViewModeMatch());
        }
    }
}
