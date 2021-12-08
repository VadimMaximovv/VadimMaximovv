using System;

namespace _11_11_21_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Контрольная работа
            // Вариант 9
            // 2) Известно сопротивление каждого из элементов электрической цепи. Все элементы соединены последовательно.
            // Определить общее сопротивление цепи. Решить задачу используя циклическую конструкцию for.
            Console.WriteLine("Введите количество элементов электрической цепи");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            Console.WriteLine("Введите значения сопротивления каждого элемента электрической цепи");
            for (int i = 1; i <= n; i++)
                r = r + Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Общее сопротивление цепи равно " + r);
        }
    }
}
