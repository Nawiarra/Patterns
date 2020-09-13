using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternProgram
{
    class Bank : IObserver
    {
        public string Name { get; set; }

        IObservable stock;
        public Bank(string name, IObservable obs)
        {
            this.Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.Euro > 40)
                Console.WriteLine("Bank {0} sells euros; Euro exchange rate: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Bank {0} sells euros; Euro exchange rate: {1}", this.Name, sInfo.Euro);
        }
    }
}
