using System;

namespace _22_10_21_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание 3: Напишите программу, которая сравнивает, введенное пользователем, целое число с нулем, и выводит одно из сообщений:
            
            число отрицательное;
            число равно нулю;
            число положительное.

            */
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
                Console.WriteLine("Число положительно");
            if (n < 0)
                Console.WriteLine("Число отиицательно");
            if (n == 0)
                Console.WriteLine("Число равно нулю");
        }
    }
}
