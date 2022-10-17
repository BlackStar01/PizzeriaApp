using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Food
{
    public class Drink : Specimen
    {
        string Name { get; set; }

        public Drink(string height, float price, float duration, string name) : base(height, price, duration)
        {
            price = 10;
            Name = name;
        }

        public override string ToString()
        {
            return "Drink - " + Name + " " + base.ToString();
        }
    }
}
