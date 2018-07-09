using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_SurroundedWithStrongTag()
        {
            HtmlFormatter htmlFormatter = new HtmlFormatter();
            var result = htmlFormatter.FormatAsBold("abc");
            
            // Specific
            Assert.That(result,Is.EqualTo("<strong>abc</strong>"));
            
            // General
            Assert.That(result,Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result,Does.EndWith("</strong>"));
            Assert.That(result,Does.Contain("abc"));
        }
    }
}