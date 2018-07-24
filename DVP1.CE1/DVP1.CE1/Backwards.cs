using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jordon van Leenen
//1807
//Project & Portfolio
//In this coding challenge I am creating a class where I reverse the order of a sentence and reverse the words themselves.
namespace DVP1.CE1
{
    class Backwards
    {
        public static void GetBackWards()
        {
            Console.WriteLine("Enter a sentence containing at least 6 words");
            string sentenceString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(sentenceString))
            {
                Console.WriteLine("You did not enter anything");
                Console.ReadLine();
            }
            Console.WriteLine($"Thank you, you entered the sentence \r\n {sentenceString}");
            Console.ReadLine();

            MirrorString(sentenceString);
            Console.ReadLine();
        }

        public static string MirrorString (string sentence)
        {
            char[] sentenceArr = sentence.ToCharArray();
            Array.Reverse(sentenceArr);
            return new string(sentenceArr);
        }
    }
}
