using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class EqualsGetHashCode
    {
        #region .net4.0版本的
        /// <summary>
        /// .net4.0版本的
        /// </summary>
        /// <param name="objA"></param>
        /// <param name="objB"></param>
        public static bool Equals4_0(object objA, object objB)
        {
            return objA == objB || (objA != null && objB != null && objB.Equals(objB));
        }
        #endregion

        #region  .net4.6.1版本的
        /// <summary>
        /// .net4.6.1版本的
        /// </summary>
        /// <param name="objA"></param>
        /// <param name="objB"></param>
        /// <returns></returns>
        public static bool Equals4_6_1(object objA, object objB)
        {
            if (objA == objB)
                return true;

            if (objA == null || objB == null)
                return false;

            return objA.Equals(objB);
        }
        #endregion

        #region ReferenceEqual
        public static bool ReferenceEqual(object objA, object objB)
        {
            return objA == objB;
        }
        #endregion

        static void EqualNumer()
        {
            int a = 1;
            int b = 1;
            int c = b;
            Console.WriteLine("----int----start----");
            Console.WriteLine("b.Equals(a) is {0} ", b.Equals(a));
            Console.WriteLine(" c.Equals(b)= {0} ", c.Equals(b));
            Console.WriteLine("b == a {0} ", b == a);
            Console.WriteLine("b == c {0} ", b == c);

            Console.WriteLine("b.GetHashCode() = {0} ", b.GetHashCode());
            Console.WriteLine("a.GetHashCode() = {0} ", a.GetHashCode());
            Console.WriteLine("c.GetHashCode() = {0} ", c.GetHashCode());

            Console.WriteLine("----int----end----");
            Console.WriteLine();

            decimal da = 1;
            decimal db = 1;
            decimal dc = b;
            Console.WriteLine("----float----start----");
            Console.WriteLine("db.Equals(da) is {0} ", db.Equals(da));
            Console.WriteLine("dc.Equals(db) = {0} ", dc.Equals(db));
            Console.WriteLine("db == da {0} ", db == da);
            Console.WriteLine("db == dc {0} ", db == dc);

            Console.WriteLine("db.GetHashCode() = {0} ", db.GetHashCode());
            Console.WriteLine("da.GetHashCode() = {0} ", da.GetHashCode());
            Console.WriteLine("dc.GetHashCode() = {0} ", dc.GetHashCode());
            Console.WriteLine("----float----end----");
            Console.WriteLine();
        }

        static void EqualString()
        {
            string sa = "1";
            string sb = "1";
            string sc = sb;
            object sd = sb;
            string se = (string)sd;

            Console.WriteLine("----string----start----");
            Console.WriteLine("sb.Equals(sa) is {0} ", sb.Equals(sa));
            Console.WriteLine("sc.Equals(sb)= {0} ", sc.Equals(sb));
            Console.WriteLine("se.Equals(sb)= {0} ", se.Equals(sb));

            Console.WriteLine("sb == sa {0} ", sb == sa);
            Console.WriteLine("sb == sc {0} ", sb == sc);

            Console.WriteLine("sb.GetHashCode() = {0} ", sb.GetHashCode());
            Console.WriteLine("sa.GetHashCode() = {0} ", sa.GetHashCode());
            Console.WriteLine("sc.GetHashCode() = {0} ", sc.GetHashCode());

            Console.WriteLine(" sb.GetType() == sc.GetType() = {0} ", sb.GetType() == sc.GetType());
            Console.WriteLine(" sb.GetType() = {0} ", sb.GetType());

            Console.WriteLine("----string----end----");
            Console.WriteLine();
        }

        static void EqualStringA()
        {
            object a = null;
            object b = null;
            Console.WriteLine("----string----start----");

            Console.WriteLine("object.Equals(a, b) is {0} ", object.Equals(a, b));
            Console.WriteLine("object.ReferenceEquals(a, b) is {0} ", object.ReferenceEquals(a, b));
            Console.WriteLine(" b==a is {0} ", b == a);

            Console.WriteLine("----string----end----");
            Console.WriteLine();

            string aa = "123";
            string bb = "1" + "2" + "3";

            Console.WriteLine("----string----start----");

            Console.WriteLine("object.Equals(aa, bb) is {0} ", object.Equals(aa, bb));
            Console.WriteLine("object.ReferenceEquals(aa, bb) is {0} ", object.ReferenceEquals(aa, bb));
            Console.WriteLine(" ba==aa is {0} ", bb == aa);

            Console.WriteLine("----string----end----");
            Console.WriteLine();

        }

        static void EqualStringB()
        {
            string aa = "123";
            string bb = "1" + "2" + "3";

            Console.WriteLine("----string----start----");

            Console.WriteLine(" aa.Equals(bb) is {0} ", aa.Equals(bb));
            Console.WriteLine("object.Equals(aa, bb) is {0} ", object.Equals(aa, bb));
            Console.WriteLine("object.ReferenceEquals(aa, bb) is {0} ", object.ReferenceEquals(aa, bb));
            Console.WriteLine(" bb==aa is {0} ", bb == aa);

            Console.WriteLine("----string----end----");
            Console.WriteLine();

            string cc = "1234";
            string dd = aa + "4";
            Console.WriteLine("----string----start----");

            Console.WriteLine(" aa.Equals(bb) is {0} ", aa.Equals(bb));
            Console.WriteLine("object.Equals(cc,dd) is {0} ", object.Equals(cc, dd));
            Console.WriteLine("object.ReferenceEquals(cc, dd) is {0} ", object.ReferenceEquals(cc, dd));
            Console.WriteLine(" cc==dd is {0} ", cc == dd);

            Console.WriteLine("----string----end----");
            Console.WriteLine();
        }

        static void EqualStringC()
        {
            string aa = "123";
            string bb = "4";
            string cc = "1234";
            string dd = aa + bb;
            //Console.WriteLine("----string----start----");
            Console.WriteLine(" cc==dd is {0} ", cc == dd);

            //Console.WriteLine(" cc.Equals(bb) dd {0} ", cc.Equals(dd));
            Console.WriteLine("object.Equals(cc,dd) is {0} ", object.Equals(cc, dd));
            //Console.WriteLine("Equals4_6_1.Equals(cc,dd) is {0} ", Equals4_6_1(cc, dd));
            //Console.WriteLine("Equals4_0.Equals(cc,dd) is {0} ", Equals4_0(cc, dd));
            //Console.WriteLine("object.ReferenceEquals(cc, dd) is {0} ", object.ReferenceEquals(cc, dd));

            //Console.WriteLine("----string----end----");
            //Console.WriteLine();
        }

        static void EqualNumerA()
        {
            int a = 1;

            decimal da = 1;
            //Console.WriteLine("----float----start----");
            Console.WriteLine("da.Equals(a) is {0} ", da.Equals(a));
            Console.WriteLine("object.Equals(da, a) = {0} ", object.Equals(da, a));
            //Console.WriteLine("object.ReferenceEquals(da, a) = {0} ", object.ReferenceEquals(da, a));
            Console.WriteLine("da == da {0} ", da == a);
            //Console.WriteLine("Equals4_0(da, a) = {0} ", Equals4_0(da, a));
            //Console.WriteLine("Equals4_6_1(da, a) = {0} ", Equals4_6_1(da, a));

            //Console.WriteLine("da.GetHashCode() = {0} ", da.GetHashCode());
            //Console.WriteLine("a.GetHashCode() = {0} ", a.GetHashCode());
            //Console.WriteLine("----float----end----");
            //Console.WriteLine();

        }

        public static void Print()
        {
            //EqualNumer();
            //EqualString();
            //EqualStringA();
            //EqualStringB();
            EqualStringC();
            EqualNumerA();

        }
    }
}
