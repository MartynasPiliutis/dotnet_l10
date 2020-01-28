using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinessLogicLayer;

namespace CRMBusinessLogicLayer.Test
{
    [TestClass]
    public class CRMUnitTest
    {
        [TestMethod]
        public void TestuojaArTeisingaiIsvedaFullName()
        {
            Customer klientas = new Customer();
            klientas.FirstName = "Vardenis";
            klientas.LastName = "Pavardenis";
            string vartotojas = klientas.FullName;
            Assert.AreEqual(vartotojas, "Pavardenis,Vardenis");
        }
        [TestMethod]
        public void TestuojaArTeisingaiIsvedaFullNameKaineraIvestaPavarde()
        {
            Customer klientas = new Customer();
            klientas.FirstName = "Vardenis";
            klientas.LastName = "";
            string vartotojas = klientas.FullName;
            Assert.AreEqual(vartotojas, "Vardenis");
        }
        [TestMethod]
        public void TestuojaArTeisingaiIsvedaFullNameKaineraIvestasVardas()
        {
            Customer klientas = new Customer();
            klientas.FirstName = "";
            klientas.LastName = "Pavardenis";
            string vartotojas = klientas.FullName;
            Assert.AreEqual(vartotojas, "Pavardenis");
        }
    }
}
