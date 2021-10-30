using System;

namespace _28_10_21_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 3: Посчитать количество и сумму парных чисел в диапазоне от 1 до N.
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine()), sum = 0;
            for (int i = 2; i <= n; i = i + 2)
                sum += i;
            Console.WriteLine("Сумма парных (чётных) чисел равна " + sum);
        }
    }
}
