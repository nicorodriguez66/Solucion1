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


        [TestMethod]
        public void StudentNameTest()
        {
            Student student = new Student();
            string NewName = "NewName";
            student.EditStudentName(NewName);
            Assert.AreEqual(NewName, student.GetName());
        }

    }
}
