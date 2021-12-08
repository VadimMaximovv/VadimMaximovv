using System;

namespace _03_12_21_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Найти все целые числа из промежутка от 1 до 300, у которых ровно пять делителей.
            int k;
            for (int i = 1; i <= 300; i++)
            {
                k = 2;
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                        k++;
                if (k == 5)
                    Console.WriteLine(i);
            }
        }
    }
}
