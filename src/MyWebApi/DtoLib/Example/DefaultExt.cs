using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class DefaultExt
    {
        public static void Print()
        {
            Example();
        }

        static void Example()
        {
            Console.WriteLine("default(string) : {0}", default(string));
            Console.WriteLine("default(int) : {0}", default(int));
            Console.WriteLine("default(float) : {0}", default(float));
            Console.WriteLine("default(double) : {0}", default(double));
            Console.WriteLine("default(bool) : {0}", default(bool));
            Console.WriteLine("default(char) : {0}", default(char));
        }
    }
}
