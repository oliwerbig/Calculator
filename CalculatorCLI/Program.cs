using System;
using CalculatorLibrary;

namespace CalculatorCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Test());
            Console.ReadKey();
        }
    }
}
