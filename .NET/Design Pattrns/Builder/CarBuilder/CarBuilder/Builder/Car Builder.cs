using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    abstract class CarBuilder
    {
        public Car Car { get; private set; }

        public CarBuilder()
        {
            Car = new Car();
        }

        public abstract void SetBody();
        public abstract void SetElectronics();
        public abstract void SetEngine();
        public abstract void SetSuspension();
        public abstract void SetTransmission();
        public abstract void SetWheels();
    }

    class MazdaBuilder : CarBuilder
    {
        public override void SetBody() =>  Car.Body = new Body() { BodyStructure = "Sports car" };

        public override void SetEngine() => Car.Engine = new Engine() { FuelType = "Diesel" };
  
        public override void SetTransmission() => Car.Transmission = new Transmission() { TransmissionType = "Manual Type" };

        public override void SetSuspension() => Car.Suspension = new Suspension() { ShockAbsorbersType = "Hydraulic type shock absorbers" };

        public override void SetWheels() => Car.Wheels = new Wheels() { TireSize = "225/45R17" };
        
        public override void SetElectronics() => Car.Electronics = new Electronics() { IsConditioner = true };

    }
}
