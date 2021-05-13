using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class StreamExt2
    {
        public static void Print()
        {
            ExampleB();
            //ExampleA();
        }

        #region StreamReader
        private static void ExampleB()
        {
            //文件路径
            string txtFilePath = "H:\\mine2\\MyApi\\src\\MyWebApi\\DtoLib\\File\\TextReader.txt";
            Console.WriteLine("Read");
            using (FileStream fs = File.OpenRead(txtFilePath))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    DisplayResultStringByUsingRead(sr);
                }
            }

            Console.WriteLine("ReadBlock");
            using (FileStream fs = File.OpenRead(txtFilePath))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    DisplayResultStringByUsingReadBlock(sr);
                }
            }

            Console.WriteLine("ReadLine");
            using (FileStream fs = File.OpenRead(txtFilePath))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    DisplayResultStringByUsingReadLine(sr);
                }
            }
        }

        #region ReadBlock
        private static void DisplayResultStringByUsingReadLine(StreamReader sr)
        {
            string str = string.Empty;
            while ((str = sr.ReadLine()) != null)
            {
                Console.WriteLine("ReadLine Result：{0}", str);
            }
        }
        #endregion

        #region ReadBlock
        private static void DisplayResultStringByUsingReadBlock(StreamReader sr)
        {
            byte[] buffer = new byte[sr.BaseStream.Length];
            sr.BaseStream.Read(buffer, 0, buffer.Length);
            int charCount = Encoding.Default.GetCharCount(buffer, 0, buffer.Length);
            //很重要，如果不置零，则读不到数据，因为position已经在最后一个字符的位置上了，读的话会读取下一个
            sr.BaseStream.Position = 0;

            char[] charBuffer = new char[charCount];
            string result = string.Empty;
            Console.WriteLine(sizeof(char));
            sr.ReadBlock(charBuffer, 0, charBuffer.Length);
            for (int i = 0; i < charBuffer.Length; i++)
            {
                result += charBuffer[i];
            }

            Console.WriteLine("ReadBlock Result：{0}", result);
        }
        #endregion

        #region Read
        private static void DisplayResultStringByUsingRead(StreamReader sr)
        {
            int readChar = 0;
            string result = string.Empty;
            Console.WriteLine(sizeof(char));
            while ((readChar = sr.Read()) != -1)
            {
                result += (char)readChar;
            }

            Console.WriteLine("Read Result：{0}", result);
        }
        #endregion

        #endregion


        #region TextReader-StringReader
        private static void ExampleA()
        {
            string text = "abc\nabc1";
            using (TextReader tReader = new StringReader(text))
            {
                while (tReader.Peek() != -1)
                {
                    Console.WriteLine("Peek = {0}", (char)tReader.Peek());
                    Console.WriteLine("Read = {0}", (char)tReader.Read());
                }

                tReader.Close();
            }

            using (TextReader reader = new StringReader(text))
            {
                char[] charBuffer = new char[3];
                int data = reader.ReadBlock(charBuffer, 0, 3);
                for (int i = 0; i < charBuffer.Length; i++)
                {
                    Console.WriteLine("通过readBlock读出的数据{0}", charBuffer[i]);
                }

                reader.Close();
            }

            using (TextReader reader = new StringReader(text))
            {
                string lineData = reader.ReadLine();
                Console.WriteLine("第一行数据：{0}", lineData);

                string lineDataTwo = reader.ReadLine();
                Console.WriteLine("第二行数据：{0}", lineDataTwo);
                reader.Close();
            }

            using (TextReader reader = new StringReader(text))
            {
                string allData = reader.ReadToEnd();
                Console.WriteLine("全部数据：{0}", allData);
                reader.Close();
            }
        }
        #endregion
    }
}
