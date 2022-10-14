using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Commis : Person
    {
        string StateCommand { get; set; }

        public Commis(string firstname, string lastname, string address, string phone, string stateCommand) : base(firstname, lastname, address, phone)
        {
            this.StateCommand = stateCommand;
        }

        public override string ToString()
        {
            return "Commis - " + base.ToString();
        }
    }
}
