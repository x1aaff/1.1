using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] set = new int[length];

            for (int i = 0; i < length; i++)
            {
                set[i] = int.Parse(Console.ReadLine());
            }

            int min = set[0];

            for (int i = 0; i < length; i++)
            {
                if (set[i] < min) min = set[i];
            }

            Console.WriteLine($"Наименьшее число из последовательности: {min}");
        }
    }
}
