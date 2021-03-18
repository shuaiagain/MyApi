using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    /// <summary>
    /// 协变逆变
    /// </summary>
    public class CovariantInversion
    {
        #region 协变
        /// <summary>
        /// 简单理解：子类 转成 父类 称为协变
        /// </summary>
        public void PrintCovariant()
        {
            #region 协变
            string str = "123";
            object obStr = str;
            #endregion

            List<string> strList = new List<string>();
            IEnumerable<object> co = strList;

            object[] obArr = new string[2];
            //IEnumerable<string> con = co;
        }
        #endregion

        public void Print()
        {

        }

    }
}
