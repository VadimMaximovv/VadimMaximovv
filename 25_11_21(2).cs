using System;

namespace _25_11_21_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2) В строке заменить все двоеточия (:) знаком процента (%). Подсчитать количество замен.
            string str = Console.ReadLine();
            int k = 0;
            str = str.Replace(":", "%");
            for (int i = 0; i < str.Length; i++)
                if (str[i] == '%')
                    k++;
            Console.WriteLine(k);
        }
    }
}
