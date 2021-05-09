using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class EqualsHelper
    {
        //private unsafe static bool EqualsHelpers(string strA, string strB)
        //{
        //    int i = strA.Length;
        //    char* ptr = &strA.m_firstChar;
        //    char* ptr2 = &strB.m_firstChar;
        //    while (i >= 10)
        //    {
        //        if (*(int*)ptr != *(int*)ptr2)
        //        {
        //            return false;
        //        }
        //        if (*(int*)(ptr + (IntPtr)2) != *(int*)(ptr2 + (IntPtr)2))
        //        {
        //            return false;
        //        }
        //        if (*(int*)(ptr + (IntPtr)4) != *(int*)(ptr2 + (IntPtr)4))
        //        {
        //            return false;
        //        }
        //        if (*(int*)(ptr + (IntPtr)6) != *(int*)(ptr2 + (IntPtr)6))
        //        {
        //            return false;
        //        }
        //        if (*(int*)(ptr + (IntPtr)8) != *(int*)(ptr2 + (IntPtr)8))
        //        {
        //            return false;
        //        }
        //        ptr += (IntPtr)10;
        //        ptr2 += (IntPtr)10;
        //        i -= 10;
        //    }
        //    while (i > 0 && *(int*)ptr == *(int*)ptr2)
        //    {
        //        ptr += (IntPtr)2;
        //        ptr2 += (IntPtr)2;
        //        i -= 2;
        //    }
        //    return i <= 0;
        //}

    }
}
