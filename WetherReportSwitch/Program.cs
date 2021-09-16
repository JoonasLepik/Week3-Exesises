using System;

namespace WetherReportSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many degrees are outside?");
            int Celsius = Convert.ToInt32(Console.ReadLine());
            switch (Celsius)
            {
                case var _ when Celsius < 0:
                    Console.WriteLine("Freezing cold!");
                    break;
                case var _ when Celsius >= 0 && Celsius < 10:
                    Console.WriteLine("It's very cold out so dress warmly.");
                    break;
                case var _ when Celsius >= 10 && Celsius < 20:
                    Console.WriteLine("It's bit chilly outside.");
                    break;
                case var _ when Celsius >= 20 && Celsius < 30:
                    Console.WriteLine("It's nice enougt to go on a walk.");
                    break;
                case var _ when Celsius >= 30 && Celsius < 35:
                    Console.WriteLine("It's hot outside.");
                    break;
                default:
                    Console.WriteLine("It's Boiling hot!");
                    break;
            }
            Console.WriteLine("Have a nice day!");
            Console.ReadLine();
        }
    }
}
