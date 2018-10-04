using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Oberver
{
    public class ConcreteClient: IObserver
    {
        public string Name { get; set; }
        IObservable promo;
        public ConcreteClient(string name, IObservable obs)
        {
            this.Name = name;
            promo = obs;
            promo.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            string info = (string)ob;
            Console.WriteLine("Promo for {0} - {1}", this.Name, info);
           
        }
        public void StopPromo()
        {
            promo.RemoveObserver(this);
            promo = null;
        }
    }
}
