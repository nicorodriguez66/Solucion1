using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ERPsystem
    {
        private List<Teacher> allteachers;
        private List<Student> allstudents;
        private List<Subject> allsubjects;
        private List<Van> allvans;

        public ERPsystem()
        {
            allteachers = new List<Teacher>();
            allsubjects = new List<Subject>();
            allstudents = new List<Student>();
            allvans = new List<Van>();
        }
        public List<Teacher> showallteachers()
        {
            return allteachers;
        }
        public List<Student> showallstudents()
        {
            return allstudents;
        }
        public List<Subject> showallsubjects()
        {
            return allsubjects;
        }
        public List<Van> showallvans()
        {
            return allvans;
        }
        public Student searchStudent(int Number)
        {
            Student found = null;
            foreach (Student element in allstudents)
            {
                if (element.GetNumber().Equals(Number))
                    found = element;
            }
            return found;
        }
        public Subject searchSubject(string code)
        {
            Subject found = null;
            foreach (Subject element in allsubjects)
            {
                if (element.GetCode().Equals(code))
                    found = element;
            }
            return found;
        }


        public void DeleteStudent(Student StudentToDelete)
        {
            if (allstudents.Contains(StudentToDelete))
            {
                //StudentToDelete.ClearData();
                allstudents.Remove(StudentToDelete);
            }
        }
        public void DeleteTeacher(Teacher TeacherToDelete)
        {
            if (allteachers.Contains(TeacherToDelete))
            {
                //TeacherToDelete.ClearData();
                allteachers.Remove(TeacherToDelete);
            }
        }
        public void DeleteSubject(Subject SubjectToDelete)
        {
            if (allsubjects.Contains(SubjectToDelete))
            {
                allsubjects.Remove(SubjectToDelete);
            }
        }
    }
}
