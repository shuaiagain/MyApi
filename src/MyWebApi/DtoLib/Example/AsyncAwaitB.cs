using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class AsyncAwaitB
    {
        #region Print
        public static void Print()
        {
            ExampleB();
        }
        #endregion

        static void ExampleB()
        {
            var html = GetResult();
            Console.WriteLine("稍等... 正在下载 cnblogs -> html \r\n");

            string content = html.Result;
            Console.WriteLine("加载完成");
            Console.WriteLine(content);

            Console.WriteLine("下载完毕");
        }

        static Task<string> GetResult()
        {
            GetResultA stateMachine = new GetResultA();
            stateMachine.builder = AsyncTaskMethodBuilder<string>.Create();

            stateMachine.state = -1;
            stateMachine.builder.Start(ref stateMachine);

            return stateMachine.builder.Task;
        }
    }

    class GetResultA : IAsyncStateMachine
    {
        public int state;
        public AsyncTaskMethodBuilder<string> builder;
        private WebClient client;
        private string content;
        private string s3;
        private TaskAwaiter<string> awaiter;

        public void MoveNext()
        {
            string result = string.Empty;
            TaskAwaiter<string> localAwaiter;
            GetResultA stateMachine;

            int num = state;
            try
            {
                if (num == 0)
                {
                    localAwaiter = awaiter;
                    awaiter = default(TaskAwaiter<string>);
                    num = state = -1;
                }
                else
                {
                    client = new WebClient();

                    localAwaiter = client.DownloadStringTaskAsync(new Uri("https://kaifa.baidu.com/")).GetAwaiter();
                    if (!localAwaiter.IsCompleted)
                    {
                        num = state = 0;
                        awaiter = localAwaiter;
                        stateMachine = this;
                        builder.AwaitUnsafeOnCompleted(ref localAwaiter, ref stateMachine);
                        return;
                    }
                }

                s3 = localAwaiter.GetResult();
                content = s3;
                s3 = null;
                result = content;
            }
            catch (Exception ex)
            {
                state = -2;
                client = null;
                content = null;
                builder.SetException(ex);
            }

            state = -2;
            client = null;
            content = null;
            builder.SetResult(result);
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }
    }
}
