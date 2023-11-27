namespace TDD
{
    public class Tests
    {
        Calculator cal;
        [SetUp]
        public void Setup()
        {
             cal = new Calculator();
        }

        [Test]
        public void OnePlusOneTwo()
        {

            Assert.AreEqual(00000101, cal.add(100,1));
        }
        [Test]
        public void NegativeNumbers() 
        {
            Assert.AreEqual(-2, cal.add(1, -3));

        }
        [Test]
        public void LargeNumbers()
        {
            Assert.AreEqual(int.MaxValue, cal.add(int.MaxValue / 2, int.MaxValue / 2));

        }
        [Test]
        public void MaxWithZero()
        {
            Assert.AreEqual(int.MaxValue, cal.add(int.MaxValue, 0));

        }
        [Test]
        public void ZeroNonZero()
        {
            Assert.AreEqual(-3, cal.add(-3, 0));

        }
        [Test]
        public void WithBothZeros()
        {

            Assert.AreEqual(0, cal.add(0, 0));

        }
        [Test]
        public void MixNumbers()
        {
            Assert.AreEqual(0, cal.add(5, -5));

        }
        [Test]
        public void TestingFractions()
        {
            Assert.AreEqual(1.5, cal.add(1, 0.5));

        }
        [Test]
        public void SimpleOne()
        {
            Assert.AreEqual(2, cal.subtract(2.5, 0.5));
        }
        [Test]
        public void SubtractZeroFromPositiveNumber()
        {
            Assert.AreEqual(5, cal.subtract(5, 0));
        }

        [Test]
        public void SubtractZeroFromNegativeNumber()
        {
            Assert.AreEqual(-3, cal.subtract(-3, 0));
        }

        [Test]
        public void SubtractPositiveNumberFromZero()
        {
            Assert.AreEqual(-2.5, cal.subtract(0, 2.5));
        }

        [Test]
        public void SubtractNegativeNumberFromZero()
        {
            Assert.AreEqual(3.8, cal.subtract(0, -3.8));
        }

        [Test]
        public void SubtractTwoNegativeDoublesWithDecimalPrecision()
        {
            Assert.AreEqual(-0.15, cal.subtract(-1.25, -1.1), 0.0001);
        }

        [Test]
        public void SubtractTwoLargePositiveDoubles()
        {
            Assert.AreEqual(1e10, cal.subtract(1e10 + 0.5, 0.5));
        }
        [Test]
        public void SameNumber()
        {
            Assert.AreEqual(1, cal.Multiply(1, 1));
        }
        [Test]
        public void MultiplyZeroByAnyNumber()
        {
            Assert.AreEqual(0, cal.Multiply(0, 5));
        }

        [Test]
        public void MultiplyAnyNumberByZero()
        {
            Assert.AreEqual(0, cal.Multiply(3.7, 0));
        }

        [Test]
        public void MultiplyPositiveNumbers()
        {
            Assert.AreEqual(12, cal.Multiply(3, 4));
        }

        [Test]
        public void MultiplyNegativeNumbers()
        {
            Assert.AreEqual(-8, cal.Multiply(-2, 4));
        }

        [Test]
        public void MultiplyNegativeAndPositiveNumbers()
        {
            Assert.AreEqual(-15, cal.Multiply(-3, 5));
        }

        [Test]
        public void MultiplyTwoLargeNumbers()
        {
            Assert.AreEqual(1e20, cal.Multiply(1e10, 1e10));
        }

        [Test]
        public void MultiplyTwoDecimalNumbersWithPrecision()
        {
            Assert.AreEqual(6.75, cal.Multiply(2.25, 3), 0.0001);
        }
        [Test]
        public void DivideSameNumbers()
        {
            Assert.AreEqual(2, cal.Divide(2, 1));
        }
        [Test]
        public void DivideByOne()
        {
            Assert.AreEqual(5, cal.Divide(5, 1));
        }

        [Test]
        public void DivideOneByNumber()
        {
            Assert.AreEqual(0.2, cal.Divide(1, 5), 0.0001);
        }

        [Test]
        public void DivideZeroByNumber()
        {
            Assert.AreEqual(0, cal.Divide(0, 10));
        }

        [Test]
        public void DivideNumberByZero()
        {
            Assert.Throws<DivideByZeroException>(() => cal.Divide(8, 0));
        }

        [Test]
        public void DivideNegativeNumberByPositiveNumber()
        {
            Assert.AreEqual(-3, cal.Divide(-9, 3));
        }

        [Test]
        public void DividePositiveNumberByNegativeNumber()
        {
            Assert.AreEqual(-2, cal.Divide(6, -3));
        }

        [Test]
        public void DivideTwoDecimalNumbersWithPrecision()
        {
            Assert.AreEqual(2.5, cal.Divide(5, 2), 0.0001);
        }

    }

}