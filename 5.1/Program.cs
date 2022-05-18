using System;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            static string[] SplitText(string text)
            {
                return text.Split(' ');
            }

            static void PrintWords (string[] words)
            {
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
            }

            PrintWords(SplitText(Console.ReadLine()));
        }
    }
}
