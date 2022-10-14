using System;
using Human;
using Models.Food;
using Models.Lists;
using Models.Order;

namespace Models // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza p1 = new Pizza("Grande", 12, 10, "vegetariennes");
            Pizza p2 = new Pizza("Grande", 20, 15, "Tomate");
            Pizza p3 = new Pizza("Grande", 10, 50, "04 Fromages");

            Drink d1 = new Drink("Grande", 12, 10, "Jus de mangue");
        
            ListPizza listP = new ListPizza();
            listP.add(p1);
            listP.add(p2);
            listP.add(p3);
            ListDrink listD = new ListDrink();
            listD.add(d1);

            Cart cart = new Cart(listP, listD);

            
            Console.WriteLine(cart.ToString());
        }
    }
}
