﻿using System;
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

            Console.WriteLine("Thank you " + name + "." + " Now please enter your last name");

            string lastName = Console.ReadLine();



            Console.WriteLine("Now please enter your age ");

            int age = int.Parse(Console.ReadLine());
            string ageResult = "";
            if (age % 2 == 0)
            {
                ageResult = "10 years";
            }
            else
            {
                ageResult = "20 years";
            }

            Console.WriteLine("Now that I know your age tell me what month you were born using a number ");

            int birthMonth = int.Parse(Console.ReadLine());
            int money;

            if (birthMonth == 1 - 4)
            {
                money = 25;
            }
            if (birthMonth == 5 - 8)
            {
                money = 50;
            }
            if (birthMonth == 9 - 12)
            {
                money = 100;
            }
            else
            {
                money = 10;
            }





            Console.WriteLine("Now can you tell me you favorite ROYGBIV color, If you dont know what colors are in ROYGBIV enter help ");

            string yourClr = Console.ReadLine();
            yourClr = yourClr.ToLower();


            string vehicle = "";




            if (yourClr == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                yourClr = Console.ReadLine();
            }



            switch (yourClr.ToLower())
            {
                case "red":
                    vehicle = ("red Ferrari");
                    break;
                case "orange":
                    vehicle = (" Audi");
                    break;
                case "yellow":
                    vehicle = ("Benz");
                    break;
                case "green":
                    vehicle = ("BMW");
                    break;
                case "blue":
                    vehicle = ("Hummer");
                    break;
                case "indigo":
                    vehicle = ("Jeep");
                    break;
                case "violet":
                    vehicle = ("Ford fiesta");
                    break;
            }


            Console.WriteLine("How many siblings you have");

            int siblings = int.Parse(Console.ReadLine());


            string vacHome = "";


            if (siblings == 0)
            {
                vacHome = ("Paris");
            }
            if (siblings == 1)
            {
                vacHome = ("Bahamas");
            }
            if (siblings == 2)
            {
                vacHome = ("Belize");
            }
            if (siblings == 3)
            {
                vacHome = ("Costa Rica");
            }
            if (siblings > 3)
            {
                vacHome = ("Florida");
            }
            else if (siblings < 0)
            {
                vacHome = ("Prison");
            }



            Console.WriteLine(name + " " + lastName + " you will retire in " + ageResult + " with $" + money + "K" + " in the bank " + " you will have a vacation home in " + vacHome + " and drive a " + vehicle);


















































        }
    }
}
