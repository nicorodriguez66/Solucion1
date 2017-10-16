using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Teacher : person
    {
        public Teacher()
        {
            name = "";
            surname = "";
            subjects = new List<Subject>();
        }
        public void EditTeacherName(string NewName)
        {
            name = NewName;
        }
        public void EditTeacherSurname(string NewSurname)
        {
            surname = NewSurname;
        }
        public void DeleteTeacher()
        {

            //subjects.Clear();
        }
        public override string ToString()
        {
            return name + " " + surname;
        }
    }
}
