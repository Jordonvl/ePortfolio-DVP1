using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jordon van Leenen
//7/29/2018
//Project & Portfolio
//In this coding challenge I am creating a class that chooses the biggest fish according the color chosen.
namespace DVP1.CE1
{
    class BigBlueFish
    {

            public static void GetBigBlueFish()

            {
                float temp = 0;

                string[] colors = new string[12];

                colors[0] = colors[4] = colors[8] = "blue";

                colors[1] = colors[3] = colors[7] = "red";

                colors[2] = colors[5] = colors[9] = "yellow";

                colors[6] = colors[10] = colors[11] = "green";

                float[] lengths = new float[12];

                Random rando = new Random();

                

                Console.WriteLine("Welcome to BigBlueFish:");

                Console.WriteLine("Looking for the biggest fish matching a certain color.");

                Console.WriteLine();

                Console.WriteLine("Please select a color of fish...");

                Console.WriteLine();

                Console.WriteLine("[1] Red");

                Console.WriteLine("[2] Blue");

                Console.WriteLine("[3] Yellow");

                Console.WriteLine("[4] Green");

                Console.WriteLine();

                Console.Write("Selection: ");

                string userInput = Console.ReadLine();

                int inputFloat;

                do

                {

                    Console.WriteLine("Please enter either a number 1 through 4");

                    string inputString = Console.ReadLine();

                    int.TryParse(inputString, out inputFloat);

                } while (inputFloat < 1 || inputFloat > 4);

                if (inputFloat == 1)
                {

                    for (int i = 0; i < colors.Length; i++)

                    {

                    if (colors[i] == "red")
                    {
                        if (lengths[i] > temp)
                        {

                            temp = lengths[i];

                        }
                    }
                }

                    Console.WriteLine("The largest red fish is " + temp);

                    Console.ReadLine();

                }

                else if (inputFloat == 2)

                {



                }

                else if (inputFloat == 3)

                {



                }

                else if (inputFloat == 4)

                {



                }

            }
    }
}
