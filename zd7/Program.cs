using System;

class Program
{
    static void Main()
    {
        // Исходный массив
        int[] array = { 1, 2, 3, 4, 5 };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив: " + string.Join(", ", array));

        // Переворачиваем массив
        Array.Reverse(array);

        // Выводим перевернутый массив
        Console.WriteLine("Перевернутый массив: " + string.Join(", ", array));
    }
}