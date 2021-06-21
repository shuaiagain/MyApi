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
           AutoMapperExt.Print();

            #region async/await
            //AsyncAwaitC.Print();

            //AsyncAwaitB.Print();

            //AsyncAwaitA.Print();
            #endregion

            #region stream
            //StreamExt5.Print();
            //StreamExt4.Print();
            //StreamExt3.Print();
            //StreamExt2.Print();
            //StreamExt.Print();
            //ReflectionPractice.Print(); 
            #endregion

            #region 2
            //Dictionary_Condictionary.Print();
            //HashTable_Dictionary_ConcurrentDictionary.Print();
            //ThreadExtE.Print();
            //ThreadExtC.Print();
            //ThreadExtB.Print();
            //StringEmptyDBNull.Print();
            //ThreadExtA.Print();
            #endregion

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
