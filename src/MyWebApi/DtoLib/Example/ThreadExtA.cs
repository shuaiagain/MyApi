using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class ThreadExtA
    {
        public static void Print()
        {
            //ThreadA();
            //ThreaB();
            ThreadC();
        }

        #region ThreadC
        private static void ThreadC()
        {
            Console.WriteLine("主线程代码");

            ThreadPool.GetMaxThreads(out int maxWorkerThreads, out int maxCompletionPortThreads);
            Console.WriteLine("workerThreads = {0}，completionPortThreads = {1}", maxWorkerThreads, maxCompletionPortThreads);

            ThreadPool.GetMinThreads(out int minWorkerThreads, out int minCompletionPortThreads);
            Console.WriteLine("workerThreads = {0}，completionPortThreads = {1}", minWorkerThreads, minCompletionPortThreads);

            Console.WriteLine("主线程代码2");
        }
        #endregion

        #region ThreadB
        private static void ThreaB()
        {

            Console.WriteLine("主线程代码1");
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    for (int j = 0; j < 100000; j++)
                    {
                        Console.WriteLine("i*j");
                    }
                }
            });
            thread.IsBackground = true;
            thread.Start();

            Console.WriteLine("主线程代码2");
        }
        #endregion

        #region ThreadA
        private static void ThreadA()
        {

            Console.WriteLine("主线程代码1");
            int worksThreads = 0, completionPortThreads = 0;

            ThreadPool.GetAvailableThreads(out worksThreads, out completionPortThreads);
            Console.WriteLine("before create a new thread, ThreadPool's AvailableThreadsCount = {0}", worksThreads + completionPortThreads);

            Thread thread = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("--a--");
            });

            Console.WriteLine("thread1 is a IsBackground = {0}, thread1 is a IsThreadPoolThread {1}  ", thread.IsBackground, thread.IsThreadPoolThread);

            thread.Start();

            Task task = new Task(() =>
              {
                  Console.WriteLine(" create threadpool's  thread ");
              });

            task.Start();

            ThreadPool.GetAvailableThreads(out worksThreads, out completionPortThreads);
            Console.WriteLine("after create a new thread, ThreadPool's AvailableThreadsCount = {0}", worksThreads + completionPortThreads);

            Console.WriteLine("主线程代码2");


            Thread thread2 = new Thread((para) =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("thread with parameter :{0} ", para ?? string.Empty);
            });

            thread2.Start(12);


            Console.Read();
        }
        #endregion
    }
}
