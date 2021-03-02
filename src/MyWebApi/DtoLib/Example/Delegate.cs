using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public delegate void Act<T>(T arg1);
    public delegate void Act<T1, T2>(T1 arg1, T2 arg2);

    public delegate TResult Fun<TResult>();
    public delegate TResult Fun<TResult, TArg1>();
    class DelegateT
    {
        int one = 1;
        object two = 2;

        public void printOne(int arg)
        {
            Console.WriteLine("{0}", arg);
        }

        public void printTwo(int arg)
        {
            Console.WriteLine("{0}", two);
        }

        public void DelegateTest()
        {
            Act<int> act;
            act = printOne;
            act += printTwo;
            act(one);
        }

        public int printFunOne()
        {
            Console.WriteLine("{0}", one);
            return one;
        }

        public int printFunTwo(int arg)
        {
            Console.WriteLine("{0}", arg);
            return arg;
        }

    }
}
