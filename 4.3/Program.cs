using System;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            Random r = new Random();
            int secretNumber = r.Next(max + 1);

            Console.WriteLine("Программа загадала число..");
            while (true)
            {
                Console.Write("Попробуйте отгадать: ");
                string guess = Console.ReadLine();

                if (int.TryParse(guess, out int guessNumber))
                {
                    if (guessNumber < secretNumber) Console.WriteLine("Ваше число меньше загаданного..");
                    else if (guessNumber > secretNumber) Console.WriteLine("Ваше число больше загаданного..");
                    else
                    {
                        Console.WriteLine("Вы угадали! Поздравляю)");
                        break;
                    }
                }
                else
                {
                    if (guess == "")
                    {
                        Console.WriteLine($"Игра окончена! Ответ: {secretNumber}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Это не число!");
                    }
                }


            }
        }
    }
}
