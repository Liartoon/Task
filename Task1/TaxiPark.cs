using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TaxiPark
    {
        public List<Car> CarPark { get; private set; }

        public int Price { get { return CarPark.Sum(x => x.Price); } }

        public TaxiPark()
        {
            CarPark = new List<Car>();
        }

        public void FillThePark(string fileName)
        {
            string str;
            string[] strArr;
            Car newCar = null;
            StreamReader sr = new StreamReader(fileName);
            while ((str = sr.ReadLine()) != null)
            {
                strArr = str.Split(' ');
                switch (int.Parse(strArr[0]))
                {
                    case 1: {newCar = new Cabriolet(strArr[1], int.Parse(strArr[2]), int.Parse(strArr[3]),
                   int.Parse(strArr[4]), int.Parse(strArr[5]),(Roof)int.Parse(strArr[6])); break; }
                    case 2: {newCar = new Pickup(strArr[1], int.Parse(strArr[2]), int.Parse(strArr[3]),
                   int.Parse(strArr[4]), int.Parse(strArr[5]), int.Parse(strArr[6])); break; }
                    case 3: {newCar = new Universal(strArr[1], int.Parse(strArr[2]), int.Parse(strArr[3]),
                  int.Parse(strArr[4]), int.Parse(strArr[5]), (Trunk)int.Parse(strArr[6])); break; }
                }
                
                CarPark.Add(newCar);
            }
            sr.Close();
        }

        public void Add(Car car)
        {
            CarPark.Add(car);
        }

        public void Sort()
        {
            Comparison<Car> sort = new Comparison<Car>
                ((x,y) => (x.FuelUsage>y.FuelUsage) ? 1 : (x.FuelUsage < y.FuelUsage) ? -1 : 0);
            CarPark.Sort(sort);
        }

        public Car FindCarBySpeedInterval(int leftBorder,int rightBorder)
        {
            return CarPark.Find(x => (x.Speed > leftBorder) && (x.Speed < rightBorder));
        }
    }
}
