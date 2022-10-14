using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Food;

namespace Models.Lists
{
    public class ListPizza
    {
        public List<Pizza> listPizza = new List<Pizza>();

        public void add(Pizza pizza) {   
            listPizza.Add(pizza);
        }
        public float computePrice()
        {
            float price = 0;
            if (listPizza != null)
            {
                foreach (Pizza pizza in listPizza)
                {
                    price += pizza.Price;
                }
            }
            return price;
        }
        public float computeDuration()
        {
            float duration = 0;
            if (listPizza != null)
            {
                foreach (Pizza pizza in listPizza)
                {
                    duration += pizza.Duration;
                }
            }
            return duration;
        }

        public override string ToString()
        {
            string displayList = "\n  - - - - - - - - - - -  LIST OF PIZZAS  - - - - - - - - - - -   \n\n";
            foreach (Pizza pizza in listPizza)
            {
                displayList += pizza.ToString();
            }
            return displayList;
        }
    }
}
