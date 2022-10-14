using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Food
{
    public abstract class Drink : Specimen
    {
        string Name { get; set; }

        public Drink(string height, float price, string name) : base(height, price)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Drink - " + Name + " " + base.ToString();
        }
    }
}
