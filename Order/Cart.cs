using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Food;

namespace Models.Order
{
    public abstract class Cart
    {
        List<Pizza>? Pizzas;
        List<Drink>? Drinks;
        float PriceCart;
        float TimeToCook;

        public float computePrice()
        {
            if (Pizzas != null)
            {
                foreach (Pizza pizza in Pizzas)
                {
                    PriceCart += pizza.Price;
                }
                if (Drinks != null)
                {
                    foreach (Drink drink in Drinks)
                    {
                        PriceCart += drink.Price;
                    }
                }
            }
            return PriceCart;
        }
    }
}
