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
            new UpFileSingleTest().UploadFile();
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

    #region FileStreamTest
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
    #endregion

    #region 分段上传
    public class UpFileSingleTest
    {
        public const int BUFFER_COUNT = 1000;

        #region WriteToServer
        private void WriteToServer(string filePath, int startPosition, byte[] btArray)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            using (fs)
            {
                fs.Position = startPosition;
                fs.Write(btArray, 0, btArray.Length);

            }
        }
        #endregion

        #region UpLoadFileFromLocal
        private void UpLoadFileFromLocal(string localFilePath, string uploadFilePath, int startPosition, int totoalCount)
        {
            //if(!File.Exists(localFilePath)){return;}
            //每次临时读取数据数
            int tempReadCount = 0;
            int tempBuffer = 0;

            //定义一个缓冲区数组
            byte[] bufferByteArray = new byte[BUFFER_COUNT];
            FileStream fs = new FileStream(localFilePath, FileMode.Open);
            //将流的位置设置在每段数据的初始位置
            fs.Position = startPosition;
            using (fs)
            {
                //循环将该段数据读出在写入服务器中
                while (tempReadCount < totoalCount)
                {
                    tempBuffer = BUFFER_COUNT;
                    //每段起始位置+每次循环读取数据的长度
                    var writeStartPosition = startPosition + tempReadCount;
                    if (tempBuffer + tempReadCount > totoalCount)
                    {
                        tempBuffer = totoalCount - tempReadCount;
                        fs.Read(bufferByteArray, 0, tempBuffer);
                        if (tempBuffer > 0)
                        {
                            byte[] newTempBtArray = new byte[tempBuffer];
                            Array.Copy(bufferByteArray, 0, newTempBtArray, 0, tempBuffer);
                            this.WriteToServer(uploadFilePath, writeStartPosition, newTempBtArray);
                        }
                    }
                    else if (tempBuffer == BUFFER_COUNT)
                    {
                        //如果缓冲区的数据量小于该段数据量，并且tempBuffer=设定BUFFER_COUNT时，通过
                        //while 循环每次读取一样的buffer值的数据写入服务器中，直到将该段数据全部处理完毕

                        fs.Read(bufferByteArray, 0, tempBuffer);
                        this.WriteToServer(uploadFilePath, writeStartPosition, bufferByteArray);
                    }

                    //通过每次的缓冲区数据，累计增加临时读取数
                    tempReadCount += tempBuffer;
                }

            }

        }
        #endregion

        public void UploadFile()
        {

            string filePathA = @"E:\back-end\MyApi\src\MyWebApi\DtoLib\File\TextReader.txt";
            string filePathB = @"E:\back-end\MyApi\src\MyWebApi\DtoLib\File\TextReader2.txt";
            UpFileSingleTest test = new UpFileSingleTest();
            FileInfo file = new FileInfo(filePathA);

            long fileLength = file.Length;
            int divide = 5;
            int perFileLength = (int)fileLength / divide;
            long restCount = (int)fileLength % divide;

            //循环上传数据
            for (int i = 0; i < divide + 1; i++)
            {
                //每次定义不同的数据段,假设数据长度是500，那么每段的开始位置都是i*perFileLength
                var startPosition = i * perFileLength;
                //取得每次数据段的数据量
                var totalCount = fileLength - perFileLength * i > perFileLength ? perFileLength : (int)(fileLength - perFileLength * i);
                //上传该段数据
                test.UpLoadFileFromLocal(filePathA, filePathB, startPosition, i == divide ? divide : totalCount);
            }
        }
    }
    #endregion


}
