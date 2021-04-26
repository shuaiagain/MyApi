using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class ThreadExtB
    {
        public static void Print()
        {
            //具名参数传参
            ShowResult(classType: typeof(ThreadExtB), methodName: nameof(AsyncTaskResultMethod));
            ShowResult(typeof(ThreadExtB), nameof(AsyncTaskMethod));
            ShowResult(typeof(ThreadExtB), nameof(AsyncVoidMethod));
            ShowResult(typeof(ThreadExtB), nameof(IsRegularMethod));
        }

        #region Async/Await
        public static async Task<int> AsyncTaskResultMethod()
        {
            return await Task.FromResult(5);
        }

        public static async Task AsyncTaskMethod()
        {
            await new TaskCompletionSource<int>().Task;
        }

        public static async void AsyncVoidMethod()
        {

        }

        public static int IsRegularMethod()
        {
            return 5;
        }

        /// <summary>
        /// 判断方法是否是异步
        /// </summary>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        private static bool IsAsyncMethod(Type className, string methodName)
        {
            MethodInfo method = className.GetMethod(methodName);
            Type attType = typeof(AsyncStateMachineAttribute);

            var attribute = (AsyncStateMachineAttribute)method.GetCustomAttribute(attType);
            return attribute != null;
        }

        private static bool IsAsyncMethods(Type className, string methodName)
        {
            MethodInfo method = className.GetMethod(methodName);
            Type asyncMachine = typeof(AsyncStateMachineAttribute);
            var attribute = method.GetCustomAttribute(asyncMachine);

            return attribute != null;
        }

        public static void ShowResult(Type classType, string methodName)
        {
            Console.WriteLine((methodName + ":").PadRight(16));
            if (IsAsyncMethod(classType, methodName))
                Console.WriteLine("async method");
            else
                Console.WriteLine("regular method");
        }

        #endregion
    }
}
