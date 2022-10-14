using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Food;
using Models.Lists;

namespace Models.Order
{
    public class Cart
    {
        ListPizza Pizzas;
        ListDrink Drinks;
        float PriceCart;
        float TimeToCook;

        public Cart(ListPizza pizzas, ListDrink drinks)
        {
            Pizzas = pizzas;
            Drinks = drinks;
        }

        public float computePrice()
        {
            PriceCart = Pizzas.computePrice() + Drinks.computePrice();
            return PriceCart;
        }
        public float computeDuration()
        {
            TimeToCook = Pizzas.computeDuration() + Drinks.computeDuration();
            return TimeToCook;
        }

        public override string ToString()
        {
            return "\n Invoice \n" + Pizzas.ToString() + Drinks.ToString() + "\n\n  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - \n\n Duration to cook : " + computeDuration() + " secondes \n\n Price : " + computePrice() + " € \n\n";
        }
    }
}
