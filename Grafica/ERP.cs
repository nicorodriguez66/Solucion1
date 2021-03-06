﻿using System;
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
        private Teacher searchedTeacher;
        private Van searchedVan;
        private Activity searchedActivity;
        private Point DefaultPanelLocation;
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
            btnSubjectSearchModify1.Hide();
            btnDeleteSubject.Hide();
            button29.Hide();
            btnCreateNewTeacher.Hide();
            btnTeacherDelete1.Hide();
            btnTeacherModify1.Hide();
            textBox8.Hide();
            TeacherSubjectsListBox.Hide();
            btnVanCreate.Hide();
            btnVanModify1.Hide();
            btnVanDelete1.Hide();
            btnVanSearchDelete.Hide();
            btnVanSearchModify.Hide();
            VanList.Hide();
            VanAvailableCheckBox.Hide();
            btnActivitySearchDelete.Hide();
            btnActivityDelete1.Hide();
            btnActivitySearchModify.Hide();
            btnActivityModify1.Hide();
            ActivityStudentsGroupBox.Hide();
            PaymentCreateGroupBox.Hide();
            btnPaymentSearchDelete.Hide();
            btnPaymentSearchModify.Hide();
            btnDeletePayment1.Hide();
            btnModifyPayment1.Hide();
            btnCreateNewPayment.Hide();
            btnTeacherSearchModify.Hide();
            btnTeacherSearchDelete.Hide();
            btnCreateNewTeacher.Hide();
            btnCreateNewActivity.Hide();

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
            SubjectEnrolledStudentsListBox.Items.Clear();
            SubjectEnrolledTeachersListBox.Items.Clear();

            VanAvailableListBox1.Items.Clear();
            foreach (Van element in mysystem.showAvailableVans())
            {
                VanAvailableListBox1.Items.Add(element.ToString());
            }
            
            ActivityListBox.Items.Clear();
            foreach(Activity element in mysystem.showallactivities())
            {
                ActivityListBox.Items.Add(element.ToString());
            }
            comboBox1.Items.Clear();
            for (int i=1;i<=12;i++)
                comboBox1.Items.Add(i.ToString());
    
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

        

        private void button9_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            VanCreateGroupBox.Visible = true;
            VanCreateGroupBox.Location = DefaultPanelLocation;
            VanCreateGroupBox.Text = "Alta Camioneta";
            textBox14.Show(); textBox14.Text = "";
            textBox16.Show(); textBox16.Text = "";
            VanAvailableCheckBox.Show();
            btnVanCreate.Show();
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



        private void btnSubjectList_Click(object sender, EventArgs e)
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

        private void btnSubjectDelete_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            SubjectCreateGroupBox.Visible = true;
            SubjectCreateGroupBox.Location = DefaultPanelLocation;
            textBox12.Hide();
            SubjectStudentListBox.Hide();
            SubjectTeachersListBox.Hide();
            btnCreateNewSubject.Hide();
            btnSubjectSearch.Show();
            btnSubjectSearchModify.Hide();//
            btnDeleteSubject.Hide();
            SubjectCreateGroupBox.Text = "Baja Materia";
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
            textBox12.Hide();
            SubjectStudentListBox.Hide();
            SubjectTeachersListBox.Hide();
            btnCreateNewSubject.Hide();
            btnSubjectSearchModify1.Show();//
            btnSubjectSearch.Hide();
            btnDeleteSubject.Hide();
            SubjectCreateGroupBox.Text = "Modificar Materia";
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

        

        private void btnTeacherList_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            TeacherListGroupBox.Visible = true;
            TeacherListGroupBox.Location = DefaultPanelLocation;
            refreshdata();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            mysystem = mysystem.LoadData();
            hideallgrouboxes();
            refreshdata();

        }

        private void btnSubjectSearchModify1_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                searchedSubject = mysystem.searchSubject(textBox11.Text);
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
                    btnSubjectSearchModify1.Hide();
                    btnSubjectSearchModify.Show();
                }
            }
        }

        private void btnTeacherModify_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            TeacherCreateGroupBox.Visible = true;
            TeacherCreateGroupBox.Location = DefaultPanelLocation;
            btnTeacherSearchModify.Show();
            btnTeacherSearchDelete.Hide();
            TeacherCreateGroupBox.Text = "Modificar Docente";
            
        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            TeacherCreateGroupBox.Visible = true;
            TeacherCreateGroupBox.Location = DefaultPanelLocation;
            btnTeacherSearchModify.Hide();
            btnTeacherSearchDelete.Show();
            TeacherCreateGroupBox.Text = "Baja Docente";

        }

        private void btnTeacherDelete1_Click(object sender, EventArgs e)
        {
            if (searchedTeacher != null)
            {
                mysystem.DeleteTeacher(searchedTeacher);
                searchedStudent = null;

            }
            else
            {

            }
            hideallgrouboxes();
        }

        private void btnTeacherSearchModify_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                searchedTeacher = mysystem.searchTeacher(textBox7.Text);
                if (searchedTeacher == null)
                {
                    MessageBox.Show("No existe Docente");
                }
                else
                {
                    textBox8.Show(); textBox8.Text = searchedTeacher.GetName();

                    TeacherSubjectsListBox.Items.Clear();
                    foreach (Subject element in searchedTeacher.GetSubjects())
                    {
                        TeacherSubjectsListBox.Items.Add(element.ToString());
                    }
                    btnTeacherSearchModify.Hide();
                    btnTeacherModify1.Show();
                }
            }
        }

        private void btnTeacherSearchDelete_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                searchedTeacher = mysystem.searchTeacher(textBox7.Text);
                if (searchedTeacher == null)
                {
                    MessageBox.Show("No existe Docente");
                }
                else
                {
                    textBox8.Show(); textBox8.Text = searchedTeacher.GetName();

                    TeacherSubjectsListBox.Items.Clear();
                    foreach (Subject element in searchedTeacher.GetSubjects())
                    {
                        TeacherSubjectsListBox.Items.Add(element.ToString());
                    }
                    btnTeacherSearchDelete.Hide();
                    btnTeacherDelete1.Show();
                }
            }
        }

        private void btnTeacherModify1_Click(object sender, EventArgs e)
        {
            if (searchedTeacher != null)

            {
                searchedTeacher.EditTeacherName(textBox8.Text);
                searchedTeacher.EditTeacherSurname(textBox7.Text);
            }
            else
            {

            }
            hideallgrouboxes();
        }

        private void StudentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myString = StudentListBox.SelectedItem.ToString();
            string[] subStrings = myString.Split(' ');
            searchedStudent = mysystem.searchStudent(Int32.Parse(subStrings[2]));
            StudentSubjectsList.Items.Clear();
            foreach (Subject element in searchedStudent.GetSubjects())
            {
                StudentSubjectsList.Items.Add(element.ToString());
            }
        }

        private void SubjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string myString = SubjectListBox.SelectedItem.ToString();
            string[] subStrings = myString.Split(' ');
            searchedSubject = mysystem.searchSubject(subStrings[0]);
            SubjectEnrolledStudentsListBox.Items.Clear();
            foreach (Student element in searchedSubject.GetStudents())
            {
                SubjectEnrolledStudentsListBox.Items.Add(element.ToString());
            }
            SubjectEnrolledTeachersListBox.Items.Clear();
            foreach(Teacher element in searchedSubject.GetTeachers())
            {
                SubjectEnrolledTeachersListBox.Items.Add(element.ToString());
            }
        }

        private void TeacherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string myString = TeacherListBox.SelectedItem.ToString();
            string[] subStrings = myString.Split(' ');
            searchedTeacher= mysystem.searchTeacher(subStrings[1]);
            TeacherSubjectslistBox1.Items.Clear();
            foreach (Subject element in searchedTeacher.GetSubjects())
            {
                TeacherSubjectslistBox1.Items.Add(element.ToString());
            }
        }

        private void btnVanCreate_Click(object sender, EventArgs e)
        {
            Van createdVan = new Van();
            createdVan.EditVanCapacity(Int32.Parse(textBox14.Text)); textBox14.Text = "";
            createdVan.EditVanId(Int32.Parse(textBox13.Text)); textBox13.Text = "";
            createdVan.EditVanName(textBox16.Text); textBox16.Text = "";
            createdVan.EditVanAvailability(VanAvailableCheckBox.Checked);
            mysystem.showallvans().Add(createdVan);
            hideallgrouboxes();
        }

        private void btnVanUpdate_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            VanCreateGroupBox.Visible = true;
            VanCreateGroupBox.Location = DefaultPanelLocation;

            textBox16.Hide();
            textBox14.Hide();
            btnVanSearchModify.Show();
            
            VanCreateGroupBox.Text = "Modificar Camioneta";
        }

        private void btnVanSearchModify_Click(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                searchedVan = mysystem.searchVan(Int32.Parse(textBox13.Text));
                if (searchedVan == null)
                {
                    MessageBox.Show("No existe camioneta");
                }
                else
                {
                    textBox14.Show(); textBox14.Text = searchedVan.GetCapacity().ToString();
                    textBox16.Show(); textBox16.Text = searchedVan.GetName();
                    btnVanModify1.Show();
                    btnVanSearchModify.Hide();
                }
            }
        }

        private void btnVanSearchDelete_Click(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                searchedVan = mysystem.searchVan(Int32.Parse(textBox13.Text));
                if (searchedVan == null)
                {
                    MessageBox.Show("No existe camioneta");
                }
                else
                {
                    textBox14.Show(); textBox14.Text = searchedVan.GetCapacity().ToString();
                    textBox16.Show(); textBox16.Text = searchedVan.GetName();
                    btnVanDelete1.Show();
                    btnVanSearchDelete.Hide();
                }
            }
        }

        private void btnVanModify1_Click(object sender, EventArgs e)
        {
            if (searchedVan != null)
            {
                searchedVan.EditVanCapacity(Int32.Parse(textBox14.Text)); textBox14.Text = "";
                searchedVan.EditVanId(Int32.Parse(textBox13.Text)); textBox13.Text = "";
                searchedVan.EditVanName(textBox16.Text); textBox16.Text = "";
            }
            else
            {

            }
            hideallgrouboxes();
        }

        private void btnVanDelete1_Click(object sender, EventArgs e)
        {
            if (searchedVan != null)
            {
                mysystem.DeleteVan(searchedVan);
                searchedVan = null;
            }
            else
            {

            }
            hideallgrouboxes();
        }

        private void btnVanDelete_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            VanCreateGroupBox.Visible = true;
            VanCreateGroupBox.Location = DefaultPanelLocation;

            textBox16.Hide();
            textBox14.Hide();
            btnVanSearchDelete.Show();

            VanCreateGroupBox.Text = "Baja Camioneta";
        }

        private void btnAvailableVans_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            VanList.Visible = true;
            VanList.Location = DefaultPanelLocation;
            refreshdata();
        }

        private void btnCreateActivity_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            ActivityCreateGroupBox.Visible = true;
            ActivityCreateGroupBox.Location = DefaultPanelLocation;
            ActivityCreateGroupBox.Text = "Alta Actividad";
            textBox20.Show();
            textBox19.Show();
            dateTimePicker1.Show();
            textBox17.Show();
            btnCreateNewActivity.Show();
        }

        private void btnCreateNewActivity_Click(object sender, EventArgs e)
        {
            Activity createdActivity = new Activity();
            createdActivity.EditActivityName(textBox20.Text);
            createdActivity.EditActivityId(Int32.Parse(textBox19.Text));
            createdActivity.EditActivityDate(dateTimePicker1.Value);
            createdActivity.EditActivityCost(Int32.Parse(textBox17.Text));
            mysystem.showallactivities().Add(createdActivity);
            hideallgrouboxes();
        }

        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            ActivityCreateGroupBox.Visible = true;
            ActivityCreateGroupBox.Location = DefaultPanelLocation;

            textBox20.Hide();
            dateTimePicker1.Hide();
            textBox17.Hide();
            btnActivitySearchDelete.Show();

            ActivityCreateGroupBox.Text = "Baja Actividad";
        }

        private void btnActivityModify1_Click(object sender, EventArgs e)
        {
            if (searchedActivity != null)
            {

                searchedActivity.EditActivityName(textBox20.Text);
                searchedActivity.EditActivityId(Int32.Parse(textBox19.Text));
                searchedActivity.EditActivityDate(dateTimePicker1.Value);
                searchedActivity.EditActivityCost(Int32.Parse(textBox17.Text));
            }
            else
            {

            }
            hideallgrouboxes();
        }

        private void btnModifyActivity_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            ActivityCreateGroupBox.Visible = true;
            ActivityCreateGroupBox.Location = DefaultPanelLocation;

            textBox20.Hide();
            dateTimePicker1.Hide();
            textBox17.Hide();
            btnActivitySearchModify.Show();
            btnCreateNewActivity.Hide();
            
            ActivityCreateGroupBox.Text = "Modificar Actividad";
        }

        private void btnActivitySearchDelete_Click(object sender, EventArgs e)
        {
            if (textBox19.Text != "")
            {
                searchedActivity = mysystem.searchActivity(Int32.Parse(textBox19.Text));
                
                if (searchedActivity == null)
                {
                    MessageBox.Show("No existe actividad");
                }
                else
                {
                    btnActivityDelete1.Show();
                    btnActivitySearchDelete.Hide();
                }
            }
        }

        private void btnActivityDelete1_Click(object sender, EventArgs e)
        {
            if (searchedActivity != null)
            {
                mysystem.DeleteActivity(searchedActivity);
                searchedActivity = null;
            }
            else
            {

            }
            hideallgrouboxes();
        }

        private void btnActivitySearchModify_Click(object sender, EventArgs e)
        {
            if (textBox19.Text != "")
            {
                searchedActivity = mysystem.searchActivity(Int32.Parse(textBox19.Text));

                if (searchedActivity == null)
                {
                    MessageBox.Show("No existe actividad");
                }
                else
                {
                    textBox20.Show();
                    dateTimePicker1.Show();
                    textBox17.Show();
                    btnActivityModify1.Show();
                    btnActivitySearchModify.Hide();
                }
            }
        }

        private void btnActivityStudents_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            ActivityStudentsGroupBox.Visible = true;
            ActivityStudentsGroupBox.Location = DefaultPanelLocation;
            refreshdata();
        }

        private void ActivityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myString = ActivityListBox.SelectedItem.ToString();
            string[] subStrings = myString.Split(' ');
            searchedActivity = mysystem.searchActivity(Int32.Parse(subStrings[1]));
            ActivityStudentsListBox.Items.Clear();
            foreach (Student element in searchedActivity.GetStudents())
            {
                ActivityStudentsListBox.Items.Add(element.ToString());
            }
        }

        private void btnCreatePayment_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            PaymentCreateGroupBox.Visible = true;
            PaymentCreateGroupBox.Location = DefaultPanelLocation;
            PaymentCreateGroupBox.Text = "Alta Pago";
            textBox9.Show();
            comboBox1.Show();
            textBox5.Show();

            btnCreateNewPayment.Show();
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            PaymentCreateGroupBox.Visible = true;
            PaymentCreateGroupBox.Location = DefaultPanelLocation;
            PaymentCreateGroupBox.Text = "Baja Pago";

            textBox9.Hide();
            comboBox1.Hide();
            textBox5.Hide();

            btnPaymentSearchDelete.Show();
        }

        private void btnModifyPayment_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            PaymentCreateGroupBox.Visible = true;
            PaymentCreateGroupBox.Location = DefaultPanelLocation;
            PaymentCreateGroupBox.Text = "Modificar Pago";

            textBox9.Hide();
            comboBox1.Hide();
            textBox5.Hide();

            btnPaymentSearchModify.Show();
        }

        private void btnListPayment_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            PaymentCreateGroupBox.Visible = true;
            PaymentCreateGroupBox.Location = DefaultPanelLocation;
            PaymentCreateGroupBox.Text = "Listar Pago";
            refreshdata();
            
        }

        private void btnModifyPayment1_Click(object sender, EventArgs e)
        {
            btnModifyPayment1.Show();
            btnModifyPayment.Hide();
        }

        private void btnDeletePayment1_Click(object sender, EventArgs e)
        {
            btnDeletePayment1.Show();
            btnDeletePayment.Hide();
        }

        private void VanAvailableListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myString = VanAvailableListBox1.SelectedItem.ToString();
            string[] subStrings = myString.Split(' ');
            searchedVan = mysystem.searchVan(Int32.Parse(subStrings[1]));
            roadmapListBox.Items.Clear();
            foreach (Student element in mysystem.routeVan(searchedVan))
            {
                roadmapListBox.Items.Add(element.ToString());
            }
        }

        private void btnTeacherCreate_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            TeacherCreateGroupBox.Visible = true;
            TeacherCreateGroupBox.Location = DefaultPanelLocation;
            TeacherCreateGroupBox.Text = "Alta Docente";
            textBox8.Show();
            textBox7.Show();
            TeacherSubjectsListBox.Show();
            btnCreateNewTeacher.Show();
        }

        private void btnCreateNewTeacher_Click(object sender, EventArgs e)
        {
            Teacher createdTeacher = new Teacher();
            createdTeacher.EditTeacherName(textBox8.Text); textBox8.Text = "";
            createdTeacher.EditTeacherSurname(textBox7.Text); textBox7.Text = "";
            mysystem.showallteachers().Add(createdTeacher);
            hideallgrouboxes();
        }
    }
}
