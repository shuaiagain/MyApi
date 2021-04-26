using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class ThreadExtB
    {
        public static void Print()
        {
            ExampleC();
        }

        #region Read

        public static void ExampleC()
        {
            ThreadPool.SetMaxThreads(8, 8);//设置线程池最大工作线程和I/O完成端口线程数量
            Read();
            Console.ReadLine();
        }

        public static void Read()
        {
            byte[] buffer;
            byte[] buffer1;

            FileStream fs = new FileStream("H:/mine2/MyApi/src/MyWebApi/DtoLib/Doc/知识点-1.txt", FileMode.Open, FileAccess.Read, FileShare.Read, 10000, useAsync: true);
            buffer = new byte[fs.Length];
            var state = Tuple.Create(buffer, fs);

            FileStream fs2 = new FileStream("H:/mine2/MyApi/src/MyWebApi/DtoLib/Doc/知识点-2.txt", FileMode.Open, FileAccess.Read, FileShare.Read, 10000, useAsync: true);
            buffer1 = new byte[fs.Length];
            var state1 = Tuple.Create(buffer1, fs2);

            fs.BeginRead(buffer, 0, (int)fs.Length, EndReadCallback, state);
            fs.BeginRead(buffer, 0, (int)fs2.Length, EndReadCallback, state1);
        }

        public static void EndReadCallback(IAsyncResult asyncResult)
        {
            Console.WriteLine("Starting EndWriteCallback");
            Console.WriteLine($"current thread:{Thread.CurrentThread.ManagedThreadId},isThreadPool:{Thread.CurrentThread.IsThreadPoolThread}");
            try
            {
                var state = (Tuple<byte[], FileStream>)asyncResult.AsyncState;
                ThreadPool.GetAvailableThreads(out int workThreads, out int portThreads);
                Console.WriteLine($"availableworkerThreads:{workThreads},availableIOThread:{portThreads}");
                state.Item2.EndRead(asyncResult);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Console.WriteLine("Ending EndWriteCallback.");
            }
        }
        #endregion

        #region Async/Await
        public static void ExampleB()
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
        #endregion


    }
}
