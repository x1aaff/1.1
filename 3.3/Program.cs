using System;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool flagIsNotPrimeNumber = false;
            int i = 1;
            while ((!flagIsNotPrimeNumber) && (i < number - 1))
            {
                i++;
                if (number % i == 0) flagIsNotPrimeNumber = true;
            }
            Console.WriteLine($"This is {!flagIsNotPrimeNumber} that your number is prime number!");
        }

    }
}
