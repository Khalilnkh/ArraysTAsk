using System;
using System.Linq;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    String sentence = "Beauty lies in the eyes of beholder";
            //    int wordCount = 0;

            //    for (int i = 0; i < sentence.Length - 1; i++)
            //    {

            //        if (sentence[i] == ' ' && Char.IsLetter(sentence[i + 1]) && (i > 0))
            //        {
            //            wordCount++;
            //        }
            //    }

            //    wordCount++;

            //    Console.WriteLine("Total number of words in the given senetence: " + wordCount);


            //string word = "Xeyrulla";
            //int vowelcount=0;
            //int conscount = 0;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
            //    {
            //        vowelcount++;
            //    }
            //    else if ((word[i] >= 'a' && word[i] <= 'z') || (word[i] >= 'A' && word[i] <= 'Z'))
            //    {
            //        conscount++;
            //    }


            //}
            //Console.Write($"The total number of vowel in the string is {vowelcount}\n");
            //Console.Write($"The total number of consonant in the string is {conscount}");

            Console.WriteLine("Said string in uppercase: " + test("abcd"));
        }
        public static string test(string text)
        {
            return new string(text.ToCharArray().Reverse().ToArray()).ToUpper();
        }
    }
    
}
