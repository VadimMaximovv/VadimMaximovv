using System;

namespace _25_11_21_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6) Дана строка, заканчивающаяся точкой. Подсчитать, сколько слов в строке.
            string str = Console.ReadLine();
            int k = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ' ' || str[i] == '.')
                    k++;
            Console.WriteLine(k);
        }
    }
}
