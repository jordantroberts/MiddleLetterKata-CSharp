using System;

namespace GettingMiddleLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            MiddleLetter middleletter = new MiddleLetter();

            while (true)
            {
                Console.WriteLine("Please enter a word");
                string input = Console.ReadLine();
                if(input != "quit")
                {
                    Console.WriteLine(middleletter.GetMiddle(input));

                }
                else
                {
                    break;
                }
            }
        }
    }

    public class MiddleLetter
    {
        public string GetMiddle(string word)
        {
            int half = word.Length;

            if (word.Length % 2 == 0)
            {
                //.Substring retrieves a substring from this instance.
                // The substring starts at a specified character position and has a specified length.
                return word.Substring(half / 2 - 1, 2);
            }
            else
            {
                return word.Substring(half / 2, 1);
            }
        }
    }
}

