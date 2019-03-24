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
        public float GoodsPrice { get; set; }
        public Goods(string goodsName, int goodsAmount, float goodsprice)
        {
            this.GoodsName = goodsName;
            this.GoodsAmount = goodsAmount;
            this.GoodsPrice = goodsprice;
        }
        public override bool Equals(object obj)
        {
            if (obj is Goods)
            {
                Goods g = (Goods)obj;
                if (g.GoodsName == GoodsName && g.GoodsAmount == GoodsAmount && g.GoodsPrice == GoodsPrice)
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
