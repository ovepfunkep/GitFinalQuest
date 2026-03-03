// Резервная полная версия Program.cs для Task01.
// Если стартовый код калькулятора будет случайно сломан,
// студент может заменить содержимое Program.cs этим файлом.

using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            while (true)
            {
                PrintMenu();
                Console.Write("Выберите операцию: ");
                var input = Console.ReadLine();

                if (string.Equals(input, "q", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Выход из калькулятора. Пока!");
                    break;
                }

                HandleOperation(calculator, input);
                Console.WriteLine();
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("=== Калькулятор мечты (v0) ===");
            Console.WriteLine("Доступные операции:");
            Console.WriteLine("  1 - сложение");
            Console.WriteLine("  2 - вычитание");
            Console.WriteLine("  3 - умножение");
            Console.WriteLine("  4 - деление");
            Console.WriteLine("  q - выход");
        }

        static double ReadNumber(string prompt)
        {
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out var value))
            {
                Console.Write("Не похоже на число. Попробуйте ещё раз: ");
            }

            return value;
        }

        static void HandleOperation(Calculator calculator, string? op)
        {
            double a = ReadNumber("Введите первое число: ");
            double b = ReadNumber("Введите второе число: ");

            double result;

            switch (op)
            {
                case "1":
                    result = calculator.Add(a, b);
                    Console.WriteLine($"Результат: {result}");
                    break;
                case "2":
                    result = calculator.Subtract(a, b);
                    Console.WriteLine($"Результат: {result}");
                    break;
                case "3":
                    result = calculator.Multiply(a, b);
                    Console.WriteLine($"Результат: {result}");
                    break;
                case "4":
                    result = calculator.Divide(a, b);
                    Console.WriteLine($"Результат: {result}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция. Попробуйте ещё раз.");
                    break;
            }
        }
    }
}

