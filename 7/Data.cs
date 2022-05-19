using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _7
{
    struct Data
    {
        Worker[] workers;
        string path;
        public int index;

        public Data(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.workers = new Worker[2];
        }
        void Resize(bool flag)
        {
            if (flag)
            {
                Array.Resize(ref this.workers, this.workers.Length * 2);
            }
        }
        public void Add(Worker person)
        {
            this.Resize(index >= this.workers.Length);
            this.workers[index] = person;
            index++;
            //Console.WriteLine("index now " + index);
        }
        public void AddNew()
        {
            //stringng fullName uint height, DateTime birth, string hometown
            Console.WriteLine("..Режим создания..");
            Console.Write("Полное имя: ");
            string fullName = Console.ReadLine();
            Console.Write("Рост: ");
            uint height = uint.Parse(Console.ReadLine());
            Console.Write("Дата рождения: ");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());
            TimeSpan span = DateTime.Now - birth;
            uint age = Convert.ToUInt32(span.TotalDays / 365);
            Console.Write("Родной город: ");
            string hometown = Console.ReadLine();

            this.Resize(index >= this.workers.Length);
            this.Add(new Worker(index + 1, DateTime.Now, fullName, age, height, birth, hometown));
            //this.workers[index-1].PrintWorker();
        }
        public void Remove(int id)
        {
            for (int i = id - 1; i < index; i++)
            {
                this.workers[i].Id = this.workers[i].Id - 1;
            }
            Array.Clear(this.workers, id - 1, 1);
            //добавить сортировку
        }
        public void Edit(int id)
        {
            if (id <= index)
            {
                this.workers[id - 1].EditWorker();
            }
            else
            {
                Console.WriteLine("Столько записей нет!");
            }
        }
        public void Load()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split('#');
                    Add(new Worker(
                        int.Parse(args[0]), 
                        Convert.ToDateTime(args[1]), 
                        args[2], 
                        uint.Parse(args[3]), 
                        uint.Parse(args[4]), 
                        Convert.ToDateTime(args[5]), 
                        args[6])
                        );
                }
            }
        }
        public void UpLoad()
        {
            //Console.WriteLine("uploading index " + index);
            string upload = string.Empty;
            for (int i = 0; i < index; i++)
            {
                if (this.workers[i].Id != 0) //удаленных не пишем))
                {
                    this.workers[i].PrintWorker();
                    upload += this.workers[i].UploadWorker() + "\n";
                }
            }
            File.WriteAllText(this.path, upload);
        }
        public void Print()
        {
            for (int i = 0; i < index; i++)
            {
                if (this.workers[i].Id != 0)
                {
                    this.workers[i].PrintWorker();
                }
            } 
        }
        public void Print(int id)
        {
            this.workers[id-1].PrintWorker();
        }
        public void Print(string date1, string date2)
        {
            for (int i = 0; i < index; i++)
            {
                if ((this.workers[i].GetCreationTime() < Convert.ToDateTime(date2)) 
                    && (this.workers[i].GetCreationTime() > Convert.ToDateTime(date1))
                    && (this.workers[i].Id != 0))
                {
                    this.workers[i].PrintWorker();
                }
            }
        }
        public void Print(string descendingSort)
        {
            if (descendingSort == "1")
            {
                foreach (var el in this.workers.OrderByDescending(x => x.GetCreationTime()))
                {
                    if (el.Id != 0)
                    {
                        el.PrintWorker();
                    }
                }
            }
            else
            {
                foreach (var el in this.workers.OrderBy(x => x.GetCreationTime()))
                {
                    if (el.Id != 0)
                    {
                        el.PrintWorker();
                    }
                }
            }
        }
    }
}
