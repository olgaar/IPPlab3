using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Strategy
{
    public class Coffee
    {
        protected int sugarPieces; 
        public Coffee(int sugar, IPreparable type)
        {
            sugarPieces = sugar;
            Preparable = type;
        }
        public IPreparable Preparable { private get; set; }
        public void Prepare()
        {
            Preparable.Prepare();
        }
    }
}
