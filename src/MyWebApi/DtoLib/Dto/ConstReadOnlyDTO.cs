using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib
{
    public class ConstReadOnlyDTO
    {
        public const int numA =2;
        public static readonly int numB = 1;
        readonly int numC = 0;
    }
}
