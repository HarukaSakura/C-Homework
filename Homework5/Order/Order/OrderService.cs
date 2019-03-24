using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class OrderService
    {
        public List<Order> orderlist = new List<Order>();
        public void CreateOrder()
        {
            string cname, id, gname;
            int n, i, gn;
            float gprice;
            id = System.Guid.NewGuid().ToString("N");
            Console.WriteLine("输入客户姓名：");
            cname = Console.ReadLine();
            List<Goods> glist = new List<Goods>();
            Console.WriteLine("需要几种货物？");
            n = int.Parse(Console.ReadLine());
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("输入第"+ ( i + 1) + "种货物名称：");
                gname = Console.ReadLine();
                Console.WriteLine("输入第" + (i + 1) + "种货物数量：");
                gn = int.Parse(Console.ReadLine());
                Console.WriteLine("输入第" + (i + 1) + "种货物价格：");
                gprice = float.Parse(Console.ReadLine());
                Goods goods = new Goods(gname, gn, gprice);
                glist.Add(goods);
            }
            Order order = new Order(id, cname, glist);
            foreach(Order o in orderlist)
            {
                if (o.Equals(order))
                {
                    Console.WriteLine("添加失败！原因：订单明细与已有订单相同");
                    return;
                }
            }
            orderlist.Add(order);
            Console.WriteLine("创建成功！订单号为" + id);
        }

        public void DisplayOrder(Order o)
        {
            Console.WriteLine(o.ToString());
        }

        public void QueryOrder()
        {
            Console.WriteLine("1.根据订单号查询");
            Console.WriteLine("2.根据客户名查询");
            Console.WriteLine("3.根据货物名查询");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: QueryOrderbyId(); break;
                case 2: QueryOrderbyCustomer(); break;
                case 3: QueryOrderbyGoods(); break;
            }
        }

        public bool QueryOrderbyId()
        {
            string id;
            try
            {
                Console.WriteLine("输入要查询的订单号：");
                id = Console.ReadLine();
                foreach (Order i in orderlist)
                {
                    if (i.OrderId == id)
                    {
                        DisplayOrder(i);
                        return true;
                    }
                }
                throw new System.Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("订单号不存在！");
                return false;
            }
        }

        public bool QueryOrderbyCustomer()
        {
            string cname;
            bool flag = false;
            try
            {
                Console.WriteLine("输入要查询的客户名：");
                cname = Console.ReadLine();
                foreach (Order i in orderlist)
                {
                    if (i.CustomerName == cname)
                    {
                        DisplayOrder(i);
                        flag = true;
                    }
                }
                if (flag)
                    return true;
                else
                    throw new System.Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("客户名不存在！");
                return false;
            }
        }

        public bool QueryOrderbyGoods()
        {
            string gname;
            bool flag = false;
            try
            {
                Console.WriteLine("输入要查询的货物名：");
                gname = Console.ReadLine();
                foreach (Order i in orderlist)
                {
                    foreach(Goods g in i.GoodsList)
                    {
                        if (g.GoodsName == gname)
                        {
                            DisplayOrder(i);
                            flag = true;
                        }
                    }
                }
                if (flag)
                    return true;
                else
                    throw new System.Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("客户名不存在！");
                return false;
            }
        }

        public bool ReviseOrder()
        {
            string id;
            try
            {
                Console.WriteLine("输入要修改的订单号：");
                id = Console.ReadLine();
                foreach (Order i in orderlist)
                {
                    if (i.OrderId == id)
                    {
                        Console.WriteLine("1.添加货物");
                        Console.WriteLine("2.删除货物");
                        Console.WriteLine("3.修改货物数量");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1: AddGoods(i); break;
                            case 2: RemoveGoods(i); break;
                            case 3: ReviseAmout(i); break;
                        }
                        Console.WriteLine("修改成功！");
                        return true;
                    }
                }
                throw new System.Exception();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("订单号不存在！");
                return false;
            }
        }

        public void AddGoods(Order o)
        {
            Console.WriteLine("输入货物名称：");
            string gname = Console.ReadLine();
            Console.WriteLine("输入货物数量：");
            int gamount = int.Parse(Console.ReadLine());
            Console.WriteLine("输入货物价格：");
            float gprice = float.Parse(Console.ReadLine());
            Goods g = new Goods(gname, gamount, gprice);
            o.GoodsList.Add(g);
            o.CaculateTotalPrcie();
        }
        public void RemoveGoods(Order o)
        {
            Goods gcancel = new Goods(" ", 0, 0);
            Console.WriteLine("输入货物名称：");
            string gname = Console.ReadLine();
            foreach(Goods g in o.GoodsList)
            {
                if (gname == g.GoodsName)
                    gcancel = g;
            }
            o.GoodsList.Remove(gcancel);
            o.CaculateTotalPrcie();

        }
        public void ReviseAmout(Order o)
        {
            Console.WriteLine("输入货物名称：");
            string gname = Console.ReadLine();
            Console.WriteLine("输入修改后的货物数量：");
            int gamount = int.Parse(Console.ReadLine());
            foreach (Goods g in o.GoodsList)
            {
                if (gname == g.GoodsName)
                    g.GoodsAmount = gamount;
            }
            o.CaculateTotalPrcie();
        }

        public bool CancelOrder()
        {
            string id;
            try
            {
                Console.WriteLine("输入要删除的订单号：");
                id = Console.ReadLine();
                foreach (Order i in orderlist)
                {
                    if (i.OrderId == id)
                    {
                        orderlist.Remove(i);
                        Console.WriteLine("删除成功！");
                        return true;
                    }
                }
                throw new System.Exception();
            }
            catch(Exception e)
            {
                Console.WriteLine("订单号不存在！");
                return false;
            }
        }

        public void SortbyId()
        {
            orderlist.Sort();
            foreach (Order o in orderlist)
                DisplayOrder(o);
        }

        public void SortbyTotalPrice()
        {
            orderlist.Sort((o1, o2)=>(int)(o1.TotalPrice - o2.TotalPrice));
            foreach (Order o in orderlist)
                DisplayOrder(o);
        }
    }
}
