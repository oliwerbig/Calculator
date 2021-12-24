using System;
using CalculatorLibrary;

namespace CalculatorCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            string expression = Console.ReadLine();
            Console.WriteLine(calculator.Calculate(expression));
            Console.ReadKey();
        }
    }
}
