using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public abstract class BinaryOperation : UnaryOperation
    {
        protected IEvaluable Left;

        public BinaryOperation(IEvaluable left, IEvaluable right) : base(right)
        {
            Left = left;
        }
    }
}
