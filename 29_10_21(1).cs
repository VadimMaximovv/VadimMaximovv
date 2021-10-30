using System;

namespace _29_10_21_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание 1. Первая строка содержит число n (1 ≤ n ≤ 100).
            Во второй строке записаны n целых чисел, каждое из которых не превышает по модулю 100.*/
            Console.WriteLine("Введите число количества элементов");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа через пробел");
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Максимальный элемент равен " + max);
        }
    }
}
