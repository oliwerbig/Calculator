using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Constant : IEvaluable
    {
        double Value { get; set; } = 0;

        public Constant(double value)
        {
            Value = value;
        }
        
        public double Evaluate()
        {
            return Value;
        }
    }
}
