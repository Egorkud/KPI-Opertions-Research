using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_research
{
    // Лабораторна робота 1 Кудрявцев Єгор Олегович
    public class FibonacciOptimisation
    {
        // Метод для знаходження мінімуму функції за допомогою методу Фібоначчі
        public double Optimisation(double a, double b, int n)
        {
            // Задання точності
            double EPS = 0.00001;

            // Ініціалізація змінних
            double x1, x2;
            double q = b - a;
            int i = 1;
            string separator = "|........|........................|........|"; // 8 24 8

            // Пошук необхідного значення n для методу Фібоначчі
            while (Fibonacci(n + 2) <= q / EPS)
            {
                n++;
            }

            // Обчислення початкових точок x1 та x2
            x1 = a + (double)Fibonacci(n) / Fibonacci(n + 2) * (b - a);
            x2 = a + (double)Fibonacci(n + 1) / Fibonacci(n + 2) * (b - a);

            // Гарний друк таблиці
            Console.WriteLine($"Iteration           [a, b]           f(x)\n{separator}");

            // Ітеративний процес методу Фібоначчі
            while (i <= n - 1)
            {
                // Зміна границь інтервалу та пресування точок
                if (Function(x1) < Function(x2))
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + (double)Fibonacci(n - i) / Fibonacci(n - i + 2) * (b - a);
                }
                else
                {
                    a = x1;
                    x1 = x2;
                    x2 = a + (double)Fibonacci(n - i + 1) / Fibonacci(n - i + 2) * (b - a);
                }

                // Гарний друк даних
                Console.WriteLine($"|{i,7} |{a,10:F6},   {b,-10:F6}| {Function((a + b) / 2),-7:F5}|\n{separator}");
                i++;
            }

            // Повернення середини останнього інтервалу як результату оптимізації
            return (a + b) / 2;
        }

        // Обчислення значення функції завдання f(x) = 3*x^4 + (x - 1)^2
        public double Function(double x)
        {
            return 3 * Math.Pow(x, 4) + Math.Pow(x - 1, 2);
        }

        // Рекурсивна функція для обчислення числа Фібоначчі
        public int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
