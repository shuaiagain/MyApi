using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class ThreeTaskOperate
    {
        public static void ContinueWithEg()
        {
            try
            {
                var task1 = new Task(() =>
                {
                    Console.WriteLine("task1 start");
                    Thread.Sleep(2000);
                    Console.WriteLine("task1 end");
                    throw new Exception("task1 error");
                });

               // var task2 = Task.Run(() =>
               //{
               //    Console.WriteLine("task2 start");
               //    Thread.Sleep(3000);
               //    Console.WriteLine("task2 end");
               //    throw new Exception("task1 error");
               //});

                task1.Start();
                //task2.Start();

                var result = task1.ContinueWith<string>(task =>
                {
                    Console.WriteLine("task3 start");
                    //throw new Exception("task3 error");
                    return "task3's result";
                });

                Console.WriteLine(result.Result.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("message：{0}", ex.Message);
                Console.WriteLine("InnerException：{0}", ex.InnerException);
            }
        }
    }
}
