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
            public TestFrom()
            {
            }

            public TestFrom(decimal weight)
            {
                Weight = weight;
            }

            static TestFrom()
            {
            }

            public decimal GetWeight()
            {
                return Weight;
            }

            public void SetWeight(decimal weight)
            {
                this.Weight = weight;
            }

            public void SetWeight(decimal weight, decimal defaultValue)
            {
                this.Weight = weight <= 0 ? defaultValue : weight;
            }

            public string Name { get; set; }

            public int Age { get; set; }

            public bool Sex { get; set; }

            public decimal Height { get; set; }

            public LevelEnum LevelEnum { get; set; }

            public decimal Weight;

            private int FieldA = 2;

            public readonly int FieldB;

            public const int FieldC = 4;

            public static readonly int FieldD = 5;
        }

        private class TestTo
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public decimal Height { get; set; }

            public LevelEnum LevelEnum { get; set; }

            public decimal Weight;

            private int FieldA;
        }
        #endregion

        public static void Print()
        {
            ExampleA();
        }

        public static void ExampleA()
        {
            TestFrom a = new TestFrom()
            {
                Name = "1",
                Age = 2,
                Weight = 3,
                LevelEnum = LevelEnum.第一层,
                Height = 100,
                Sex = true
            };

            PrintEntityInfo(a);
            Console.WriteLine("-----");

            TestTo b = Mapping<TestFrom, TestTo>(a);
            Console.WriteLine("-----");
            PrintEntityInfo(b);
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
            ToEntity toEntity = Activator.CreateInstance<ToEntity>();
            //ToEntity toEntity = Activator.CreateInstance(toType) as ToEntity;

            #region member
            foreach (MemberInfo member in fromMembers)
            {
                MemberInfo tempMember = toMembers.Where(p => p.Name == member.Name).FirstOrDefault();
                if (tempMember != null && member.MemberType == MemberTypes.Property)
                {
                    PropertyInfo ppFrom = fromType.GetProperty(member.Name);
                    PropertyInfo toProp = toType.GetProperty(member.Name);

                    //object value = ppFrom.GetValue(fromEntity);
                    //toProp.SetValue(toEntity, value);
                }
            }
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

            FieldInfo[] fromPF = fromType.GetFields();
            FieldInfo[] toPF = toType.GetFields();
            foreach (FieldInfo field in fromPF)
            {
                FieldInfo tempP = toPF.Where(p => p.Name == field.Name).FirstOrDefault();
                if (tempP == null)
                    continue;

                object value = field.GetValue(fromEntity);
                tempP.SetValue(toEntity, value);
            }

            return toEntity;
        }

        private static void PrintEntityInfo<T>(T entity) where T : class, new()
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Static);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Static);
            ConstructorInfo[] constructors = type.GetConstructors();

            foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine("PrppertyName={0}，PropertyValue={1} ", prop.Name, prop.GetValue(entity));
            }

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine("FieldName={0}，FieldValue={1} ", field.Name, field.GetValue(entity));
            }

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine();
                Console.WriteLine("method--begin--");

                Console.WriteLine("MethodName={0} ，IsConstructor：{1}", method.Name, method.IsConstructor);
                foreach (var item in method.GetParameters())
                {
                    Console.WriteLine("parameterName:{0},positioin:{1},parameterType:{2}", item.Name,item.Position,item.ParameterType);
                }

                Console.WriteLine("method--end--");
                Console.WriteLine();
            }

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine("ConstructorName={0} ，IsConstructor：{1}", constructor.Name, constructor.IsConstructor);
            }
        }
    }
}
