using System;
using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class MathTests
    {
        private Math math;

        [SetUp]
        public void SetUp()
        {
            math = new Math();
        }
        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_WhenABiggerThanB_ReturnA()
        {
            var result = math.Max(3, 1);            
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_WhenBBiggerThanA_ReturnB()
        {
            var result = math.Max(1, 3);
            Assert.That(result,Is.EqualTo(3));
        }

        [Test]
        public void Max_WhenArgumentsAreEqual_ReturnSameArgument()
        {
            var result = math.Max(3, 3);
            Assert.That(result,Is.EqualTo(3));
        }
    }
}