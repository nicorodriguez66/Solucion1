using System.Collections.Generic;

namespace Dominio
{
    public class Subject
    {
        private string name { get; set; }
        private string code { get; set; }
        private List<Student> students;
        private List<Teacher> teachers;
        public Subject()
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