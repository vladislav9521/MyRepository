using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkFactory
{
    abstract class AbstractLiquid
    {

    }

    class PepsiLiquid : AbstractLiquid
    {
        public override string ToString() => "Pepsi liquid";
    }

    class ColaLiquid : AbstractLiquid
    {
        public override string ToString() => "Coca-cola liquid";
    }
}
