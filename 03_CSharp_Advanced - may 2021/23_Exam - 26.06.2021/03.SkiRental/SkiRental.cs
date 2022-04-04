using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => data.Count; }

        public void Add(Ski ski)
        {
            if (Count < Capacity)
            {
                data.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            foreach (var item in data)
            {
                if (item.Manufacturer == manufacturer && item.Model == model)
                {
                    data.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public Ski GetNewestSki() => data.OrderByDescending(x => x.Year).FirstOrDefault();
        public Ski GetSki(string manufacturer, string model) => data.Where(x => x.Manufacturer == manufacturer && x.Model == model).FirstOrDefault();
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
