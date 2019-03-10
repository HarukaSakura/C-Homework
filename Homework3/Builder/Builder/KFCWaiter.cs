using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
        public class KFCWaiter
        {
            private MealBuilder mb;
            public void setMealBuilder(MealBuilder mb)
            {
                this.mb = mb;
            }
            public Meal construct()
            {
                mb.buildFood();
                mb.buildDrink();
                return mb.getMeal();
            }
        }
   
}
