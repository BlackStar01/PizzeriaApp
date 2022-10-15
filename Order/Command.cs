using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Food;

namespace Models.Order
{
    public class Command
    {
        public string NoCommande { get; set; }
        public Cart CartOrder { get; set; }
        public string PhoneCustomer { get; set; }
        public string NameCommis { get; set; }
        public string NameLivreur { get; set; }
        public DateOnly Date { get; set; }
        public string State { get; set; }

        public Command(
            Cart cart,
            string noCommande,
            string ? phoneCustomer,
            string nameCommis,
            string nameLivreur,
            DateOnly date
        )
        {
            CartOrder = cart;
            NoCommande = noCommande;
            PhoneCustomer = phoneCustomer;
            NameCommis = nameCommis;
            NameLivreur = nameLivreur;
            Date = date;
            /* en preparation, en livraison ou fermee */
            /*Before going to kitchen, Still cooking, Being deliver, Close */
            State = "Before going to kitchen";
        }

        public override string ToString()
        {
            return "\n\n* * * * * * * * * * * * * * Command  " + NoCommande + "  Date : " + Date + " * * * * * * * * * * * * * * \n\n Customer : " + PhoneCustomer + " \n\n Commis : "  + NameCommis + " \n\n Livreur : "  + NameLivreur + " \n\n " + CartOrder.ToString() + " --> State : " + State + "\n\n";
        }
    }
}
