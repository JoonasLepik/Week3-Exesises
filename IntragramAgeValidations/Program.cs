using System;

namespace IntragramAgeValidations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year did you born in?");
            int Year = Convert.ToInt32(Console.ReadLine());
            int age = 2021 - Year;
            if (age < 13)
            {
                Console.WriteLine("You can not use intagramm!");
            }
            else
            {
                Console.WriteLine("You can use intsagramm.");
            }
            Console.WriteLine("Have a good day!");
            Console.ReadLine();

        }
    }
}
