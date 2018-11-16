using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounterMain
{
    public class WordCounterClass
    {

        public static char CheckLetter(char letter)
        {
            if (letter == 'e' || letter == 'E')
            {
                return '3';
            }
            else if (letter == 'o' || letter == 'O')
            {
                return '0';
            }
            else if (letter == 'l' || letter == 'L')
            {
                return '1';
            }
            else if (letter == 't' || letter == 'T')
            {
                return '7';
            }
            else if (letter == 's' || letter == 'S')
            {
                return 'z';
            }
            else
            {
                return letter;
            }
        }
        public static void Main()
        {
            Console.WriteLine("Please type a that might appear in your sentence");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Please type a sentence to compare to your word");
            string userInput2 = Console.ReadLine();
            string[] words2 = userInput2.Split();
            foreach (var word2 in words2)
            {
                System.Console.WriteLine($"<{word2}>");
            }


            // for(int i=0;i < userArray.Length;i++)
            // {
            //   if ((userArray[i]=='S' || userArray[i]=='s') && (userArray[i-1]==' ' || i==0))
            //   {
  
            //   } else
            //   {
            //     userArray[i] = CheckLetter(userArray[i]);
            //   }
            // }
            // string result = string.Join("", userArray);
            // Console.WriteLine("Your translated L337 Sp3ak:");
            // Console.WriteLine(result);
        }
    }
}
