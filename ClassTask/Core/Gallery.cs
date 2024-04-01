using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Gallery
    {
        private static int _id = 1000;
        public int Id { get; set; }

        public string Name { get; set; }

        public Car[] Cars = new Car[] { };

        public void AddEmployee(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;
        }

        public Car[] GelAllCars()
        {
            return Cars;
        }

        public void ShowAllCars()
        {
            for(int i = 0; i < Cars.Length; i++)
            {
                Car car = Cars[i];
                Console.WriteLine($"{car.Id}, {car.Name}, {car.Speed}, {car.CarCode}");
            }
        }

        public Car[] FindCarById(int id)
        {
            Car[] newCars = { };
            for(int i = 0;i < Cars.Length;i++)
            {
                Car car = Cars[i];
                if(car.Id == id)
                {
                    Array.Resize(ref newCars, newCars.Length + 1);
                    newCars[newCars.Length - 1] = Cars[i];
                }
                else
                {
                    Console.WriteLine("Bu id`de car yoxdur");
                }
            }
            return newCars;
        }

        public Car[] FindCarByCarCode(string carcode)
        {
            Car[] checkCarCode = { };
            for (int i = 0;i<Cars.Length;i++)
            {
                Car car = Cars[i];
                if(car.CarCode == carcode)
                {
                    Array.Resize(ref checkCarCode, checkCarCode.Length + 1);
                    checkCarCode[checkCarCode.Length - 1] = Cars[i];                  
                }
                else
                {
                    Console.WriteLine("Bele bir CarCode movcud deyil");
                }
            }
            return checkCarCode;
        }

        public Car[] FindCarsBySpeedInterval(double minSpeed, double maxSpeed)
        {
            Car[] speeds = { };

            for(int i = 0; i<Cars.Length;i++)
            {
                Car car = Cars[i];
                if(car.Speed <=  minSpeed && car.Speed >= maxSpeed)
                {
                    Array.Resize(ref speeds, speeds.Length + 1);
                    speeds[speeds.Length - 1] = Cars[i];
                }
                else
                {
                    Console.WriteLine("Bu araliqda car yoxdur");
                }
            }
            return speeds;
        }
    }
}
