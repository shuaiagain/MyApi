using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicKnowledge.Dal
{
    public class TwoDto
    {
        #region task.Delay
        /// <summary>
        /// task.Delay
        /// </summary>
        public static void DelayExample()
        {
            CancellationTokenSource source = new CancellationTokenSource();
            Task<int> t = Task.Run(async delegate
            {
                Console.WriteLine("async start");
                await Task.Delay(2000, source.Token);
                Console.WriteLine("async end ");
                return 42;
            });

            //source.Cancel();

            try
            {
                //t.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                    Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
            }

            Console.WriteLine("Task t Status: {0}", t.Status);
            //if (t.Status == TaskStatus.RanToCompletion)
            Console.WriteLine("Result: {0}", t.Result);
            source.Dispose();

            // The example displays the following output:
            //       TaskCanceledException: A task was canceled.
            //       Task t Status: Canceled
        }
        #endregion

        #region ThreadSleepEg
        /// <summary>
        /// ThreadSleepEg
        /// </summary>
        public static void ThreadSleepEg()
        {

            Stopwatch sw = new Stopwatch();
            Console.WriteLine("sw is ready to start ");
            sw.Start();
            Thread.Sleep(3000);
            var ar = sw.ElapsedMilliseconds;
            Console.WriteLine("t1 :{0} ,sw：{1} ", ar, sw.ElapsedMilliseconds);
            sw.Stop();
            Console.WriteLine("t1 :{0} ,sw：{1} ", ar, sw.ElapsedMilliseconds);
        }
        #endregion

        #region Stopwatch
        /// <summary>
        /// Stopwatch
        /// </summary>
        public static void DelayExampleTwo()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            DateTime t1 = DateTime.Now;
            Thread.Sleep(100);
            DateTime t2 = DateTime.Now;
            sw.Stop();

            long runTime = sw.ElapsedTicks;
            Console.WriteLine("stopwatch running time:{0} ", runTime);
            Console.WriteLine("datetime running time:{0} ", (t2 - t1).TotalMilliseconds);
        }
        #endregion

        #region threadpool-GetMaxThreads-GetAvailableThreads
        /// <summary>
        /// threadpool-GetMaxThreads-GetAvailableThreads
        /// </summary>
        public static void MaxThreadpoolEg()
        {
            int workerThreads;
            int completionPortThreads;
            ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine("workerThreads = {0}，completionPortThreads = {1} ", workerThreads, completionPortThreads);
            ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine("workerThreads = {0}，completionPortThreads = {1} ", workerThreads, completionPortThreads);
        }
        #endregion
    }
}
