using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Addition : BinaryOperation
    {
        public Addition(IEvaluable left, IEvaluable right) : base(left, right)
        {
            
        }
        public override double Evaluate()
        {
            return Left.Evaluate() + Right.Evaluate();
        }
    }
}
