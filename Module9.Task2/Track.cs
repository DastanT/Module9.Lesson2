using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task2
{
    class Track : Trans
    {
        public void InitTracks(int size, List<Track> tracks, Random rnd)
        {
            for (int i = 0; i < size; i++)
            {
                Track track = new Track();
                track.Type = "Motorbike";
                track.ModelName = string.Format("{0}", rnd.Next(1, 10));
                track.Id = rnd.Next(1000, 9999);
                track.MaxSpeed = rnd.Next(80, 350);
                track.Carrying = rnd.Next(200, 1000);
                tracks.Add(track);
            }
        }

        public void Show(List<Track> tracks)
        {
            User user = new User();
            foreach (Track track in tracks)
            {
                Console.WriteLine("Тип: " + track.Type);
                Console.WriteLine("Модель: " + track.ModelName);
                Console.WriteLine("Номер: " + track.Id);
                Console.WriteLine("Скорость: " + track.MaxSpeed);
                Console.Write("Наличие прицепа (yes/no): ");
                switch (user.UserChoice())
                {
                    case "yes":
                        {
                            Console.WriteLine("Грузоподъемность c прицепом: " + track.Carrying * 2);
                        }
                        break;
                    case "no":
                        {
                            Console.WriteLine("Грузоподьемность без прицепа: " + track.Carrying);
                        }
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
