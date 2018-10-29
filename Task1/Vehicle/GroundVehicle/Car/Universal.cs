using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Universal : Car
    {
        public Trunk TrunkType { get; private set; }

        public Universal(string name, int price, int fuelUsage, int speed, int wheels,Trunk trunkType) : base(name,price,fuelUsage,speed,wheels)
        {
            TrunkType = trunkType;
        }

        public new string GetData()
        {
            return Name + " " + Price + " " + FuelUsage + " " + Speed + " " + Wheels + " " + TrunkType;
        }
    }
}
