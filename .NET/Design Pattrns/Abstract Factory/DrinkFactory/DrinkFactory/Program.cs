using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDrinkFactory factory = new PepsiFactory();
            Client drink = new Client(factory);
            drink.Interact();

            factory = new ColaFactory();
            drink = new Client(factory);
            drink.Interact();

            Console.Read();
        }
    }
}
