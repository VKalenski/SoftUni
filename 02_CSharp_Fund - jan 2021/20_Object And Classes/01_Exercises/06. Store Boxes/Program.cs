using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Box
{
    class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }

    class Box
    {
        public string SerailNumber { get; set; }

        public string Item { get; set; }

        public int ItemQuantity { get; set; }

        public double Price { get; set; }

        public double TotalPrice { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] data = input.Split();
                string serialNumber = data[0];
                string item = data[1];
                int quantity = int.Parse(data[2]);
                double price = double.Parse(data[3]);
                double totalprice = quantity * price;

                Box box = new Box();
                box.SerailNumber = serialNumber;
                box.Item = item;
                box.ItemQuantity = quantity;
                box.Price = price;
                box.TotalPrice = quantity * price;
                boxes.Add(box);
                input = Console.ReadLine();
            }

            List<Box> filterPriceBox = boxes.OrderByDescending(p => p.TotalPrice).ToList();

            foreach (Box box in filterPriceBox)
            {
                Console.WriteLine($"{box.SerailNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }
        }
    }
}