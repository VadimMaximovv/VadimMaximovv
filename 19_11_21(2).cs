using System;

namespace _19_11_21_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Самостаятельная работа
            // Вариант 9
            //2.В массиве действительных чисел все нулевые элементы заменить на среднее арифметическое всех элементов массива.
            Console.WriteLine("Введите число количества элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] b = new double[n];
            double sum = 0;
            Console.WriteLine("Введите числа значений элементов");
            for (int i = 0; i < n; i++)
            {
                b[i] = Convert.ToDouble(Console.ReadLine());
                sum = sum + b[i];
            }
            sum = sum / n;
            Console.WriteLine("Индекс - элемент");
            for (int i = 0; i < n; i++)
            {
                if (b[i] != 0)
                    Console.WriteLine(i + 1 + " - " + b[i]);
                else
                {
                    b[i] = sum;
                    Console.WriteLine(i + 1 + " - " + b[i] + " / Произошла замена");
                }
            }
        }
    }
}
