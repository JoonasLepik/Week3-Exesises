using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program küsib kasutajal sisestada PIN koodi
            //programm võrdleb siststatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234 siis programm kuvab konsoolis "Tere tuelemast!"
            //kui sisestatatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti."
            Console.WriteLine("Please enter your PIN-code");
            int PIN = Convert.ToInt32(Console.ReadLine());

            if (PIN == 1234)
            {
                Console.WriteLine("Hello and welcome!");
            }
            else
            {
                Console.WriteLine("Wrong PIN, please try again.");
            }
            /*if (PIN == 1234) 
             {
              Console.WriteLine("Hello and welcome!");
             }
             else
             {
              Console.WriteLine("Wrong PIN, Please try again.");
             }*/

            if (PIN != 1234)
            {
                Console.WriteLine("Wrong PIN, Please try again.");
            }
            else
            {
                Console.WriteLine("Hello and welcome!");
            }
        }
    }
}
