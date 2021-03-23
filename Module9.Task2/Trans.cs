using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task2
{
    abstract public class Trans
    {
        public string Type { get; set; }
        public string ModelName { get; set; }
        public int Id { get; set; }
        public int MaxSpeed { get; set; }

        public virtual double Carrying { get; set; }


        public virtual void Show()
        {
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("Модель: " + ModelName);
            Console.WriteLine("Номер: " + Id);
            Console.WriteLine("Скорость: " + MaxSpeed);
            Console.WriteLine("Грузоподъемность]tvyjcnm: " + Carrying);
        }
    }
}
