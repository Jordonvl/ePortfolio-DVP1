using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jordon van Leenen
//1807
//Project & Portfolio
//In this coding challenge I am creating a class where you can convert your age into days, hours, minutes, and seconds.
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

            Console.WriteLine($"Thank you {nameString}, What is your age?");
            string ageString = Console.ReadLine();
            int ageInt;
            while (!int.TryParse(ageString, out ageInt))
            {
                Console.WriteLine("You did not enter a valid number, please try again");
                ageString = Console.ReadLine();
            }

            TheAgeConverter(ageInt);
            Console.WriteLine("Press return to get back to menu");
            Console.Read();

        }

        public static void TheAgeConverter(int age)
        {
            int days = age * 365;
            int hours = age * 8760;
            int minutes = age * 525600;
            int seconds = age * 31536000;

            Console.WriteLine($"{age} years, Fantastic! Next time someone asks, try asnwering with: \r\n {days} days -or- \r\n {hours} hours -or- \r\n {minutes} minutes -or- \r\n {seconds} seconds");

        }
    }
}