using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperate
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"H:\mine2\MyApi\src\MyWebApi\FileOperate\Doc\test.config";
            FileOperate.ReadXml(filePath);
        }
    }
}
