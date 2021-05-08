using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class Dictionary_Condictionary
    {

        public static void Print()
        {
            ExampleC();
            //ExampleB();
            //ExampleA();
        }

        #region ExampleC
        private static void ExampleC()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            ThreadPool.QueueUserWorkItem(a =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error1：{0}", ex.Message);
                }
            });

            ThreadPool.QueueUserWorkItem(a =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error2：{0}", ex.Message);
                }
            });
            ThreadPool.QueueUserWorkItem(a =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error3：{0}", ex.Message);
                }
            });

            ThreadPool.QueueUserWorkItem(a =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error4：{0}", ex.Message);
                }
            });

            ThreadPool.QueueUserWorkItem(a =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error5：{0}", ex.Message);
                }
            });

            Thread.Sleep(2000);
            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("key = {0},value = {1}", item.Key, item.Value);
            }
        }
        #endregion

        #region ExampleB
        private static void ExampleB()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Thread t1 = new Thread(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error1：{0}", ex.Message);
                }
            });


            Thread t2 = new Thread(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error2：{0}", ex.Message);
                }
            });

            Thread t3 = new Thread(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error3：{0}", ex.Message);
                }
            });

            Thread t4 = new Thread(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error4：{0}", ex.Message);
                }
            });

            Thread t5 = new Thread(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error5：{0}", ex.Message);
                }
            });

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();

            Thread.Sleep(2000);
            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("key = {0},value = {1}", item.Key, item.Value);
            }
        }
        #endregion

        #region ExampleA
        private static void ExampleA()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            TaskFactory taskFactory = new TaskFactory(TaskCreationOptions.None, TaskContinuationOptions.None);

            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error1：{0}", ex.Message);
                }
            });
            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error2：{0}", ex.Message);
                }
            });
            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error3：{0}", ex.Message);
                }
            });
            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error4：{0}", ex.Message);
                }
            });
            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error5：{0}", ex.Message);
                }
            });
            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error6：{0}", ex.Message);
                }
            });
            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error7：{0}", ex.Message);
                }
            });
            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error8：{0}", ex.Message);
                }
            });
            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error9：{0}", ex.Message);
                }
            });
            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error10：{0}", ex.Message);
                }
            });

            Thread.Sleep(2000);

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("key = {0},value = {1}", item.Key, item.Value);
            }
        }
        #endregion
    }
}
