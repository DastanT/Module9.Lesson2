using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task3
{
    public class Matriculant : Persona
    {

        public void InitMatriculant(int size, List<Matriculant> obj)
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                Matriculant matriculant = new Matriculant();
                matriculant.Name = string.Format("{0}", rnd.Next(1, 999));
                matriculant.DateOfBirth = DateTime.Today.AddYears(-(rnd.Next(20, 30))).AddDays(rnd.Next(1, 1000));
                matriculant.Age = DateTime.Today.Year - matriculant.DateOfBirth.Year;
                matriculant.Faculty = string.Format("{0}", rnd.Next(10, 100));
                obj.Add(matriculant);
            }

        }
        public void ShowInfo(List<Matriculant> matriculants)
        {
            foreach (Matriculant matriculant in matriculants)
            {
                Console.WriteLine();
                Console.WriteLine("Имя: " + matriculant.Name);
                Console.WriteLine("Дата рождения: " + matriculant.DateOfBirth.ToString("dd.MM.yyy"));
                Console.WriteLine("Возраст: " + matriculant.Age);
                Console.WriteLine("Факультет: " + matriculant.Faculty);
            }
        }

        public void FindByAge(List<Matriculant> matriculants, int min, int max)
        {
            var selectedUsers = from Matriculant in matriculants
                                where Matriculant.Age >= min
                                where Matriculant.Age <= max
                                select Matriculant;
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Matriculant matr in selectedUsers)
            {
                Console.WriteLine();
                matr.ShowInfo();
            }
            Console.ResetColor();
        }


    }
}
