using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class ClassAA
    {
        public int num = 1;
    }

    public class ClassAASub : ClassAA
    {
        public int numA = 2;
    }

    public class ClassAAA { }



    public class As_Is
    {
        public int name;
        public void ShowIs()
        {
            ClassAA a = new ClassAA();
            ClassAASub aSub = new ClassAASub();
            bool isAA = aSub is ClassAA ? true : false;
            bool isObject = aSub is object ? true : false;
            bool isInt = aSub is int ? true : false;

            Console.WriteLine("ClassAASub is ClassAA: {0} ", isAA);
            Console.WriteLine("ClassAASub is object: {0} ", isObject);
            Console.WriteLine("ClassAASub is ClassAA: {0} ", isInt);
        }

        public void ShowAs()
        {
            ClassAA a = new ClassAA();
            JudgeType(a);

            ClassAASub sub = new ClassAASub();
            JudgeType(sub);

            ClassAAA aa = new ClassAAA();
            JudgeType(aa);
        }

        private void JudgeType(object obj)
        {
            bool isType = obj is ClassAA;
            Console.WriteLine("obj is ClassA: {0} ", isType);

            isType = false;
            ClassAA tempA = obj as ClassAA;
            if (tempA != null)
            {
                isType = true;
                Console.WriteLine("obj as ClassAA:{0},NumA={0}", isType);
            }
            else
                Console.WriteLine("obj as ClassAA:{0}", isType);
        }

    }
}
