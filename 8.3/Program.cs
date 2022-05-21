using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            HashSet<int> set = new HashSet<int>();
            Console.WriteLine("Ввод оканчивается пустой строкой и Enter");
            while ((input = Console.ReadLine()) != string.Empty)
            {
                if (set.Contains(int.Parse(input)))
                {
                    Console.WriteLine("число уже вводилось ранее");
                }
                else
                {
                    set.Add(int.Parse(input));
                    Console.WriteLine("число успешно сохранено.");
                }
            }
        }
    }
}
