namespace WindowsFormsApplication1
{
    partial class Form_AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Doctors = new System.Windows.Forms.Button();
            this.button_Diagnosis = new System.Windows.Forms.Button();
            this.button_Cases = new System.Windows.Forms.Button();
            this.button_Drugs = new System.Windows.Forms.Button();
            this.button_Patients = new System.Windows.Forms.Button();
            this.button_Users = new System.Windows.Forms.Button();
            this.button_LogOut = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Visits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Doctors
            // 
            this.button_Doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Doctors.Location = new System.Drawing.Point(242, 198);
            this.button_Doctors.Name = "button_Doctors";
            this.button_Doctors.Size = new System.Drawing.Size(181, 70);
            this.button_Doctors.TabIndex = 0;
            this.button_Doctors.Text = "Doktoři";
            this.button_Doctors.UseVisualStyleBackColor = true;
            this.button_Doctors.Click += new System.EventHandler(this.button_Doctors_Click);
            // 
            // button_Diagnosis
            // 
            this.button_Diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Diagnosis.Location = new System.Drawing.Point(13, 109);
            this.button_Diagnosis.Name = "button_Diagnosis";
            this.button_Diagnosis.Size = new System.Drawing.Size(181, 70);
            this.button_Diagnosis.TabIndex = 1;
            this.button_Diagnosis.Text = "Diagnózy";
            this.button_Diagnosis.UseVisualStyleBackColor = true;
            this.button_Diagnosis.Click += new System.EventHandler(this.button_Diagnosis_Click);
            // 
            // button_Cases
            // 
            this.button_Cases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Cases.Location = new System.Drawing.Point(13, 198);
            this.button_Cases.Name = "button_Cases";
            this.button_Cases.Size = new System.Drawing.Size(181, 70);
            this.button_Cases.TabIndex = 2;
            this.button_Cases.Text = "Případy";
            this.button_Cases.UseVisualStyleBackColor = true;
            this.button_Cases.Click += new System.EventHandler(this.button_Cases_Click);
            // 
            // button_Drugs
            // 
            this.button_Drugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Drugs.Location = new System.Drawing.Point(242, 13);
            this.button_Drugs.Name = "button_Drugs";
            this.button_Drugs.Size = new System.Drawing.Size(181, 70);
            this.button_Drugs.TabIndex = 3;
            this.button_Drugs.Text = "Léky";
            this.button_Drugs.UseVisualStyleBackColor = true;
            this.button_Drugs.Click += new System.EventHandler(this.button_Drugs_Click);
            // 
            // button_Patients
            // 
            this.button_Patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Patients.Location = new System.Drawing.Point(13, 13);
            this.button_Patients.Name = "button_Patients";
            this.button_Patients.Size = new System.Drawing.Size(181, 70);
            this.button_Patients.TabIndex = 4;
            this.button_Patients.Text = "Pacienti";
            this.button_Patients.UseVisualStyleBackColor = true;
            this.button_Patients.Click += new System.EventHandler(this.button_Patients_Click);
            // 
            // button_Users
            // 
            this.button_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Users.Location = new System.Drawing.Point(242, 109);
            this.button_Users.Name = "button_Users";
            this.button_Users.Size = new System.Drawing.Size(181, 70);
            this.button_Users.TabIndex = 5;
            this.button_Users.Text = "Uživatelé";
            this.button_Users.UseVisualStyleBackColor = true;
            this.button_Users.Click += new System.EventHandler(this.button_Users_Click);
            // 
            // button_LogOut
            // 
            this.button_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_LogOut.Location = new System.Drawing.Point(274, 295);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(125, 38);
            this.button_LogOut.TabIndex = 6;
            this.button_LogOut.Text = "Odhlásit se";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Cancel.Location = new System.Drawing.Point(298, 339);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(85, 38);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Zrušit";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Visits
            // 
            this.button_Visits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Visits.Location = new System.Drawing.Point(13, 295);
            this.button_Visits.Name = "button_Visits";
            this.button_Visits.Size = new System.Drawing.Size(181, 70);
            this.button_Visits.TabIndex = 8;
            this.button_Visits.Text = "Návštěvy";
            this.button_Visits.UseVisualStyleBackColor = true;
            this.button_Visits.Click += new System.EventHandler(this.button_Visits_Click);
            // 
            // Form_AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 382);
            this.Controls.Add(this.button_Visits);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_LogOut);
            this.Controls.Add(this.button_Users);
            this.Controls.Add(this.button_Patients);
            this.Controls.Add(this.button_Drugs);
            this.Controls.Add(this.button_Cases);
            this.Controls.Add(this.button_Diagnosis);
            this.Controls.Add(this.button_Doctors);
            this.Name = "Form_AdminPanel";
            this.Text = "Form_AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Doctors;
        private System.Windows.Forms.Button button_Diagnosis;
        private System.Windows.Forms.Button button_Cases;
        private System.Windows.Forms.Button button_Drugs;
        private System.Windows.Forms.Button button_Patients;
        private System.Windows.Forms.Button button_Users;
        private System.Windows.Forms.Button button_LogOut;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Visits;
    }
}