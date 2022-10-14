using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Order;

namespace Human
{
    public class Customer : Person
    {
        public DateOnly ? FirstCommand { get; set; }
        public float TimeForThinking { get; set; }

        /* Construct for older customer */
        public Customer(
            string firstname,
            string lastname,
            string address,
            string phone,
            DateOnly firstCommand,
            float timeForThinking
        ) : base(firstname, lastname, address, phone)
        {
            this.FirstCommand = firstCommand;
            this.TimeForThinking = timeForThinking;
        }
        /* Construct for new customer */
        public Customer(
            string firstname,
            string lastname,
            string address,
            string phone,
            float timeForThinking
        ) : base(firstname, lastname, address, phone)
        {
            this.FirstCommand = null;
            this.TimeForThinking = timeForThinking;
        }

        public string checkCommand(List<Command> listCommand, string no_commande)
        {
            if (listCommand != null)
            {
                Command ? command = listCommand.Find(e => e.NoCommande == no_commande);
                if (command != null)
                {
                    return command.ToString();   
                }
            }
            return "No command found ...";   
        }

        public override string ToString()
        {
            string display = "Client - " + base.ToString();
            if(FirstCommand == null) {
                display += " - It's a new customer ... ";
            }
            else {
                display += " - First command made : " + FirstCommand;
            }
            return display;
        }
    }
}
