using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Strategy
{
    public class ClassicCoffee: IPreparable
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Classic coffee...");
        }
    }
}
