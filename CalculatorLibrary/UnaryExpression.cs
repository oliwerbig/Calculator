using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public abstract class UnaryExpression : IExpression
    {
        protected IExpression Right;

        public UnaryExpression(IExpression right)
        {
            this.Right = right;
        }

        public abstract double Calculate();
    }
}
