using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public abstract class UnaryOperation : IEvaluable
    {
        protected IEvaluable Right;

        public UnaryOperation(IEvaluable right)
        {
            Right = right;
        }

        public abstract double Evaluate();
    }
}
