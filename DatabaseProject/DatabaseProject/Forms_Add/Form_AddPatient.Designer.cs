namespace WindowsFormsApplication1
{
    partial class Form_AddPatient
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
            this.textBox_PIN = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Residence = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Anamnesis = new System.Windows.Forms.TextBox();
            this.textBox_Note = new System.Windows.Forms.TextBox();
            this.textBox_Nationality = new System.Windows.Forms.TextBox();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.comboBox_Insurence = new System.Windows.Forms.ComboBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_idPatient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_PIN
            // 
            this.textBox_PIN.Location = new System.Drawing.Point(152, 206);
            this.textBox_PIN.Name = "textBox_PIN";
            this.textBox_PIN.Size = new System.Drawing.Size(92, 20);
            this.textBox_PIN.TabIndex = 1;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(123, 94);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname.TabIndex = 3;
            // 
            // textBox_Residence
            // 
            this.textBox_Residence.Location = new System.Drawing.Point(130, 361);
            this.textBox_Residence.Multiline = true;
            this.textBox_Residence.Name = "textBox_Residence";
            this.textBox_Residence.Size = new System.Drawing.Size(200, 38);
            this.textBox_Residence.TabIndex = 6;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(123, 56);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 7;
            // 
            // textBox_Anamnesis
            // 
            this.textBox_Anamnesis.Location = new System.Drawing.Point(380, 59);
            this.textBox_Anamnesis.Multiline = true;
            this.textBox_Anamnesis.Name = "textBox_Anamnesis";
            this.textBox_Anamnesis.Size = new System.Drawing.Size(293, 167);
            this.textBox_Anamnesis.TabIndex = 8;
            // 
            // textBox_Note
            // 
            this.textBox_Note.Location = new System.Drawing.Point(380, 276);
            this.textBox_Note.Multiline = true;
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.Size = new System.Drawing.Size(291, 173);
            this.textBox_Note.TabIndex = 9;
            // 
            // textBox_Nationality
            // 
            this.textBox_Nationality.Location = new System.Drawing.Point(130, 414);
            this.textBox_Nationality.Name = "textBox_Nationality";
            this.textBox_Nationality.Size = new System.Drawing.Size(200, 20);
            this.textBox_Nationality.TabIndex = 12;
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(160, 249);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker_BirthDate.TabIndex = 14;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Location = new System.Drawing.Point(123, 140);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Gender.TabIndex = 15;
            // 
            // comboBox_Insurence
            // 
            this.comboBox_Insurence.FormattingEnabled = true;
            this.comboBox_Insurence.Location = new System.Drawing.Point(121, 327);
            this.comboBox_Insurence.Name = "comboBox_Insurence";
            this.comboBox_Insurence.Size = new System.Drawing.Size(245, 21);
            this.comboBox_Insurence.TabIndex = 18;
            // 
            // button_Ok
            // 
            this.button_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Ok.Location = new System.Drawing.Point(25, 455);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(134, 50);
            this.button_Ok.TabIndex = 31;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Cancel.Location = new System.Drawing.Point(195, 455);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(135, 50);
            this.button_Cancel.TabIndex = 32;
            this.button_Cancel.Text = "Zrušit";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_idPatient
            // 
            this.label_idPatient.AutoSize = true;
            this.label_idPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_idPatient.Location = new System.Drawing.Point(20, 9);
            this.label_idPatient.Name = "label_idPatient";
            this.label_idPatient.Size = new System.Drawing.Size(109, 25);
            this.label_idPatient.TabIndex = 13;
            this.label_idPatient.Text = "PACIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Národnost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Bydliště";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Pohlaví";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(1, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Datum narození";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(15, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Rodné číslo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Příjmení";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Jméno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(448, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "Anamnéza";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(473, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 24);
            this.label9.TabIndex = 51;
            this.label9.Text = "Poznámky";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(3, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 52;
            this.label10.Text = "Pojišťovna";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 517);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.comboBox_Insurence);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.dateTimePicker_BirthDate);
            this.Controls.Add(this.label_idPatient);
            this.Controls.Add(this.textBox_Nationality);
            this.Controls.Add(this.textBox_Note);
            this.Controls.Add(this.textBox_Anamnesis);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Residence);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_PIN);
            this.Name = "Form_AddPatient";
            this.Text = "Form_AddPatient";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_PIN;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Residence;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Anamnesis;
        private System.Windows.Forms.TextBox textBox_Note;
        private System.Windows.Forms.TextBox textBox_Nationality;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.ComboBox comboBox_Insurence;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_idPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}