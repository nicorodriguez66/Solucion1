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
        
        public Student()
        {
            name = "";
            surname = "";            
            number = 0;
            idcard = 0;
            x = 0;
            y = 0;
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
            x=newX;
            y = newY;
        }

        public float GetX()
        {
            return x;
        }

        public float GetY()
        {
            return y;
        }
        public override string ToString()
        {
            return name+ " " + surname + " " + number;
        }
    }
}
