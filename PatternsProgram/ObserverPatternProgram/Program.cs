using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();

            Bank bank = new Bank("UnitBank", stock);
            Broker broker = new Broker("Pavel", stock);

            stock.Market();
            broker.StopTrade();
            stock.Market();

            Console.Read();
        }
    }

}
