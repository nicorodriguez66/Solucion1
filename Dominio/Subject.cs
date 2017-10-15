using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class subject
    {
        private string name { get; set; }
        private string code { get; set; }
        private List<Student> students;
        private List<Teacher> teachers;
        public subject()
        {
            students = null;
            teachers = null;
            name = "empty";
            code = "-1";
        }
        public void EditSubject()
        {

        }
        public void DeleteSubject()
        {
            students.Clear();
            teachers.Clear();
        }

    }
}
