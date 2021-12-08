using System;

namespace _11_11_21_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Контрольная работа
            // Вариант 9
            // 1) Вычислить значение функции f(x)
            Console.WriteLine("Введите x");
            double f = 0;
            double x = Convert.ToDouble(Console.ReadLine());
            if (x >= 0)
            {
                f = 0.5 - Math.Pow(Math.Abs(x), 0.25);
                Console.WriteLine("Так как x >= 0, то выполняется действие 0,5 -|x|^(1/4), и f(x) = " + f);
            }
            else
            {
                f = Math.Sin(x * x) * Math.Sin(x * x) / Math.Abs(x + 1);
                Console.WriteLine("Так как x < 0, то выполняется действие sin(x^2) * sin(x^2) / |x + 1|, и f(x) = " + f);
            }
        }
    }
}
