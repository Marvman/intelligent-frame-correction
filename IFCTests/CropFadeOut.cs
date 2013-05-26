using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace IFCTests
{
    /// <summary>
    /// Summary description for CropFadeOut
    /// </summary>
    [TestClass]
    public class CropFadeOut
    {
        //int toTop = 2, toBottom = 3, toLeft = 4, toRight = 5;
        //int fromTop = 70, fromBottom = 60, fromLeft = 5, fromRight = 6;
        
        public CropFadeOut()
        {

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestFadeOut(int fromTop, int fromBottom, int fromLeft, int fromRight, int toTop, int toBottom, int toLeft, int toRight)
        {
            int currentTop = 0, currentBottom = 0, currentLeft = 0, currentRight = 0;

            for (int t = fromTop, b = fromBottom, l = fromLeft, r = fromRight; 
                            t >= toTop ||
                            b >= toBottom ||
                            l >= toLeft ||
                            r >= toRight; 
                            t--, b--, l--, r--)
            {
                if (t >= toTop)
                {
                    //Assert.AreEqual(fromTop+1, t);
                    currentTop = t;
                }
                if (b >= toBottom)
                {
                    currentBottom = b;
                }
                if (l >= toLeft)
                {
                    currentLeft = l;
                }
                if (r >= toRight)
                {
                    currentRight = r;
                }

                Thread.Sleep(1);
                System.Console.Out.WriteLine(currentTop + " " + currentBottom + " " + currentLeft + " " + currentRight);
            }


            System.Console.Out.WriteLine("");
            Assert.AreEqual(toTop, currentTop);
            Assert.AreEqual(toBottom, currentBottom);
            Assert.AreEqual(toLeft, currentLeft);
            Assert.AreEqual(toRight, currentRight);
            
        }

    }
}
