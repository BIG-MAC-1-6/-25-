using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ___25_Структуры
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int N = 5;
            Worked[] workers = new Worked[N];
            int experienceThreshold;

            Console.WriteLine("Введите данные о работниках:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Работник {i + 1}:");
                Console.Write("ФИО: ");
                workers[i].Fio = Console.ReadLine();

                Console.Write("Должность: ");
                workers[i].Position = Console.ReadLine();

                Console.Write("Год поступления на работу: ");
                while (!int.TryParse(Console.ReadLine(), out workers[i].YearStart))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }
            }

            Console.Write("Введите порог стажа (в годах): ");
            while (!int.TryParse(Console.ReadLine(), out experienceThreshold))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            bool found = false;
            Console.WriteLine($"\nРаботники со стажем более {experienceThreshold} лет:");
            for (int i = 0; i < N; i++)
            {
                int experience = DateTime.Now.Year - workers[i].YearStart;
                if (experience > experienceThreshold)
                {
                    Console.WriteLine($"{workers[i].Fio} (Стаж: {experience} лет)");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Нет работников со стажем более {experienceThreshold} лет.");
            }

            Console.ReadKey();
        }
    }
}
