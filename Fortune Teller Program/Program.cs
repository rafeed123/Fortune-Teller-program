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

            Console.WriteLine("Now " + name + " " + lastName + " can you tell me how old you are");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Now that I know your age tell me what month you were born using a # ");

            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("So you were born in the monnth of " + birthMonth + " very nice");

            string clrSpectrum = "Red, Orang, Yellow, Green, Blue, Indigo, Violet";

            Console.WriteLine("Now can you tell me you favorite ROYGBIV color ");
            Console.WriteLine("If you dont know what colors are in ROYGBIV enter help");

            string help = Console.ReadLine();

            Console.WriteLine(clrSpectrum);



            string favColor = Console.ReadLine();
            Console.WriteLine("your favorite coloer is " + favColor + "Now how many siblings do you have");

            int siblings = int.Parse(Console.ReadLine());

            Console.WriteLine("So you have " + siblings + ", Thanks for answering my questions");


            Console.WriteLine("Are You ready for your fortune");


























        }
    }
}
