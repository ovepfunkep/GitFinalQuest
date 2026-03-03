// Часть 2: шумная и неправильная работа с историей для Task09.
// Этот код добавляет лишний вывод и дублирует результаты.
// Его нужно будет закоммитить, а затем вернуть назад через revert.

using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    public class Calculator
    {
        private readonly List<double> _history = new();

        public IReadOnlyList<double> History => _history;

        public double Add(double a, double b) => Save(a + b);
        public double Subtract(double a, double b) => Save(a - b);
        public double Multiply(double a, double b) => Save(a * b);
        public double Divide(double a, double b) => Save(a / b);

        private double Save(double result)
        {
           Console.WriteLine($"[DEBUG] Сохраняем результат: {result}");
           _history.Add(result);
           _history.Add(result); // баг: дублируем запись
           return result;
        }
    }
}

