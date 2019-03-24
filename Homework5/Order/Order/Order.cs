using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Order:IComparable
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public List<Goods> GoodsList { get; set; }
        public float TotalPrice { get; set; }
        public Order(string orderId, string customerName, List<Goods> glist)
        {
            this.OrderId = orderId;
            this.CustomerName = customerName;
            this.GoodsList = glist;
            this.CaculateTotalPrcie();
        }
        public override bool Equals(object obj)
        {
            if (obj is Order)
            {
                Order o = (Order)obj;
                if (o.CustomerName == CustomerName && (o.GoodsList.All(GoodsList.Contains) && o.GoodsList.Count == GoodsList.Count))
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            string s = "订单号"+ OrderId +"\n客户名：" + CustomerName + "\n货物明细：\n货物    数量    价格\n";
            foreach(Goods g in GoodsList)
            {
                s += g.GoodsName +"       "+ g.GoodsAmount + "       " + g.GoodsPrice +"\n";
            }
            s += "总金额："+ TotalPrice + "\n";
            return s;
        }
        public int CompareTo(object obj2)
        {
            if (!(obj2 is Order))
                throw new System.ArgumentException();
            Order rec2 = (Order)obj2;
            return String.Compare(this.OrderId, rec2.OrderId);
        }
        public void CaculateTotalPrcie()
        {
            float totalprice = 0;
            foreach (Goods g in GoodsList)
                totalprice += g.GoodsAmount * g.GoodsPrice;
            TotalPrice = totalprice;
        }
    }
}
