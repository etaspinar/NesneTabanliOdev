using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_lab
{
    public class Vehicle
    {
        private double _engine;
        public virtual double Engine { get => _engine;
            set
            {
                if (value >=1.0 && value <=5.0)
                {
                    _engine = value;
                }
                else
                {
                    _engine = 1.0;
                }
            }
        }
        public virtual int NumberOfWeel { get; set; }
        public virtual string Model { get; set; }
        public virtual int Price { get; set; }
        public virtual string Transmission { get; set; }


        public virtual void Start()
        {
            Console.WriteLine("Engine Start..");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Engine Stop..");

        }

        public override string? ToString()
        {
            return $"{Engine}\n{Model}\n{NumberOfWeel}\n{Transmission}\n{Price}";
        }
    }

}
