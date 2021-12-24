using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Negation : UnaryOperation
    {
        public Negation(IEvaluable right) : base(right)
        {
            
        }

        public override double Evaluate()
        {
            return (Right.Evaluate() * -1);
        }
    }
}
