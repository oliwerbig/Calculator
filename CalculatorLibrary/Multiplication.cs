using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Multiplication : BinaryOperation
    {
        public Multiplication(IEvaluable left, IEvaluable right) : base(left, right)
        {
            
        }
        public override double Evaluate()
        {
            return Left.Evaluate() * Right.Evaluate();
        }
    }
}
