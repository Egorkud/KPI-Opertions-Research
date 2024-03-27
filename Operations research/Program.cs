using System;
using System.Text;

namespace Operations_research
{
    public abstract class Program
    {
        // Усі лабораторні викликаю з відповідних класів
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Введення значень
            double a = 0; // Ліва межа інтервалу
            double b = 4; // Права межа інтервалу
            int n = 1;    // Початкове значення n

            // Створення змінних обчислень Лаб 1
            FibonacciOptimisation Lab1 = new FibonacciOptimisation();
            double resultFibo = Lab1.Optimisation(a, b, n);
            double resultFunc = Lab1.Function(resultFibo);

            // Друк результату та обчислень
            Console.WriteLine($"\nМінімум функції методом Фібоначчі:\nx = {resultFibo}\n");
            Console.WriteLine($"Мінімум функції:\nf(x) = {resultFunc}");
        }
    }
}