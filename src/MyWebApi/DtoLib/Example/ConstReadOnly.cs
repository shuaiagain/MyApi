using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class ConstReadOnly
    {
        public const int One = 0;
        public readonly int two = 2;
        public static readonly int Three = 3;
        public const string str ="";
        public ConstReadOnly()
        {
            two++;
        }

        static ConstReadOnly()
        {
            Three++;
        }

        public void ConstReadOnlyTest()
        {
            Console.WriteLine("numA = {0}", ConstReadOnlyDTO.numA);
            Console.WriteLine("numB = {0}", ConstReadOnlyDTO.numB);
        }

        public void Print()
        {
            Console.WriteLine("One = {0} ", One);
            Console.WriteLine("Two = {0} ", two);
            Console.WriteLine("Three = {0} ", Three);
        }
    }
}
