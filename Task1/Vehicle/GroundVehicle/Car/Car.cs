using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Car : Vehicle
    {
        public int Wheels { get; private set; }

        public Car(string name,int price, int fuelUsage, int speed, int wheels) : base(name,price,fuelUsage,speed)
        {
            Wheels = wheels;
        }

        public override string GetData()
        {
            return Name + " " + Price + " " + FuelUsage + " " + Speed + " " + Wheels;
        }
    }
}
