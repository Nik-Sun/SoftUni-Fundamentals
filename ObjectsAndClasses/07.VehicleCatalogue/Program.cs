using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Car> cars  = new List<Car>();
            List<Truck> trucks  = new List<Truck>();
            while (input != "end")
            {
                string[] info = input.Split("/");
                string vehicleType = info[0];
                if (vehicleType=="Car")
                {
                    Car currentCar = new Car();
                    currentCar.Brand = info[1];
                    currentCar.Model = info[2];
                    currentCar.HorsePower = int.Parse(info[3]);

                    cars.Add(currentCar);
                }
                else
                {
                    Truck currentTruck = new Truck();
                    currentTruck.Brand = info[1];
                    currentTruck.Model = info[2];
                    currentTruck.Weight = int.Parse(info[3]);

                    trucks.Add(currentTruck);
                }


                input = Console.ReadLine();
            }
            VehiclesCatalogue vehicles = new VehiclesCatalogue();
            vehicles.CarsList = cars;
            vehicles.TruckList = trucks;
            vehicles.PrintCatalouge();
            
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck 
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class VehiclesCatalogue
    {
        public List<Car> CarsList { get; set; }
        public List<Truck> TruckList { get; set; }

        public void PrintCatalouge()
        {
            if (CarsList.Count>0)
            {
                List<Car> orderedList = CarsList.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in orderedList)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (TruckList.Count>0)
            {
                List<Truck> orderedList = TruckList.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach  (Truck truck in orderedList)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
        }
        
    }


}
