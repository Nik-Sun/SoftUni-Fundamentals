using System;
using System.Collections.Generic;

namespace _14.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                Car currentCar = new Car(carInfo[0],double.Parse(carInfo[1]),double.Parse(carInfo[2]));
                cars.Add(currentCar);
            }
            string[] commandInfo = Console.ReadLine().Split();
            while (commandInfo[0] != "End")
            {
                int index = cars.FindIndex(x => x.Model == commandInfo[1]);
                cars[index].Drive(double.Parse(commandInfo[2]));
                commandInfo = Console.ReadLine().Split();
            }
            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Model} {item.Fuel :f2} {item.Mileage}");
            }



        }
    }
    class Car
    {
        public Car(string model,double fuel,double fuelUse)
        {
            Model = model;
            Fuel = fuel;
            FuelPerKM = fuelUse;
            Mileage = 0;
        }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double FuelPerKM { get; set; }
        public double  Mileage { get; set; }

        public void Drive(double kilometersDriven)
        {
            double fuelNeeded = FuelPerKM * kilometersDriven;
            if (fuelNeeded >Fuel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                Fuel -= fuelNeeded;
                Mileage += kilometersDriven;
            }
        }

    }

}
