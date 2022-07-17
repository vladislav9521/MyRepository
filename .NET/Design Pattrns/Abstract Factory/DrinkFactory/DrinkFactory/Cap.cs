using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkFactory
{
    abstract class AbstractCap
    {

    }

    class PepsiCap : AbstractCap
    {
        public override string ToString() => "Pepsi cap";
    }

    class ColaCap : AbstractCap
    {
        public override string ToString() => "Coca-cola cap";
    }
}
