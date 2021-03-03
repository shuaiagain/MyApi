using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class UserDto
    {
        #region Equals
        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //        return false;

        //    if (obj.GetType().Equals(this.GetType()) == false)
        //        return false;

        //    UserDto tempUser = null;
        //    tempUser = (UserDto)obj;

        //    return this.age.Equals(tempUser.age) && this.name.Equals(tempUser.name);
        //} 
        #endregion

        public int age { get; set; }

        public string name { get; set; }
    }
}
