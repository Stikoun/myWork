namespace WindowsFormsApplication1
{
    partial class Form_AddCase
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
            this.components = new System.ComponentModel.Container();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.comboBox_Doctors = new System.Windows.Forms.ComboBox();
            this.comboBox_Patients = new System.Windows.Forms.ComboBox();
            this.comboBox_Diagnosis = new System.Windows.Forms.ComboBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_DiagnosisCategory = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2_Drugs = new System.Windows.Forms.DataGridView();
            this.dataGridView_Visits = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_AddVisit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Drugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Visits)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Cancel.Location = new System.Drawing.Point(76, 302);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(142, 45);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "Zrušit";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_OK.Location = new System.Drawing.Point(76, 226);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(142, 45);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // comboBox_Doctors
            // 
            this.comboBox_Doctors.FormattingEnabled = true;
            this.comboBox_Doctors.Location = new System.Drawing.Point(91, 101);
            this.comboBox_Doctors.Name = "comboBox_Doctors";
            this.comboBox_Doctors.Size = new System.Drawing.Size(158, 21);
            this.comboBox_Doctors.TabIndex = 11;
            // 
            // comboBox_Patients
            // 
            this.comboBox_Patients.FormattingEnabled = true;
            this.comboBox_Patients.Location = new System.Drawing.Point(91, 151);
            this.comboBox_Patients.Name = "comboBox_Patients";
            this.comboBox_Patients.Size = new System.Drawing.Size(158, 21);
            this.comboBox_Patients.TabIndex = 12;
            // 
            // comboBox_Diagnosis
            // 
            this.comboBox_Diagnosis.FormattingEnabled = true;
            this.comboBox_Diagnosis.Location = new System.Drawing.Point(91, 57);
            this.comboBox_Diagnosis.Name = "comboBox_Diagnosis";
            this.comboBox_Diagnosis.Size = new System.Drawing.Size(209, 21);
            this.comboBox_Diagnosis.TabIndex = 13;
            this.comboBox_Diagnosis.SelectedIndexChanged += new System.EventHandler(this.comboBox_Diagnosis_SelectedIndexChanged);
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(341, 201);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(321, 178);
            this.textBox_Description.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doktor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pacient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(460, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Popis";
            // 
            // comboBox_DiagnosisCategory
            // 
            this.comboBox_DiagnosisCategory.FormattingEnabled = true;
            this.comboBox_DiagnosisCategory.Location = new System.Drawing.Point(91, 15);
            this.comboBox_DiagnosisCategory.Name = "comboBox_DiagnosisCategory";
            this.comboBox_DiagnosisCategory.Size = new System.Drawing.Size(209, 21);
            this.comboBox_DiagnosisCategory.TabIndex = 21;
            this.comboBox_DiagnosisCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_DiagnosisCategory_SelectedIndexChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(95, 49);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(154, 20);
            this.textBox_Name.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(4, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kategorie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(24, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Název";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Název";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox_Diagnosis);
            this.panel1.Controls.Add(this.comboBox_DiagnosisCategory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(341, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 100);
            this.panel1.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(340, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Diagnóza";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(12, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 24);
            this.label12.TabIndex = 42;
            this.label12.Text = "PŘÍPAD PACIENTA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridView2_Drugs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(745, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 367);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Léky diagnózy";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(147, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 32);
            this.label4.TabIndex = 45;
            this.label4.Text = "Pro zobrazení dávkování, dvakrát klikněte na požadovaný lék.";
            // 
            // dataGridView2_Drugs
            // 
            this.dataGridView2_Drugs.AllowUserToAddRows = false;
            this.dataGridView2_Drugs.AllowUserToDeleteRows = false;
            this.dataGridView2_Drugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2_Drugs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2_Drugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_Drugs.Location = new System.Drawing.Point(13, 37);
            this.dataGridView2_Drugs.Name = "dataGridView2_Drugs";
            this.dataGridView2_Drugs.ReadOnly = true;
            this.dataGridView2_Drugs.Size = new System.Drawing.Size(318, 323);
            this.dataGridView2_Drugs.TabIndex = 29;
            this.dataGridView2_Drugs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_Drugs_CellDoubleClick);
            // 
            // dataGridView_Visits
            // 
            this.dataGridView_Visits.AllowUserToAddRows = false;
            this.dataGridView_Visits.AllowUserToDeleteRows = false;
            this.dataGridView_Visits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Visits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Visits.Location = new System.Drawing.Point(6, 37);
            this.dataGridView_Visits.Name = "dataGridView_Visits";
            this.dataGridView_Visits.ReadOnly = true;
            this.dataGridView_Visits.Size = new System.Drawing.Size(451, 290);
            this.dataGridView_Visits.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_AddVisit);
            this.groupBox1.Controls.Add(this.dataGridView_Visits);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(1109, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 367);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seznam návštěv";
            // 
            // button_AddVisit
            // 
            this.button_AddVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AddVisit.Location = new System.Drawing.Point(169, 333);
            this.button_AddVisit.Name = "button_AddVisit";
            this.button_AddVisit.Size = new System.Drawing.Size(123, 26);
            this.button_AddVisit.TabIndex = 32;
            this.button_AddVisit.Text = "Přidat";
            this.button_AddVisit.UseVisualStyleBackColor = true;
            this.button_AddVisit.Click += new System.EventHandler(this.button_AddVisit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_AddCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.comboBox_Patients);
            this.Controls.Add(this.comboBox_Doctors);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "Form_AddCase";
            this.Text = "Form_AddCase";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Drugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Visits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.ComboBox comboBox_Doctors;
        private System.Windows.Forms.ComboBox comboBox_Patients;
        private System.Windows.Forms.ComboBox comboBox_Diagnosis;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_DiagnosisCategory;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2_Drugs;
        private System.Windows.Forms.DataGridView dataGridView_Visits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_AddVisit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}