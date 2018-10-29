using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Pickup : Car
    {
        public int PlatformSize { get; private set; }

        public Pickup(string name, int price, int fuelUsage, int speed, int wheels, int platformSize) : base(name,price,fuelUsage,speed,wheels)
        {
            PlatformSize = platformSize;
        }

        public new string GetData()
        {
            return Name +" "+ Price + " "+FuelUsage + " "+ Speed+ " " + Wheels + " " + PlatformSize;
        }
    }
}
