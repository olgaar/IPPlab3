using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.State
{
    public interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
