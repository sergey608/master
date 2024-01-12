using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число от 10 до 99: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number < 10 || number > 99)
        {
            Console.WriteLine("Число должно быть в диапазоне от 10 до 99");
            return;
        }

        int firstDigit = number / 10;
        int secondDigit = number % 10;

        int maxDigit = (firstDigit > secondDigit) ? firstDigit : secondDigit;

        Console.WriteLine($"Наибольшая цифра числа {number} : {maxDigit}");
    }
}