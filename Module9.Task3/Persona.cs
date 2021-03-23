using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task3
{
    abstract public class Persona
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Faculty { get; set; }
        public int Age { get; set; }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Дата рождения: " + DateOfBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine("Факультет: " + Faculty);
        }        
    }
}
