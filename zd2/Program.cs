using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите координату X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой четверти.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во второй четверти.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей четверти.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвертой четверти.");
        }
    }
}
