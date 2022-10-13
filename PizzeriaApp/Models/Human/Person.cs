using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Models.Human
{
    public class Person : IMessage
    {
        #region Propieties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string ContentMessage { get; set; }

        #endregion

        #region Constructors
        public Person() {}
        #endregion

        public void SendMessage(Person Sender, Person[] Receiver, string ContentMessage)
        {
            Console.WriteLine("ejbf");
        }

        public override string ToString() { 
            return Firstname + " " + Lastname + " - " + Address;
        }

    }
}
