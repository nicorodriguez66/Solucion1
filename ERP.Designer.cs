namespace Solucion1
{
    partial class ERP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnActivity = new System.Windows.Forms.Button();
            this.btnVans = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.BtnStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnPayments);
            this.splitContainer1.Panel1.Controls.Add(this.btnActivity);
            this.splitContainer1.Panel1.Controls.Add(this.btnVans);
            this.splitContainer1.Panel1.Controls.Add(this.btnTeachers);
            this.splitContainer1.Panel1.Controls.Add(this.btnSubjects);
            this.splitContainer1.Panel1.Controls.Add(this.BtnStudents);
            this.splitContainer1.Size = new System.Drawing.Size(622, 342);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(93, 82);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(75, 23);
            this.btnPayments.TabIndex = 5;
            this.btnPayments.Text = "Pagos";
            this.btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnActivity
            // 
            this.btnActivity.Location = new System.Drawing.Point(12, 82);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(75, 23);
            this.btnActivity.TabIndex = 4;
            this.btnActivity.Text = "Actividades";
            this.btnActivity.UseVisualStyleBackColor = true;
            // 
            // btnVans
            // 
            this.btnVans.Location = new System.Drawing.Point(93, 53);
            this.btnVans.Name = "btnVans";
            this.btnVans.Size = new System.Drawing.Size(75, 23);
            this.btnVans.TabIndex = 3;
            this.btnVans.Text = "Camionetas";
            this.btnVans.UseVisualStyleBackColor = true;
            // 
            // btnTeachers
            // 
            this.btnTeachers.Location = new System.Drawing.Point(12, 53);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(75, 23);
            this.btnTeachers.TabIndex = 2;
            this.btnTeachers.Text = "Profesores";
            this.btnTeachers.UseVisualStyleBackColor = true;
            // 
            // btnSubjects
            // 
            this.btnSubjects.Location = new System.Drawing.Point(93, 24);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(75, 23);
            this.btnSubjects.TabIndex = 1;
            this.btnSubjects.Text = "Materias";
            this.btnSubjects.UseVisualStyleBackColor = true;
            // 
            // BtnStudents
            // 
            this.BtnStudents.Location = new System.Drawing.Point(12, 24);
            this.BtnStudents.Name = "BtnStudents";
            this.BtnStudents.Size = new System.Drawing.Size(75, 23);
            this.BtnStudents.TabIndex = 0;
            this.BtnStudents.Text = "Alumnos";
            this.BtnStudents.UseVisualStyleBackColor = true;
            // 
            // ERP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 342);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ERP";
            this.Text = "ERP";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnActivity;
        private System.Windows.Forms.Button btnVans;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button BtnStudents;
    }
}

