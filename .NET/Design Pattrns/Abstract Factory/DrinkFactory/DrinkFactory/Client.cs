using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkFactory
{
    class Client
    {

    AbstractLiquid liquid = null;
    AbstractCap cap = null;
    AbstractBottle bottle = null;

    public Client(AbstractDrinkFactory drinkFactory)
    {
        liquid = drinkFactory.GetLiquid();
        cap = drinkFactory.GetCap();
        bottle = drinkFactory.GetBottle();
    }

    public void Interact()
    {
        bottle.ScrewCap(cap);
        bottle.PourLiquid(liquid);
    }
    }
 
}
