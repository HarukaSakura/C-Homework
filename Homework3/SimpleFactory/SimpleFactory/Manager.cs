using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Manager: User
    {

    public Manager()
    {
        Console.WriteLine("´´½¨¾­Àí¶ÔÏó£¡");
    }

    override public void diffOperation()
    {
        Console.WriteLine("¾­ÀíÓµÓÐ´´½¨ºÍÉóÅú¼ÙÌõÈ¨ÏÞ£¡");
    }
}
}
