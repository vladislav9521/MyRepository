using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    class CarConstructor
    {
        CarBuilder carBuilder = null;
        public CarConstructor(CarBuilder carBuilder)
        {
            this.carBuilder = carBuilder; 
        }

        public void Construct()
        {
            carBuilder.SetBody();
            carBuilder.SetEngine();
            carBuilder.SetTransmission();
            carBuilder.SetSuspension();
            carBuilder.SetWheels();
            carBuilder.SetElectronics();
        }
    }
}
