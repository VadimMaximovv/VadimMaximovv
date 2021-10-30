using System;

namespace _28_10_21_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1: Найти сумму первых N членов арифметической прогрессии с использованием цикла for.
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Сумма членов арифметической прогрессии " + sum);
        }
    }
}
