using System;

namespace _29_10_21_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2: В первой строке записано число N. В следующей строке N целых чисел. Все числа не превышают 100.
            Console.WriteLine("Введите число количества элементов");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа через пробел");
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
