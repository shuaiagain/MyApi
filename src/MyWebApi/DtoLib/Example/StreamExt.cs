using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    #region MyStream
    class MyStream : Stream
    {
        public override bool CanRead => throw new NotImplementedException();

        public override bool CanSeek => throw new NotImplementedException();

        public override bool CanWrite => throw new NotImplementedException();

        public override long Length => throw new NotImplementedException();

        #region Position
        /// <summary>
        ///虽然从字面中可以看出这个Position属性只是标示了流中的一个位置而已，可是我们在实际开发中会发现这个想法会非常的幼稚，
        ///很多asp.net项目中文件或图片上传中很多朋友会经历过这样一个痛苦：Stream对象被缓存了，导致了Position属性在流中无法
        ///找到正确的位置，这点会让人抓狂，其实解决这个问题很简单，聪明的你肯定想到了，其实我们每次使用流前必须将Stream.Position
        ///设置成0就行了，但是这还不能根本上解决问题，最好的方法就是用Using语句将流对象包裹起来，用完后关闭回收即可。
        /// </summary>
        public override long Position
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        #endregion

        #region Flush
        /// <summary>
        /// 当我们使用流写文件时，数据流会先进入到缓冲区中，而不会立刻写入文件，当执行这个方法后，缓冲区的数据流会立即注入基础流
        ///  MSDN中的描述：使用此方法将所有信息从基础缓冲区移动到其目标或清除缓冲区，或者同时执行这两种操作。
        ///  根据对象的状态，可能需要修改流内的当前位置（例如，在基础流支持查找的情况下即如此）
        ///  当使用 StreamWriter 或 BinaryWriter 类时，不要刷新 Stream 基对象，
        ///  而应使用该类的 Flush 或 Close 方法，此方法确保首先将该数据刷新至基础流，然后再将其写入文件
        /// </summary>
        public override void Flush()
        {
            throw new NotImplementedException();
        }
        #endregion

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    public class StreamExt
    {
        public static void Print()
        {
            ExampleB();
            //ExampleA();
        }

        #region ExampleB
        private static void ExampleB()
        {
            byte[] buffer = null;
            string str = "123你好";
            using (MemoryStream mStream = new MemoryStream())
            {
                Console.WriteLine("流的初始位置：{0},流的长度：{1}", mStream.Position, mStream.Length);

                buffer = Encoding.Default.GetBytes(str);
                if (mStream.CanWrite)
                {
                    mStream.Write(buffer, 0, 3);
                    Console.WriteLine("流的当前的位置：{0},流的长度：{1}", mStream.Position, mStream.Length);
                }

                if (mStream.CanRead)
                {
                    long newPosition = mStream.CanSeek ? mStream.Seek(2, SeekOrigin.Current) : 0;
                    Console.WriteLine("流的初始位置：{0},流的长度：{1}", mStream.Position, mStream.Length);

                    if (mStream.Position < buffer.Length)
                    {
                        mStream.Write(buffer, (int)newPosition, buffer.Length - (int)newPosition);
                        Console.WriteLine("流的初始位置：{0},流的长度：{1}", mStream.Position, mStream.Length);
                    }

                    //写完后将stream的Position属性设置成0，开始读流中的数据
                    mStream.Position = 0;

                    byte[] newBuffer = new byte[mStream.Length];
                    int count = mStream.CanRead ? mStream.Read(newBuffer, 0, newBuffer.Length) : 0;
                    int charCount = Encoding.Default.GetCharCount(newBuffer, 0, count);

                    string newStr = string.Empty;
                    char[] charArr = new char[charCount];
                    Encoding.Default.GetDecoder().GetChars(newBuffer, 0, count, charArr, 0);
                    for (int i = 0; i < charArr.Length; i++)
                    {
                        newStr += charArr[i];
                    }

                    Console.WriteLine("读出的字符串：{0},长度：{1}", newStr, newStr.Length);
                }

            }
        }
        #endregion

        #region ExampleA
        private static void ExampleA()
        {
            byte[] buffer = null;
            string testString = "Stream!Hello world";
            char[] readCharArray = null;
            byte[] readBuffer = null;
            string readString = string.Empty;

            using (MemoryStream sm = new MemoryStream())
            {
                Console.WriteLine("初始字符串为：{0}", testString);
                Console.WriteLine("Stream的初始位置：{0}", sm.Position);
                if (sm.CanWrite)
                {
                    //首先我们尝试将testString写入流中
                    //关于Encoding我会在另一篇文章中详细说明，暂且通过它实现string->byte[]的转换
                    buffer = Encoding.Default.GetBytes(testString);

                    //我们从该数组的第一个位置开始写，长度为3，写完之后 stream中便有了数据
                    //对于新手来说很难理解的就是数据是什么时候写入到流中，在冗长的项目代码面前，我碰见过很
                    //多新手都会有这种经历，我希望能够用如此简单的代码让新手或者老手们在温故下基础
                    sm.Write(buffer, 0, 3);
                    Console.WriteLine("现在Stream.Position在第{0}位置", sm.Position + 1);

                    //从刚才结束的位置（当前位置）往后移3位，到第7位
                    long newPositionInStream = sm.CanSeek ? sm.Seek(3, SeekOrigin.Current) : 0;
                    Console.WriteLine("重定位后Stream.Position在第{0}位置", newPositionInStream + 1);

                    if (newPositionInStream < buffer.Length)
                    {
                        // 将从新位置（第7位）一直写到buffer的末尾，注意下stream已经写入了3个数据“Str”
                        sm.Write(buffer, (int)newPositionInStream, buffer.Length - (int)newPositionInStream);
                    }

                    //写完后将stream的Position属性设置成0，开始读流中的数据
                    sm.Position = 0;
                    // 设置一个空的盒子来接收流中的数据，长度根据stream的长度来决定
                    readBuffer = new byte[sm.Length];

                    //设置stream总的读取数量 ，
                    //注意！这时候流已经把数据读到了readBuffer中
                    int count = sm.CanRead ? sm.Read(readBuffer, 0, readBuffer.Length) : 0;

                    //由于刚开始时我们使用加密Encoding的方式,所以我们必须解密将readBuffer转化成Char数组，这样才能重新拼接成string
                    //首先通过流读出的readBuffer的数据求出从相应Char的数量
                    int charCount = Encoding.Default.GetCharCount(readBuffer, 0, count);
                    //通过该Char的数量 设定一个新的readCharArray数组
                    readCharArray = new char[charCount];
                    //Encoding 类的强悍之处就是不仅包含加密的方法，甚至将解密者都能创建出来（GetDecoder()），
                    //解密者便会将readCharArray填充（通过GetChars方法，把readBuffer 逐个转化将byte转化成char，并且按一致顺序填充到readCharArray中）
                    Encoding.Default.GetDecoder().GetChars(readBuffer, 0, count, readCharArray, 0);

                    for (int i = 0; i < readCharArray.Length; i++)
                    {
                        readString += readCharArray[i];
                    }

                    Console.WriteLine("读取的字符串为：{0}", readString);
                }

                sm.Close();
            }

            Console.ReadKey();
        }
        #endregion
    }
}
