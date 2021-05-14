using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class StreamExt3
    {
        public static void Print()
        {
            ExampleA();
        }

        #region StreamWriter
        private static void ExampleA()
        {
            string txtFilePath = "H:\\mine2\\MyApi\\src\\MyWebApi\\DtoLib\\File\\TextReader.txt";

            NumberFormatInfo numberFomatProvider = new NumberFormatInfo();
            numberFomatProvider.PercentDecimalSeparator = "?";
            StreamWriterTest st = new StreamWriterTest(Encoding.Default, txtFilePath, numberFomatProvider);

            st.WriteSomethingToFile();

            st.WriteSomthingToFileByUsingTextWriter();
        }
        #endregion
    }

    public class StreamWriterTest
    {
        private Encoding _encoding;

        private IFormatProvider _provider;

        private string _textFilePath;

        public StreamWriterTest(Encoding encoding, string filePath) : this(encoding, filePath, null)
        {

        }

        public StreamWriterTest(Encoding encoding, string filePath, IFormatProvider provider)
        {
            this._encoding = encoding;
            this._textFilePath = filePath;
            this._provider = provider;
        }

        public void WriteSomethingToFile()
        {
            using (FileStream fs = File.OpenWrite(_textFilePath))
            {
                using (StreamWriter sw = new StreamWriter(fs, this._encoding))
                {
                    WriteSomethingToFile(sw);
                }

                using (StreamWriter sw = new StreamWriter(_textFilePath, true, _encoding, 20))
                {
                    WriteSomethingToFile(sw);
                }
            }
        }

        public void WriteSomethingToFile(StreamWriter sw)
        {
            string[] str =
                {
                 "1.Write(bool);",
              "2.Write(char);",
              "3.Write(Char[])",
              "4.Write(Decimal)",
              "5.Write(Double)",
              "6.Write(Int32)",
              "7.Write(Int64)",
              "8.Write(Object)",
              "9.Write(Char[])",
              "10.Write(Single)",
              "11.Write(Char[])",
              "12.Write(String)",
              "13Write(UInt32)",
              "14.Write(string format,obj)",
              "15.Write(Char[])"
            };

            //sw.AutoFlush = true;
            sw.WriteLine("这个stream里用了{0}编码", sw.Encoding.EncodingName);
            sw.WriteLine("这里简单演示下StreamWriter.Writer方法的各种重载版本");
         
            str.ToList().ForEach(item =>
            {
                sw.WriteLine(item);
            });

            sw.WriteLine("StreamWriter.WriteLine()方法就是在加上行结束符，其余和上述方法是用一致");
            sw.Close();
        }

        public void WriteSomthingToFileByUsingTextWriter()
        {
            using (TextWriter writer = new StringWriter(_provider))
            {
                writer.WriteLine("这里简单介绍下TextWriter 怎么使用用户设置的IFomatProvider，假设用户设置了NumberFormatInfoz.PercentDecimalSeparator属性");
                writer.WriteLine("看下区别吧 {0:p10}", 0.12);
                Console.WriteLine(writer.ToString());
                writer.Flush();
                writer.Close();
            }
        }
    }

}
