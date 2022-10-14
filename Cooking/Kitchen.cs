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
            Console.WriteLine("\n Start cook command of : " + command.PhoneCustomer + " ... Delay -> " + command.CartOrder.computeDuration());
            Console.WriteLine("Started cooking");
            await Task.Delay(6000);

            return command;
        }

        public async Task<Command> finish(Command command)
        {
            command.State = "Finish";
            await Task.Delay(1000);
            Console.WriteLine("Start put command in bag...");
            await Task.Delay(3000);

            return command;
        }
    }
}
