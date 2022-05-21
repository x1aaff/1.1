using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            static List<int> FillList(int n)
            {
                Random random = new Random();
                List<int> numbers = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    numbers.Add(random.Next(0, 101));
                }
                return numbers;
            }

            static void RemoveBetween(List<int> numbers, int a, int b)
            {
                numbers.RemoveAll(x => x > a && x < b);
            }
            
            static void PrintList(List<int> numbers)
            {
                foreach (var el in numbers)
                {
                    Console.Write(el + " ");
                }
                Console.Write("\n");
            }

            List<int> numbers = FillList(100);
            PrintList(numbers);
            RemoveBetween(numbers, 25, 50);
            PrintList(numbers);
        }
    }
}
