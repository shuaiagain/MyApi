using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    class ConstReadOnly
    {
        const int One = 0;
        readonly int two = 2;

        public void ConstReadOnlyTest()
        {
            Console.WriteLine("numA = {0}", ConstReadOnlyDTO.numA);
            Console.WriteLine("numB = {0}", ConstReadOnlyDTO.numB);
        }
    }
}
