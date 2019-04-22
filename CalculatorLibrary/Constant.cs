using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Constant : IExpression
    {
        double Value { get; set; }

        public Constant(double value)
        {
            this.Value = value;
        }
        
        public double Calculate()
        {
            return Value;
        }
    }
}
