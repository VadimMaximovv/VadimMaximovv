using System;

namespace _22_10_21_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2: Даны три целых числа. Выбрать из них те, которые принадлежат интервалу [1,3].
            Console.WriteLine("Введите 3 числа: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числа, которые принадлежат отрезку [1;3]:");
            if (n1 >= 1 && n1 <= 3)
                Console.Write(n1 + " ");
            if (n2 >= 1 && n2 <= 3)
                Console.Write(n2 + " ");
            if (n3 >= 1 && n3 <= 3)
                Console.Write(n3 + " ");
            Console.WriteLine("");
        }
    }
}
