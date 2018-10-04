using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Command
{
    public class Receiver
    {
            public bool TakeAndLeave { get; set; }
            public bool DrinkInside { get; set; }
            public Receiver(bool takeAndLeave, bool drinkInside)
            {
            TakeAndLeave = takeAndLeave;
            DrinkInside = drinkInside;
            }
        }
    
}
