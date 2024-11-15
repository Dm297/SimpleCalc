namespace TestProject
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            double result = _calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsCorrectResult()
        {
            double result = _calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsCorrectResult()
        {
            double result = _calculator.Multiply(7, 6);
            Assert.AreEqual(42, result);
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsCorrectResult()
        {
            double result = _calculator.Divide(12, 3);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsInCorrectResult()
        {
            double result = _calculator.Divide(12, 3);
            Assert.AreEqual(3, result);
        }
    }
}