using System;
using System.Collections.Generic;
// using System.Linq;

namespace WordCounterMain
{
    public class WordCounterClass
    {
        public int CountStringOccurrences(string userInputWord, string userInputSentence)
                {
                    int count = 0;
                    string[] words2 = userInputSentence.Split();
                    for (int i = 0; i<words2.Length; i++)
                    {
                        if (userInputSentence == userInputWord)
                        {                        
                        count++;
                        }
                    }
                    return count;
                }

        public static void Main()
        {
            Console.WriteLine("Please type a word that might appear in your sentence");
            string userInputWord = Console.ReadLine();
            Console.WriteLine("Please type a sentence to compare to your word");
            string userInputSentence = Console.ReadLine();
            
            // foreach (var word2 in words2)
            // {
            //     System.Console.WriteLine($"<{word1}>");

            //     System.Console.WriteLine($"<{word2}>");

            // }
            
            WordCounterClass countedResults = new WordCounterClass();
            Console.WriteLine("Your duplicate word count is: {0}", countedResults.CountStringOccurrences(userInputWord, userInputSentence));

        }
    }
}
