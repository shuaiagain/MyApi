using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public delegate void ActionSync();
    public class ThreadExtE
    {
        public static void Print()
        {
            ExampleB();
            //ExampleA();
            //Example();
        }

        #region Example线程的无序性
        public static void Example()
        {
            Thread thread = new Thread(() =>
               {
                   for (int i = 0; i < 10; i++)
                   {
                       Console.WriteLine("sub thread1，threadid:{0}", Thread.CurrentThread.ManagedThreadId);
                   }
               });

            Thread thread2 = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("sub thread2，threadid:{0}", Thread.CurrentThread.ManagedThreadId);
                }
            });

            thread2.Priority = ThreadPriority.Highest;

            thread.Start();
            thread2.Start();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("main thread，threadid:{0}", Thread.CurrentThread.ManagedThreadId);
            }

            Console.ReadKey();
        }
        #endregion

        #region Example线程的无序性
        public static void ExampleA()
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("sub thread1，threadid:{0}", Thread.CurrentThread.ManagedThreadId);
                }
            });

            Console.WriteLine("main threadId : {0} ", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("main thread");
            ActionSync act = delegate ()
            {
                Console.WriteLine("this is a anonymous function，threadId : {0} ", Thread.CurrentThread.ManagedThreadId);
            };

            //act.BeginInvoke(a =>
            //{
            //    Console.WriteLine("callback does success ");
            //    Console.WriteLine("BeginInvoke threadId : {0} ", Thread.CurrentThread.ManagedThreadId);
            //}, null);
            act.BeginInvoke(a =>
            {
                Console.WriteLine("callback does success:{0} ", a);
                Console.WriteLine("BeginInvoke threadId : {0} ", Thread.CurrentThread.ManagedThreadId);
            }, 666);

            Console.WriteLine("main thread2");
            Console.ReadKey();
        }
        #endregion

        public static void ExampleB()
        {
            Console.WriteLine("main threadId1 :{0}", Thread.CurrentThread.ManagedThreadId);
            Task.Run(() =>
            {
                Console.WriteLine("subthread1:{0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("subthread1 :{0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("subthread1");
            });

            Task.Run(() =>
            {
                Console.WriteLine("subthread3 :{0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("subthread3");
            });

            Task.Run(() =>
            {
                Console.WriteLine("subthread2 :{0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("subthread2");
            });
            Console.WriteLine("main threadId2 :{0}", Thread.CurrentThread.ManagedThreadId);

            ThreadPool.QueueUserWorkItem(a => { Console.WriteLine("state：{0}", a); }, "pool");
            Console.ReadKey();

            //ThreadPool.SetMaxThreads();
        }

    }
}
