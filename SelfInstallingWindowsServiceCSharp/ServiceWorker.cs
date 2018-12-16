using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace SelfInstallingWindowsServiceCSharp
{
    class ServiceWorker
    {
        private Thread workerThread;
        private static readonly string AppPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public void Start()
        {
            workerThread = new Thread(StartService)
            {
                IsBackground = true
            };
            workerThread.Start();
            Console.WriteLine("Service started.");
        }

        public void Stop()
        {
            workerThread.Abort();
            workerThread = null;
            StopService();
            Console.WriteLine("Service stopped.");
        }

        #region "Your service's code goes here"

        // The sample service code below writes the current time to a text file every second.
        // replace it with your code to perform your tasks.

        private System.Timers.Timer workerTimer;

        private void StartService()
        {
            workerTimer = new System.Timers.Timer(1000);
            workerTimer.Elapsed += WorkerTimer_Elapsed;
            workerTimer.Start();
        }

        private void StopService()
        {
            workerTimer.Stop();
        }

        private void WorkerTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
           using (StreamWriter sw = new StreamWriter(Path.Combine(AppPath, "test.txt")))
            {
                sw.WriteLine(DateTime.Now.ToString());
            }
        }



        #endregion
    }
}
