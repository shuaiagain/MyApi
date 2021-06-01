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
    public class AsyncAwaitC
    {
        #region Print
        public static void Print()
        {
            ExampleA();
        }
        #endregion

        static void ExampleA()
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine(" Method 1");
                }
            });
        }

        static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

    }
}
