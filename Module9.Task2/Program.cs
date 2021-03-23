using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Motorbike motorbike = new Motorbike();
            Track track = new Track();

            User user = new User();
            int userSize = user.UserSize();

            List<Trans> transpotrs = new List<Trans>();
            List<Car> cars = new List<Car>();
            List<Motorbike> motorbikes = new List<Motorbike>();
            List<Track> tracks = new List<Track>();
            Random rnd = new Random();

            Console.WriteLine();

            Console.WriteLine("Машины");
            Console.Write("Введите количество транспортных средств: ");
            car.InitCars(userSize, cars, rnd);
            car.Show(cars);
            Console.WriteLine();
            
            Console.WriteLine("Мотоциклы");
            Console.Write("Введите количество транспортных средств: ");
            motorbike.InitMotorbikes(userSize, motorbikes, rnd);
            motorbike.Show(motorbikes);

            Console.WriteLine("Грузовой автомобиль");
            Console.Write("Введите количество транспортных средств: ");
            track.InitTracks(userSize, tracks, rnd);
            track.Show(tracks);
            
            Console.WriteLine();

            Console.WriteLine();

        }
    }
}
