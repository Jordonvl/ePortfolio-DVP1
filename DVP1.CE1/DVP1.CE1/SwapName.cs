using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jordon van Leenen
//1807
//Project & Portfolio
//In this coding challenge I am creating a class where the names the user inputs will be reversed.
namespace DVP1.CE1
{
    class SwapName
    {
        public static void GetSwapName()
        {
            Console.WriteLine("Please Enter your first name");
            string firstNameString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(firstNameString))
            {
                Console.WriteLine("You did not enter anything.");
                Console.ReadLine();
            }
            Console.WriteLine($"Thank you {firstNameString}, now I will need your last name");
            string lastNameString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(lastNameString))
            {
                Console.WriteLine("You did not enter anything.");
                Console.ReadLine();
            }
        }

        public static void NameSwap(string firstNameString, string lastNameString)
        {
            Console.WriteLine($"Excellent your name {firstNameString} {lastNameString} reversed would be {lastNameString}, {firstNameString}");
        }
    }
}
