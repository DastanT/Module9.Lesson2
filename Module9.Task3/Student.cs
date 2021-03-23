using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task3
{
    public class Student : Persona
    {
        public string Cource { get; set; }
        public void InitStudent(int size, List<Student> students)
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                Student student = new Student();
                student.Name = string.Format("{0}", rnd.Next(100, 999));
                student.DateOfBirth = DateTime.Today.AddYears(-(rnd.Next(20, 35))).AddDays(rnd.Next(1, 1000));
                student.Age = DateTime.Today.Year - student.DateOfBirth.Year;
                student.Faculty = string.Format("{0}", rnd.Next(10, 100));
                student.Cource = string.Format("{0}", rnd.Next(1, 10));
                students.Add(student);
            }

        }
        public void ShowInfo(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine();
                Console.WriteLine("Имя: " + student.Name);
                Console.WriteLine("Дата рождения:" + student.DateOfBirth.ToString("dd.MM.yyy"));
                Console.WriteLine("Возраст: " + student.Age);
                Console.WriteLine("Факультет: " + student.Faculty);
                Console.WriteLine("Курс: " + student.Cource);
            }
        }
        public void FindByAge(List<Student> students, int min, int max)
        {
            var selectedUsers = from Student in students
                                where Student.Age >= min
                                where Student.Age <= max
                                select Student;
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Student stud in selectedUsers)
            {
                Console.WriteLine();
                stud.ShowInfo();
            }
            Console.ResetColor();
        }
    }
}
