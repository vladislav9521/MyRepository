using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    class Car
    {
        public Body Body { get; set; }
        public Electronics Electronics { get; set; }
        public Engine Engine { get; set; }
        public Suspension Suspension { get; set; }
        public Transmission Transmission { get; set; }
        public Wheels Wheels { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Body != null) sb.Append("Тип кузова автомобиля: " + Body.BodyStructure + "\n");
            if (Engine != null) sb.Append("Род применяемого топлива: " + Engine.FuelType + "\n");
            if (Transmission != null) sb.Append("Тип трансмиссии (коробка передачи): " + Transmission.TransmissionType + "\n");
            if (Suspension != null) sb.Append("Типы амортизаторов: " + Suspension.ShockAbsorbersType + "\n");
            if (Wheels != null) sb.Append("Размеры колёс: " + Wheels.TireSize + "\n");
            if (Electronics != null) sb.Append("Кондиционер: " + Electronics.IsConditioner + "\n");

            return sb.ToString();
        }
    }
}
