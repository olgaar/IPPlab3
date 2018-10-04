using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.State
{
    public class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Transforming ice into water");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Continue frosting");
        }
    }
}
