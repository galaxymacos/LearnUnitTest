using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        DemeritPointsCalculator demeritPointsCalculator;

        [SetUp]
        public void SetUp()
        {
            demeritPointsCalculator = new DemeritPointsCalculator();
        }
        
        [Test]
        [TestCase(-1)]
        [TestCase(360)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            Assert.That(()=>demeritPointsCalculator.CalculateDemeritPoints(speed),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase()]
        public void CalculateDemeritPoints_SpeedLowerThanSpeedLimit_Return0()
        {
            var result = demeritPointsCalculator.CalculateDemeritPoints(30);
            Assert.That(result,Is.EqualTo(0));
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed,int expectedResult)
        {
            var result = demeritPointsCalculator.CalculateDemeritPoints(speed);
            Assert.That(result,Is.EqualTo(expectedResult));
        }

    }
}