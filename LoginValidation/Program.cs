using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //altgr + < == |
            //Shift + 6 == &
            // true || true --> true
            //programm küsib kasutajal sisestada kasutajatunnus ja paool
            //proglammkontrollib sisestatud andmed
            //Kui sisestatud kasjutaja on "admin"
            //sisestatud parool on "admin1234"
            //siis programm kuvab "Tere tulemast!"
            //else "vale kasutaja või parool. proovi uuesti"

            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string Pasword = Console.ReadLine();
            /* if (username == "admin" && Pasword == "admin1234")
             {
                Console.WriteLine("Hello Admin and Welcome!");
             }
             else
             {
                 Console.WriteLine("Wrong password or user, Please try again");
             }
            */
            if (username != "admin" || Pasword != "admin1234")
            {
                Console.WriteLine("Wrong password or user, Please try again.");
            }
            else
            {
                Console.WriteLine("Hello Admin and Welcome!");
            } 
            
        }
    }
}
