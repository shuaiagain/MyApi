using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class RefOut
    {
        int value = 1;
        UserDto user = new UserDto() { age = 1, name = "aa" };

        #region ExchangeValue
        public void ExchangeValue()
        {
            UserDto aa = new UserDto() { age = 1, name = "aa" };
            ExchangeRefType(aa);
            Console.WriteLine("name= {0} ", aa.name);
            Console.WriteLine("age= {0} ", aa.age);
            Console.WriteLine("tostring()= {0} ", aa.ToString());

            ExchangeRefType(user);
        }
        #endregion

        #region ExChangeValueType
        public void ExchangeValueType(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
        }
        #endregion

        #region ExChangeValue
        public void ExchangeRefType(UserDto a)
        {
            a.name = string.Empty;
            a.age = default(int);

            Console.WriteLine("a.Equals(user) is {0} ", a.Equals(user));
            Console.WriteLine("object.ReferenceEquals(a,user) is {0} ", object.ReferenceEquals(a, user));
        }
        #endregion

        #region ref

        #region value-ref
        public void TestValueRef()
        {
            int a = 1, b = 2;
            ExchangeValueType(ref a, ref b);
            Console.WriteLine("a={0},b={1}", a, b);
        }

        public void ExchangeValueType(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        #endregion

        #region object-ref
        public void TestObjRef()
        {
            UserDto a = new UserDto() { name = "a", age = 1 },
                b = new UserDto() { name = "b", age = 2 };

            UserDto c = b;
            #region 证明引用类型参数是按值传参的
            ExchangeObj(a, b);
            Console.WriteLine("a.name={0},b.name={1},c.name = {2}", a.name, b.name, c.name);
            Console.WriteLine("a.age={0},b.age={1},c.age = {2}", a.age, b.age, c.age);

            ExchangeObjValue(a, b);
            Console.WriteLine("a.name={0},b.name={1}", a.name, b.name);
            Console.WriteLine("a.age={0},b.age={1}", a.age, b.age);
            #endregion

            a.name = "a";
            b.name = "b";
            ExchangeObj(ref a, ref b);
            Console.WriteLine("a.name = {0},b.name={1},c.name= {2}", a.name, b.name, c.name);
            Console.WriteLine("a.age={0},b.age={1},c.age = {2} ", a.age, b.age, c.age);

            ExchangeObjValueRef(ref a, ref b);
            Console.WriteLine("a.name = {0},b.name={1},c.name= {2}", a.name, b.name, c.name);
            Console.WriteLine("a.age={0},b.age={1},c.age = {2} ", a.age, b.age, c.age);
        }

        public void ExchangeObj(ref UserDto a, ref UserDto b)
        {
            //a = new UserDto() { name = "aa-1", age = 11 };
            //b = new UserDto() { name = "bb-1", age = 22 };

            UserDto tempUser = null;
            tempUser = a;
            a = b;
            b = tempUser;
        }

        public void ExchangeObj(UserDto a, UserDto b)
        {
            //a = new UserDto() { name = "aa-1", age = 11 };
            //b = new UserDto() { name = "bb-1", age = 22 };

            UserDto tempUser = null;
            tempUser = new UserDto();
            tempUser.name = a.name;
            a.name = b.name;
            b.name = tempUser.name;
        }

        public void ExchangeObjValue(UserDto a, UserDto b)
        {
            a = new UserDto() { name = "aa-1", age = 11 };
            b = new UserDto() { name = "bb-1", age = 22 };
        }

        public void ExchangeObjValueRef(ref UserDto a,ref UserDto b)
        {
            a = new UserDto() { name = "aa-1", age = 11 };
            b = new UserDto() { name = "bb-1", age = 22 };
        }
        #endregion




        #endregion

        #region out
        #region value-ref
        public void TestValueOut()
        {
            int a, b;
            ExchangeValueTypeOut(out a, out b);
            Console.WriteLine("a={0},b={1}", a, b);
        }

        public void ExchangeValueTypeOut(out int a, out int b)
        {
            a = 1;
            b = 2;
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region object-out
        public void TestObjOut()
        {
            UserDto a = null, b = null;
            Console.WriteLine("a={0}");
            #region 证明引用类型参数是按值传参的
            ExchangeObjValueOut(a, b);
            Console.WriteLine("a.name={0},b.name={1}", a.name, b.name);
            Console.WriteLine("a.age={0},b.age={1}", a.age, b.age);
            #endregion

            ExchangeObjOut(ref a, ref b);
            Console.WriteLine("a={0},b={1}", a.name, b.name);
        }

        public void ExchangeObjOut(ref UserDto a, ref UserDto b)
        {
            UserDto tempUser = null;
            tempUser = a;
            a = b;
            b = tempUser;
        }

        public void ExchangeObjValueOut(UserDto a, UserDto b)
        {
            a = new UserDto() { name = "aa-1", age = 11 };
            b = new UserDto() { name = "bb-1", age = 22 };
        }
        #endregion
        #endregion
    }
}
