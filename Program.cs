using System.Net;
using System;
using Human;
using Models.Food;
using Models.Lists;
using Models.Order;
using Models.Cooking;
using Models.Files;
using System.Threading.Tasks;

namespace Models
{
    public class Program
    {
        
        static async Task Main(string[] args)
        {

            
            
            /* ReadCustomer reader = new ReadCustomer();
            reader.readFile();
            Console.WriteLine(reader.ToString()); */

            
            /* Customer customer1 = new Customer(
                "Vital",
                "Warren",
                "Paris",
                "+33 5 65 65 65 41",
                30
            );
            Customer customer2 = new Customer(
                "Vital",
                "Warren",
                "Paris",
                "+33 5 65 65 65 41",
                new DateOnly(2022, 1, 1),
                30
            );
            Console.WriteLine(customer1.ToString());
            Console.WriteLine(customer2.ToString()); */

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

            Command command = new Command(
                cart,
                "NIGHT415",
                "+33 7 75 00 55 57",
                "Patrick",
                "Lucas",
                new DateOnly(2022, 1, 1)
            );
            Kitchen kitchen = new Kitchen();
            var cooking = kitchen.cook(command);
            var end = kitchen.finish(command);

            var TaskForCooking = new List<Task> { cooking, end };
            while (TaskForCooking.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(TaskForCooking);
                if (finishedTask == cooking)
                {
                    Console.WriteLine("Command is ready to be deliver .... ");
                }
                else if (finishedTask == end)
                {
                    Console.WriteLine("Finish put command in bag");
                }
                TaskForCooking.Remove(finishedTask);
            }

            /* Console.WriteLine(command.ToString()); */
        }
    }
}
