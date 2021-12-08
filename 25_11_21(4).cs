using System;

namespace _25_11_21_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4) В строке заменить букву(а) буквой (о). Подсчитать количество замен. Подсчитать, сколько символов в строке.
            string str = Console.ReadLine();
            int k = 0;
            str = str.Replace("а", "о");
            for (int i = 0; i < str.Length; i++)
                if (str[i] == 'о')
                    k++;
            Console.WriteLine(k);
        }
    }
}
