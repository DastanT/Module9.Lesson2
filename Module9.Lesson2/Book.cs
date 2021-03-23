using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Lesson2
{
    public class Book:Publication
    {
        public string BookName { get; set; }
        public DateTime Year { get; set; }  
        public virtual void PrintInfo()
        {
            Console.WriteLine("Автор: "+Autor);
            Console.WriteLine("Название книги: "+BookName);
            Console.WriteLine("Год: "+Year.ToString("dd/MM/yyyy"));
            Console.WriteLine("Название издания: " + NamePublication);
            Console.WriteLine("Дата основания издания: " + Date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Город: "+ City);
            Console.WriteLine("");
        }



    }
    

}
