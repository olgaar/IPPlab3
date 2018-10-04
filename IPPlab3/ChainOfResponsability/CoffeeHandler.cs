using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Command
{
    public abstract class CoffeeHandler
    {
       
            public CoffeeHandler Successor { get; set; }
            public abstract void Handle(Receiver receiver);
        
    }
}
