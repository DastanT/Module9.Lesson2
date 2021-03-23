using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Lesson2
{
    abstract public class Publication
    {
        public string Autor { get; set; }
        public string NamePublication { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Название издания: " + NamePublication);
            Console.WriteLine("Дата основания издания: " + Date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Местоположение: "+ City);
        }

    }
}
