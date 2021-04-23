using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml;

namespace FileOperate
{
    public class FileOperate
    {
        public static void ReadXml(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    Console.WriteLine("文件路径不能为空");
                    return;
                }

                if (!File.Exists(filePath))
                {
                    Console.WriteLine("文件未找到");
                }

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                XmlNodeList nodeList = xmlDoc.SelectSingleNode();
                foreach (XmlNode item in xmlDoc.ChildNodes)
                {
                    Console.WriteLine("OuterXml：{0}，InnerText：{1}", item.OuterXml, item.InnerText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("异常：{0}", ex.Message));
            }
        }
    }
}
