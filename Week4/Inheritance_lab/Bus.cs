using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_lab
{
    public class Bus :Vehicle
    {
        public Bus(double engine, int numberOfWeel, string model, int price, string transmission)
        {
            Engine = engine;
            NumberOfWeel = numberOfWeel;
            Model = model;
            Price = price;
            Transmission = transmission;
        }

        public override string? ToString()
        {
            return $"{Engine}\n{Model}\n{NumberOfWeel}\n{Transmission}\n{Price}";
        }
    }
}
