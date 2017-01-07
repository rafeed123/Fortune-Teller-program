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

            Console.WriteLine("Now can you tell me you favorite ROYGBIV color");























        }
    }
}
