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
        DateOnly FirstCommand { get; set; }

        public Customer(
            string firstname,
            string lastname,
            string address,
            string phone,
            DateOnly firstCommand
        ) : base(firstname, lastname, address, phone)
        {
            this.FirstCommand = firstCommand;
        }

        public string checkCommand(List<Command> listCommand, string no_commande)
        {
            if (listCommand != null)
            {
                Command ? command = listCommand.Find(e => e.NoCommande == no_commande);
                return command.NoCommande;
            }
            else {
                throw new Exception(" Command not found ");
            }
             
        }

        public override string ToString()
        {
            return "Client - " + base.ToString() + " - First command the " + FirstCommand;
        }
    }
}
