using System;
using System.Linq;
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
//        [Ignore("because I wanted to")]
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

        [Test]
        public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = math.GetOddNumbers(5);
//            Assert.That(odds,Is.Not.Empty);
//            Assert.That(result.Count(), Is.EqualTo(3));
//            Assert.That(result.Contains(1));
//            Assert.That(result.Contains(3));
//            Assert.That(result.Contains(5));
            Assert.That(result,Is.EquivalentTo(new []{1,3,5}));
            
//            Assert.That(result,Is.Ordered);
//            Assert.That(result,Is.Unique);
        }
    }
}