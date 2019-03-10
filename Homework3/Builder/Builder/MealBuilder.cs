using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class MealBuilder
    {
        protected Meal meal = new Meal();
        public abstract void buildFood();
        public abstract void buildDrink();
        public Meal getMeal()
        {
            return meal;
        }
    }
}
