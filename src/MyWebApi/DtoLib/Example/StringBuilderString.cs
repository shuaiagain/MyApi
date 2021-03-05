using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class StringBuilderString
    {

        public void Print()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(" sb.Length = {0}，sb.Capacity = {1} ", sb.Length, sb.Capacity);
            sb.AppendFormat("1-2-3-4-5-6-7-8");
            Console.WriteLine(" sb.Length = {0}，sb.Capacity = {1} ", sb.Length, sb.Capacity);
            sb.AppendFormat("1-2-3-4-5-6-7-8");
            Console.WriteLine(" sb.Length = {0}，sb.Capacity = {1} ", sb.Length, sb.Capacity);
            sb.AppendFormat("1-2-3-4-5-6-7-8");
            sb.AppendFormat("1-2-3-4-5-6-7-8");
            Console.WriteLine(" sb.Length = {0}，sb.Capacity = {1} ", sb.Length, sb.Capacity);
        }
    }
}
