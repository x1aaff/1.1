using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example_621_String
{
    class Program
    {
        static void Main(string[] args)
        {
            static void WriteDown(string id)
            {

                string output = string.Empty;
                Console.WriteLine("Новая запись:");

                output += id + "#";
                output += DateTime.Now.ToString("dd.MM.yyyy HH.mm") + "#";
                Console.Write("Ф. И. О.: ");
                output += Console.ReadLine() + "#";
                Console.Write("Дата рождения (дд.мм.гггг): ");
                DateTime birth = DateTime.Parse(Console.ReadLine());
                TimeSpan age = DateTime.Now - birth;
                output += (int) age.TotalDays / 365 + "#";
                Console.Write("Рост: ");
                output += Console.ReadLine() + "#";
                output += birth.ToShortDateString() + "#";
                Console.Write("Место рождения: ");
                output += Console.ReadLine() + "\n";


                File.AppendAllText("Сотрудники.csv", output);
            }

            static string ReadUp()
            {
                using (StreamReader sr = new StreamReader("Сотрудники.csv"))
                {
                    string line, output = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('#');
                        foreach (var el in data)
                        {
                            output += el + "\t";
                        }
                        output += "\n";
                    }
                    return output;
                }
            }

            static string GenerateId()
            {
                string import = ReadUp();

                //определение id
                string id;

                if (import.Split('\n').Length - 1 == 0)
                {
                    id = "1";
                }
                else
                {
                    //Console.WriteLine(import.Split('\n')[import.Split('\n').Length-2].Split('\t')[0]);
                    id = (int.Parse(import.Split('\n')[import.Split('\n').Length-2].Split('\t')[0]) + 1).ToString();
                }

                return id;
            }

            if (!File.Exists("Сотрудники.csv"))
            {
                File.Create("Сотрудники.csv");
                Console.WriteLine("Файл создан, перезапустите книжку");
            }
            else
            {
                Console.WriteLine("Введите 1 для чтения\nВведите 2 для новой записи\n");
                string choice = Console.ReadLine();

                if (choice == "1") //чтение
                {
                        Console.WriteLine(ReadUp());
                }
                else if (choice == "2") //запись
                {
                    string id = GenerateId();
                    WriteDown(id);
                }
                else
                {
                    Console.WriteLine("ошибка");
                }
            }
        }
    }
}
