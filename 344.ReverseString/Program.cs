using System;
using System.Linq;

namespace _344.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the values as you wish. Rule: Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
            string word = "wellington";

            //Easy way using linq (broke the rule above but is just another way to solve)
            string[] wordArray = { "w", "e", "l", "l", "i", "n", "g", "t", "o", "n" };
            string[] reverseWordWithLinq = EasyWayReverseWord(wordArray);

            //Without linq
            char[] reverseWord = ReverseWord(word.ToCharArray());

            Console.WriteLine("Array Reversed: " + "[{0}]", string.Join(", ", reverseWord));
            Console.ReadKey();
        }

        static string[] EasyWayReverseWord(string[] word)
        {
            return word.Reverse().ToArray();
        }

        static char[] ReverseWord(char[] word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                char aux = word[i];

                //Reverse letter position
                word[i] = word[word.Length - 1 - i];
                word[word.Length - 1 - i] = aux;
            }

            return word;            
        }
    }
}
