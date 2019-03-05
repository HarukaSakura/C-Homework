using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, i = 0, max = 0, min = 0, sum = 0;
            float average = 0;
            string s;
            Console.WriteLine("请输入数组长度");
            s = Console.ReadLine();
            length = int.Parse(s);
            int []a = new int[length];
            while(i<length)
            {
                Console.WriteLine("输入第"+ (i + 1)+"个元素");
                a[i] = int.Parse(Console.ReadLine());
                i++;
            }
            foreach(int element in a)
            {
                if (element > max)
                    max = element;
                if (element < min)
                    min = element;
                sum += element;
            }
            average = sum / length;
            Console.WriteLine("最大值:"+ max );
            Console.WriteLine("最小值:" + min);
            Console.WriteLine("平均值:" + average);
            Console.WriteLine("元素总和:" + sum);
            Console.ReadLine();
        }
    }
}
