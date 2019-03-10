using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class UserDAO
    {
        public int findPermission(String userName, String userPassword)
        {
            if ("zhangsan" == userName && "123456" == userPassword)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }
    }
}
