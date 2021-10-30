using System;

namespace _28_10_21_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2: Вычислить факториал числа p(при p > 0), используя цикл do while.
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine()), n1 = 1, sum = 1;
            do
            {
                sum = sum * n1;
                n1++;
            }
            while (n1 <= n);
            Console.WriteLine("Факториал введёного числа: " + sum);
        }
    }
}
