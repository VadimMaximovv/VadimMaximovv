using System;

namespace _03_12_21_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Составить программу для графического изображения делимости чисел от 1 до n (значение n вводится с клавиатуры).
            //В каждой строке надо напечатать очередное число и столько символов «+», сколько делителей у этого числа.
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                for (int j = 1; j <= i; j++)
                    if (i % j == 0)
                        Console.Write("+");
                Console.WriteLine(" ");
            }
        }
    }
}
