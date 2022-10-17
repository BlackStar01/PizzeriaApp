using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human;
using Models.Food;
using Models.Lists;
using Models.Order;
namespace Models.Lists
{
    public class ListCommand
    {
        public List<Command> listCommand = new List<Command>();

        public void add(Command command) {   
            listCommand.Add(command);
        }

        public Command get(int index) {   
            return listCommand[index];
        }

        public int nbrElements() {   
            return listCommand.Count;
        }

        public ListCommand createListCommand()
        {
            Customer customer1 = new Customer("Vital", "WARREN", "Paris", "+33 5 65 65 65 41");
            Customer customer2 = new Customer(
                "Marin-Pierre",
                "BABIN",
                "Bordeaux",
                "+33 3 65 04 68 96",
                new DateOnly(2022, 1, 1)
            );
            Customer customer3 = new Customer("Lucas", "GROSJEAN", "Nantes", "+33 6 89 65 70 41");
            Customer customer4 = new Customer(
                "Eric",
                "ISAK",
                "Marseille",
                "+33 7 00 65 65 17",
                new DateOnly(2022, 1, 1)
            );

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
            listCustomers.Add(customer4);

            ListPizza listP = new ListPizza();
            ListDrink listD = new ListDrink();
            listP.add(new Pizza("Grande", 15, 1000, "vegetariennes"));
            listP.add(new Pizza("Grande", 20, 2500, "ROYALE"));
            listP.add(new Pizza("Petite", 10, 2000, "Bacon"));
            listD.add(new Drink("Grande", 15, 1000, "vegetarienne"));

            ListPizza listP2 = new ListPizza();
            ListDrink listD2 = new ListDrink();
            listP2.add(new Pizza("Petite", 15, 1000, "vegetarienne"));
            listP2.add(new Pizza("Grande", 30, 1500, "ROYALE"));
            listD2.add(new Drink("Grande", 12, 1000, "Jus de papaye"));

            ListPizza listP3 = new ListPizza();
            listP3.add(new Pizza("Petite", 15, 3000, "vegetarienne"));
            listP3.add(new Pizza("Grande", 18, 3000, "Bacon"));
            listP3.add(new Pizza("Petite", 15, 3000, "vegetarienne"));
            listP3.add(new Pizza("Grande", 20, 7500, "ROYALE"));
            ListDrink listD3 = new ListDrink();
            listD3.add(new Drink("Grande", 12, 3000, "Jus de papaye"));
            listD3.add(new Drink("Grande", 12, 1000, "Jus de papaye"));

            ListPizza listP4 = new ListPizza();
            listP4.add(new Pizza("Petite", 12, 3000, "Jambon"));
            listP4.add(new Pizza("Grande", 20, 7500, "ROYALE"));
            ListDrink listD4 = new ListDrink();
            listD4.add(new Drink("Grande", 12, 3000, "Jus de papaye"));

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

            Command command2 = new Command(
                new Cart(listP3, listD3),
                "MORNING 24-0",
                listCustomers[2].Phone,
                "Patrick",
                "Lucas",
                new DateOnly(2022, 1, 1)
            );

            Command command3 = new Command(
                new Cart(listP4, listD4),
                "MORNING 75-10",
                listCustomers[3].Phone,
                "Patrick",
                "Lucas",
                new DateOnly(2022, 1, 1)
            );

            ListCommand listCommand = new ListCommand();
            listCommand.add(command);
            listCommand.add(command1);
            listCommand.add(command2);
            listCommand.add(command3);

            return listCommand;
        }

        public override string ToString()
        {
            string displayList = "\n  - - - - - - - - - - -  List of commands  - - - - - - - - - - -   \n\n";
            foreach (Command command in listCommand)
            {
                displayList += command.ToString();
            }
            return displayList;
        }
    }
}
