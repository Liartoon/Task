using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace Task1
{
    public class TaxiPark
    {
        public List<Vehicle> CarPark { get; private set; }

        public int TotalValue { get { return CarPark.Sum(x => x.Price); } }

        public TaxiPark()
        {
            CarPark = new List<Vehicle>();
        }

        public void FillThePark(string fileName)
        {
            string str;
            string[] strArr;
            Vehicle newVehicle = null;
            try
            {
                StreamReader sr = new StreamReader(fileName);
                while ((str = sr.ReadLine()) != null)
                {
                    strArr = str.Split(' ');
                    switch (int.Parse(strArr[0]))
                    {
                        case 1:
                            {
                                newVehicle = new Cabriolet(strArr[1], int.Parse(strArr[2]), int.Parse(strArr[3]),
                      int.Parse(strArr[4]), int.Parse(strArr[5]), bool.Parse(strArr[6])); break;
                            }
                        case 2:
                            {
                                newVehicle = new Pickup(strArr[1], int.Parse(strArr[2]), int.Parse(strArr[3]),
                      int.Parse(strArr[4]), int.Parse(strArr[5]), int.Parse(strArr[6])); break;
                            }
                        case 3:
                            {
                                newVehicle = new Universal(strArr[1], int.Parse(strArr[2]), int.Parse(strArr[3]),
                     int.Parse(strArr[4]), int.Parse(strArr[5]), bool.Parse(strArr[6])); break;
                            }
                    }
                    CarPark.Add(newVehicle);
                }
                sr.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                CarPark.Clear();
                Console.ReadKey();
                Environment.Exit(0);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                CarPark.Clear();
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public void Add(Vehicle vehicle)
        {
            CarPark.Add(vehicle);
        }

        public void Sort()
        {
            Comparison<Vehicle> sort = new Comparison<Vehicle>
                ((x,y) => (x.FuelUsage>y.FuelUsage) ? 1 : (x.FuelUsage < y.FuelUsage) ? -1 : 0);
            CarPark.Sort(sort);
        }

        public Vehicle FindCarBySpeedInterval(int leftBorder,int rightBorder)
        {
            return CarPark.Find(x => (x.Speed > leftBorder) && (x.Speed < rightBorder));
        }
    }
}
