using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class UserFactory
    {
        public static User getUser(int permission)
        {
            if (0 == permission)
            {
                return new Employee();
            }
            else if (1 == permission)
            {
                return new Manager();
            }
            else if (2 == permission)
            {
                return new Administrator();
            }
            else
            {
                return null;
            }
        }
    }
}
