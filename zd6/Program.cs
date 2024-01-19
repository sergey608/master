using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя размер массива
        Console.WriteLine("Введите размер массива:");
        int n = int.Parse(Console.ReadLine());

        // Создаем массив из n элементов
        int[] array = new int[n];

        // Создаем объект для генерации случайных чисел
        Random random = new Random();

        // Заполняем массив случайными трехзначными числами
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        // Объявляем переменную для подсчета количества четных чисел
        int evenCount = 0;

        // Перебираем элементы массива и проверяем, являются ли они четными
        for (int i = 0; i < n; i++)
        {
            if (array[i] % 2 == 0)
            {
                // Увеличиваем счетчик четных чисел
                evenCount++;
            }
        }

        // Выводим результат на экран
        Console.WriteLine("Количество четных чисел в массиве: " + evenCount);
    }
}