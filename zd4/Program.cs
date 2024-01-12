using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number <= 0)
        {
            Console.WriteLine("Число должно быть натуральным (больше 0)");
            return;
        }

        string numberString = number.ToString();
        string result = string.Join(", ", numberString.ToCharArray());

        Console.WriteLine($"Цифры числа {number} : {result}");
    }
}