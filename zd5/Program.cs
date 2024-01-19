using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Бесконечный цикл, который запрашивает целые числа с консоли
            // An infinite loop that requests integers from the console
            while (true)
            {
                // Выводим приглашение для ввода
                // Print the prompt for input
                Console.Write("Введите целое число или 'q' для выхода: ");
                // Считываем строку с консоли
                // Read a line from the console
                string input = Console.ReadLine();
                // Если введен символ 'q', то выходим из цикла
                // If the character 'q' is entered, then exit the loop
                if (input == "q")
                {
                    break;
                }
                // Пытаемся преобразовать строку в целое число
                // Try to convert the string to an integer
                int number;
                bool success = int.TryParse(input, out number);
                // Если преобразование успешно, то проверяем сумму цифр числа
                // If the conversion is successful, then check the sum of the digits of the number
                if (success)
                {
                    // Вычисляем сумму цифр числа
                    // Calculate the sum of the digits of the number
                    int sum = 0;
                    while (number > 0)
                    {
                        sum += number % 10;
                        number /= 10;
                    }
                    // Если сумма цифр четная, то выходим из цикла
                    // If the sum of the digits is even, then exit the loop
                    if (sum % 2 == 0)
                    {
                        break;
                    }
                    // Иначе выводим сообщение, что сумма цифр нечетная
                    // Otherwise, print a message that the sum of the digits is odd
                    else
                    {
                        Console.WriteLine("Сумма цифр введенного числа нечетная.");
                    }
                }
                // Если преобразование не успешно, то выводим сообщение об ошибке
                // If the conversion is not successful, then print an error message
                else
                {
                    Console.WriteLine("Неверный формат ввода. Пожалуйста, введите целое число или 'q'.");
                }
            }
            // Выводим сообщение о завершении программы
            // Print a message about the completion of the program
            Console.WriteLine("Программа завершена.");
        }
    }
}