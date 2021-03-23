using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task2
{
    public class User
    {
        public void UserMenu()
        {
            Console.WriteLine("Главное меню: ");
            Console.WriteLine();
            Console.WriteLine("1.Абитуриент");
            Console.WriteLine("2.Студент");
            Console.WriteLine("3.Преподаватель");
            Console.WriteLine("4.Поиск");
            Console.WriteLine("5.Выход");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введите значение: ");
            Console.ResetColor();
        }

        public void SearchMenu()
        {
            Console.WriteLine("Поиск: ");
            Console.WriteLine();
            Console.WriteLine("1.Абитуриент");
            Console.WriteLine("2.Студент");
            Console.WriteLine("3.Преподаватель");
            Console.WriteLine("4.Назад");
            Console.Write("Введите значение: ");
        }
        public void UserHeader()
        {
            Console.WriteLine(new String('=', 20));
            Console.WriteLine("Выбор траспортного средства");
            Console.WriteLine(new String('=', 20));
        }
        public int UserSize()
        {
            int size = int.Parse(Console.ReadLine());
            return size;
        }
        public string UserChoice()
        {
            string userChoice = Console.ReadLine();
            return userChoice;
        }
        
        public int AgeFrom { get { return int.Parse(UserChoice()); } }
        public int AgeTo { get { return int.Parse(UserChoice()); } }
    }
}
