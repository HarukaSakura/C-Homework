using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string s = "";
            while (true)
            {
                Console.WriteLine("Please enter a number");
                s = Console.ReadLine();
                a = Double.Parse(s);
                Console.WriteLine("Please enter another number");
                s = Console.ReadLine();
                b = Double.Parse(s);
                c = a * b;
                Console.WriteLine("The result is " + c +"\n");
            }
            
        }
    }
}
