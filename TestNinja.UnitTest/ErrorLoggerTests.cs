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

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };
            
            logger.Log("a");
            Assert.That(id,Is.Not.EqualTo(Guid.Empty));
        }
    }
}