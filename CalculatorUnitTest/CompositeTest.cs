using System;
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CompositeTest
    {
        [TestMethod]
        public void TestConstant()
        {
            IExpression e = new Constant(1.0);
            Assert.AreEqual(1, e.Calculate());
        }

        [TestMethod]
        public void TestNegate()
        {
            IExpression e = new Negate(new Constant(-1.0));
            Assert.AreEqual(1, e.Calculate());
        }

        [TestMethod]
        public void TestAdder()
        {
            IExpression e = new Adder(new Constant(1.0), new Constant(2.0));
            Assert.AreEqual(3, e.Calculate());
        }

        [TestMethod]
        public void TestSubtracter()
        {
            IExpression e = new Subtracter(new Constant(1.0), new Constant(2.0));
            Assert.AreEqual(-1, e.Calculate());
        }

        [TestMethod]
        public void TestMultiplier()
        {
            IExpression e = new Multiplier(new Constant(5.0), new Constant(2.0));
            Assert.AreEqual(10, e.Calculate());
        }

        [TestMethod]
        public void TestDivider()
        {
            IExpression e = new Divider(new Constant(5.0), new Constant(2.0));
            Assert.AreEqual(2.5, e.Calculate());
        }

        [TestMethod]
        public void TestComplex()
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
            Assert.AreEqual(-1, e.Calculate());
        }
    }
}
