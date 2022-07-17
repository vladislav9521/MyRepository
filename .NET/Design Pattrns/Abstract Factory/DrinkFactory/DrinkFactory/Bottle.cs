using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkFactory
{
    abstract class AbstractBottle
    {
        public abstract void ScrewCap(AbstractCap cap);
        public abstract void PourLiquid(AbstractLiquid liquid);
    }

    class PepsiBottle : AbstractBottle
    {
        public override string ToString() => "Pepsi bottle";
        public override void ScrewCap(AbstractCap cap) => Console.WriteLine("Крышка {0} закручена на бутылку {1}", cap, this);
        public override void PourLiquid(AbstractLiquid liquid) => Console.WriteLine("Бутылка {0} наполнена жидкостью {1}", this, liquid);
    }

    class ColaBottle : AbstractBottle
    {
        public override string ToString() => "Coca-Cola bottle";
        public override void ScrewCap(AbstractCap cap) => Console.WriteLine("Крышка {0} закручена на бутылку {1}", cap, this);
        public override void PourLiquid(AbstractLiquid liquid) => Console.WriteLine("Бутылка {0} наполнена жидкостью {1}", this, liquid);
    }
}
