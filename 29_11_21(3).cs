using System;

namespace _29_11_21_3_
{
    class Program
    {
        // 3) Выполнить: Вводится двузначное целое число.
        // Создайте метод ChangeDigits(), который принимает введенный аргумент по ссылке и изменяет его значение так,
        // чтобы первая цифра нового числа была второй цифрой введенного числа и, наоборот,
        // вторая цифра нового числа была первой цифрой введенного числа. Например, если ввести 45, то результирующее число будет равно 54.
        static void ChangeDigits(int n)
        {
            Console.WriteLine((n % 10) * 10 + (n / 10));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            ChangeDigits(n);
        }
    }
}
