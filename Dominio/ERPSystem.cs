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
    }
}
