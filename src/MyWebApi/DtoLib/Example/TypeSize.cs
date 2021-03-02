using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    class TypeSize
    {
        int one;

        public object two;

        public void printOne(int one)
        {
            Console.WriteLine("{0}", one);
        }
    }
}
