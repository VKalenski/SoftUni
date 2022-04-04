using System;

namespace _07._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double distance = distanceInMeters * secondsPerMeter;
            double delay = Math.Floor((distanceInMeters / 15)) * 12.5;

            double finalTime = distance + delay;

            if (finalTime < currentRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:F2} seconds.");
            }

            else if (finalTime >= currentRecord)
            {
                Console.WriteLine($"No, he failed! He was {finalTime - currentRecord:F2} seconds slower.");
            }
        }
    }
}
