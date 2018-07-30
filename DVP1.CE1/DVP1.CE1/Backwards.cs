using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jordon van Leenen
//7/22/2018
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

            sentenceString = WordCount(sentenceString);

            Console.WriteLine(MirrorString(sentenceString));
            Console.ReadLine();
        }

        public static string WordCount(string sentence)
        {
            do
            {
                int count = 0;
                string[] words = sentence.Split(' ');
                foreach (var word in words)
                {
                    count++;
                }
                if (count >= 6)
                {
                    Console.WriteLine("Correct amount of words");
                    break;
                }
                else if (count < 6)
                {
                    Console.WriteLine("Incorrect amount of words");
                }
                sentence = Console.ReadLine();
            } while (true);
            return sentence;
        }

        public static string MirrorString(string sentence)
        {
            char[] sentenceArr = sentence.ToCharArray();
            Array.Reverse(sentenceArr);
            return new string(sentenceArr);

        }
    }
}
