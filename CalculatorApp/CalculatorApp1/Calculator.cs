using System;

namespace CalculatorApp
{
    /// <summary>
    /// Простой калькулятор с базовыми операциями.
    /// Реальная логика будет постепенно дорабатываться по задачам.
    /// </summary>
    public class Calculator
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}

