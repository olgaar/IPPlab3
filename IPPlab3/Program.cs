using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPPlab3.State;
using IPPlab3.Strategy;
using IPPlab3.Oberver;
using IPPlab3.Command;


namespace IPPlab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------State DEMO-------");
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
            water.Frost();
            Console.WriteLine();

            Console.WriteLine("-------Strategy DEMO-------");
            Coffee cofee = new Coffee(2, new Frappe());
            cofee.Prepare();
            cofee.Preparable = new ClassicCoffee();
            cofee.Prepare();
            Console.WriteLine();

            Console.WriteLine("-------Observer DEMO-------");
            ConcretePromo promo = new ConcretePromo();
            ConcreteClient client1 = new ConcreteClient("Olga", promo);
            ConcreteClient client2 = new ConcreteClient("Ann", promo);
            promo.PromoMarket("green tea for 10 lei!");
            client1.StopPromo();
            client2.StopPromo();
            Console.WriteLine();

            Console.WriteLine("-------Chain of Responsability DEMO-------");
            Receiver receiver = new Receiver(false, true);

            CoffeeHandler takeAndLeaveHandler = new TakeAndLeaveHandler();
            CoffeeHandler drinkInsideHandler = new DrinkInsideHandler();
            Console.WriteLine("(Client should drink coffee)");
            drinkInsideHandler.Handle(receiver);
            takeAndLeaveHandler.Handle(receiver);
            Console.WriteLine("(Successor changes - we take two lines)");
            takeAndLeaveHandler.Successor = drinkInsideHandler;

            drinkInsideHandler.Handle(receiver);
            takeAndLeaveHandler.Handle(receiver);
            Console.WriteLine();

            Console.WriteLine("-------Command DEMO-------");
            CoffeeMachine tv = new CoffeeMachine();
            Sugar sugar = new Sugar();
            MultiController mController = new MultiController();
            mController.SetCommand(0, new CoffeeMachineOnCommand(tv));
            mController.SetCommand(1, new SugarCommand(sugar));
            // Coffee machine on
            mController.PressButton(0);
            // sugar level up
            mController.PressButton(1);
            mController.PressButton(1);
            mController.PressButton(1);
            // Undo
            mController.PressUndoButton();
            mController.PressUndoButton();
            mController.PressUndoButton();
            mController.PressUndoButton();

        }
    }
}
