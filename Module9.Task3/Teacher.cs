using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task3
{
    class Teacher : Persona
    {
        public string Post { get; set; }
        public int Experience { get; set; }

        public void InitTeacher(int size, List<Teacher> teachers)
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                Teacher teacher = new Teacher();
                teacher.Name = string.Format("{0}", rnd.Next(100, 999));
                teacher.DateOfBirth = DateTime.Today.AddYears(-(rnd.Next(30, 50))).AddDays(rnd.Next(1, 1000));
                teacher.Age = DateTime.Today.Year - teacher.DateOfBirth.Year;
                teacher.Faculty = string.Format("{0}", rnd.Next(10, 100));
                teacher.Post = string.Format("{0}", rnd.Next(1, 300));
                teacher.Experience = rnd.Next(1, 10);
                teachers.Add(teacher);
            }
        }
        public void ShowInfo(List<Teacher> teachers)
        {
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine();
                Console.WriteLine("Имя: " + teacher.Name);
                Console.WriteLine("Дата рождения:" + teacher.DateOfBirth.ToString("dd.MM.yyy"));
                Console.WriteLine("Возраст: " + teacher.Age);
                Console.WriteLine("Факультет: " + teacher.Faculty);
                Console.WriteLine("Должность: " + teacher.Post);
                Console.WriteLine("Стаж: " + teacher.Experience);
            }
        }

        public void FindByAge(List<Teacher> teachers, int min, int max)
        {
            var selectedUsers = from Teacher in teachers
                                where Teacher.Age >= min
                                where Teacher.Age <= max
                                select Teacher;
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Teacher teach in selectedUsers)
            {
                Console.WriteLine();
                teach.ShowInfo();
            }
            Console.ResetColor();
        }
    }
}
