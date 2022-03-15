using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в будущей матрице: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в будущей матрице: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];
            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(101);
                    Console.Write($"{matrix[i,j], 3} ");
                    sum += matrix[i, j];
                }
                Console.Write("\n");
            }

            Console.WriteLine($"Сумма элементов матрицы: {sum}");
        }
    }
}
