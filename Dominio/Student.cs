using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Student:person
    {

        private int number { set; get; }
        private int idcard { set; get; }
        private float x { set; get; }
        private float y { set; get; }
        //private List<payment> payments { set; get; }
        public Student()
        {
            name = "";
            surname = "";
            //subjects = null;
            number = 0;
            idcard = 0;
            x = 0;
            y = 0;
            //payments = null;
        }

        public string GetName()
        {
            return name;
        }

        public void EditStudentName(string newName)
        {
            name=newName;
        }

        public void EditStudentSurname(string newSurname)
        {
            surname = newSurname;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void EditStudentNumber(int newNumber)
        {
            number=newNumber;
        }

        public int GetNumber()
        {
            return number;
        }

        public void EditStudentidCard(int newidCard)
        {
            idcard=newidCard;
        }

        public int GetidCard()
        {
            return idcard;
        }

        public void EditStudentXY(float newX, float newY)
        {
            throw new NotImplementedException();
        }

        public float GetX()
        {
            throw new NotImplementedException();
        }

        public float GetY()
        {
            throw new NotImplementedException();
        }
    }
}
