using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We will enter the input which is text (Book).
            string[] input = Console.ReadLine()
                 .Split(new string[] { " ", ", ", ". ", "- ",
                     "!", "?", "„", "“" }, StringSplitOptions.RemoveEmptyEntries);

            GetCountOfWords(input);
            GetShortestWord(input);
            GetLongestWord(input);
            GetAvarageLenghtOfWords(input);
          
           
        }

        private static void GetCountOfWords(string[] input)
        {
            int number = input.Length;
            Console.WriteLine("There are total of " + number + " words!");
        }

        private static void GetShortestWord(string[] input)
        {
            int numberOfChars = int.MaxValue;
            string shortestWord = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length < numberOfChars)
                {
                    numberOfChars = input[i].Length;
                    shortestWord = input[i];
                }
            }

            Console.WriteLine("The shortest word is - " + shortestWord);
        }

        private static void GetLongestWord(string[] input)
        {
            int numberOfChars = int.MinValue;
            string longestWord = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > numberOfChars)
                {
                    numberOfChars = input[i].Length;
                    longestWord = input[i];
                }
            }

            Console.WriteLine("The longest word is - " + longestWord);
        }

        private static void GetAvarageLenghtOfWords(string[] input)
        {
            double averageLength = input.Average(w => w.Length);
            Console.WriteLine("The average length of all words is - " + averageLength);
        }
    }
}
