using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounterMain
{
    public class WordCounterClass
    {
        public static int CountStringOccurrences(string word1, string words2)
                {
                    // Loop through all instances of the string 'words2'.
                    int count = 0;
                    int i = 0;
                    while ((i = word1.IndexOf(words2, i)) != -1)
                    {
                        i += words2.Length;
                        count++;
                    }
                    return count;
                }

        public static void Main()
        {
            Console.WriteLine("Please type a that might appear in your sentence");
            string userInput1 = Console.ReadLine();
            string word1 = userInput1;
            Console.WriteLine("Please type a sentence to compare to your word");
            string userInput2 = Console.ReadLine();
            string[] words2 = userInput2.Split();
            // foreach (var word2 in words2)
            // {
            //     System.Console.WriteLine($"<{word1}>");

            //     System.Console.WriteLine($"<{word2}>");
            // }
            
            Console.WriteLine("Your duplicate word count is: {0}", count);
            Console.WriteLine("Your duplicate word count is: " + (WordCounterClass.CountStringOccurrences(word1, words2)));
        }
    }
}
