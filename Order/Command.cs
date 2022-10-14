using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Food;

namespace Models.Order
{
    public abstract class Command
    {
        public string NoCommande { get; set; }
        public string PhoneCustomer { get; set; }
        public string NameCommis { get; set; }
        public string NameLivreur { get; set; }
        public DateOnly Date { get; set; }
        public Cart CartOrder { get; set; }
        public string State { get; set; }

        public Command(Cart cart, string noCommande, string phoneCustomer, string nameCommis, string nameLivreur, DateOnly date, string state)
        {
            CartOrder = cart;
            NoCommande = noCommande;
            PhoneCustomer = phoneCustomer;
            NameCommis = nameCommis;
            NameLivreur = nameLivreur;
            Date = date;
            State = state;
        }

        public override string ToString()
        {
            return NoCommande + " " + CartOrder + " - State : " + State;
        }
    }
}
