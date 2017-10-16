using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
namespace Solucion1
{
    public partial class ERP : Form
    {
        private ERPsystem mysystem;
        private Student searchedStudent;
        private Subject searchedSubject;
        Point DefaultPanelLocation;
        public ERP()
        {
            InitializeComponent();
            DefaultPanelLocation.X = ModulesGroupBox.Width + 15;
            DefaultPanelLocation.Y = ModulesGroupBox.Location.Y;
            mysystem = new ERPsystem();
            hideallgrouboxes();
        }

        private void hideallgrouboxes()
        {
            StudentGroupBox.Visible = false;
            TeacherGroupBox.Visible = false;
            VanGroupBox.Visible = false;
            SubjectGroupBox.Visible = false;
            ActivityGroupBox.Visible = false;
            PaymentGroupBox.Visible = false;
            StudentCreatGroupBox.Visible = false;
            StudentModifyGroupBox.Visible = false;
            StudentListGroupBox.Visible = false;
            TeacherCreateGroupBox.Visible = false;
            SubjectCreateGroupBox.Visible = false;
            VanCreateGroupBox.Visible = false;
            ActivityCreateGroupBox.Visible = false;
            SubjectListGroupBox.Visible = false;
            TeacherListGroupBox.Visible = false;
            btnSubjectSearch.Hide();
            btnSubjectSearchModify.Hide();
            btnDeleteSubject.Hide();
            button29.Hide();
        }

        public void refreshdata()
        {
            StudentListBox.Items.Clear();
            foreach (Student element in mysystem.showallstudents())
            {
                StudentListBox.Items.Add(element.ToString());
            }
            SubjectStudentListBox.Items.Clear();
            foreach (Student element in mysystem.showallstudents())
            {
                SubjectStudentListBox.Items.Add(element.ToString());
            }
            SubjectTeachersListBox.Items.Clear();
            foreach (Teacher element in mysystem.showallteachers())
            {
                SubjectTeachersListBox.Items.Add(element.ToString());
            }
            SubjectListBox.Items.Clear();
            foreach(Subject element in mysystem.showallsubjects())
            {
                SubjectListBox.Items.Add(element.ToString());
            }
            TeacherListBox.Items.Clear();
            foreach(Teacher element in mysystem.showallteachers())
            {
                TeacherListBox.Items.Add(element.ToString());
            }
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            StudentGroupBox.Visible = true;
            StudentGroupBox.Location = DefaultPanelLocation;
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            StudentCreatGroupBox.Visible = true;
            StudentCreatGroupBox.Location = DefaultPanelLocation;
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            StudentModifyGroupBox.Visible = true;
            StudentModifyGroupBox.Location = DefaultPanelLocation;
            StudentModifyGroupBox.Text = "Baja Alumno";
            textBox1.Hide();
            textBox3.Hide();
            textBox4.Hide();
            button26.Hide();
            btnStudentSearchModify.Hide();
            btnStudentSearch.Show();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            StudentListGroupBox.Visible = true;
            StudentListGroupBox.Location = DefaultPanelLocation;
            refreshdata();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            StudentModifyGroupBox.Visible = true;
            StudentModifyGroupBox.Location = DefaultPanelLocation;
            textBox1.Hide();
            textBox3.Hide();
            textBox4.Hide();
            button26.Hide();
            btnStudentSearch.Hide();
            btnStudentSearchModify.Show();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            SubjectGroupBox.Visible = true;
            SubjectGroupBox.Location = DefaultPanelLocation;

        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            TeacherGroupBox.Visible = true;
            TeacherGroupBox.Location = DefaultPanelLocation;
        }

        private void btnVans_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            VanGroupBox.Visible = true;
            VanGroupBox.Location = DefaultPanelLocation;
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            ActivityGroupBox.Visible = true;
            ActivityGroupBox.Location = DefaultPanelLocation;
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            PaymentGroupBox.Visible = true;
            PaymentGroupBox.Location = DefaultPanelLocation;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            TeacherCreateGroupBox.Visible = true;
            TeacherCreateGroupBox.Location = DefaultPanelLocation;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            VanCreateGroupBox.Visible = true;
            VanCreateGroupBox.Location = DefaultPanelLocation;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            ActivityCreateGroupBox.Visible = true;
            ActivityCreateGroupBox.Location = DefaultPanelLocation;
        }

        private void CreateStudent_Click(object sender, EventArgs e)
        {
            Student createdStudent = new Student();
            createdStudent.EditStudentName (studentNameTxtBox.Text); studentNameTxtBox.Text = "";
            createdStudent.EditStudentSurname(studentSurnameTxtBox.Text); studentSurnameTxtBox.Text = "";
            createdStudent.EditStudentNumber(Int32.Parse(studentNumberTxtBox.Text)); studentNumberTxtBox.Text = "";
            createdStudent.EditStudentidCard(Int32.Parse(studentIdCardTxtBox.Text)); studentIdCardTxtBox.Text = "";
            mysystem.showallstudents().Add(createdStudent);
            hideallgrouboxes();
          }

