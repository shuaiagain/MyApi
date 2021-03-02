using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public abstract class MyAbstract : MyInterface
    {
        public int numA { get; set; }

        public void print()
        {
        }
    }

    public interface MyInterface
    {
        void print();

        int numA { get; set; }
    }

    class ClassA
    {
        protected int numA;
        int numB;

        public virtual void print()
        {
            Console.WriteLine("numA={0}", numA);
        }
    }

    class ClassB : ClassA
    {
        protected internal int numA;
        int numB;

        public void print()
        {
            Console.WriteLine("{0}", numA);
        }
    }

}
