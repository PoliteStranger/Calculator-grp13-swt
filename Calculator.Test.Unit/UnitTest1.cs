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
        public void TestAdd()
        {
            //ACT + ASSERT LAMBDA
            Assert.That(() => calc.Add(2, 2), Is.EqualTo(4));
        }

        [Test]
        public void TestAdd_negativeNumber()
        {
            //ACT + ASSERT LAMBDA
            Assert.That(()=>calc.Add(2,-4), Is.EqualTo(-2));
        }

        [Test]
        public void TestAdd_doubleNegativeNumber()
        {
            //ACT + ASSERT LAMBDA
            Assert.That(() => calc.Add(-2, -4), Is.EqualTo(-6));
        }

        [Test]
        public void TestSubtract()
        {
            //ACT
            double a = calc.Subtract(4, 2);

            //ASSERT
            Assert.That(a, Is.EqualTo(2));
        }

        [Test]
        public void TestSubtract_negativeNumber()
        {
            //ACT
            double a = calc.Subtract(4, -2);

            //ASSERT
            Assert.That(a, Is.EqualTo(6));
        }

        [Test]
        public void TestSubtract_doubleNegativeNumber()
        {
            //ACT
            double a = calc.Subtract(-4, -2);

            //ASSERT
            Assert.That(a, Is.EqualTo(-2));
        }

        [Test]
        public void TestMultiply()
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
        public void TestPower()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Power(2, 3), Is.EqualTo(8));
        }

        [Test]
        public void TestPowerB()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Power(3, 4), Is.EqualTo(81));
        }

        [Test]
        public void TestPowerC()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Power(2, 5), Is.EqualTo(32));
        }

        [Test]
        public void TestNegativeExpPower()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Power(2, -2), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void TestDivideA()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Devide(8, 2), Is.EqualTo(4));
        }

        [Test]
        public void TestDivideB()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Devide(10, 2), Is.EqualTo(5));
        }

        [Test]
        public void TestDivideC()
        {
            //ACT + ASSERT
            Assert.That(() => calc.Devide(10, 3), Is.EqualTo(3.33));
        }
    }
}