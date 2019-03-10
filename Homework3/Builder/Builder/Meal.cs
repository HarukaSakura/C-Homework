using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Meal
    {
        private String food;
        private String drink;

        public void setFood(String food)
        {
            this.food = food;
        }

        public void setDrink(String drink)
        {
            this.drink = drink;
        }

        public String getFood()
        {
            return (this.food);
        }

        public String getDrink()
        {
            return (this.drink);
        }
    }
}
