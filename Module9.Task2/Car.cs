using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task2
{
    class Car : Trans
    {
        public string Concern { get; set; }        
        public void InitCars(int size, List<Car> cars, Random rnd)
        {
            for (int i = 0; i < size; i++)
            {
                Car car = new Car();
                car.Type = "Car";
                car.Concern = string.Format("{0}", rnd.Next(1, 20));
                car.ModelName = string.Format("{0}", rnd.Next(1, 10));
                car.Id = rnd.Next(1000, 9999);
                car.MaxSpeed = rnd.Next(80, 500);
                car.Carrying = rnd.Next(20, 300);
                cars.Add(car);
            }
        }

        public void Show(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine("Тип: " + car.Type);
                Console.WriteLine("Концерн: " + car.Concern);
                Console.WriteLine("Модель: " + car.ModelName);
                Console.WriteLine("Номер: " + car.Id);
                Console.WriteLine("Скорость: " + car.MaxSpeed);
                Console.WriteLine("Грузоподъёмность: " + car.Carrying);
            }

        }
    }
}
