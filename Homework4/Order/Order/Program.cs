using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            while (true)
            {
                Console.WriteLine("选择服务：");
                Console.WriteLine("1.添加订单");
                Console.WriteLine("2.删除订单");
                Console.WriteLine("3.查询订单");
                Console.WriteLine("4.修改订单");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: os.CreateOrder(); break;
                    case 2: os.CancelOrder(); break;
                    case 3: os.QueryOrder(); break;
                    case 4: os.ReviseOrder(); break;
                }
                Console.WriteLine(" ");
            }
            
        }
    }
}
