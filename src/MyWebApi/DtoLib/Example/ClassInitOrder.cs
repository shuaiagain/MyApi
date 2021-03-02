using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{

    class ParentClassInitOrder
    {
        public const int nameA = 1;
        public static readonly int nameB = 1;
        public readonly int nameC = 1;
        int nameD = 1;
        public static int nameE = 1;

        public ParentClassInitOrder()
        {
            nameE++;
            Console.WriteLine("ParentClassInitOrder.nameB = {0} ", ParentClassInitOrder.nameB);
            Console.WriteLine("ParentClassInitOrder.nameE = {0} ", ParentClassInitOrder.nameE);
        }

        static ParentClassInitOrder()
        {
            nameB++;
            nameE++;
            Console.WriteLine("parent invoke ParentClassInitOrder.nameB = {0} ", ParentClassInitOrder.nameB);
            Console.WriteLine("parent invoke ParentClassInitOrder.nameE = {0} ", ParentClassInitOrder.nameE);
        }
    }

    class ClassInitOrder : ParentClassInitOrder
    {
        public int numA = 1;
        public static readonly int numB = 1;
        public readonly int numC = 1;
        public const int numD = 1;
        public static int numE = 1;

        public ClassInitOrder()
        {
            Console.WriteLine("numD = {0}", numB);
            Console.WriteLine("numE = {0}", numE);
        }

        static ClassInitOrder()
        {
            numB++;
            numE++;
            Console.WriteLine("child numB = {0} ", numB);
            Console.WriteLine("child numE = {0} ", numE);
        }
    }
}
