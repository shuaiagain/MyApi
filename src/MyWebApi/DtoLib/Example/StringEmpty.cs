using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class StringEmpty
    {
        public readonly string Empty = "";
        public static readonly string EmptyGlobal = "1234";
        public string MyEmpty = string.Empty;
        public const string ConstEmpty = "";

        public void Print()
        {
            bool isEqual = Empty == string.Empty;
            Console.WriteLine("Empty == string.Empty = {0} ", isEqual);

            isEqual = Empty.Equals(string.Empty);
            Console.WriteLine("Empty.Equals(string.Empty) = {0} ", isEqual);

            isEqual = object.ReferenceEquals(Empty, string.Empty);

            Console.WriteLine("object.ReferenceEquals(Empty, string.Empty) = {0} ", isEqual);

            Console.WriteLine("string.IsInterned(string.Empty) = {0} ", string.IsInterned(string.Empty));
            Console.WriteLine("string.Intern(string.Empty) = {0} ", string.Intern(string.Empty));

        }

        public void TypeSize()
        {
            int size = sizeof(char);
            Console.WriteLine("sizeof(char) = {0} ", size);

            size = sizeof(int);
            Console.WriteLine("sizeof(int) = {0} ", size);

            size = sizeof(short);
            Console.WriteLine("sizeof(short) = {0} ", size);

            size = sizeof(bool);
            Console.WriteLine("sizeof(bool) = {0} ", size);

            size = sizeof(long);
            Console.WriteLine("sizeof(long) = {0} ", size);

            size = sizeof(double);
            Console.WriteLine("sizeof(double) = {0} ", size);
        }

        public void PrintString()
        {
            string a = "aaa" + "bbb" + "ccc";
            Console.WriteLine("{0}", a);

            a = a + "ddd";
            a += "eee";

        }

    }
}
