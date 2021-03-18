using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class AnonymousDelegate
    {
        private delegate void MyActionA<T>(T a);
        private delegate TResult MyActionB<T1, TResult>(T1 t1);

        private void PrintA(int a)
        {
            Console.WriteLine("ActA {0} ", a);
        }

        private void PrintAct()
        {
            MyActionA<int> a = PrintA;
            MyActionA<int> b = pa => Console.WriteLine("{0}", pa);
            //匿名委托
            MyActionA<string> c = delegate (string aa) { Console.WriteLine("{0}", aa); };
            a(1);
            b(2);
            c("anonymous Act");

            MyActionA<int> d = PrintA;
            d += delegate (int pb) { Console.WriteLine("anonymous 2：{0}", pb); };
            d(2);
        }


        private int PrintB(int a)
        {
            Console.WriteLine("PrintB：{0}", a);
            return a;
        }

        private void PrintFun()
        {
            MyActionB<int, int> a = PrintB;
            a += p => { Console.WriteLine("anonymous: {0}", p); return p; };
            a += p2 => p2;
            a(1);

            MyActionB<int, string> aa = p => p.ToString();
        }

        private void PrintC()
        {
            MyActionA<int> a = (arg) => { Console.WriteLine("第一个：{0} ", arg); };
            a += (arg) => { Console.WriteLine("第二个：{0} ", arg); };
            a += (arg) => { Console.WriteLine("第三个：{0} ", arg); };
            a += (arg) => { Console.WriteLine("第四个：{0} ", arg); };
            a += PrintA;
            a(1);
            a.GetInvocationList();
        }


        public void Print()
        {
            //PrintAct();
            //PrintFun();
            PrintC();
        }


    }
}
