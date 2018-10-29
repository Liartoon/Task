using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Plane : Vehicle
    {
        public int WingsLength { get; private set; }

        public Plane(string name, int price, int fuelUsage, int speed,int wingsLength) : base(name, price, fuelUsage, speed)
        {
            WingsLength = wingsLength;
        }
    }
}
