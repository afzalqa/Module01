using NUnit.Framework;
using Calc.Lib;

namespace Calc.Lib.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenCalledWithNegativeIntengers_ReturnsTheirSum()
        {
                var result = _calculator.Add(-2, -3);
                Assert.AreEqual(-5, result);
        }

        [Test]
        public void Add_WhenCalledWithPositiveIntengers_ReturnsTheirSum()
        {
            var result = _calculator.Add(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
