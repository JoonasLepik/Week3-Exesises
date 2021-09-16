using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // tungimused sisseastumiseks;
            //miinium matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinium bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema eksami puktid ja otsutab, kas kasjutaja saab arstiks õpida.

            Console.WriteLine("Please inert your Math exam resoults:");
            int Math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please inert your Cemersty exam resoults");
            int Cemersty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please inert your Biology exam resoults");
            int Biology = Convert.ToInt32(Console.ReadLine());
            if (Math >= 85 && Cemersty >= 90 && Biology >= 95)
            {
                Console.WriteLine($"Your Exam resaults are {Math},{Cemersty},{Biology}. You can study as a doctor!");
            }
            else
            {
                Console.WriteLine($"Your Exam resaults are {Math},{Cemersty},{Biology}. You can't study as a doctor!");
            }
            Console.WriteLine("Have a nice day!");
            Console.ReadLine();


        }
    }
}
