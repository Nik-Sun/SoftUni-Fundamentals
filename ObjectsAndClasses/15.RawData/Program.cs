using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.RawData
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
                Engine engine = new Engine(int.Parse(carInfo[1]),int.Parse(carInfo[2]));
                Cargo cargo = new Cargo(carInfo[4],int.Parse(carInfo[3]));
                Car car = new Car(carInfo[0],cargo,engine);
                cars.Add(car);
            }
            string input = Console.ReadLine();
            if (input == "fragile")
            {
                cars = cars.Where(x=>x.Shipment.Type == "fragile").Where(x =>x.Shipment.Weight<1000).ToList();
            }
            else
            {
                cars = cars.Where(x => x.Shipment.Type == "flamable").Where(x => x.Motor.Power > 250).ToList();
            }
            foreach (Car item in cars)
            {
                Console.WriteLine(item.Model);
            }
        }
    }
    class Car 
    {
        public Car(string model,Cargo cargo,Engine engine)
        {
            Model = model;
            Shipment = cargo;
            Motor = engine;
        }
        public string Model { get; set; }
        public Cargo Shipment { get; set; }
        public Engine Motor { get; set; }
    }
    class Cargo 
    {
        public Cargo(string type,int weight)
        {
            Type = type;
            Weight = weight;
        }
        public string Type { get; set; }
        public int Weight { get; set; }
    }
    class Engine 
    {
        public Engine(int speed,int power)
        {
            Speed = speed;
            Power = power;
        }
        public int Speed { get; set; }
        public int Power { get; set; }
    }
}
