using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Models.Human;

namespace PizzeriaApp.Services
{
    public class MainWindowService
    {
        public string TitleOfMainWindow { get; set; }

        public List<Person> listOfPerson { get; set; }

        public MainWindowService()
        {
            TitleOfMainWindow = "Helle";
            listOfPerson = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                Person person = new Person();

                person.Firstname = "vital";
                person.Lastname = "ez,lr";
                person.Address = "lzjr";
                person.ContentMessage = "zf,l";

                listOfPerson.Add(person);
            }
        }
    }
}
