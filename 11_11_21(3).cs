﻿using System;

namespace _11_11_21_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Контрольная работа
            // Вариант 9
            // 3) Дано целое число N (> 0). Найти наибольшее целое число K, квадрат которого не превосходит N: K^2 ≤ N.
            // Функцию извлечения квадратного корня не использовать. Решить задачу используя циклическую конструкцию while.
            Console.WriteLine("Введите количество элнментов");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            while (k * k <= n)
                k++;
            k--;
            Console.WriteLine("Наибольшее целое число K, квадрат которого не превосходит N: " + k);
        }
    }
}