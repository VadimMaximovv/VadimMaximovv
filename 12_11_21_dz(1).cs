using System;

namespace _12_11_21_dz_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // 1) Дан массив из n целых чисел. Определите, сколько в нем элементов, больших двух своих соседей, и выведите количество таких элементов.
            // Крайние элементы списка не учитывать, поскольку у них мало соседей.
            Console.WriteLine("Задайте количество элементов");
            int n = Convert.ToInt32(Console.ReadLine()), k = 0;
            int[] a = new int[n];
            Console.WriteLine("Задайте значения элементов");
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n - 1; i++)
                if (a[i] > a[i - 1] && a[i] > a[i + 1])
                    k++;
            Console.WriteLine("Количество элементов, больших двух своих соседей: " + k);
        }
    }
}
