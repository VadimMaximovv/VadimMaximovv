using System;

namespace _29_11_21_1_
{
    class Program
    {
        /* 1) Выполнить: Вводятся три числа — длины трех сторон треугольника.
        Создайте функцию Perimeter(), которая вычисляет периметр треугольника по длинам трех его сторон.
        Указание 1: Метод Perimeter() должен принимать в качестве аргументов три целых числа.
        Указание 2: Метод не должен возвращать никакого значения, поэтому вы должны использовать ключевое слово void в сигнатуре:

        static void Perimeter(...);
        Указание 3: Не забудьте преобразовать введенные значения в целые числа. Например:

        int a = int.Parse(Console.ReadLine());
        */
        static void Perimeter(int a, int b, int c)
        {
            Console.WriteLine(a+b+c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте значения сторон треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Периметр: ");
            Perimeter(a, b, c);
        }
    }
}
