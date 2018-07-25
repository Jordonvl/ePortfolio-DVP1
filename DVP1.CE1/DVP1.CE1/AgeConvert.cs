using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class AgeConvert
    {
        public static void GetAgeConvert()
        { 
            Console.WriteLine("What is your name?");
            string nameString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nameString))
            {
                Console.WriteLine("You did not write anything");
                Console.ReadLine();
            }

            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            int ageInt;
            while (!int.TryParse(ageString, out ageInt))
            {
                Console.WriteLine()
            }
        }
    }
}
