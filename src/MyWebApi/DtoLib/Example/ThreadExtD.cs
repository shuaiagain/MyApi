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
    public class ThreadExtD
    {
        public static void Print()
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        public static async void Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.WriteLine("Method1");
                }
            });
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("method 2");
            }
        }

    }
}
