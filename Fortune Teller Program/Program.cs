using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("If you want to know your future please enter your first name");

            string name = Console.ReadLine();

            Console.WriteLine(" Thank you " + name + "." + " Now please enter your last name");

            string lastName = Console.ReadLine();

            Console.WriteLine("Now please enter your age ");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Now that I know your age tell me what month you were born using a number ");

            int birthMonth = int.Parse(Console.ReadLine());





            string clrSpectrum = "Red, Orange, Yellow, Green, Blue, Indigo, Violet";

            Console.WriteLine("Now can you tell me you favorite ROYGBIV color, If you dont know what colors are in ROYGBIV enter help ");

            string yourClr = Console.ReadLine();

            if (yourClr == "help")
            {
                Console.WriteLine(clrSpectrum);
                yourClr = Console.ReadLine();
            }

            Console.WriteLine(" Now enter how many siblings you have");

            int siblings = int.Parse(Console.ReadLine());


            Console.WriteLine(name + " " + lastName);







            if (age % 2 == 0)
            {
                Console.WriteLine("You will retire in 10 years");
            }
            else
            {
                Console.WriteLine("You will retire in 15 years");
            }


            if (birthMonth == 1 - 4)
            {
                Console.WriteLine("You will retire with $25k ");
            }
            if (birthMonth == 5 - 8)
            {
                Console.WriteLine("You will retire with $50k ");
            }
            if (birthMonth == 9 - 12)
            {
                Console.WriteLine("You will retire with $100k ");
            }
            else
            {
                Console.WriteLine("You will retire with $0 in the bank");
            }


            if (siblings == 0)
            {
                Console.WriteLine("You will retire with a vacation home  in paris");
            }
            if (siblings == 1)
            {
                Console.WriteLine("You will retire with a vacation home in the Bahamas");
            }
            if (siblings == 2)
            {
                Console.WriteLine("You will retire with a vacation home in Belize");
            }
            if (siblings == 3)
            {
                Console.WriteLine("You will retire with a vacation home in Costa Rica");
            }
            if (siblings > 3)
            {
                Console.WriteLine("You will retire with a vacation home in Florida.");
            }
            else if (siblings < 0)
            {
                Console.WriteLine("You will retire in Prison Sucka!");
            }



            switch (yourClr)
            {
                case "red":
                    Console.WriteLine("You will retire with a jet plane");
                    break;
                case "orange":
                    Console.WriteLine("You will retire with a boat");
                    break;
                case "yellow":
                    Console.WriteLine("You will retire with a Benz");
                    break;
                case "green":
                    Console.WriteLine("you will retire with a BMW");
                    break;
                case "blue":
                    Console.WriteLine("you will retire with a Hummer");
                    break;
                case "indigo":
                    Console.WriteLine("You will retire with a Jeep");
                    break;
                case "violet":
                    Console.WriteLine("You will retire with a  Ford fiesta");
                    break;
            }









































        }
    }
}
