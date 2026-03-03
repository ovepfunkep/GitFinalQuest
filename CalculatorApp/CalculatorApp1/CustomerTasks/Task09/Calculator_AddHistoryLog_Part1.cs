// Часть 1: аккуратная история операций для Task09.
// Можно использовать как пример для расширения класса Calculator.

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
            _history.Add(result);
            return result;
        }
    }
}

