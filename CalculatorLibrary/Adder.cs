using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Adder : BinaryExpression
    {
        public Adder(IExpression left, IExpression right) : base(left, right)
        {
            
        }
        public override double Calculate()
        {
            return Left.Calculate() + Right.Calculate();
        }
    }
}
