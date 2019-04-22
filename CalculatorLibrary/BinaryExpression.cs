using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public abstract class BinaryExpression : UnaryExpression
    {
        protected IExpression Left;

        public BinaryExpression(IExpression left, IExpression right) : base(right)
        {
            this.Left = left;
        }
    }
}
