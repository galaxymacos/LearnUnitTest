using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");
            Assert.That(logger.LastError,Is.EqualTo("a"));
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        [Test]
        public void Log_InvalidError_ThrowArgumentNullException(string errorMessage)
        {
            var logger = new ErrorLogger();
//            Assert.That(()=>logger.Log(errorMessage),Throws.ArgumentNullException);
            Assert.That(()=>logger.Log(errorMessage),Throws.TypeOf<ArgumentNullException>());
            
        }
    }
}