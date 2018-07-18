using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jordon van Leenen
//1807
//Project & Portfolio
//In this coding challenge I am creating a welcoming menu where the user starts.
namespace DVP1.CE1
{
    class Menu
    {
        static int menuChoice = 0;


        public static void GetMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("Enter valid number choice for challenge you want to run");
                Console.WriteLine("");
                Console.WriteLine("[1] Swap Name");
                Console.WriteLine("[2] Backwards");
                Console.WriteLine("[3] Age Convert");
                Console.WriteLine("[4] Temp Convert");
                Console.WriteLine("[5] Big Blue Fish");
                Console.WriteLine("");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("");
                Console.WriteLine("Enter your slection");

                switch (GetValidation(menuChoice))
                {
                    case 1:
                        {


                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Not ready yet");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Not ready yet");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Not ready yet");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Not ready yet");
                        }
                        break;
                    case 0:
                        {
                            Console.WriteLine();
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        public static int GetValidation(int menuChoiceInt)
        {
            string menuInput = Console.ReadLine();

            while (!int.TryParse(menuInput, out menuChoiceInt) && menuChoiceInt < 0 && menuChoiceInt > 5)
            {
                Console.WriteLine("Please enter one of the choice in the menu");
            }
            return menuChoiceInt;
        }
    }
}
