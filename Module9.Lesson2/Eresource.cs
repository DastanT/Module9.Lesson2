using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Lesson2
{
    public class Eresource:Publication
    {
        public string Ename { get; set; }
        public string Linq { get; set; }
        public string Anotation { get; set; }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Автор: " + Autor);
            Console.WriteLine("Название статьи: " + Ename);
            Console.WriteLine("Ссылка: " + Linq);
            Console.WriteLine("Анотация: " + Anotation);
            Console.WriteLine("");
        }
    }
}
