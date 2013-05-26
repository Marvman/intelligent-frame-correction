using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using IntelligentFrameCorrection;

namespace IFCTests
{
    /// <summary>
    /// Summary description for Threading
    /// </summary>
    [TestClass]
    public class Threading
    {
        BackgroundWorker processingThread = new BackgroundWorker();
        BackgroundWorker processingThread2 = new BackgroundWorker();
        static EventWaitHandle finished = new AutoResetEvent(false);

        Object locked = new Object();

        public Threading()
        {
            //
            // TODO: Add constructor logic here
            //
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
        public void TestMethod1()
        {
            
            processingThread.DoWork += run;
            //processingThread2.DoWork += run2;
            processingThread.WorkerSupportsCancellation = true;
            //processingThread2.WorkerSupportsCancellation = true;
            processingThread.RunWorkerCompleted += complete;
            //processingThread.RunWorkerAsync();
            //processingThread2.RunWorkerAsync();
            
            //Thread.Sleep(1);
            
            
            //if (processingThread.IsBusy)
            //{
            //    Console.Out.WriteLine("Start Cancel: " + DateTime.Now);
            //    processingThread.CancelAsync();
                
            //    Console.Out.WriteLine("End Cancel: " + DateTime.Now);
            //}
            //else
            //{
            //   processingThread.RunWorkerAsync();
            //}
            
            //Console.Out.WriteLine("Start Cancel: " + DateTime.Now);
            //processingThread.CancelAsync();
            //Console.Out.WriteLine("End Cancel: " + DateTime.Now);
            startThread();
            for (int i = 0; i < 10; i++)
            {
                
                Monitor.Enter(this);
                Console.Out.WriteLine("testThread: " + i);
                stopThread();
                //startThread();
                Monitor.Exit(this);
                //Thread.Sleep(1);
            }
        }

        static void complete(object sender, RunWorkerCompletedEventArgs e)
        {
            //Console.Out.WriteLine(e.Cancelled);
            Console.Out.WriteLine("completed");
            finished.Set();
        }
        //private void run2(object sender, DoWorkEventArgs e)
        //{
        //    Console.Out.WriteLine("enter 2nd run: " + DateTime.Now);
        //    for (int i = 0; i < 100; i++)
        //    {
                
        //        Monitor.Enter(this);
        //        Console.Out.WriteLine("run2Thread: " + i);
        //        stopThread();
        //        //startThread();
        //        Monitor.Exit(this);
        //    }
        //}
        private void run(object sender, DoWorkEventArgs e)
        {
       
            while(true)
            {
                if (processingThread.CancellationPending)
                {
                    Console.Out.WriteLine("Canceled: " + DateTime.Now);
                    e.Cancel = true;
                    //finished.Set();
                    return;
                }
                //Console.Out.WriteLine(processingThread.CancellationPending);
                //processingThread.ReportProgress(100);
                //Thread.Sleep(10);
                //Console.Out.WriteLine("do some work: " + DateTime.Now.Millisecond);
            }
        }
    
        private void startThread()
        {
            //Monitor.Enter(locked);
            processingThread.RunWorkerAsync();
            Console.Out.WriteLine("Started");
            //Monitor.Exit(locked);
        }

        private void stopThread()
        {
            Console.Out.WriteLine("Thread stopping...");
            //processingThread.CancelAsync();
            //sleep.Set();
            Console.Out.WriteLine("processingThread.IsBusy {0}, processingThread.CancellationPending {1}", processingThread.IsBusy, processingThread.CancellationPending);
            if (processingThread.IsBusy)
            {
                Console.Out.WriteLine("processingThread is still busy :-/");
                processingThread.CancelAsync();
                finished.WaitOne(500);
            }
            Console.Out.WriteLine("Thread stopped!");
        }
    }
}
