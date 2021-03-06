﻿using System;
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
        private List<Activity> allactivities;

        public ERPsystem()
        {
            allteachers = new List<Teacher>();
            allsubjects = new List<Subject>();
            allstudents = new List<Student>();
            allvans = new List<Van>();
            allactivities = new List<Activity>(); 
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
        public List<Van> showAvailableVans()
        {
            List<Van> Availables = new List<Van>();
            foreach (Van element in allvans)
                if (element.GetAvailability())
                    Availables.Add(element);
            Availables = Availables.OrderByDescending(o => o.GetCapacity()).ToList();
            return Availables;
        }
        public List<Activity> showallactivities()
        {
            return allactivities;
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
        public Teacher searchTeacher(string surname)
        {
            Teacher found = null;
            foreach (Teacher element in allteachers)
            {
                if (element.GetSurname().Equals(surname))
                    found = element;
            }
            return found;
        }
        public Van searchVan(int id)
        {
            Van found = null;
            foreach (Van element in allvans)
            {
                if (element.GetId().Equals(id))
                    found = element;
            }
            return found;
        }


        public void DeleteStudent(Student StudentToDelete)
        {
            if (allstudents.Contains(StudentToDelete))
            {
                foreach(Subject element in StudentToDelete.GetSubjects())
                {
                    searchSubject(element.GetCode()).GetStudents().Remove(StudentToDelete);
                }
                allstudents.Remove(StudentToDelete);
            }
        }
        public void DeleteTeacher(Teacher TeacherToDelete)
        {
            if (allteachers.Contains(TeacherToDelete))
            {
                foreach(Subject element in TeacherToDelete.GetSubjects())
                {
                    searchSubject(element.GetCode()).GetTeachers().Remove(TeacherToDelete);
                }
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
        public void DeleteVan(Van VanToDelete)
        {
            if (allvans.Contains(VanToDelete))
            {
                allvans.Remove(VanToDelete);
            }
        }
        public void DeleteActivity(Activity ActivityToDelete)
        {
            if (allactivities.Contains(ActivityToDelete))
            {
                allactivities.Remove(ActivityToDelete);
            }
        }
        public float distance(Student student)
        {
            return student.GetX() + student.GetY();
        }
        public List<Student> routeVan(Van van)
        {
            List<Student> roadmap = new List<Student>();
            if (van.GetAvailability())
            {             
                List<Student> closer = allstudents.OrderByDescending(o => distance(o)).ToList();
                int actualCapacity = van.GetCapacity();
                while (actualCapacity > 0)
                {
                    roadmap.Add(closer.First());
                    closer.Remove(closer.First());
                    actualCapacity--;
                }
            }
            return roadmap;
        }
        public List<List<Student>> routeAllVan()
        {
            List<List<Student>> allroadmaps = new List<List<Student>>();
            foreach (Van element in allvans)
                allroadmaps.Add(routeVan(element));
            return allroadmaps;
        }

        public Activity searchActivity(int id)
        {
            Activity found = null;
            foreach (Activity element in allactivities)
            {
                if (element.GetId().Equals(id))
                    found = element;
            }
            return found;
        }
        public ERPsystem LoadData()
        {
            ERPsystem mysystem = new ERPsystem();

            Student s1 = new Student(); s1.EditStudentName("s1"); s1.EditStudentSurname("s1"); s1.EditStudentNumber(1); s1.EditStudentidCard(1);
            Student s2 = new Student(); s2.EditStudentName("s2"); s2.EditStudentSurname("s2"); s2.EditStudentNumber(2); s2.EditStudentidCard(2);
            Student s3 = new Student(); s3.EditStudentName("s3"); s3.EditStudentSurname("s3"); s3.EditStudentNumber(3); s3.EditStudentidCard(3);
            Student s4 = new Student(); s4.EditStudentName("s4"); s4.EditStudentSurname("s4"); s4.EditStudentNumber(4); s4.EditStudentidCard(4);
            mysystem.showallstudents().Add(s1);
            mysystem.showallstudents().Add(s2);
            mysystem.showallstudents().Add(s3);
            mysystem.showallstudents().Add(s4);
            Teacher t1 = new Teacher(); t1.EditTeacherName("T1"); t1.EditTeacherSurname("T1");
            Teacher t2 = new Teacher(); t2.EditTeacherName("T2"); t2.EditTeacherSurname("T2");
            Teacher t3 = new Teacher(); t3.EditTeacherName("T3"); t3.EditTeacherSurname("T3");
            Teacher t4 = new Teacher(); t4.EditTeacherName("T4"); t4.EditTeacherSurname("T4");
            mysystem.showallteachers().Add(t1);
            mysystem.showallteachers().Add(t2);
            mysystem.showallteachers().Add(t3);
            mysystem.showallteachers().Add(t4);
            Subject sub1 = new Subject(); sub1.EditSubjectCode("sub1"); sub1.EditSubjectName("subject1"); sub1.SubjectAddStudent(s1); s1.GetSubjects().Add(sub1); sub1.SubjectAddTeacher(t1); t1.GetSubjects().Add(sub1);
            Subject sub2 = new Subject(); sub2.EditSubjectCode("sub2"); sub2.EditSubjectName("subject2"); sub2.SubjectAddStudent(s2); s2.GetSubjects().Add(sub2); sub2.SubjectAddTeacher(t2); t2.GetSubjects().Add(sub2);
            Subject sub3 = new Subject(); sub3.EditSubjectCode("sub3"); sub3.EditSubjectName("subject3"); sub3.SubjectAddStudent(s3); s3.GetSubjects().Add(sub3); sub3.SubjectAddTeacher(t3); t3.GetSubjects().Add(sub3);
            mysystem.showallsubjects().Add(sub1);
            mysystem.showallsubjects().Add(sub2);
            mysystem.showallsubjects().Add(sub3);
            Activity a1 = new Activity(); a1.EditActivityCost(1); a1.EditActivityDate(System.DateTime.Now); a1.EditActivityId(1); a1.EditActivityName("1");
            Activity a2 = new Activity(); a2.EditActivityCost(2); a2.EditActivityDate(System.DateTime.Now); a2.EditActivityId(2); a2.EditActivityName("2");
            Activity a3 = new Activity(); a3.EditActivityCost(3); a3.EditActivityDate(System.DateTime.Now); a3.EditActivityId(3); a3.EditActivityName("3");
            a1.GetStudents().Add(s1);
            a2.GetStudents().Add(s2);
            a3.GetStudents().Add(s3);
            mysystem.showallactivities().Add(a1);
            mysystem.showallactivities().Add(a2);
            mysystem.showallactivities().Add(a3);
            Van v1 = new Van(); v1.EditVanAvailability(true); v1.EditVanCapacity(1); v1.EditVanId(1); v1.EditVanName("1");
            Van v2 = new Van(); v2.EditVanAvailability(true); v2.EditVanCapacity(2); v2.EditVanId(2); v2.EditVanName("2");
            Van v3 = new Van(); v3.EditVanAvailability(true); v3.EditVanCapacity(3); v3.EditVanId(3); v3.EditVanName("3");
            mysystem.showallvans().Add(v1);
            mysystem.showallvans().Add(v2);
            mysystem.showallvans().Add(v3);

            return mysystem;
        }
    }
}
