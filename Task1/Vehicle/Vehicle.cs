using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Vehicle
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int FuelUsage { get; private set; }
        public int Speed { get; private set; }

        public Vehicle(string name,int price,int fuelUsage,int speed)
        {
            Name = name;
            Price = price;
            FuelUsage = fuelUsage;
            Speed = speed;
        }
    }
}
