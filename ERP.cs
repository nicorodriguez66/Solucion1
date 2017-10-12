using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion1
{
    public partial class ERP : Form
    {
        public ERP()
        {
            InitializeComponent();
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
        }

    private void BtnStudents_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            StudentGroupBox.Visible = true;
            StudentGroupBox.Location = new Point(ModulesGroupBox.Width + 15, ModulesGroupBox.Location.Y);
        }
        
        private void btnCreateStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            SubjectGroupBox.Visible = true;
            SubjectGroupBox.Location = new Point(ModulesGroupBox.Width+15, ModulesGroupBox.Location.Y);
            //SubjectGroupBox.BringToFront();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            TeacherGroupBox.Visible = true;
            TeacherGroupBox.Location = new Point(ModulesGroupBox.Width + 15, ModulesGroupBox.Location.Y);
        }

        private void btnVans_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            VanGroupBox.Visible = true;
            VanGroupBox.Location = new Point(ModulesGroupBox.Width + 15, ModulesGroupBox.Location.Y);
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            ActivityGroupBox.Visible = true;
            ActivityGroupBox.Location = new Point(ModulesGroupBox.Width + 15, ModulesGroupBox.Location.Y);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            hideallgrouboxes();
            PaymentGroupBox.Visible = true;
            PaymentGroupBox.Location = new Point(ModulesGroupBox.Width + 15, ModulesGroupBox.Location.Y);
        }
    }
}
