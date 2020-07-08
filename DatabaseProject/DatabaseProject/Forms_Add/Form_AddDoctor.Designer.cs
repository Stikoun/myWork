namespace WindowsFormsApplication1
{
    partial class Form_AddDoctor
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
            this.label_Nationality = new System.Windows.Forms.Label();
            this.label_Residence = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.label_Pin = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_Nationality = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Residence = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_PIN = new System.Windows.Forms.TextBox();
            this.comboBox_User = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Nationality
            // 
            this.label_Nationality.AutoSize = true;
            this.label_Nationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Nationality.Location = new System.Drawing.Point(321, 108);
            this.label_Nationality.Name = "label_Nationality";
            this.label_Nationality.Size = new System.Drawing.Size(106, 24);
            this.label_Nationality.TabIndex = 42;
            this.label_Nationality.Text = "Národnost";
            // 
            // label_Residence
            // 
            this.label_Residence.AutoSize = true;
            this.label_Residence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Residence.Location = new System.Drawing.Point(321, 51);
            this.label_Residence.Name = "label_Residence";
            this.label_Residence.Size = new System.Drawing.Size(82, 24);
            this.label_Residence.TabIndex = 41;
            this.label_Residence.Text = "Bydliště";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Gender.Location = new System.Drawing.Point(63, 131);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(78, 24);
            this.label_Gender.TabIndex = 39;
            this.label_Gender.Text = "Pohlaví";
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Birthdate.Location = new System.Drawing.Point(4, 218);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(156, 24);
            this.label_Birthdate.TabIndex = 38;
            this.label_Birthdate.Text = "Datum narození";
            // 
            // label_Pin
            // 
            this.label_Pin.AutoSize = true;
            this.label_Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Pin.Location = new System.Drawing.Point(39, 171);
            this.label_Pin.Name = "label_Pin";
            this.label_Pin.Size = new System.Drawing.Size(121, 24);
            this.label_Pin.TabIndex = 37;
            this.label_Pin.Text = "Rodné číslo";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Surname.Location = new System.Drawing.Point(54, 92);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(87, 24);
            this.label_Surname.TabIndex = 36;
            this.label_Surname.Text = "Příjmení";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Name.Location = new System.Drawing.Point(68, 52);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(73, 24);
            this.label_Name.TabIndex = 35;
            this.label_Name.Text = "Jméno";
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Location = new System.Drawing.Point(166, 131);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Gender.TabIndex = 33;
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(166, 218);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker_BirthDate.TabIndex = 32;
            // 
            // textBox_Nationality
            // 
            this.textBox_Nationality.Location = new System.Drawing.Point(433, 113);
            this.textBox_Nationality.Name = "textBox_Nationality";
            this.textBox_Nationality.Size = new System.Drawing.Size(134, 20);
            this.textBox_Nationality.TabIndex = 31;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(166, 56);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 30;
            // 
            // textBox_Residence
            // 
            this.textBox_Residence.Location = new System.Drawing.Point(413, 52);
            this.textBox_Residence.Multiline = true;
            this.textBox_Residence.Name = "textBox_Residence";
            this.textBox_Residence.Size = new System.Drawing.Size(154, 36);
            this.textBox_Residence.TabIndex = 29;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(166, 96);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname.TabIndex = 28;
            // 
            // textBox_PIN
            // 
            this.textBox_PIN.Location = new System.Drawing.Point(166, 175);
            this.textBox_PIN.Name = "textBox_PIN";
            this.textBox_PIN.Size = new System.Drawing.Size(100, 20);
            this.textBox_PIN.TabIndex = 27;
            // 
            // comboBox_User
            // 
            this.comboBox_User.FormattingEnabled = true;
            this.comboBox_User.Location = new System.Drawing.Point(358, 208);
            this.comboBox_User.Name = "comboBox_User";
            this.comboBox_User.Size = new System.Drawing.Size(174, 21);
            this.comboBox_User.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(354, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Uživatelské jméno";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Cancel.Location = new System.Drawing.Point(430, 258);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(137, 40);
            this.button_Cancel.TabIndex = 46;
            this.button_Cancel.Text = "Zrušit";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Ok.Location = new System.Drawing.Point(280, 258);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(137, 40);
            this.button_Ok.TabIndex = 45;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "DOKTOR";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_User);
            this.Controls.Add(this.label_Nationality);
            this.Controls.Add(this.label_Residence);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_Birthdate);
            this.Controls.Add(this.label_Pin);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.dateTimePicker_BirthDate);
            this.Controls.Add(this.textBox_Nationality);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Residence);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_PIN);
            this.Name = "Form_AddDoctor";
            this.Text = "Form_AddDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nationality;
        private System.Windows.Forms.Label label_Residence;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Birthdate;
        private System.Windows.Forms.Label label_Pin;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
        private System.Windows.Forms.TextBox textBox_Nationality;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Residence;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_PIN;
        private System.Windows.Forms.ComboBox comboBox_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}