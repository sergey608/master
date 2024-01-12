using System;

void Multiple(num)
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.Readline());

    if(num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"{num} кратно однровременно 7 и 23");
    }
    else
    {
        Console.WriteLine($"{num} не кратно 7 и 23");
    }
}
Multiple(num)