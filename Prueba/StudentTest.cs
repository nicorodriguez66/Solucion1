﻿using System;
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

        [TestMethod]
        public void StudentSurnameTest()
        {
            Student student = new Student();
            string NewSurname = "NewSurame";
            student.EditStudentSurname(NewSurname);
            Assert.AreEqual(NewSurname, student.GetSurname());
        }

        [TestMethod]
        public void StudentNumberTest()
        {
            Student student = new Student();
            int NewNumber = 123;
            student.EditStudentNumber(NewNumber);
            Assert.AreEqual(NewNumber, student.GetNumber());
        }

        [TestMethod]
        public void StudentidCardTest()
        {
            Student student = new Student();
            int NewidCard = 123;
            student.EditStudentidCard(NewidCard);
            Assert.AreEqual(NewidCard, student.GetidCard());
        }


        [TestMethod]
        public void StudentXYTest()
        {
            Student student = new Student();
            float newX = 1;
            float newY = 2;
<<<<<<< HEAD
            student.EditStudentXY(newX, newY);
=======
            student.EditStudentXY(newX,newY);
>>>>>>> f106a7e5ac171116453753bd5ef0f916f2bfde51
            Assert.AreEqual(newX, student.GetX());
            Assert.AreEqual(newY, student.GetY());
        }
        [TestMethod]
        public void StudentToStringTest()
        {
            Student student = new Student();
            string NewName = "NewName";
            string NewSurname = "NewSurName";
            int NewNumber = 123;
            student.EditStudentName(NewName);
            student.EditStudentSurname(NewSurname);
            student.EditStudentNumber(NewNumber);
            string NewString = NewName + " " + NewSurname + " " + NewNumber;
            Assert.AreEqual(NewString, student.ToString());
        }
<<<<<<< HEAD
        
=======



>>>>>>> f106a7e5ac171116453753bd5ef0f916f2bfde51
    }
}
