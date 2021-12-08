using System;

namespace _19_11_21_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Самостаятельная работа
            // Вариант 9
            // 1) Дан одномерный массив, состоящий из N целочисленных элементов.
            // Ввести массив с клавиатуры. Найти максимальный элемент. Вывести массив на экран в обратном порядке.
            Console.WriteLine("Введите число количества элементов");
            int n = Convert.ToInt32(Console.ReadLine()), max = 0;
            int[] a = new int[n];
            Console.WriteLine("Введите числа значений элементов");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                    max = a[i];
                if (max < a[i])
                    max = a[i];
            }
            Console.WriteLine("Максимальное значение равно " + max);

        }
    }
}
