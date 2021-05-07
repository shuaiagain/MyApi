using BasicKnowledge.Dal;
using DtoLib.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable_Dictionary_ConcurrentDictionary.Print();
            //ThreadExtE.Print();
            //ThreadExtC.Print();
            //ThreadExtB.Print();
            //StringEmptyDBNull.Print();
            //ThreadExtA.Print();

            #region before
            //Console.WriteLine("main thread start");
            //OneDto.AsynchronyWithTPL();
            //Console.WriteLine("main thread end ");
            //t.Wait();

            //t = OneDto.AsynchronyWithAwait();
            //t.Wait(); 

            //TwoDto.DelayExample();
            //TwoDto.DelayExampleTwo();
            //TwoDto.ThreadSleepEg();
            //TwoDto.MaxThreadpoolEg();

            //task的基本操作
            //OneDto.TaskBasicOperate();
            //TaskBasicOperate.TaskBasic();
            //OneDto.TaskBasicOperateTwo();
            //OneDto.TaskBasicOperateThree();
            //OneDto.ThreadPoolEg();
            //TaskBasicOperate.InsertSort();
            //ThreeTaskOperate.ContinueWithEg();

            //new ValueRefType().Test();

            //Console.WriteLine("{0} ", Marshal.SizeOf(new TypeSize()));

            //DelegateT dele = new DelegateT();

            //ConstReadOnly read = new ConstReadOnly();
            //read.ConstReadOnlyTest();

            //ClassInitOrder classOrder = new ClassInitOrder();

            //ClassB classB = new ClassB();
            //classB.print();

            //AutoProperty autoP = new AutoProperty();
            //autoP.printHandField();

            //RefOut ro = new RefOut();
            //ro.TestValueRef();
            //ro.TestObjRef();

            //RefOut ro = new RefOut();
            //ro.TestValueOut();

            //As_Is asIs = new As_Is();
            //asIs.ShowAs();

            //ConstReadOnly ro = new ConstReadOnly();
            //ro.Print();
            //ConstReadOnly roOne = new ConstReadOnly();
            //roOne.Print();

            //StringEmpty se = new StringEmpty();
            //se.Print();

            //StringBuilderString sb = new StringBuilderString();
            //sb.Print();

            //StringEmpty se = new StringEmpty();
            //se.TypeSize();

            //AnonymousDelegate an = new AnonymousDelegate();
            //an.Print();

            //EqualsGetHashCode.Print();
            //PointerType.Print();
            //DefaultExt.Print();
            //IEnumeratorExt.Print();
            //ExpressionTree.Print(); 
            #endregion
        }
    }
}
