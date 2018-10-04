using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.State
{
    public class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Continue raising gas temperature");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Tranforming gas into water");
            water.State = new LiquidWaterState();
        }
    }
}
