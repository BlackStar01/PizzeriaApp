using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Order;

/*Before going to kitchen, Still cooking, Being deliver, Close */

namespace Models.Cooking
{
    public class Kitchen
    {

        public async Task<Command> cook(Command command)
        {
            Console.WriteLine("\n Start cook command of : " + command.PhoneCustomer + " ... Time for cooking -> " + (command.CartOrder.computeDuration())/1000 + " seconds");
            await Task.Delay((int)command.CartOrder.computeDuration());
            command.State = "En preparation ... ";
            return command;
        }
    }
}
