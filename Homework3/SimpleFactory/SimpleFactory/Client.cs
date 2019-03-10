using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            try
            {
                User user;
                UserDAO userDao = new UserDAO();
                int permission = userDao.findPermission("zhangsan", "123456");
                user = UserFactory.getUser(permission);
                user.sameOperation();
                user.diffOperation();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
        }
    }
}
