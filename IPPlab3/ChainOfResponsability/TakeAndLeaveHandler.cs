using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Command
{
    public class TakeAndLeaveHandler : CoffeeHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.TakeAndLeave == true)
                Console.WriteLine("Client takes the coffee and leaves the place");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
