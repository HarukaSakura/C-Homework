using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Employee:User
    {

    public Employee()
    {
        Console.WriteLine("´´½¨Ô±¹¤¶ÔÏó£¡");
    }

    override public void diffOperation()
    {
         Console.WriteLine("Ô±¹¤ÓµÓÐ´´½¨¼ÙÌõÈ¨ÏÞ£¡");
    }
}
}
