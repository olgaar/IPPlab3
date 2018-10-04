using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Command
{
    public class CoffeeMachineOnCommand:ICommand
    {
        CoffeeMachine coffeeMachine;
        public CoffeeMachineOnCommand(CoffeeMachine cM)
        {
            coffeeMachine = cM;
        }
        public void Execute()
        {
            coffeeMachine.On();
        }
        public void Undo()
        {
            coffeeMachine.Off();
        }
    }
}
