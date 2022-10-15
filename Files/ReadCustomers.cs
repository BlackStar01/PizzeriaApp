using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human;

namespace Models.Files
{
     public class ReadCustomer
    {
        public string path = "./Files/customers.csv";
        public List<Customer> listCustomers = new List<Customer>();
        
        public List<Customer> readFile() {
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach(string line in lines)
            {
                string[] columns = line.Split(',');
                Customer c = new Customer(columns[0], columns[1], columns[2], columns[3], new DateOnly(Int32.Parse(columns[4].Split('-')[0]), Int32.Parse(columns[4].Split('-')[1]), Int32.Parse(columns[4].Split('-')[2])));
                 listCustomers.Add(c);
            }
            return listCustomers;
        }

        public override string ToString()
        {
            string display = "";
            foreach (Customer cus in listCustomers)
            {
                display += cus.ToString() + "\n";
            }
            return display;
        }
    }
}