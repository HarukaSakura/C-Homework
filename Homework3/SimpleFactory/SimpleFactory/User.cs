using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class User
    {
        public void sameOperation()
        {
            Console.WriteLine("ÐÞ¸Ä¸öÈË×ÊÁÏ£¡");
        }

        public abstract void diffOperation();
    }
}
