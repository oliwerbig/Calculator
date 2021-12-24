using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Division : BinaryOperation
    {
        public Division(IEvaluable left, IEvaluable right) : base(left, right)
        {

        }
        public override double Evaluate()
        {
            return Left.Evaluate() / Right.Evaluate();
        }
    }
}
