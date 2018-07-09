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
        [TestCase(1,2,3)]
        public void Add_WhenCalled_ReturnSumOfArguments(int a,int b ,int expectedResult)
        {
            var result = math.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(3,1,3)]
        [TestCase(1,3,3)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a,int b, int expectedResult)
        {
            var result = math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}