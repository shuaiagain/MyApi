using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class StreamExt5
    {
        public static void Print()
        {
            ExampleB();
            //ExampleA();
        }

        #region ExampleB
        public static void ExampleB()
        {
            byte[] tempBytes = new byte[256 * 1024];
            //publiclyVisible:true 才能访问GetBuffer 方法
            MemoryStream ms = new MemoryStream(tempBytes, 0, tempBytes.Length, true, true);
            using (ms)
            {
                Console.WriteLine("ms.GetBuffer() = {0}", ms.GetBuffer().Length);
            }

            Console.ReadLine();
        }
        #endregion

        #region ExampleA
        public static void ExampleA()
        {
            byte[] testBytes = new byte[256 * 1024 * 1024];
            MemoryStream ms = new MemoryStream();

            using (ms)
            {
                for (int i = 0; i < 1000; i++)
                {
                    try
                    {
                        ms.Write(testBytes, 0, testBytes.Length);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("该内存流已经使用了{0}M容量的内存,该内存流最大容量为{1}M,溢出时容量为{2}M",
                         GC.GetTotalMemory(false) / (1024 * 1024),//MemoryStream已经消耗内存量
                         ms.Capacity / (1024 * 1024), //MemoryStream最大的可用容量
                         ms.Length / (1024 * 1024));//MemoryStream当前流的长度（容量）
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
        #endregion
    }

}
