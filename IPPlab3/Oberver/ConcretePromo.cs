using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab3.Oberver
{
    public class ConcretePromo : IObservable
    {
        string info; 

        List<IObserver> observers;
        public ConcretePromo()
        {
            observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(info);
            }
        }

        public void PromoMarket(string promo)
        {
            info = promo;
            NotifyObservers();
        }
    }
}
