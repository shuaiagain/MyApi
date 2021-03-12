using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    /// <summary>
    /// 指针类型
    /// </summary>
    public class PointerType
    {
        public unsafe static void Print()
        {
            Pointer();
            int a = 1, b = 2;
            ChangeValue(&a, &b);
        }

        static unsafe void Pointer()
        {
            int* a;
            int b = 2;
            a = &b;
            Console.WriteLine("a->ToString() = {0}", a->ToString());
            Console.WriteLine(" *a = {0}", *a);
            Console.WriteLine();
        }

        static unsafe void ChangeValue(int* a, int* b)
        {
            int temp = *a;
            a = b;
            b = &temp;

            Console.WriteLine("a={0},b={1}", *a, *b);
        }
    }
}
