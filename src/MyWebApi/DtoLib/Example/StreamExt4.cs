using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class StreamExt4
    {
        public static void Print()
        {
            //ExampleB();
            //ExampleA();
        }

        #region ExampleB
        private static void ExampleB()
        {
            string filePath = "H:\\mine2\\MyApi\\src\\MyWebApi\\DtoLib\\File\\FileFileCreate.txt";
            CreateFileConfig fileConfig = new CreateFileConfig()
            {
                FileName = "FileFileCreate.txt",
                IsAsync = false,
                CreateUrl = filePath
            };

            CopyFileConfig copyConfig = new CopyFileConfig()
            {
                OriginalFileUrl = "H:\\mine2\\MyApi\\src\\MyWebApi\\DtoLib\\File\\FileFileCreate.txt",
                DestinationFileUrl = "H:\\mine2\\MyApi\\src\\MyWebApi\\DtoLib\\File\\FileFileCreate2.txt",
                IsAsync = true
            };

            FileStreamTest fs = new FileStreamTest();
            fs.Create(fileConfig);

            fs.Copy(copyConfig);
        }
        #endregion

        #region ExampleA
        private static void ExampleA()
        {
            string txtFilePath = "H:\\mine2\\MyApi\\src\\MyWebApi\\DtoLib\\File\\TextReader.txt";
            FileStream fs = new FileStream(txtFilePath, FileMode.OpenOrCreate);

            fs.Close();
            Console.ReadLine();
            File.Delete(txtFilePath);
        }
        #endregion
    }

    public interface IFileConfig
    {
        string FileName { get; set; }
        bool IsAsync { get; set; }
    }

    #region 复制文件配置文件
    public class CopyFileConfig : IFileConfig
    {
        public string FileName { get; set; }

        public bool IsAsync { get; set; }

        public string OriginalFileUrl { get; set; }

        public string DestinationFileUrl { get; set; }

        public FileStream OriginalStream { get; set; }

        public byte[] OriginalFileByte { get; set; }
    }

    #endregion

    #region 创建文件配置文件
    public class CreateFileConfig : IFileConfig
    {
        // 文件名
        public string FileName { get; set; }
        //是否异步操作
        public bool IsAsync { get; set; }
        //创建文件所在url
        public string CreateUrl { get; set; }
    }
    #endregion

    public class FileStreamTest
    {
        const int WriteTimeout = 6000;
        private static readonly object _lockObject = new object();

        public void Copy(IFileConfig config)
        {
            lock (_lockObject)
            {
                CopyFileConfig fileConfig = config as CopyFileConfig;
                if (this.CheckConfigIsError(fileConfig)) return;

                FileStream fs = fileConfig.IsAsync
                    ? new FileStream(fileConfig.OriginalFileUrl, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true)
                    : new FileStream(fileConfig.OriginalFileUrl, FileMode.Open);

                byte[] originalByte = new byte[fs.Length];
                using (fs)
                {
                    if (fs.IsAsync)
                    {
                        fileConfig.OriginalFileByte = originalByte;
                        fileConfig.OriginalStream = fs;
                        if (fs.CanRead)
                            fs.BeginRead(originalByte, 0, originalByte.Length, End_CreateFileCallBack, fileConfig);
                    }
                    else
                    {
                        if (fs.CanRead)
                        {
                            fs.Read(originalByte, 0, originalByte.Length);
                        }

                        FileStream fs2 = new FileStream(fileConfig.DestinationFileUrl, FileMode.CreateNew);
                        using (fs2)
                        {
                            fs2.Write(originalByte, 0, originalByte.Length);
                            fs2.Close();
                        }
                    }
                }

            }
        }

        public void End_ReadFileCallBack(IAsyncResult result)
        {
            var config = result.AsyncState as CopyFileConfig;
            config.OriginalStream.EndRead(result);

            if (File.Exists(config.DestinationFileUrl)) File.Delete(config.DestinationFileUrl);
            FileStream fs = new FileStream(config.DestinationFileUrl, FileMode.CreateNew);
            using (fs)
            {
                Console.WriteLine("异步复制原文件地址：{0}", config.OriginalStream.Name);
                Console.WriteLine("复制后的新文件地址：{0}", config.DestinationFileUrl);

                fs.BeginWrite(config.OriginalFileByte, 0, config.OriginalFileByte.Length, this.End_CreateFileCallBack, fs);
                fs.Close();
            }
        }


        public void Create(IFileConfig config)
        {
            lock (_lockObject)
            {
                CreateFileConfig fileConfig = config as CreateFileConfig;
                if (this.CheckConfigIsError(fileConfig)) return;

                char[] insertContent = "HelloWorld".ToCharArray();
                byte[] byteArrayContent = Encoding.Default.GetBytes(insertContent, 0, insertContent.Length);

                FileStream fs = fileConfig.IsAsync
                    ? new FileStream(fileConfig.CreateUrl, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, true)
                    : new FileStream(fileConfig.CreateUrl, FileMode.Create);

                using (fs)
                {
                    // 如果不注释下面代码会抛出异常，google上提示是WriteTimeout只支持网络流
                    //fs.WriteTimeout = WriteTimeout;
                    if (fs.CanWrite && !fs.IsAsync)
                        fs.Write(byteArrayContent, 0, byteArrayContent.Length);
                    else if (fs.CanWrite)
                        fs.BeginWrite(byteArrayContent, 0, byteArrayContent.Length, End_CreateFileCallBack, fs);

                    Console.WriteLine("正在以 {0} 的方式创建文件", fs.IsAsync ? "异步" : "同步");

                    fs.Close();
                }
            }
        }

        public bool CheckConfigIsError(IFileConfig config)
        {
            return config == null || string.IsNullOrEmpty(config.FileName);
        }

        public void End_CreateFileCallBack(IAsyncResult result)
        {
            //从IAsyncResult对象中得到原来的FileStream
            FileStream stream = result.AsyncState as FileStream;
            //结束异步写

            Console.WriteLine("异步创建文件地址：{0}", stream.Name);
            stream.EndWrite(result);

            Console.ReadLine();
        }
    }

}
