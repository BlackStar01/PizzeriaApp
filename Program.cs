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
            List<Customer> ? listCustomers = new List<Customer>();
            ReadCustomer reader = new ReadCustomer();
            listCustomers = reader.readFile();

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

            Pizza pizza1 = new Pizza("Grande", 12, 1000, "vegetariennes");
            Pizza pizza2 = new Pizza("Grande", 20, 2500, "Tomate");
            Pizza pizza3 = new Pizza("Petite", 10, 2000, "04 Fromages");

            Drink drink1 = new Drink("Grande", 12, 1000, "Jus de mangue");

            ListPizza listP = new ListPizza();
            listP.add(pizza1);
            listP.add(pizza2);
            listP.add(pizza3);
            ListDrink listD = new ListDrink();
            listD.add(drink1);

            Pizza p1 = new Pizza("Petite", 12, 1000, "Jambon");
            Pizza p2 = new Pizza("Grande", 20, 1500, "ROYALE");

            Drink d1 = new Drink("Grande", 12, 1000, "Jus de papaye");

            ListPizza listP2 = new ListPizza();
            listP2.add(p1);
            listP2.add(p2);
            ListDrink listD2 = new ListDrink();
            listD2.add(d1);
/*  */
            Pizza pp = new Pizza("Petite", 12, 3000, "Jambon");
            Pizza ppp = new Pizza("Grande", 20, 7500, "ROYALE");

            Drink dd = new Drink("Grande", 12, 1000, "Jus de papaye");

            ListPizza listPP = new ListPizza();
            listPP.add(pp);
            listPP.add(pp);
            ListDrink listDD = new ListDrink();
            listDD.add(dd);

            Command command = new Command(
                new Cart(listP, listD),
                "MORNING 7-5",
                listCustomers[0].Phone,
                "Patrick",
                "Lucas",
                new DateOnly(2022, 1, 1)
            );

            Command command1 = new Command(
                new Cart(listP2, listD2),
                "NIGHT415",
                listCustomers[1].Phone,
                "Patrick",
                "Lucas",
                new DateOnly(2022, 1, 1)
            );

             Command command3 = new Command(
                new Cart(listPP, listDD),
                "MORNING 7-5",
                listCustomers[3].Phone,
                "Patrick",
                "Lucas",
                new DateOnly(2022, 1, 1)
            );

            Kitchen kitchen = new Kitchen();

            ListCommand listCommand = new ListCommand();
            listCommand.add(command);
            listCommand.add(command1);
            listCommand.add(command3);

            var TaskForCooking = new List<Task> { kitchen.cook(listCommand.get(0)), kitchen.cook(listCommand.get(1)) };
            int i = 0;
            while (TaskForCooking.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(TaskForCooking);
                i++;
                if (finishedTask == TaskForCooking[0]  )
                {
                    Console.WriteLine("Command 1 is ready to be deliver .... ");
                }
                else if (finishedTask == TaskForCooking[1])
                {
                    Console.WriteLine("Command 2 is ready to be deliver .... ");
                }
                TaskForCooking.Add(kitchen.cook(listCommand.get(i-1)));
                TaskForCooking.Remove(finishedTask);
                if (i == listCommand.nbrElements())
                {
                    break;
                }
                Console.WriteLine(i + "-----");
            }

            /* Console.WriteLine(command.ToString()); */
        }
    }
}
