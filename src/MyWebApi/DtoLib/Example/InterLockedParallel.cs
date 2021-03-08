using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class InterLockedParallel
    {
        static int value = 0;

        static void ChangeValue(int val)
        {
            value += val;
        }

        static void ChangeValueInterLocked(int val)
        {
            Interlocked.Add(ref value, val);
        }

        public static void Print()
        {
            for (int j = 0; j < 20; j++)
            {
                value = 0;
                Parallel.For(0, 10000, i => ChangeValue(1));
                Console.WriteLine("value = {0}", value);
            }
        }

        public static void Print1()
        {
            for (int j = 0; j < 20; j++)
            {
                value = 0;
                Parallel.For(0, 10000, i => ChangeValueInterLocked(1));
                Console.WriteLine("value = {0}", value);
            }
        }

    }
}
