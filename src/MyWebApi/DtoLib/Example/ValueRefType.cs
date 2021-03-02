using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DtoLib.Example
{
    public class ValueRefType
    {
        public void Test()
        {
            UserDto user = new UserDto();
            user.age = 1;

            ReferenceTest(user);

            Console.WriteLine("user.age = {0} ", user.age);
        }

        private void ReferenceTest(UserDto user)
        {
            user.age = 20;
        }
    }
}
