using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SubMealBuilderA : MealBuilder
    {
        override public void buildFood()
        {
            meal.setFood("Ò»¸ö¼¦ÍÈ±¤");
        }
        override public void buildDrink()
        {
            meal.setDrink("Ò»±­¿ÉÀÖ");
        }
}
}
