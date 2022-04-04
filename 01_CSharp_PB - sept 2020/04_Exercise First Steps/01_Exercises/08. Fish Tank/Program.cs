using System;

namespace _08._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Length = double.Parse(Console.ReadLine());
            double Width = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());
            double Percent = double.Parse(Console.ReadLine());

            double Volume = (Length * Width * Height);
            double Litre = Volume * 0.001;
            double PercentOf = Percent * 0.01;
            double Sum = Litre * (1 - PercentOf);

            Console.WriteLine(Sum);
        }
    }
}
