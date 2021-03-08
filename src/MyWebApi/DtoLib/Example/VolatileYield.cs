using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class VolatileYield
    {
        static bool isSingle = false;

        public static void Print()
        {
            Parallel.Invoke(() => PrintList1(), () => PrintList2());
        }

        public static void Print1()
        {
            Parallel.Invoke(() => PrintList3(), () => PrintList4());
        }

        #region PrintList1
        static void PrintList1()
        {
            for (int i = 0; i < 50; i = i + 2)
            {
                while (true)
                {
                    if (Volatile.Read(ref isSingle) == true)
                    {
                        Console.WriteLine("PrintList1： {0}", i);
                        Volatile.Write(ref isSingle, false);
                        break;
                    }

                    Thread.Yield();
                }
            }
        }
        #endregion

        #region PrintList2
        static void PrintList2()
        {
            for (int i = 0; i < 50; i = i + 2)
            {
                while (true)
                {
                    if (Volatile.Read(ref isSingle) == false)
                    {
                        Console.WriteLine("PrintList2：{0} ", i);
                        Volatile.Write(ref isSingle, true);
                        break;
                    }
                    Thread.Yield();
                }
            }
        }
        #endregion

        #region PrintList3
        static void PrintList3()
        {
            for (int i = 0; i < 50; i = i + 2)
            {
                while (true)
                {
                    isSingle = true;
                    if (isSingle == true)
                    {
                        Console.WriteLine("PrintList3： {0}", i);
                        isSingle = false;
                        break;
                    }

                    Thread.Yield();
                }
            }
        }
        #endregion

        #region PrintList4
        static void PrintList4()
        {
            for (int i = 0; i < 50; i = i + 2)
            {
                while (true)
                {
                    isSingle = false;
                    if (isSingle == false)
                    {
                        Console.WriteLine("PrintList4：{0} ", i);
                        isSingle = true;
                        break;
                    }
                    Thread.Yield();
                }
            }
        }
        #endregion
    }
}
