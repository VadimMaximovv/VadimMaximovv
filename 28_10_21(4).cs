using System;

namespace _28_10_21_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 4: Вывести на экран, консольного приложения, прямоугольный треугольник из звездочек “*”, с длиной катета m.
            Console.WriteLine("Введите число. Оно будет являтся длинной одного из катетов прямоугольного треугольника");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                int j = 0;
                while (i > j)
                {
                    Console.Write('*');
                    j++;
                }
                Console.WriteLine();
            }
        }
    }
}
