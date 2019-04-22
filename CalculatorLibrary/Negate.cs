using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Negate : UnaryExpression
    {
        public Negate(IExpression right) : base(right)
        {
            
        }

        public override double Calculate()
        {
            return (Right.Calculate() * -1);
        }
    }
}
