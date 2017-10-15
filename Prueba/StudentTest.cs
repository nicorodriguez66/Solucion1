using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
namespace Prueba
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentBuilderTest()
        {
            Student student = new Student();
            Assert.AreNotEqual(student, null);
        }
    }
}
