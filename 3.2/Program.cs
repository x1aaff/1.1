using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, username.");
            Console.Write("How many cards in your hand? ");
            int cardsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter card values. It either contains a number or: ");
            Console.WriteLine("J for Jack");
            Console.WriteLine("Q for Queen");
            Console.WriteLine("K for King");
            Console.WriteLine("T for Ace");

            int totalPoints = 0;
            
            //Console.WriteLine(int.TryParse(Console.ReadLine(), out int result));

            for (int i = 1; i <= cardsNumber; i++)
            {
                Console.Write($"Enter the value for card-{i}: ");
                string value = Console.ReadLine();
                if ((int.TryParse(value, out int result)) && (1 < result) && (result <= 10))
                {
                    totalPoints += result;
                }
                else
                {
                    switch (value)
                    {
                        case "J":
                            totalPoints += 10;
                            break;
                        case "Q":
                            totalPoints += 10;
                            break;
                        case "T":
                            totalPoints += 10;
                            break;
                        case "K":
                            totalPoints += 10;
                            break;
                        default:
                            Console.WriteLine("Incorrect value...");
                            i--;
                            break;
                    }
                }
            }

            Console.WriteLine($"You have {totalPoints} points in total!");
        }
    }
}
