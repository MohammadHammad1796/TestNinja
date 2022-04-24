using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _customerController;

        [SetUp]
        public void SetUp()
        {
            _customerController = new CustomerController();
        }
        
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = _customerController.GetCustomer(0);
            
            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());
        }
        
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var result = _customerController.GetCustomer(1);
            
            // Ok or one of it's derivatives
            Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}