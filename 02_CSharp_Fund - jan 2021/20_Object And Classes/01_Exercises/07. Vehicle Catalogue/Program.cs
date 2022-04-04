using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            while (true)
            {
                string[] input = Console.ReadLine().Split("/");
                if (input[0] == "end")
                {
                    break;
                }

                string typeOfVehicale = input[0];
                string branOfVehicale = input[1];
                string modelOfVehicale = input[2];
                int horsePowerOfVehicale = int.Parse(input[3]);

                if (typeOfVehicale == "Car")
                {
                    catalogue.Cars.Add(new Car()
                    {
                        Brand = branOfVehicale,
                        Model = modelOfVehicale,
                        HorsePower = horsePowerOfVehicale
                    });
                }
                else if (typeOfVehicale == "Truck")
                {
                    catalogue.Trucks.Add(new Truck()
                    {
                        Brand = branOfVehicale,
                        Model = modelOfVehicale,
                        Weight = horsePowerOfVehicale
                    });
                }
            }

            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car carList in catalogue.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HorsePower}hp");
                }
            }

            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truckList in catalogue.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truckList.Brand}: {truckList.Model} - {truckList.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalogue
    {
        public List<Car> Cars { get; }
        public List<Truck> Trucks { get; }

        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}