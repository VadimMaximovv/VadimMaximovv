using System;

namespace _25_11_21_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Дана строка, содержащая русскоязычный текст. Найти количество слов, начинающихся с буквы "о".
            string str = Console.ReadLine();
            int k = 0;
            for (int i = 0; i < str.Length - 1; i++)
                if (i == 0 && (str[i] == 'о' || str[i] == 'О'))
                    k++;
                else if ((str[i + 1] == 'о' || str[i + 1] == 'О') && str[i] == ' ')
                    k++;
            Console.WriteLine(k);
        }
    }
}
