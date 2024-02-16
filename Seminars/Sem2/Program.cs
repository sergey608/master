using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num2 % num1 == 0)
        {
            Console.WriteLine("Второе число кратно первому");
        }
        else
        {
            Console.WriteLine("Остаток от деления: " + num2 % num1);
        }
    }
}