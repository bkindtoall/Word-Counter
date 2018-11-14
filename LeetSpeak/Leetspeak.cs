using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetSpeakMain
{
    public class LeetSpeakClass
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
            Console.WriteLine("Please type a sentence to convert to L337 Sp3ak");
            string userInput = Console.ReadLine();
            char[] userArray = userInput.ToCharArray();
            for(int i=0;i < userArray.Length;i++)
            {
              if ((userArray[i]=='S' || userArray[i]=='s') && (userArray[i-1]==' ' || i==0))
              {
  
              } else
              {
                userArray[i] = CheckLetter(userArray[i]);
              }
            }
            string result = string.Join("", userArray);
            Console.WriteLine("Your translated L337 Sp3ak:");
            Console.WriteLine(result);
        }
    }
}
