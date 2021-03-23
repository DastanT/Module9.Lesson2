using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task2
{
    public class Motorbike : Trans
    {
        public string CycleCar()
        {
            User user = new User();

            return user.UserChoice();
        }

        public void InitMotorbikes(int size, List<Motorbike> motorbikes, Random rnd)
        {
            
            
            for (int i = 0; i < size; i++)
            {
                Motorbike bike = new Motorbike();
                bike.Type = "Motorbike";
                bike.ModelName = string.Format("{0}", rnd.Next(1, 10));
                bike.Id = rnd.Next(1000, 9999);
                bike.MaxSpeed = rnd.Next(80, 350);
                bike.Carrying = rnd.Next(20, 100);
                motorbikes.Add(bike);
            }
        }

        public void Show(List<Motorbike> motorbikes)
        {
            User user = new User();
            foreach (Motorbike bike in motorbikes)
            {
                Console.WriteLine("Тип: " + bike.Type);
                Console.WriteLine("Модель: " + bike.ModelName);
                Console.WriteLine("Номер: " + bike.Id);
                Console.WriteLine("Скорость: " + bike.MaxSpeed);
                Console.Write("Наличие коляски (yes/no): ");
                switch (user.UserChoice())
                {
                    case "yes":
                        {
                            Console.WriteLine("Грузоподъемность: " + bike.Carrying);
                        }
                        break;
                    case "no":
                        {
                            Console.WriteLine("Грузоподьемность: " + 0);
                        }
                        break;
                }
                Console.WriteLine();
            }

            //Console.WriteLine("Тип: " + bike.Type);
            //Console.WriteLine("Модель: " +bike.ModelName);
            //Console.WriteLine("Номер: " + bike.Id);
            //Console.WriteLine("Скорость: " + bike.MaxSpeed);
            //CycleCar();
        }

    }
}
