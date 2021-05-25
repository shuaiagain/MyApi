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
        }
        #endregion

        static Task<string> GetResult()
        {
            GetResultA stateMachine = new GetResultA();
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
                        builder.AwaitUnsafeOnCompleted();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
