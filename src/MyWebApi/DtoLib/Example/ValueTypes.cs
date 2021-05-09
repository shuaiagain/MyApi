using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class ValueTypes
    {
        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //    {
        //        return false;
        //    }
        //    RuntimeType runtimeType = (RuntimeType)base.GetType();
        //    RuntimeType left = (RuntimeType)obj.GetType();
        //    if (left != runtimeType)
        //    {
        //        return false;
        //    }
        //    if (ValueType.CanCompareBits(this))
        //    {
        //        return ValueType.FastEqualsCheck(this, obj);
        //    }
        //    FieldInfo[] fields = runtimeType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        //    for (int i = 0; i < fields.Length; i++)
        //    {
        //        object obj2 = ((RtFieldInfo)fields[i]).UnsafeGetValue(this);
        //        object obj3 = ((RtFieldInfo)fields[i]).UnsafeGetValue(obj);
        //        if (obj2 == null)
        //        {
        //            if (obj3 != null)
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            if (!obj2.Equals(obj3))
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}
    }
}
