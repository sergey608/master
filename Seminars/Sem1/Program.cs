// System.Console.WriteLine("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 == num2 * num2)
// {
//     System.Console.WriteLine($"{num1} is quad of {num2}");
// } else
// {
//    System.Console.WriteLine($"{num1} is not quad of {num2}"); 
// }
//Напишите программу которая на вход принимает
// Целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число:");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = -n; i <= n; i++)
        {
            Console.WriteLine(i);
        }
//Напишите программу, которая принимает на вход
//трёхзначное целое число и на выходе показывает сумму
//первой и последней цифры этого числа

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трехзначное целое число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int firstDigit = number / 100; // Получаем первую цифру
        int lastDigit = number % 10; // Получаем последнюю цифру

        int sum = firstDigit + lastDigit; // Суммируем первую и последнюю цифры

        Console.WriteLine("Сумма первой и последней цифры: " + sum);
    }
}