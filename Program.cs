using System.Net;
using System;
using Human;
using Models.Food;
using Models.Lists;
using Models.Order;
using Models.Cooking;
using Models.Display;
using System.Threading.Tasks;

namespace Models
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(" 1 - Parcours individuel ");
            Console.WriteLine(" 2 - Charger un fichier command ");
            string? res = Console.ReadLine();

            Kitchen kitchen = new Kitchen();

            switch (Int32.Parse(res))
            {
                case 1:
                    Menu menu = new Menu();
                    Customer myCustomer = menu.checkOlder();

                    Command command = new Command(
                        new Cart(menu.selectPizza(), menu.selectDrink(myCustomer.Phone)),
                        "MORNING 7-5",
                        myCustomer.Phone,
                        "Patrick",
                        "Lucas",
                        DateOnly.FromDateTime(DateTime.Now)
                    );

                    Console.WriteLine(command.ToString());

                    var myTask = new List<Task>
                    {
                        kitchen.cook(command),
                    };
                    while (myTask.Count > 0)
                    {
                        if (myTask.Count == 0)
                        {
                            break;
                        }
                        Task finishedTask = await Task.WhenAny(myTask);
                        if (finishedTask == myTask[0])
                        {
                            Console.WriteLine("\nCommand is ready to be deliver .... ");
                        }
                        
                        myTask.Remove(finishedTask);
                    }
                    break;
                case 2:
                    ListCommand commands = new ListCommand();
                    ListCommand listCommand = commands.createListCommand();

                    var TaskForCooking = new List<Task>
                    {
                        kitchen.cook(listCommand.get(0)),
                        kitchen.cook(listCommand.get(1))
                    };
                    int i = 2;
                    while (TaskForCooking.Count > 0)
                    {
                        ineligible:

                        if (TaskForCooking.Count == 0)
                        {
                            break;
                        }
                        Task finishedTask = await Task.WhenAny(TaskForCooking);
                        if (finishedTask == TaskForCooking[0])
                        {
                            Console.WriteLine("\nCommand 1 is ready to be deliver .... ");
                        }
                        else if (finishedTask == TaskForCooking[1])
                        {
                            Console.WriteLine("\nCommand 2 is ready to be deliver .... ");
                        }

                        TaskForCooking.Remove(finishedTask);
                        if (i == listCommand.nbrElements())
                        {
                            goto ineligible;
                        }
                        else if (i > listCommand.nbrElements())
                        {
                            break;
                        }
                        TaskForCooking.Add(kitchen.cook(listCommand.get(i)));
                        i++;
                    }
                    break;
                default:
                    break;
            }

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

            /* Pizza pizza1 = new Pizza("Grande", 12, 1000, "vegetariennes");
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

            Pizza pp = new Pizza("Petite", 12, 3000, "Jambon");
            Pizza ppp = new Pizza("Grande", 20, 7500, "ROYALE");

            Drink dd = new Drink("Grande", 12, 3000, "Jus de papaye");

            ListPizza listPP = new ListPizza();
            listPP.add(pp);
            listPP.add(ppp);
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
                "MORNING 77-5",
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
            int i = 2;
            while (TaskForCooking.Count > 0)
            {
                ineligible:

                if(TaskForCooking.Count == 0) {
                    break;
                }
                Task finishedTask = await Task.WhenAny(TaskForCooking);
                if (finishedTask == TaskForCooking[0])
                {
                    Console.WriteLine("\nCommand 1 is ready to be deliver .... ");
                }
                else if (finishedTask == TaskForCooking[1])
                {
                    Console.WriteLine("\nCommand 2 is ready to be deliver .... ");
                }

                TaskForCooking.Remove(finishedTask);
                if (i == listCommand.nbrElements())
                {
                    goto ineligible;
                }
                else if (i > listCommand.nbrElements()) {
                    break;
                }
                TaskForCooking.Add(kitchen.cook(listCommand.get(i)));
                i++;
            } */

            /* Console.WriteLine(listCommand.ToString()); */
        }
    }
}
