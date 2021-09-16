using System;

namespace WetherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kui palju kraadi on õues.
            // kui õues on rohkem kui 35 kraadi, programm kuvab "boiling hot";
            //kui õues on 30-35 kraadi, programm kuvab "hot"
            //kui õues on 20-30 kraadi, programm kuvab "nice"
            //kui õues on 10-20 kraadi, programm kuvab "chilly"
            //kui õues on 0-10 kraadi, programm kuvab "cold"
            Console.WriteLine("How many degrease is the outside?");
            int Celsius = Convert.ToInt32(Console.ReadLine());
            if (Celsius >= 35)
            {
                Console.WriteLine("It's Boiling hot!");
            }
            else if (Celsius >= 30 && Celsius < 35)
            {
                Console.WriteLine("It's hot outside.");
            }
            else if (Celsius >= 20 && Celsius < 30)
            {
                Console.WriteLine("It's nice enougt to go on a walk.");
            }
            else if (Celsius >= 10 && Celsius < 20)
            {
                Console.WriteLine("It's bit chilly outside.");
            }
            else if (Celsius >= 0 && Celsius < 10)
            {
               Console.WriteLine("It's very cold out so dress warmly.");
            }
            else
            {
                Console.WriteLine("Frezing cold");
            }
            Console.WriteLine("Have a nice day!");
            Console.ReadLine();
        }
    }
}
