using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            students = new List<Student>();
            teachers = new List<Teacher>();
            name = "empty";
            code = "-1";
        }
        public void EditSubjectName(string NewName)
        {
            name = NewName;
        }
        public void EditSubjectCode(string NewCode)
        {
            code = NewCode;
        }
        public void SubjectAddStudent(Student NewStudent)
        {
            if (!SubjectStudentExists(NewStudent))
                students.Add(NewStudent);
        }
        public bool SubjectStudentExists(Student NewStudent)
        {
            return students.Contains(NewStudent);
        }
        public void SubjectAddTeacher(Teacher NewTeacher)
        {
            if (!SubjectTeacherExists(NewTeacher))
                teachers.Add(NewTeacher);
        }
        public bool SubjectTeacherExists(Teacher NewTeacher)
        {
            return teachers.Contains(NewTeacher);
        }
        public void DeleteSubject()
        {
            students.Clear();
            teachers.Clear();
        }
        public override string ToString()
        {
            return code + " " + name;
        }
        public string GetCode()
        {
            return code;
        }
        public string GetName()
        {
            return name;
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public List<Teacher> GetTeachers()
        {
            return teachers;
        }
    }
}
