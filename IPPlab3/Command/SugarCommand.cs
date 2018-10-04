using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Command
{
    public class SugarCommand: ICommand
    {
        Sugar sugar;
        public SugarCommand(Sugar s)
        {
            sugar = s;
        }
        public void Execute()
        {
            sugar.RaiseLevel();
        }

        public void Undo()
        {
            sugar.DropLevel();
        }
    }
}
