using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class Ski
    {
        public Ski(string manifact, string model, int year)
        {
            Manufacturer = manifact;
            Model = model;
            Year = year;
        }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Manufacturer} - {Model} - {Year}".TrimEnd();
        }
    }
}
