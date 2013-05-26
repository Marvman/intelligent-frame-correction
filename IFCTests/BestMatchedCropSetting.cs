using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IFCTests
{
    [TestClass]
    public class BestMatchedCropSetting
    {
        private Dictionary<int, int> bestMatchedCropSettingTop = new Dictionary<int, int>();
        private Dictionary<int, int> tempBestMatchedCropSettingTop = new Dictionary<int, int>();
        private int top;

        [TestMethod]
        public void TestaddBestMatchedCropSetting()
        {
            bestMatchedCropSettingTop.Add(1,1);
            
            top = 1;
            addBestMatchedCropSetting(top);
            Assert.AreEqual(tempBestMatchedCropSettingTop.Count, 0);
            Assert.AreEqual(1, bestMatchedCropSettingTop.Count);

            top = 2;
            addBestMatchedCropSetting(top);
            Assert.AreEqual(tempBestMatchedCropSettingTop.Count, bestMatchedCropSettingTop.Count);
            Assert.AreEqual(1, bestMatchedCropSettingTop.Count);

            top = 3;
            addBestMatchedCropSetting(top);
            Assert.AreEqual(tempBestMatchedCropSettingTop.Count, bestMatchedCropSettingTop.Count);
            Assert.AreEqual(1, bestMatchedCropSettingTop.Count);

            top = 2;
            addBestMatchedCropSetting(top);
            Assert.AreEqual(tempBestMatchedCropSettingTop.Count, bestMatchedCropSettingTop.Count);
            Assert.AreEqual(1, bestMatchedCropSettingTop.Count);

            top = 4;
            addBestMatchedCropSetting(top);
            Assert.AreNotEqual(tempBestMatchedCropSettingTop.Count, bestMatchedCropSettingTop.Count);
            Assert.AreEqual(2, bestMatchedCropSettingTop.Count);

            bestMatchedCropSettingTop.Clear();
            tempBestMatchedCropSettingTop.Clear();

            bestMatchedCropSettingTop.Add(1, 1);

            top = 1;
            addBestMatchedCropSetting(top);
            Assert.AreEqual(tempBestMatchedCropSettingTop.Count, 0);
            Assert.AreEqual(1, bestMatchedCropSettingTop.Count);

            top = 8;
            addBestMatchedCropSetting(top);
            Assert.AreEqual(2, bestMatchedCropSettingTop.Count);

            top = 3;
            addBestMatchedCropSetting(top);
            Assert.AreEqual(2, bestMatchedCropSettingTop.Count);

        }

        private void addBestMatchedCropSetting(int top)
        {
            if (!bestMatchedCropSettingTop.ContainsKey(top) && bestMatchedCropSettingTop.Count < 2)
            {
                if (bestMatchedCropSettingTop.Count < 1)
                {
                    bestMatchedCropSettingTop.Add(top, top);
                }
                else
                {

                   tempBestMatchedCropSettingTop = new Dictionary<int, int>(bestMatchedCropSettingTop);

                    Assert.AreEqual(tempBestMatchedCropSettingTop.Count, bestMatchedCropSettingTop.Count);

                    foreach (int temp in tempBestMatchedCropSettingTop.Values)
                    {
                        if (top > temp + 2 || top < temp - 2)
                        {
                            bestMatchedCropSettingTop.Add(top, top);
                        }
                    }
                }
            }
        }
    }
}
