using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jordon van Leenen
//1807
//Project & Portfolio
//In this coding challenge I am creating a class that converts degrees in fahrenheit to celcius and celcius to fahrenheit.
namespace DVP1.CE1
{
    class TempConvert
    {
        public double farInput;
        public double celciusInput;


        public static void GetTempConvert()
        {
            Console.WriteLine("Welcome to the TempConvert program! Would you like to...");
            Console.WriteLine("1. Convert temperature from Fahrenheit to Celcius");
            Console.WriteLine("2. Convert temperature from Celcius to Fahrenheit");
            int inputInt;

            do
            {
                Console.WriteLine("Enter 1 or 2");
                string inputString = Console.ReadLine();
                int.TryParse(inputString, out inputInt);
            } while (inputInt != 1 && inputInt != 2);

            if (inputInt == 1)
            {
                Console.WriteLine("Ok, what temperature in Fahrenheit would you like to convert?");
                string inputFar = Console.ReadLine();
                double farInput;
                while (!double.TryParse(inputFar, out farInput))
                {
                    Console.WriteLine("Enter valid number");
                    inputFar = Console.ReadLine();
                }

                FahrenheitConvert(farInput);
                Console.WriteLine("Press return to go back to menu");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("Okay, what temperature in Celcius would you like to convert?");
                string inputCelc = Console.ReadLine();
                double celciusInput;
                while(!double.TryParse(inputCelc, out celciusInput))
                {
                    Console.WriteLine("You did not enter a valid number");
                    inputCelc = Console.ReadLine();
                }

                CelciusConvert(celciusInput);
                Console.WriteLine("Press return to go back to menu");
                Console.ReadLine();
            }
        }

        public static void FahrenheitConvert(double fahrenheitDuble)
        {
            double convertFahr = (((fahrenheitDuble - 32) * 5) / 9);
            Console.WriteLine($"Excellent! {fahrenheitDuble} Fahrenheit would be {convertFahr} Celcius");
        }

        public static void CelciusConvert(double celciusduble)
        {
            double convertCelc = (double)(celciusduble * 1.8) + 32;
            Console.WriteLine($"Excellent! {celciusduble} Celecius would be {convertCelc} Fahrenheit");
        }
    }
}
