using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Boat : Vehicle
    {
        public int DeckSize { get; private set; }

        public Boat(string name, int price, int fuelUsage, int speed,int deckSize) : base(name, price, fuelUsage,speed)
        {
            DeckSize = deckSize;
        }
    }
}
