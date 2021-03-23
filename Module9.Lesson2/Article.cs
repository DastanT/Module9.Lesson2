using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Lesson2
{
    public class Article : Publication
    {
        public string ArticleName { get; set; }
        public string MagazineName { get; set; }
        public int MagazineNumber { get; set; }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Автор: " + Autor);
            Console.WriteLine("Название статьи: " + ArticleName);
            Console.WriteLine("Название журнала: " + MagazineName);
            Console.WriteLine("Номер журнала: " + MagazineNumber);
            Console.WriteLine("Год публикации: " + Date.ToString("dd/MM/yyyy"));
            Console.WriteLine("");
        }
    }
}
