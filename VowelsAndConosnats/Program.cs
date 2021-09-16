using System;

namespace VowelsAndConosnats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programm küsib kastajal sissestada tähte
            //Programm kontrollib, kas sisestatyd täht on täishäälik või kaashäälik
            //kui sisestatud täht on täishäälik siis programm kuvab "Täishäälik."
            //kui täht on kaashäälik siis kuvab "Kaashäälik"
            //Kasutame switch'i

            // "mingi sõne " - string
            // "a" - char

            Console.WriteLine("Enter a letter:");
            char UserCharacter = Convert.ToChar(Console.ReadLine().ToLower());

            switch (UserCharacter)
            {
                case 'a':
                    Console.WriteLine("Vowel.");
                    break;
                case 'e':
                    Console.WriteLine("Vowel.");
                    break;
                case 'i':
                    Console.WriteLine("Vowel.");
                    break;
                case 'o':
                    Console.WriteLine("Vowel.");
                    break;
                case 'u':
                    Console.WriteLine("Vowel.");
                    break;
                default:
                    Console.WriteLine("Cososnat.");
                    break;
            }
            Console.WriteLine("Have a nice day!");
            Console.ReadLine();

        }
    }
}
