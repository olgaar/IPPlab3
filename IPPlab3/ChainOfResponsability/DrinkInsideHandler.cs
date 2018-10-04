using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Command
{
    public class DrinkInsideHandler: CoffeeHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.DrinkInside == true)
                Console.WriteLine("Client drinks the coffee and then leaves the place");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
