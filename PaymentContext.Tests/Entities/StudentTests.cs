using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var name = new Name("Bruce", "Wayne");
            var document = new Document("03165674000", EDocumentType.CPF);
            var email = new Email("batman@balta.com");
            var student = new Student(name, document, email);

            Assert.Fail();
        }
        [TestMethod]
        public void ShouldReturnErrorWhenHasNoPayment()
        {
            var name = new Name("Bruce", "Wayne");
            var document = new Document("03165674000", EDocumentType.CPF);
            var email = new Email("batman@balta.com");
            var student = new Student(name, document, email);

            Assert.Fail();
        }
    }
}
