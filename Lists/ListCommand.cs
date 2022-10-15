using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Order;

namespace Models.Lists
{
    public class ListCommand
    {
        public List<Command> listCommand = new List<Command>();

        public void add(Command command) {   
            listCommand.Add(command);
        }

        public Command get(int index) {   
            return listCommand[index];
        }

        public int nbrElements() {   
            return listCommand.Count;
        }

        public override string ToString()
        {
            string displayList = "\n  - - - - - - - - - - -  List of commands  - - - - - - - - - - -   \n\n";
            foreach (Command command in listCommand)
            {
                displayList += command.ToString();
            }
            return displayList;
        }
    }
}
