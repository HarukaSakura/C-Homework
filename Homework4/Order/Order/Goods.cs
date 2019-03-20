using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Goods
    {
        public string GoodsName { get; set; }
        public int GoodsAmount { get; set; }
        public Goods(string goodsName, int goodsAmount)
        {
            this.GoodsName = goodsName;
            this.GoodsAmount = goodsAmount;
        }
    }
}
