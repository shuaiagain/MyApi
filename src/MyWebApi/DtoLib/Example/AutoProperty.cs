using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    /// <summary>
    /// 属性-字段-自动属性
    /// </summary>
    public class AutoProperty
    {
        #region 手动属性
        private int fieldA = 0;

        public int FieldA
        {
            get { return fieldA; }
            set { fieldA = value; }
        }

        #endregion

        #region 自动实现属性
        public int FieldB { get; set; }
        #endregion

        public void printHandField()
        {
            FieldA = 1;
            Console.WriteLine("field = {0} ", fieldA);
            Console.WriteLine("Field = {0} ", FieldA);
        }

        public void printAutoField()
        {
            FieldB = 1;
            Console.WriteLine("field = {0} ", FieldB);
        }
    }
}
