using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace DtoLib.Example
{
    #region 测试类
    [DataContract]
    class Book
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public float Price { get; set; }
    }
    #endregion

    public class SerilizationExt
    {
        public static void Print()
        {
            ExampleA();
        }

        public static void ExampleA()
        {
            Book book = new Book { ID = 1, Name = "book1", Price = 1 };

            DataContractSerializer formatter = new DataContractSerializer(typeof(Book));
            using (MemoryStream ms = new MemoryStream())
            {
                formatter.WriteObject(ms, book);
                string result = Encoding.UTF8.GetString(ms.ToArray());
            }
        }
    }
}
