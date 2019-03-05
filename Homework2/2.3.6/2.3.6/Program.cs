using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string s;
            s = Console.ReadLine();
            n = int.Parse(s);

            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    n = n / i;
                    Console.WriteLine(i);
                    if (n != 1)
                        Console.WriteLine(" ");
                }
            }
            if (n != 1)
                Console.WriteLine(n);          //判断最后剩下的n是否为质数
            Console.ReadLine();
            return;
          
        }
    }
}
