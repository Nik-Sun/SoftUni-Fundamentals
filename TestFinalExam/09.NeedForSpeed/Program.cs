using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> garage = new List<Car>();
            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine().Split("|");
                Car currentCar = new Car();
                currentCar.Model = carData[0];
                currentCar.Mileage = int.Parse(carData[1]);
                currentCar.Fuel = int.Parse(carData[2]);
                garage.Add(currentCar);
                
            }
            string input = Console.ReadLine();
            while (input !="Stop")
            {
                string[] commandData = input.Split(" : ");
                string command = commandData[0];
                string carModel = commandData[1];
                int carIndex = garage.FindIndex(x=>x.Model==carModel);
                if (command == "Drive")
                {
                    int distanceDriven = int.Parse(commandData[2]);
                    int fuelNeeded = int.Parse(commandData[3]);
                    if (garage[carIndex].Fuel>=fuelNeeded)
                    {
                        garage[carIndex].Fuel -= fuelNeeded;
                        garage[carIndex].Mileage += distanceDriven;
                        Console.WriteLine($"{garage[carIndex].Model} driven for {distanceDriven} kilometers. {fuelNeeded} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    if (garage[carIndex].Mileage>=100000)
                    {
                        Console.WriteLine($"Time to sell the {garage[carIndex].Model}!");
                        garage.Remove(garage[carIndex]);
                    }

                }
                else if (command == "Refuel")
                {
                    int refuel = int.Parse(commandData[2]);
                    int refuelAmount = 0;
                    garage[carIndex].Fuel += refuel;
                    if (garage[carIndex].Fuel>75)
                    {
                        refuelAmount = refuel - (garage[carIndex].Fuel-75);
                        garage[carIndex].Fuel = 75;
                    }
                    else
                    {
                        refuelAmount = refuel;
                    }
                    Console.WriteLine($"{garage[carIndex].Model} refueled with {refuelAmount} liters");

                }
                else if (command == "Revert")
                {
                    int revertedKM = int.Parse(commandData[2]);
                    garage[carIndex].Mileage -= revertedKM;
                    if (garage[carIndex].Mileage<10000)
                    {
                        garage[carIndex].Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{garage[carIndex].Model} mileage decreased by {revertedKM} kilometers");
                    }
                }


                input = Console.ReadLine();
            }
            garage = garage.OrderByDescending(x => x.Mileage).ThenBy(x => x.Model).ToList();
            foreach (Car car in garage)
            {
                Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }
    class Car 
    {
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
