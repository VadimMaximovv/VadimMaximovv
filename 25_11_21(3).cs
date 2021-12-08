using System;

namespace _25_11_21_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3) В строке удалить символ точку (.) и подсчитать количество удаленных символов.
            string str = Console.ReadLine();
            int k = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == '.')
                    k++;
            str = str.Replace(".", "");
            Console.WriteLine(str);
            Console.WriteLine(k);
        }
    }
}
