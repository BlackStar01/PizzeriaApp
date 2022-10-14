using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Food
{
    public abstract class Pizza : Specimen
    {
        string Type { get; set; }

        public Pizza(string height, float price, string type) : base(height, price)
        {
            Type = type;
        }

        public override string ToString()
        {
            return "Pizza - " + Type + " " + base.ToString();
        }
    }
}
