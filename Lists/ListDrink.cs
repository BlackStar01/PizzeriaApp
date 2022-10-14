using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Food;

namespace Models.Lists
{
    public class ListDrink : IList
    {
        public List<Drink> listDrink = new List<Drink>();

        public float computePrice()
        {
            float price = 0;
            if (listDrink != null)
            {
                foreach (Drink Drink in listDrink)
                {
                    price += Drink.Price;
                }
            }
            return price;
        }

        public float computeDuration()
        {
            float duration = 0;
            if (listDrink != null)
            {
                foreach (Drink drink in listDrink)
                {
                    duration += drink.Duration;
                }
            }
            return duration;
        }

        public void add(Drink Drink) {   
            listDrink.Add(Drink);
        }

        public override string ToString()
        {
            string displayList = "\n  - - - - - - - - - - -  LIST OF DRINKS  - - - - - - - - - - -   \n\n";
            foreach (Drink Drink in listDrink)
            {
                displayList += Drink.ToString();
            }
            return displayList;
        }
    }
}
