using System;

namespace _12_11_21_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //2)  Задан массив из n целых чисел. Найти сумму и количество чисел, больших среднего арифметического элементов массива.
            Console.WriteLine("Задайте количество элементов");
            int n = Convert.ToInt32(Console.ReadLine()), sr_z = 0, sum = 0, k = 0;
            int[] a = new int[n];
            Console.WriteLine("Задайте значения элементов");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                sr_z += a[i];
            }
            sr_z = sr_z / n;
            for (int i = 0; i < n; i++)
            if (a[i] > sr_z)
                {
                    k++;
                    sum += a[i];
                }
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Количество: " + k);
        }
    }
}
