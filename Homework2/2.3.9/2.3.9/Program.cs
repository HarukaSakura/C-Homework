using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] list = new int[n+1];
            for(int i = 0; i <= n; i++)
                list[i] = 1;//等于1表示是素数,先初始化为所有数都是素数
            list[0] = 0;
            list[1] = 0;//1不是素数
            int s = (int)System.Math.Sqrt(n);
            for (int i = 2; i <= s; i++)
            {
                //先判断是不是素数
                if (list[i] == 1)
                {
                    int a = i * i;//忽略小于i的倍数，因为之前已经出现过了
                    while (a <= n)
                    {
                        list[a] = 0;
                        a += i;
                    }
                }
            }
            for(int i = 2; i <= n; i++)//输出元素内容为1的数组索引，即为素数
            {
                if (list[i] == 1)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
