using NUnit.Framework;
using System;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class Tests
    {
        private Calc calc;
        [SetUp]
        public void Setup()
        {
            //Arrange
            calc = new Calc();
        }


        [Test]
        public void TestAddPositivePositive()
        {
            //ACT + ASSERT LAMBDA
            Assert.That(() => calc.Add(2, 2), Is.EqualTo(4));
        }

        [Test]
        public void TestAddPositiveNegative()
        {
            //ACT + ASSERT LAMBDA
            Assert.That(()=>calc.Add(2,-4), Is.EqualTo(-2));
        }

        [Test]
        public void TestAddNegativeNegative()
        {
            //ACT + ASSERT LAMBDA
            Assert.That(() => calc.Add(-2, -4), Is.EqualTo(-6));
        }

        [Test]
        public void TestSubtractPositivePositive()
        {
            //ACT
            double a = calc.Subtract(4, 2);

            //ASSERT
            Assert.That(a, Is.EqualTo(2));
        }

        [Test]
        public void TestSubtractPositiveNegative()
        {
            //ACT
            double a = calc.Subtract(4, -2);

            //ASSERT
            Assert.That(a, Is.EqualTo(6));
        }

        [Test]
        public void TestSubtractNegativeNegative()
        {
            //ACT
            double a = calc.Subtract(-4, -2);

            //ASSERT
            Assert.That(a, Is.EqualTo(-2));
        }

        [Test]
        public void TestMultiplyPositivePositive()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Multiply(4, 4), Is.EqualTo(16));
        }

        [Test]
        public void TestMultiplyPositiveNegative()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Multiply(4, -4), Is.EqualTo(-16));
        }

        [Test]
        public void TestMultiplyNegativeNegative()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Multiply(-4, -4), Is.EqualTo(16));
        }

        [Test]
        public void TestPowerPositivePositive()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Power(2, 3), Is.EqualTo(8));
        }

        [Test]
        public void TestPowerPositiveNegative()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Power(2, -3), Is.EqualTo(0.125));
        }

        [Test]
        public void TestPowerNegativePositive()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Power(-2, 3), Is.EqualTo(-8));
        }

        [Test]
        public void TestPowerNegativeNegative()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Power(-2, -3), Is.EqualTo(-0.125));
        }

        [Test]
        public void TestPowerPositiveZero()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Power(2, 0), Is.EqualTo(1));
        }

        [Test]
        public void TestPowerZeroPostive()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Power(0, 3), Is.EqualTo(0));
        }

        [Test]
        public void TestDividePositivePositive()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Division(9, 3), Is.EqualTo(3));
        }

        [Test]
        public void TestDividePositiveNegative()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Division(9, -3), Is.EqualTo(-3));
        }

        [Test]
        public void TestDivideNegativeNegative()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Division(-9, -3), Is.EqualTo(3));
        }

        [Test]
        public void TestDivideDecimal()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Division(10, 3), Is.EqualTo(3.33).Within(0.01));
        }

        [Test]
        public void TestSquareRootPositive()
        {
            //ACT + ASSERT
            Assert.That(() => calc.SquareRoot(25), Is.EqualTo(5));
        }
        [Test]
        public void TestSquareRootZero()
        {
            //ACT + ASSERT
            Assert.That(() => calc.SquareRoot(0), Is.EqualTo(0));
        }
        [Test]
        public void TestSquareRootNegative()
        {
            //ACT + ASSERT
            Assert.That(() => calc.SquareRoot(-25), Is.EqualTo(double.NaN));
        }

    }
}
