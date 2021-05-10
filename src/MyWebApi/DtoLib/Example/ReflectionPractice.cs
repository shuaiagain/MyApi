using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class ReflectionPractice
    {
        #region 测试类
        private class TestFrom
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public bool Sex { get; set; }

            public int Weight;

        }

        private class TestTo
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public int Weight;
        }
        #endregion

        public static void Print()
        {
            ExampleA();
        }


        public static void ExampleA()
        {
            TestFrom a = new TestFrom() { Name = "1", Age = 2, Weight = 3 };

            TestTo b = Mapping<TestFrom, TestTo>(a);
            Console.WriteLine("b.Name={0}，b.Age={1}，b.Weight={2}", b.Name, b.Age, b.Weight);
        }


        private static ToEntity Mapping<FromEntity, ToEntity>(FromEntity fromEntity) where FromEntity : class, new() where ToEntity : class, new()
        {
            if (fromEntity == null)
                throw new ArgumentNullException("FromEntity参数不能为null");

            Type fromType = fromEntity.GetType();
            Type toType = typeof(ToEntity);

            MemberInfo[] fromMembers = fromType.GetMembers();
            MemberInfo[] toMembers = toType.GetMembers();

            //同样可以创建目标对象实例
            //ToEntity toEntity = new ToEntity();
            ToEntity toEntity = Activator.CreateInstance(toType) as ToEntity;

            #region member
            //foreach (MemberInfo member in fromMembers)
            //{
            //    MemberInfo tempMember = toMembers.Where(p => p.Name == member.Name).FirstOrDefault();
            //    if (tempMember != null && member.MemberType == MemberTypes.Property)
            //    {
            //        PropertyInfo ppFrom = fromType.GetProperty(member.Name);
            //        PropertyInfo toProp = toType.GetProperty(member.Name);

            //        object value = ppFrom.GetValue(fromEntity);
            //        toProp.SetValue(toEntity, value);
            //    }
            //} 
            #endregion

            PropertyInfo[] fromP = fromType.GetProperties();
            PropertyInfo[] toP = toType.GetProperties();
            foreach (PropertyInfo prop in fromP)
            {
                PropertyInfo tempP = toP.Where(p => p.Name == prop.Name).FirstOrDefault();
                if (tempP == null)
                    continue;

                object value = prop.GetValue(fromEntity);
                tempP.SetValue(toEntity, value);
            }

            return toEntity;
        }
    }
}
