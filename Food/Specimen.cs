using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Food
{
    public abstract class Specimen
    {
        /* In the case of drink , our drink volume is the height */
        public string Height { get; set; }
        public float Price { get; set; }

        public Specimen(string height, float price)
        {
            Height = height;
            Price = price;
        }

        public override string ToString()
        {
            return this.Height + " " + this.Price + " € ";
        }
    }
}
