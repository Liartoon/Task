using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Cabriolet : Car, IHasRoof
    {
        public bool HasRoof
        {
            get
            {
                return _hasRoof;
            }
            set
            {
                _hasRoof = value;
            }
        }
        private bool _hasRoof;

        public Cabriolet(string name, int price, int fuelUsage, int speed, int wheels, bool hasRoof) : base(name,price,fuelUsage,speed,wheels)
        {
            _hasRoof = hasRoof;
        }

        public override string GetData()
        {
            return Name + " " + Price + " " + FuelUsage + " " + Speed + " " + Wheels + " " + HasRoof;
        }
    }
}
