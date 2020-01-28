using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinessLogicLayer;

namespace CRMBusinessLogicLayer.Test
{
    [TestClass]
    public class CustomerReopositoryTests
    {
        [TestMethod]
        public void RetrieveValid()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expected = new Customer(1);
            expected.EmailAdress = "vardas.pavarde@mail.com";
            expected.FirstName = "Vardas";
            expected.LastName = "Pavarde";

            Customer actual = customerRepository.Retrieve(1);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
    }
}
