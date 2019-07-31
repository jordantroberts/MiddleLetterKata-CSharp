using System;

namespace MiddleLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word");
            MiddleLetter middleletter = new MiddleLetter();
            string input = Console.ReadLine();
            Console.WriteLine(middleletter.GetMiddle(input));
        }
    }

    public class MiddleLetter
    {
        public string GetMiddle(string word)
        {
            if (word.Length % 2 == 0)
            {
                return word.Substring(word.Length / 2 - 1, 2);
            }
            else
            {
                return word.Substring(word.Length / 2, 1);
            }
        }
    }
}

