using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Universal : Car, IHasTrunk
    {
        public bool HasTrunk
        {
            get
            {
                return _hasTrunk;
            }
            set
            {
                _hasTrunk = value;
            }
        }
        private bool _hasTrunk;

        public Universal(string name, int price, int fuelUsage, int speed, int wheels,bool hasTrunk) : base(name,price,fuelUsage,speed,wheels)
        {
            _hasTrunk = hasTrunk;
        }

        public override string GetData()
        {
            return Name + " " + Price + " " + FuelUsage + " " + Speed + " " + Wheels + " " + HasTrunk;
        }
    }
}
