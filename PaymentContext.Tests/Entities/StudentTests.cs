﻿using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Teste", "Teste");
            foreach(var not in name.Notifications)
            {
                Console.WriteLine($"{not.Key}: {not.Message}");
            }
        }
    }
}
