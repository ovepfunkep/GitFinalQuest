// Базовые операции калькулятора для Task02.
// Используется как эталон для класса Calculator.

using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}

