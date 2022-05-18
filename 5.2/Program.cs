using System;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            static string[] SplitReversedText(string text)
            {
                string[] newText = text.Split(' ');
                Array.Reverse(newText);
                return newText;
            }

            static string ReverseWords (string phrase)
            {
                string invertedText = "";
                foreach (string word in SplitReversedText(phrase))
                {
                    invertedText += word + " ";
                }
                return invertedText.Trim();
            }

            Console.WriteLine(ReverseWords(Console.ReadLine()));
        }
    }
}
