using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalH = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            int examHtransf = examH * 60;
            int examMinTransf = examHtransf + examMin;

            int arrivalHtransf = arrivalH * 60;
            int arrivalMinTransf = arrivalHtransf + arrivalMin;

            int difference = Math.Abs(arrivalMinTransf - examMinTransf);
            int diffH = difference / 60;
            int diffMin = difference % 60;

            string reslut1 = string.Empty; // Late or ...

            if (arrivalMinTransf > examMinTransf)
            {
                Console.WriteLine("Late");

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{diffH}:{diffMin:00} hours after the start");
                }
            }

            else if (arrivalMinTransf == examMinTransf) // On time
            {
                Console.WriteLine("On time");
            }

            else if (examMinTransf > arrivalMinTransf)
            {
                if (difference <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }

                else if (difference < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference} minutes before the start");
                }

                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffH}:{diffMin:00} hours before the start");
                }
            }
        }
    }
}
