using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class StringEmptyDBNull
    {
        public static void Print()
        {
            ExampleB();
            //ExampleA();
        }

        private static void ExampleB()
        {
            object a = DBNull.Value;
            object b = null;
            Console.WriteLine($"a==b:{a == b}");

            Console.WriteLine($"DBNull.Value:{DBNull.Value.ToString().Length}");
            Console.WriteLine($"null:{null}");
            Console.WriteLine($"DBNull.length = {typeof(DBNull)}");

            Console.WriteLine($"Convert.IsDBNull(DBNull.Value)= {Convert.IsDBNull(DBNull.Value)}");
        }

        private static void ExampleA()
        {
            string str = string.Empty;
            string stra = "";

            Console.WriteLine("str.Equals(stra) = {0}", str.Equals(stra));
            Console.WriteLine("object.ReferenceEquals(str,stra) = {0}", object.ReferenceEquals(str, stra));
            Console.WriteLine("str == stra = {0}", str == stra);
        }
    }
}
