using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());
            string result = (number % 2 == 0) ? "Your number is even." : "Your number is odd";
            Console.WriteLine(result);
        }
    }
}
