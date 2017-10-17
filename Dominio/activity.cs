using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Activity : payment
    {
        private string name;
        private int id;
        private DateTime date;
        private int cost;
        private List<Student> students;


        public Activity()
        {
            name = "";
            id = -1;
            date = System.DateTime.Now;
            cost = 0;
            students = new List<Student>();
        }

        public void EditActivityName(string NewName)
        {
            name = NewName;
        }
        public void EditActivityId(int NewId)
        {
            id = NewId;
        }
        public void EditActivityDate(DateTime NewDate)
        {
            date= NewDate;
        }
        public void EditActivityCost(int NewCost)
        {
            cost = NewCost;
        }
        public int GetId()
        {
            return id;
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public void DeleteActivity()
        {
            students.Clear();
        }
        public override string ToString()
        {
            return name + " " + id;
        }
        public override void pay()
        {
            throw new NotImplementedException();
        }
    }
}
