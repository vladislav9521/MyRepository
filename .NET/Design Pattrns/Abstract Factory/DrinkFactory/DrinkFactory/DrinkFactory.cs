using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkFactory
{
    abstract class AbstractDrinkFactory
    {
        public abstract AbstractBottle GetBottle();
        public abstract AbstractCap GetCap();
        public abstract AbstractLiquid GetLiquid();
    }

    class PepsiFactory : AbstractDrinkFactory
    {
        public override AbstractBottle GetBottle() => new PepsiBottle();
        public override AbstractCap GetCap() => new PepsiCap();
        public override AbstractLiquid GetLiquid() => new PepsiLiquid();
    }

    class ColaFactory : AbstractDrinkFactory
    {
        public override AbstractLiquid GetLiquid() => new ColaLiquid();
        public override AbstractBottle GetBottle() => new ColaBottle();
        public override AbstractCap GetCap() => new ColaCap();
    }

}
