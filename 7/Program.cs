using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Menu(Data list)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Посмотреть все записи data.csv");
                Console.WriteLine("2. Посмотреть запись по ID");
                Console.WriteLine("3. Посмотреть записи в диапазоне дат");
                Console.WriteLine("4. Посмотреть записи отсортированные по дате");
                Console.WriteLine("5. Создать новую запись");
                Console.WriteLine("6. Редактировать запись по ID");
                Console.WriteLine("7. Удалить запись по ID");
                Console.Write("Ваш выбор: ");

                char input = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                switch (input)
                {
                    case ('1'):
                        list.Print();
                        break;
                    case ('2'):
                        Console.Write("Введите ID: ");
                        list.Print(int.Parse(Console.ReadLine()));
                        break;
                    case ('3'):
                        Console.Write("С какой даты: ");
                        string date1 = Console.ReadLine();
                        Console.Write("По какую дату: ");
                        string date2 = Console.ReadLine();
                        list.Print(date1, date2);
                        break;
                    case ('4'):
                        Console.Write("Введите 1 для соритровки по убыванию, остальное - по возрастанию: ");
                        list.Print(Console.ReadLine());
                        break;
                    case ('5'):
                        list.AddNew();
                        list.UpLoad();
                        break;
                    case ('6'):
                        Console.Write("Введите ID: ");
                        list.Edit(int.Parse(Console.ReadLine()));
                        list.UpLoad();
                        break;
                    case ('7'):
                        Console.Write("Введите ID: ");
                        list.Remove(int.Parse(Console.ReadLine()));
                        list.UpLoad();
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет)");
                        break;
                }
            }

            string path = @"data.csv";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            Data list = new Data(path);

            list.Load();
            Menu(list);
        }
    }
}
