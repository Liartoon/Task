using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static void OutputVehicle(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.GetData());
        }

        private static void OutputCarPark(List<Vehicle> carPark)
        {
            foreach (Car car in carPark)
            {
                Console.WriteLine(car.GetData());
            }
        }

        static void Main(string[] args)
        {
            bool condition=true;
            TaxiPark park = new TaxiPark();
            park.FillThePark("input.txt");
            
            while (condition)
            {
                Console.WriteLine("Введите число:(0 - Состав таксопарка, 1 - Стоимость автопарка, 2 - Сортировка, 3 - Нахождение авто по интервалу скорости, 4 - Отчистка консли, 5 - Выход)");
                switch (Console.ReadLine())
                {
                    case "0": { OutputCarPark(park.CarPark); break; }
                    case "1": { Console.WriteLine(park.TotalValue); break; }
                    case "2": { park.Sort(); break; }
                    case "3": {
                            Console.WriteLine("Введите левый и правый интервал: ");
                            OutputVehicle(park.FindCarBySpeedInterval(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()))); break;
                        }
                    case "4": { Console.Clear(); break; }
                    case "5": { condition = false; break; }
                }
            }
        }
    }
}
