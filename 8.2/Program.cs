using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            static Dictionary<string, string> FillBook()
            {
                Console.WriteLine("Заполните книгу в формате: Номер ФИО");
                Dictionary<string, string> phoneBook = new Dictionary<string, string>();
                string input = string.Empty;
                while ((input = Console.ReadLine()) != string.Empty)
                {
                    phoneBook.Add(input.Split(' ')[0], input.Split(' ')[1]);
                }
                Console.WriteLine("Все записано!");
                return phoneBook;
            }

            static void FindContact(Dictionary<string, string> phoneBook)
            {
                Console.WriteLine("Поиск по номеру: ");
                if (phoneBook.TryGetValue(Console.ReadLine(), out string name))
                {
                    Console.WriteLine(name);
                }
                else
                {
                    Console.WriteLine("владельца по такому номеру телефона не зарегистрировано");
                }
            }

            phoneBook = FillBook();
            FindContact(phoneBook);
        }
    }
}
