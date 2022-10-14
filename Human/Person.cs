using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Person
    {
        #region Propieties
        public string ? Firstname { get; set; }
        public string ? Lastname { get; set; }
        public string ? Address { get; set; }
        public string ? Phone { get; set; }

        #endregion

        #region Constructor
        public Person(string firstName, string lastName, string address, string phone) {
            Firstname = firstName;
            Lastname = lastName;
            Address = address;
            Phone = phone;
        }

        #endregion

        public override string ToString() { 
            return Firstname + " " + Lastname + " - " + Address + " - " + Phone;
        }

    }

}
    