using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Order
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public List<Goods> GoodsList { get; set; }
        public Order(string orderId, string customerName, List<Goods> glist)
        {
            this.OrderId = orderId;
            this.CustomerName = customerName;
            this.GoodsList = glist;
        }
    }
}
