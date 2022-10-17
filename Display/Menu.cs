using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Order;
using System.Linq;
using Models.Lists;
using Models.Files;
using Models.Food;
using Human;

/* Before going to kitchen, Still cooking, Being deliver, Close */

namespace Models.Display
{

    enum enumType
    {
        // following are the data members
        Vegetarienne = 15,
        Bacon = 18,
        Royale = 30
    }
    enum enumDuration
    {
        // following are the data members
        five = 5000,
        ten = 1000,
        twelve = 1200,
        fifteen = 1500
    }

    public class Menu
    {
        public ListPizza selectPizza()
        {
            ListPizza listP = new ListPizza();
            Type ourTypes = typeof(enumType);
            Type ourDurations = typeof(enumDuration);

            Console.WriteLine(" Choisir la pizza ");

            Console.WriteLine(" 1 - Végétarienne ");
            Console.WriteLine(" 2 - Bacon ");
            Console.WriteLine(" 3 - Royale ");
            goback:
            string? res = Console.ReadLine();

            switch (Int32.Parse(res))
            {
                case 1:
                case 2:
                case 3:
                    string[] durations = new string[] { "five", "ten", "twelve", "fifteen" };
                    Random rnd = new Random();
                    int indexDuration = rnd.Next(durations.Length);
                    string[] typePizza = new string[] { "Vegetarienne", "Bacon", "Royale" };
                    int indexTypePizza = rnd.Next(typePizza.Length);
                    Pizza pizza = new Pizza("Grand", 12, float.Parse(Enum.Format(ourDurations, Enum.Parse(ourDurations, durations[indexDuration]), "d")), Enum.Format(ourTypes, Enum.Parse(ourTypes, typePizza[indexTypePizza]), "d"));
                    listP.add(pizza);
                    Console.WriteLine(" Une autre ? 'o' oui ");

                    string? other = Console.ReadLine();
                    if (other == "o")
                    {
                        goto goback;
                    }
                    return listP;
                    break;

                default:
                    return null;
                    break;
            }
        }

        public ListDrink selectDrink(string phone)
        {
            ListDrink listD = new ListDrink();

            Console.WriteLine(" Choisir annexe ");

            Console.WriteLine(" 1 - Boisson aaaa ");
            Console.WriteLine(" 2 - Boisson rrr ");
            Console.WriteLine(" 3 - Boisson pppp ");
            goback:
            string? res = Console.ReadLine();

            switch (Int32.Parse(res))
            {
                case 1:
                case 2:
                case 3:
                    Drink dr = new Drink("500 cl", 10, 1000, res);
                    listD.add(dr);
                    Console.WriteLine(" Une autre ? 'o' oui ");

                    string? other = Console.ReadLine();
                    if (other == "o")
                    {
                        goto goback;
                    }
                    return listD;

                default:
                    return listD;
            }
        }

        public Customer checkOlder()
        {
            int alpha = 0;

            Console.WriteLine("Vous êtes : ");
            Console.WriteLine(" 1 - Ancien client ");
            Console.WriteLine(" 2 - Nouveau client ");

            alpha = Int32.Parse(Console.ReadLine());

            List<Customer>? listCustomers = new List<Customer>();
            ReadCustomer reader = new ReadCustomer();
            listCustomers = reader.readFile();

            switch (alpha)
            {
                case 1:
                    Console.WriteLine("Votre numéro de telephone : ");
                    string ? phoneCustomer = Console.ReadLine();
                    Customer? found = listCustomers.Find(el => el.Phone == phoneCustomer);
                    Console.WriteLine(found.ToString());
                    return found;

                case 2:
                    Console.WriteLine("Firstname : ");
                    string ? firstname = Console.ReadLine();
                    Console.WriteLine("Lastname :");
                    string ? lastname = Console.ReadLine();
                    Console.WriteLine("Addresse : ");
                    string ? address = Console.ReadLine();
                    Console.WriteLine("Phone : ");
                    string ? phone = Console.ReadLine();
                    Customer newCustomer = new Customer(
                        firstname,
                        lastname,
                        address,
                        phone,
                        DateOnly.FromDateTime(DateTime.Now)
                    );
                    return newCustomer;

                default:
                    return null;
            }
        }
    }
}
