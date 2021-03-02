using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicKnowledge.Dal
{
    public class OneDto
    {
        #region 线程池-QueueUserWorkItem
        public static void ThreadPoolEg()
        {
            Console.WriteLine("main thread：queuing an asynchronous operation 1");
            ThreadPool.QueueUserWorkItem(new OneDto().Compute, "running");
            Console.WriteLine("main thread：doing other here 2");
            Thread.Sleep(5000);
            Console.WriteLine("Hit <Enter> to end this program ... 6 ");

            int workerThreads, completionPortThreads;
            ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
        }
        #endregion

        #region Compute,这个方法签名必须匹配WaitCallBack
        public void Compute(object state)
        {
            //这个方法由一个线程池线程执行
            Console.WriteLine("compute start 3");
            Console.WriteLine("state {0}  4", state);
            //模拟其他工作1秒钟
            Thread.Sleep(2000);
            Console.WriteLine("compute end 5 ");
            //这个方法返回后，线程会回到线程池中，等待下一个任务
        }
        #endregion

        #region AsynchronyWithTPL
        /// <summary>
        /// AsynchronyWithTPL
        /// </summary>
        /// <returns></returns>
        public static Task AsynchronyWithTPL()
        {
            Task<string> t = GetInfoAsync("Task 1");
            Console.WriteLine("main thread");
            Console.WriteLine("task's result = {0} ", t.Result);
            Console.WriteLine("main thread go on");
            Task t2 = t.ContinueWith(task => Console.WriteLine(t.Result), TaskContinuationOptions.NotOnFaulted);
            Task t3 = t.ContinueWith(task => Console.WriteLine(t.Exception.InnerException), TaskContinuationOptions.OnlyOnCanceled);

            //return Task.WhenAny(t2, t3);
            return t;
        }
        #endregion

        #region AsynchronyWithAwait
        /// <summary>
        /// AsynchronyWithAwait
        /// </summary>
        /// <returns></returns>
        public async static Task AsynchronyWithAwait()
        {
            try
            {
                string result = await GetInfoAsync("Task 2");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        #endregion

        #region GetInfoAsync
        /// <summary>
        /// GetInfoAsync
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async static Task<string> GetInfoAsync(string name)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //throw new Exception("Boom!");
            Console.WriteLine("in async method inside... ");
            return string.Format("Task {0} is  running on a  thread,id {1} . Is thread pool thread:{2} ",
                name, Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsThreadPoolThread);
        }
        #endregion

        #region TaskBasicOperate
        /// <summary>
        /// 1.task的执行是异步的，也就是task里方法的执行是不定时的
        /// 2.task外部方法是同步执行的
        /// 3.task与task之间如果不特殊设置的话，每个task的执行也是异步的
        /// </summary>
        public static void TaskBasicOperate()
        {
            Task.Run(() =>
            {
                Console.WriteLine("t0 end");
            });

            Task t1 = new Task(() =>
            {
                Console.WriteLine("t1 start ");
                //System.IO.File.WriteAllText(@"H:\mine\MyThread\Console\One\File\f1", "t1-逐字字符串");
                //System.IO.File.WriteAllText("H:\\mine\\MyThread\\Console\\One\\File\\f1", "t1-转义符");
                long index = 1000000;
                for (int i = 0; i < index; i++)
                {
                }

                Console.WriteLine("t1 end ");
            });

            Console.WriteLine("t1 status：{0}", t1.Status);
            t1.Start();
            Console.WriteLine("t1 status：{0}", t1.Status);
            //t1.Wait();
            Task t2 = new Task(() =>
           {
               Console.WriteLine("t2 start");
               System.IO.File.WriteAllText(@"H:\mine\MyThread\Console\One\File\f2", "t3");
               long index = 1000000;
               for (int i = 0; i < index; i++)
               {
               }
               Console.WriteLine("t2 end");
           });

            Console.WriteLine("t2 status：{0}", t2.Status);
            t2.Start();
            Console.WriteLine("t2 status：{0}", t2.Status);

            Task t3 = Task.Factory.StartNew(() =>
              {
                  Console.WriteLine("t3 start");
                  long index = 1000000;
                  for (int i = 0; i < index; i++)
                  {

                  }

                  Console.WriteLine("t3 end ");
              });

            Console.WriteLine("t3 status：{0}", t3.Status);

            Console.WriteLine("t1- status：{0}", t1.Status);
            Console.WriteLine("t2- status：{0}", t2.Status);
            Console.WriteLine("t3- status：{0}", t3.Status);
        }
        #endregion

        #region TaskBasicOperateTwo
        /// <summary>
        /// 1.task的执行是异步的，也就是task里方法的执行是不定时的
        /// 2.task外部方法是同步执行的
        /// 3.task与task之间如果不特殊设置的话，每个task的执行也是异步的
        /// </summary>
        public static void TaskBasicOperateTwo()
        {
            Task<string> t0 = Task<string>.Run(() =>
              {
                  Console.WriteLine("t0 end");
                  long index = 1000000000;
                  for (int i = 0; i < index; i++)
                  {
                  }
                  return "t0";
              });

            Console.WriteLine("t0 result：{0}", t0.Result);

            Task t1 = new Task(() =>
            {
                Console.WriteLine("t1 start ");
                long index = 1000000;
                for (int i = 0; i < index; i++)
                {
                }
                Console.WriteLine("t1 end ");
            });

            t1.Start();
            Task t2 = new Task(() =>
            {
                Console.WriteLine("t2 start");
                System.IO.File.WriteAllText(@"H:\mine\MyThread\Console\One\File\f2", "t3");
                long index = 1000000;
                for (int i = 0; i < index; i++)
                {
                }
                Console.WriteLine("t2 end");
            });

            t2.Start();

            Task t3 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t3 start");
                long index = 1000000;
                for (int i = 0; i < index; i++)
                {

                }
            });
        }
        #endregion

        #region TaskBasicOperateThree
        /// <summary>
        /// 1.task的执行是异步的，也就是task里方法的执行是不定时的
        /// 2.task外部方法是同步执行的
        /// 3.task与task之间如果不特殊设置的话，每个task的执行也是异步的
        /// </summary>
        public static void TaskBasicOperateThree()
        {
            Task t0 = new Task(() =>
            {
                Console.WriteLine("t0 start");
                int count = 1000000;
                for (int i = 0; i < count; i++)
                {
                }
                Console.WriteLine("t0 end");
            });

            Task t1 = new Task(() =>
            {
                Console.WriteLine("t1 start");
                int count = 1000000;
                for (int i = 0; i < count; i++)
                {
                }
                Console.WriteLine("t1 end");
            });

            t0.Start();
            t1.Start();

            Task<string> t2 = t1.ContinueWith<string>(task =>
              {
                  Console.WriteLine("t1 status：{0} ", t1.Status);
                  return "t1's next task's result ";
              });

            Console.WriteLine("t2's result：{0} ", t2.Result);

            Task t3 = new Task(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("t3 start ");
            });

            Task t4 = new Task(() =>
            {
                Console.WriteLine("t4 start ");
            });

            t3.Start();
            t4.Start();

            Task.WaitAny(t3, t4);
            Console.WriteLine("exist task completed");
        }
        #endregion

        #region 异步函数
        public async void AsynchronousFun()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("123456");
            });

        }
        #endregion
    }
}
