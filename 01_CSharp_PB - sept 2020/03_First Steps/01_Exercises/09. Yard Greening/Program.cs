using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SquareMeter = double.Parse(Console.ReadLine());

            double SumWithoutDiscount = SquareMeter * 7.61;
            double Discount = SumWithoutDiscount * 0.18;
            double Price = SumWithoutDiscount - Discount;

            Console.WriteLine("The final price is:" + Price + " " + "lv.");      
            Console.WriteLine("The discount is:" + Discount + " " + "lv.");          
        }
    }
}
