using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Administrator : User
    {

    public Administrator()
    {
        Console.WriteLine("´´½¨¹ÜÀíÔ±¶ÔÏó£¡");
    }


    override public void diffOperation()
    {
            Console.WriteLine("¹ÜÀíÔ±ÓµÓÐ´´½¨ºÍ¹ÜÀí¼ÙÌõÈ¨ÏÞ£¡");
    }
}
}
