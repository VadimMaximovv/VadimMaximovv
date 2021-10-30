using System;

namespace _28_10_21_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 5: Используя вложенные циклы, вывести таблицы умножения от второй до шестой.
            int g;
            for (int i = 2; i <= 6; i++)
                for (int j = 1; j <= 10; j++)
                {
                    g = i * j;
                    Console.WriteLine(i + " * " + j + " = " + g);
                }
        }
    }
}
