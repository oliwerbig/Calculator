using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public double Test()
        {
            IExpression e =
                    new Divider(
                            new Multiplier(
                                    new Negate(new Constant(5.0)),
                                    new Divider(new Constant(9.0), new Constant(6.0))
                            ),
                            new Adder(
                                    new Constant(7.0),
                                    new Subtracter(new Constant(2.0), new Constant(1.5))
                            )
                    );
            return e.Calculate();
        }
    }
}
