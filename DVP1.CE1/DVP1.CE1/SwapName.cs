using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
