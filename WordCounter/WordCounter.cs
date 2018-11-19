using System;
// using System.Collections.Generic;
// using System.Linq;

namespace WordCounterMain
{
public class WordCounterClass
    {
        public static void Main()
        {
            Console.WriteLine("Please type a word that might appear in your sentence");
            string userInputWord = Console.ReadLine();
            Console.WriteLine("Please type a sentence to compare to your word");
            string userInputSentence = Console.ReadLine();
			

            WordCounter countedResults = new WordCounter();
            Console.WriteLine("Your duplicate word count is: {0}", countedResults.Counter(userInputWord, userInputSentence));

        }
    }
	
	public class WordCounter
	{
		int wordMatches = 0;
		public string Counter(string userInputWord, string userInputSentence){
					string[] wordList = userInputSentence.Split(' ');
			
					
					foreach (string word in wordList) {
						
						 if (word.ToLower() == userInputWord.ToLower())
							 wordMatches ++;
					}
			return wordMatches.ToString();
		}
	}	
}
