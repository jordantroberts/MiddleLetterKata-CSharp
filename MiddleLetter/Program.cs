using System;

namespace MiddleLetter
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

