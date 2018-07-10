using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_idIsZero_ReturnNotFound()
        {
            CustomerController customerController = new CustomerController();
            var result = customerController.GetCustomer(0);
            
            // NotFound
            Assert.That(result,Is.TypeOf<NotFound>());
            
            // NotFound or one of its derivatives
            Assert.That(result,Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            CustomerController customerController = new CustomerController();
            var result = customerController.GetCustomer(1);
            
            Assert.That(result,Is.TypeOf<Ok>());
            
        }
    }
}