using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService os = new OrderService();
        [TestMethod()]
        public void CreateOrderTest()
        {
            List<Goods> glist = new List<Goods>();
            glist.Add(new Goods("玻璃", 20, 6));
            glist.Add(new Goods("木材", 30, 2));
            glist.Add(new Goods("圆石", 40, 2));
            Order o = new Order("0065312f4c014e63ace9ba5e561da624", "史蒂夫", glist);
            os.orderlist.Add(o);
            Assert.IsTrue(os.orderlist.Count != 0);
        }
        
        [TestMethod()]
        public void QueryOrderbyIdTest()
        {
            List<Goods> glist = new List<Goods>();
            glist.Add(new Goods("玻璃", 20, 6));
            glist.Add(new Goods("木材", 30, 2));
            glist.Add(new Goods("圆石", 40, 2));
            Order o = new Order("0065312f4c014e63ace9ba5e561da624", "史蒂夫", glist);
            os.orderlist.Add(o);
            var query = os.QueryOrderbyId("0065312f4c014e63ace9ba5e561da624");
            string id = "";
            foreach (Order i in query)
            {
                id = i.OrderId;
                Assert.IsTrue(id == "0065312f4c014e63ace9ba5e561da624");
            }   
        }

        [TestMethod()]
        public void QueryOrderbyCustomerTest()
        {
            List<Goods> glist = new List<Goods>();
            glist.Add(new Goods("玻璃", 20, 6));
            glist.Add(new Goods("木材", 30, 2));
            glist.Add(new Goods("圆石", 40, 2));
            Order o = new Order("0065312f4c014e63ace9ba5e561da624", "史蒂夫", glist);
            os.orderlist.Add(o);
            var query = os.QueryOrderbyCustomer("史蒂夫");
            string cname = "";
            foreach (Order i in query)
            {
                cname = i.CustomerName;
                Assert.IsTrue(cname == "史蒂夫");
            }
        }
        
        
        

        [TestMethod()]
        public void CancelOrderTest()
        {
            List<Order> orderlist = new List<Order>();
            List<Goods> glist = new List<Goods>();
            glist.Add(new Goods("玻璃", 20, 6));
            glist.Add(new Goods("木材", 30, 2));
            glist.Add(new Goods("圆石", 40, 2));
            Order o = new Order("0065312f4c014e63ace9ba5e561da624", "史蒂夫", glist);
            os.orderlist.Add(o);
            os.CancelOrder("0065312f4c014e63ace9ba5e561da624");
            Assert.IsTrue(orderlist.Count == 0);
        }
        

        [TestMethod()]
        public void ExportTest()
        {
            List<Order> orderlist = new List<Order>();
            List<Goods> glist = new List<Goods>();
            glist.Add(new Goods("玻璃", 20, 6));
            glist.Add(new Goods("木材", 30, 2));
            glist.Add(new Goods("圆石", 40, 2));
            Order o = new Order("0065312f4c014e63ace9ba5e561da624", "史蒂夫", glist);
            os.orderlist.Add(o);
            string xml1 = os.Export();
            string xml2 = File.ReadAllText("test.xml");
            Assert.AreEqual(xml1, xml2);
        }
        

    }
}