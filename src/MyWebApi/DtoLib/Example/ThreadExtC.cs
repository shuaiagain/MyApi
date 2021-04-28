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
    public class ThreadExtC
    {
        public static void Print()
        {
            ExampleA();
            //Example();
        }
        #region ExampleA
        static void ExampleA()
        {
            var html = GetResultExt();

            Console.WriteLine("稍等... 正在下载 cnblogs -> html \r\n");

            var content = html.Result;
            Console.WriteLine(content);
        }

        static Task<string> GetResultExt()
        {
            GetResult stateMachine = new GetResult();
            stateMachine.builder = AsyncTaskMethodBuilder<string>.Create();
            stateMachine.state = -1;
            stateMachine.builder.Start(ref stateMachine);

            return stateMachine.builder.Task;
        }
        #endregion

        #region Example
        static void Example()
        {
            Task<string> html = GetResult();
            Console.WriteLine("正在下载......");
            var content = html.Result;
            Console.WriteLine(content);
        }

        static async Task<string> GetResult()
        {
            var wbClient = new WebClient();
            var content = await wbClient.DownloadStringTaskAsync(new Uri("https://www.cnblogs.com/"));
            return content;
        }
        #endregion
    }

    class GetResult : IAsyncStateMachine
    {
        public int state;
        public AsyncTaskMethodBuilder<string> builder;
        private WebClient webClient;
        private string content;
        private string s3;
        private TaskAwaiter<string> awaiter;

        public void MoveNext()
        {
            string result = string.Empty;
            TaskAwaiter<string> localAwaiter;
            GetResult stateMachine;

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
                    webClient = new WebClient();
                    webClient.Encoding = Encoding.GetEncoding("utf-8");
                    localAwaiter = webClient.DownloadStringTaskAsync(new Uri("https://www.cnblogs.com/")).GetAwaiter();

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
                webClient = null;
                content = null;
                builder.SetException(ex);
            }

            state = -2;
            webClient = null;
            content = null;
            builder.SetResult(result);
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }
    }
}
