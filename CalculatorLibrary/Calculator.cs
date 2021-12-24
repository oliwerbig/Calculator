using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public Queue<IEvaluable> Output = new();
        public Stack<IEvaluable> Operator = new();

        public double Calculate(string expression)
        {
            // TODO: Implement Shunting-yard algorithm for expression parsing
            return 0;
        }

        public double Test()
        {
            IEvaluable e =
                    new Division(
                            new Multiplication(
                                    new Negation(new Constant(5.0)),
                                    new Division(new Constant(9.0), new Constant(6.0))
                            ),
                            new Addition(
                                    new Constant(7.0),
                                    new Subtraction(new Constant(2.0), new Constant(1.5))
                            )
                    );
            return e.Evaluate();
        }
    }
}
