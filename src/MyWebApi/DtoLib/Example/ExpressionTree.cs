using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class ExpressionTree
    {
        public static void Print()
        {
            Example();
        }

        private static void Example()
        {
            ParameterExpression a = Expression.Parameter(typeof(int), "i");
            ParameterExpression b = Expression.Parameter(typeof(int), "j");

            BinaryExpression abParent = Expression.Multiply(a, b);

            ParameterExpression c = Expression.Parameter(typeof(int), "x");
            ParameterExpression d = Expression.Parameter(typeof(int), "y");

            BinaryExpression cdParent = Expression.Multiply(c, d);

            BinaryExpression result = Expression.Add(abParent, cdParent);

            Expression<Func<int, int, int, int, int>> lambda = Expression.Lambda<Func<int, int, int, int, int>>(result, a, b, c, d);

            Func<int, int, int, int, int> f = lambda.Compile();
            int data = f(1, 2, 3, 4);
            Console.WriteLine("f(1,2,3,4) = {0} ", data);
        }
    }
}
