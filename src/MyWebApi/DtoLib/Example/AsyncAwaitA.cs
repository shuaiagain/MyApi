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
    public class AsyncAwaitA
    {
        public static void Print()
        {
            ExampleB();
        }

        #region ExampleB
        private static void ExampleB()
        {
            Task<string> html = GetResult();
            Console.WriteLine("稍等... 正在下载 cnblogs -> html \r\n");

            string content = html.Result;
            Console.WriteLine("加载完成");
            Console.WriteLine(content);

            Console.WriteLine("下载完毕");
        }
        #endregion

        #region GetResult
        static async Task<string> GetResult()
        {
            Console.WriteLine("异步方法开始");
            WebClient client = new WebClient();
            string uri = "https://kaifa.baidu.com/";
            string content = await client.DownloadStringTaskAsync(new Uri(uri));

            Console.WriteLine("异步方法结束");
            return content;
        }
        #endregion
    }
}
