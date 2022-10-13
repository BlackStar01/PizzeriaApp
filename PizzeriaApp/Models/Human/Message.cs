using Pizzeria.Models.Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Models.Human
{
    public  interface IMessage
    {
        public string ContentMessage { get; set; }
        void SendMessage(Person Sender, Person[] Receiver, string ContentMessage);

    }
}
