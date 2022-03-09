using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // first part
            string fullName = "Name", 
                   email = "name2000@a.ru";

            int age = 67;

            double codingScore = 13.2, 
                   mathScore = 14, 
                   physicsScore = 20;

            Console.WriteLine("name:\t{0}\nemail:\t{1}\nage:\t{2}\nCoding Score:\t{3}\nMaths Score:\t{4}\nPhysics Score:\t{5}\n",
                fullName, email, age, codingScore, mathScore, physicsScore);

            Console.ReadKey();
            // second part

            double totalScore = codingScore + mathScore + physicsScore;
            double averageScore = totalScore / 3.0;

            Console.WriteLine($"\nTotal Score:\t{totalScore}\nAverage Score:\t{averageScore:#.##}");
        }
    }
}
