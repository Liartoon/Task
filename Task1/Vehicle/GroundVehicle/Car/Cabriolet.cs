using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Cabriolet : Car
    {
        public Roof RoofType { get; private set; }

        public Cabriolet(string name, int price, int fuelUsage, int speed, int wheels, Roof roofType) : base(name,price,fuelUsage,speed,wheels)
        {
            RoofType = roofType;
        }

        public new string GetData()
        {
            return Name + " " + Price + " " + FuelUsage + " " + Speed + " " + Wheels + " " + RoofType;
        }
    }
}