        private void btnStudentSearchModify_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!="")
            {
                searchedStudent = mysystem.searchStudent(Int32.Parse(textBox2.Text));
                if (searchedStudent == null)
                {
                    MessageBox.Show("No existe estudiante");
                }
                else
                {
                    textBox1.Show(); textBox1.Text = searchedStudent.GetidCard().ToString();
                    textBox3.Show(); textBox3.Text = searchedStudent.GetSurname();
                    textBox4.Show(); textBox4.Text = searchedStudent.GetName();
                    button26.Show();
                    btnStudentSearchModify.Hide();
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if(searchedStudent != null)
            {
                searchedStudent.EditStudentName(textBox4.Text);
                searchedStudent.EditStudentSurname(textBox3.Text);
                searchedStudent.EditStudentNumber(Int32.Parse(textBox2.Text));
                searchedStudent.EditStudentidCard(Int32.Parse(textBox1.Text));
            }
            else
            {
                
            }
            hideallgrouboxes();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                searchedStudent = mysystem.searchStudent(Int32.Parse(textBox2.Text));
                if (searchedStudent == null)
                {
                    MessageBox.Show("No existe estudiante");
                }
                else
                {
                    button29.Show();
                    btnStudentSearch.Hide();
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (searchedStudent!= null)
            {
                mysystem.DeleteStudent(searchedStudent);
                searchedStudent = null;
                
            }
            else
            {

            }
            hideallgrouboxes();
        }

        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            
        }



        private void button3_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            SubjectListGroupBox.Visible = true;
            SubjectListGroupBox.Location = DefaultPanelLocation;
            refreshdata();
        }

        private void btnSubjectSearch_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                searchedSubject= mysystem.searchSubject(textBox11.Text);
                if (searchedSubject == null)
                {
                    MessageBox.Show("No existe Materia");
                }
                else
                {

                    textBox12.Show(); textBox12.Text = searchedSubject.GetName();
                    SubjectStudentListBox.Items.Clear();
                    foreach (Student element in searchedSubject.GetStudents())
                    {
                        SubjectStudentListBox.Items.Add(element.ToString());
                    }
                    SubjectTeachersListBox.Items.Clear();
                    foreach (Teacher element in searchedSubject.GetTeachers())
                    {
                        SubjectTeachersListBox.Items.Add(element.ToString());
                    }
                    btnSubjectSearch.Hide();
                    btnDeleteSubject.Show();
                }
            }
        }

        private void btnCreateSubject_Click_1(object sender, EventArgs e)
        {
            hideallgrouboxes();
            SubjectCreateGroupBox.Visible = true;
            SubjectCreateGroupBox.Location = DefaultPanelLocation;
            SubjectStudentListBox.Show();
            SubjectTeachersListBox.Show();
            textBox12.Show();
            refreshdata();
        }

        private void btnCreateNewSubject_Click_1(object sender, EventArgs e)
        {
            Subject createdSubject = new Subject();
            createdSubject.EditSubjectCode(textBox11.Text); textBox11.Text = "";
            createdSubject.EditSubjectName(textBox12.Text); textBox12.Text = "";
            mysystem.showallsubjects().Add(createdSubject);
            hideallgrouboxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            SubjectCreateGroupBox.Visible = true;
            SubjectCreateGroupBox.Location = DefaultPanelLocation;
            SubjectCreateGroupBox.Text = "Baja Materia";
            textBox12.Hide();
            SubjectStudentListBox.Hide();
            SubjectTeachersListBox.Hide();
            btnCreateNewSubject.Hide();
            btnSubjectSearch.Show();
            btnDeleteSubject.Hide();
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (searchedSubject != null)
            {
                mysystem.DeleteSubject(searchedSubject);
                searchedSubject = null;
            }
            else
            {

            }
            hideallgrouboxes();
        }

        private void btnSubjectModify_Click(object sender, EventArgs e)
        {
            
            hideallgrouboxes();
            SubjectCreateGroupBox.Visible = true;
            SubjectCreateGroupBox.Location = DefaultPanelLocation;
            SubjectCreateGroupBox.Text = "Modificar Materia";
            /*
            textBox12.Hide();
            SubjectStudentListBox.Hide();
            SubjectTeachersListBox.Hide();
            btnCreateNewSubject.Hide();
            btnSubjectSearch.Show();
            btnDeleteSubject.Hide();
            */
        }

        private void btnSubjectSearchModify_Click(object sender, EventArgs e)
        {
            if (searchedSubject!=null)
            
            {
                searchedSubject.EditSubjectName(textBox12.Text);
                searchedSubject.EditSubjectCode(textBox11.Text);
            }
            else
            {

            }
            hideallgrouboxes();
        }

        private void btnCreateTeacher_Click(object sender, EventArgs e)
        {
            Teacher createdTeacher = new Teacher();
            createdTeacher.EditTeacherName(textBox8.Text); textBox8.Text = "";
            createdTeacher.EditTeacherSurname(textBox7.Text); textBox7.Text = "";
            mysystem.showallteachers().Add(createdTeacher);
            hideallgrouboxes();
        }

        private void btnTeacherList_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            TeacherListGroupBox.Visible = true;
            TeacherListGroupBox.Location = DefaultPanelLocation;
            refreshdata();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
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
            Subject sub1 = new Subject(); sub1.EditSubjectCode("sub1"); sub1.EditSubjectName("subject1"); sub1.SubjectAddStudent(s1); sub1.SubjectAddTeacher(t1);
            Subject sub2 = new Subject(); sub2.EditSubjectCode("sub2"); sub2.EditSubjectName("subject2"); sub2.SubjectAddStudent(s2); sub2.SubjectAddTeacher(t2);
            Subject sub3 = new Subject(); sub3.EditSubjectCode("sub3"); sub3.EditSubjectName("subject3"); sub3.SubjectAddStudent(s3); sub3.SubjectAddTeacher(t3);
        }
    }
}
