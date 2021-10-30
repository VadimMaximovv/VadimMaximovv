using System;

namespace _22_10_21_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание 4: Написать программу вычисления стоимости покупки с учетом скидки.
            Скидка в 3% предоставляется в том случае, если сумма покупки больше 500 руб., в 5% - если сумма больше 1000 руб.*/
            Console.WriteLine("Введите стоимость покупки, которую хотите купить: ");
            double n = Convert.ToDouble(Console.ReadLine());
            if (n >= 500 && n < 1000)
            {
                n = n * 97/100;
                Console.WriteLine("Скидка 3%. Цена " + n);
            }
            else if (n >= 1000)
            {
                n = n * 95 / 100;
                Console.WriteLine("Скидка 5%. Цена " + n);
            }
            else
                Console.WriteLine("Скидки нет. Цена " + n);
        }
    }
}
