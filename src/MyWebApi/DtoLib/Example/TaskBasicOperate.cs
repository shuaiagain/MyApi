using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class TaskBasicOperate
    {
        #region TaskBasicOperate
        /// <summary>
        /// 1.task的执行是异步的，也就是task里方法的执行是不定时的
        /// 2.task外部方法是同步执行的
        /// 3.task与task之间如果不特殊设置的话，每个task的执行也是异步的
        /// </summary>
        public static void TaskBasic()
        {
            Task.Run(() =>
            {
                Console.WriteLine("t0 end");
            });

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
            t1.Wait();
            Console.WriteLine("t1 status：{0}", t1.Status);

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

            Console.WriteLine("t1- status：{0}", t1.Status);
            Console.WriteLine("t2- status：{0}", t2.Status);
            Console.WriteLine("t3- status：{0}", t3.Status);
        }
        #endregion

        #region TaskBasicOperate
        /// <summary>
        /// 1.task的执行是异步的，也就是task里方法的执行是不定时的
        /// 2.task外部方法是同步执行的
        /// 3.task与task之间如果不特殊设置的话，每个task的执行也是异步的
        /// </summary>
        public static void InsertSort()
        {
            int[] arr = new int[] { 3, 2, 6, 4, 5, 1 };
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[i] < arr[j - 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j-1];
                        arr[j-1] = temp;
                    }
                }

                string result = string.Empty;
                for (int k = 0; k < arr.Length; k++)
                {
                    result = result + arr[k].ToString() + '，';
                }
                Console.WriteLine("{0}", result);
            }



            Console.WriteLine("sort end");
        }
        #endregion
    }
}
