using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Client
    {
        static void Main()
        {
            MealBuilder mb = (MealBuilder)XMLUtil.getBean();
            KFCWaiter waiter = new KFCWaiter();
            waiter.setMealBuilder(mb);
            Meal meal = waiter.construct();

            Console.WriteLine("Ì×²Í×é³É£º");
            Console.WriteLine(meal.getFood());
            Console.WriteLine(meal.getDrink());
        }
    }
}
