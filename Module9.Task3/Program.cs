using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module9.Task2;

namespace Module9.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriculant matriculant = new Matriculant();
            Student student = new Student();
            Teacher teacher = new Teacher();
            List<Matriculant> matriculants = new List<Matriculant>();
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            User user = new User();
            int minAge;
            int maxAge;
            do
            {
            start: user.UserMenu(); // не нашёл другого решения, поэтому использовал goto (((
                switch (int.Parse(user.UserChoice()))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Абитуриент");
                        Console.Write("Введите количество абитуриентов: ");
                        matriculant.InitMatriculant(user.UserSize(), matriculants);
                        matriculant.ShowInfo(matriculants);
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Студент");
                        Console.Write("Введите количество студентов: ");
                        student.InitStudent(user.UserSize(), students);
                        student.ShowInfo(students);
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Преподаватель");
                        Console.Write("Введите количество преподавателей: ");
                        teacher.InitTeacher(user.UserSize(),teachers);
                        teacher.ShowInfo(teachers);
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        do
                        {
                            user.SearchMenu();
                            switch (int.Parse(user.UserChoice()))
                            {
                                case 1:
                                    Console.WriteLine("Поиск абитуринтов");
                                    matriculant.ShowInfo(matriculants);
                                    Console.Write("Введите возраст от: ");
                                    int min = int.Parse(Console.ReadLine());
                                    Console.Write("Введите возраст до: ");
                                    int max = int.Parse(Console.ReadLine());
                                    Console.WriteLine(new String('-', 20));
                                    matriculant.FindByAge(matriculants, min, max);
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.WriteLine("Поиск студентов");
                                    student.ShowInfo(students);
                                    Console.Write("Введите возраст от: ");
                                    minAge = int.Parse(user.UserChoice());
                                    Console.Write("Введите возраст до: ");
                                    maxAge = int.Parse(user.UserChoice());
                                    Console.WriteLine(new String('-', 20));
                                    student.FindByAge(students, minAge, maxAge);
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.WriteLine("Поиск студентов");
                                    teacher.ShowInfo(teachers);
                                    Console.Write("Введите возраст от: ");
                                    minAge = int.Parse(user.UserChoice());
                                    Console.Write("Введите возраст до: ");
                                    maxAge = int.Parse(user.UserChoice());
                                    Console.WriteLine(new String('-', 20));
                                    teacher.FindByAge(teachers, minAge, maxAge);
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.Clear();
                                    goto start;
                            }
                        } while (true);
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}
