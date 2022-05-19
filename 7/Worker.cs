using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    struct Worker
    {
        /*    ID
        Дата и время добавления записи
        Ф.И.О.
        Возраст
        Рост
        Дата рождения
        Место рождения*/
        
        DateTime creationTime;
        public DateTime GetCreationTime()
        {
            return this.creationTime;
        }

        public Worker(int id, DateTime creationTime, string fullName, uint age, uint height, DateTime birth, string hometown)
        {
            Id = id;
            this.creationTime = creationTime;
            FullName = fullName;
            Age = age;
            Height = height;
            Birth = birth;
            Hometown = hometown;
        }
        public int Id { get; set; }
        string FullName { get; set; }
        uint Age { get; set; }
        uint Height { get; set; }
        DateTime Birth { get; set; }
        string Hometown { get; set; }

        public void PrintWorker()
        {
            Console.WriteLine($"{this.Id}\t{this.creationTime}\t{this.FullName}\t{this.Age}\t{this.Height}\t{this.Birth}\t{this.Hometown}");
        }
        public string UploadWorker()
        {
            string output = string.Empty;
            output += this.Id + "#";
            output += this.creationTime + "#";
            output += this.FullName + "#";
            output += this.Age + "#";
            output += this.Height + "#";
            output += this.Birth + "#";
            output += this.Hometown;
            return output;
        }
        object Rewrite(object entity, object oldEntity)
        {
            if (!(entity.ToString() == string.Empty))
            {
                return entity;
            }
            else
            {
                return oldEntity;
            }
        }
        public void EditWorker()
        {
            Console.WriteLine("..Режим редактирования..");
            Console.WriteLine("(введите новое значение или оставьте пустым чтобы оставить как было)\n");

            Console.Write($"Полное имя - {FullName}: ");
            FullName = Rewrite(Console.ReadLine(), FullName).ToString();

            Console.Write($"Дата рождения - {Birth}: ");
            Birth = Convert.ToDateTime(Rewrite(Console.ReadLine(), Birth).ToString());
            TimeSpan span = DateTime.Now - Birth;
            Age = Convert.ToUInt32(span.TotalDays / 365);

            Console.Write($"Рост - {Height}: ");
            Height = Convert.ToUInt32(Rewrite(Console.ReadLine(), Height).ToString());

            Console.Write($"Родной город - {Hometown}: ");
            Hometown = Rewrite(Console.ReadLine(), Hometown).ToString();
        }
    }
}
