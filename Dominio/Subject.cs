<<<<<<< HEAD
﻿using System.Collections.Generic;

namespace Dominio
{
    public class Subject
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class subject
>>>>>>> f106a7e5ac171116453753bd5ef0f916f2bfde51
    {
        private string name { get; set; }
        private string code { get; set; }
        private List<Student> students;
        private List<Teacher> teachers;
<<<<<<< HEAD
        public Subject()
=======
        public subject()
>>>>>>> f106a7e5ac171116453753bd5ef0f916f2bfde51
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
<<<<<<< HEAD
}
=======
}
>>>>>>> f106a7e5ac171116453753bd5ef0f916f2bfde51
