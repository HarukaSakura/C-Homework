using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SubMealBuilderB : MealBuilder
    {

    override public void buildFood()
    {
        meal.setFood("Ò»¸ö¼¦Èâ¾í");
    }
    override public void buildDrink()
    {
        meal.setDrink("Ò»±­¹ûÖ­");
    }
}
}
