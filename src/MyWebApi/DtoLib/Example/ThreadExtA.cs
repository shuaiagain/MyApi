using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //ThreadC();
            //ThreadD();
            //TaskA();
            //TaskB();
            //TaskC();
            TaskD();
        }

        #region TaskD
        /// <summary>
        /// task异常捕获
        /// </summary>
        private static void TaskD()
        {
            try
            {
                var parent = Task.Factory.StartNew(() =>
                {
                    int[] nums = { 0 };
                    var childFactory = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.None);

                    childFactory.StartNew(() => 1 / nums[0]);
                    childFactory.StartNew(() => 1 / nums[0]);
                    childFactory.StartNew(() => throw null);
                });

                parent.Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var item in ex.InnerExceptions)
                {
                    Console.WriteLine($"ex:{item.Message}");
                }
            }

            Console.Read();
        }

        #endregion

        #region TaskC
        /// <summary>
        /// task异常捕获
        /// </summary>
        private static void TaskC()
        {
            Console.WriteLine($"主线程 id：{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"主线程 is backgroudthread ：{Thread.CurrentThread.IsBackground}");
            Console.WriteLine($"主线程 is IsThreadPoolThread ：{Thread.CurrentThread.IsThreadPoolThread}");

            Task.Run(() =>
            {
                Console.WriteLine($"子线程1 id：{Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"子线程1 is backgroudthread ：{Thread.CurrentThread.IsBackground}");
                Console.WriteLine($"子线程1 is IsThreadPoolThread ：{Thread.CurrentThread.IsThreadPoolThread}");
                return new { aa = 1 };
            }).ContinueWith(t =>
            {
                Console.WriteLine($"1ContinueWith Completed:threadId:{Thread.CurrentThread.ManagedThreadId},isThreadPool:{Thread.CurrentThread.IsThreadPoolThread}");
                Console.WriteLine($"1ContinueWith Completed:{t.Result}");
            }, TaskContinuationOptions.ExecuteSynchronously);

            var getAwaiter = Task.Run(() =>
              {
                  Console.WriteLine($"子线程2 id：{Thread.CurrentThread.ManagedThreadId}");
                  Console.WriteLine($"子线程2 is backgroudthread ：{Thread.CurrentThread.IsBackground}");
                  Console.WriteLine($"子线程2 is IsThreadPoolThread ：{Thread.CurrentThread.IsThreadPoolThread}");
                  return new { aa = 2 };
              }).GetAwaiter();

            getAwaiter.OnCompleted(() =>
            {
                var a = getAwaiter.GetResult();
                Console.WriteLine($"2 ContinueWith Completed:threadId:{Thread.CurrentThread.ManagedThreadId},isThreadPool:{Thread.CurrentThread.IsThreadPoolThread}");
                Console.WriteLine($"2 ContinueWith Completed:{a}");
            });


            Console.WriteLine($"主线程 CurrentContext.ContextID：{Thread.CurrentContext.ContextID}");
            Console.Read();
        }

        #endregion

        #region TaskB
        /// <summary>
        /// task异常捕获
        /// </summary>
        private static void TaskB()
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        Console.WriteLine("task running");
                        int a = 0;
                        int b = 1;
                        int c = b / a;
                        throw new Exception("1234");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"ex:{ex.Message}");
                        throw ex;
                    }
                });

                Thread thread = new Thread(() =>
                {
                    var a = 0;
                    var b = 1;
                    var c = b / a;
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Console.ReadKey();
        }


        #endregion

        #region TaskA
        /// <summary>
        /// 任务启动的3种方式
        /// </summary>
        private static void TaskA()
        {
            Task.Run(() =>
            {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                var isbackground = Thread.CurrentThread.IsBackground;
                var isthreadpool = Thread.CurrentThread.IsThreadPoolThread;

                Thread.Sleep(3000);
                Debug.WriteLine($"task1 work on thread:{threadId},isBackgound:{isbackground},isThreadPool:{isthreadpool}");
            });

            Task task = new Task(() =>
            {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                var isBackgound = Thread.CurrentThread.IsBackground;
                var isThreadPool = Thread.CurrentThread.IsThreadPoolThread;
                Thread.Sleep(3000);//模拟耗时操作
                Debug.WriteLine($"task2 work on thread:{threadId},isBackgound:{isBackgound},isThreadPool:{isThreadPool}");
            });

            task.Start(TaskScheduler.FromCurrentSynchronizationContext());

            Task.Factory.StartNew(() =>
            {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                var isBackgound = Thread.CurrentThread.IsBackground;
                var isThreadPool = Thread.CurrentThread.IsThreadPoolThread;
                Thread.Sleep(3000);//模拟耗时操作
                Debug.WriteLine($"task3 work on thread:{threadId},isBackgound:{isBackgound},isThreadPool:{isThreadPool}");
            }, TaskCreationOptions.LongRunning);
        }
        #endregion

        #region ThreadD
        private static void ThreadD()
        {
            Console.WriteLine("主线程代码");

            ThreadPool.SetMaxThreads(6, 6);

            ThreadPool.GetMaxThreads(out int maxWorkerThreads, out int maxCompletionPortThreads);
            Console.WriteLine("workerThreads = {0}，completionPortThreads = {1}", maxWorkerThreads, maxCompletionPortThreads);

            ThreadPool.GetMinThreads(out int minWorkerThreads, out int minCompletionPortThreads);
            Console.WriteLine("workerThreads = {0}，completionPortThreads = {1}", minWorkerThreads, minCompletionPortThreads);

            for (int i = 0; i < 20; i++)
            {
                ThreadPool.QueueUserWorkItem(s =>
                {
                    var workThreadId = Thread.CurrentThread.ManagedThreadId;
                    var isbackgroudThread = Thread.CurrentThread.IsBackground;
                    var isthreadpoolthread = Thread.CurrentThread.IsThreadPoolThread;

                    Console.WriteLine(string.Format("work is on threadId = {0}，now time is:{1} , isbackgroundthread:{2}，isthreadpoolthread:{3}", workThreadId, DateTime.Now.ToString("ss.ff"), isbackgroudThread, isthreadpoolthread));

                    Thread.Sleep(5000);
                });
            }

            Console.ReadLine();
        }
        #endregion

        #region ThreadC
        private static void ThreadC()
        {
            Console.WriteLine("主线程代码");

            ThreadPool.GetMaxThreads(out int maxWorkerThreads, out int maxCompletionPortThreads);
            Console.WriteLine("workerThreads = {0}，completionPortThreads = {1}", maxWorkerThreads, maxCompletionPortThreads);

            ThreadPool.GetMinThreads(out int minWorkerThreads, out int minCompletionPortThreads);
            Console.WriteLine("workerThreads = {0}，completionPortThreads = {1}", minWorkerThreads, minCompletionPortThreads);

            for (int i = 0; i < 20; i++)
            {
                ThreadPool.QueueUserWorkItem(s =>
                {
                    var workThreadId = Thread.CurrentThread.ManagedThreadId;
                    var isbackgroudThread = Thread.CurrentThread.IsBackground;
                    var isthreadpoolthread = Thread.CurrentThread.IsThreadPoolThread;

                    Console.WriteLine(string.Format("work is on threadId = {0}，now time is:{1} , isbackgroundthread:{2}，isthreadpoolthread:{3}", workThreadId, DateTime.Now.ToString("ss.ff"), isbackgroudThread, isthreadpoolthread));

                    Thread.Sleep(5000);
                });
            }

            Console.ReadLine();
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
