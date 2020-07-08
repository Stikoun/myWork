namespace ServisniProtokol
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_protocolDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_protocolNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_customerIC = new System.Windows.Forms.TextBox();
            this.textBox_customerZIP = new System.Windows.Forms.TextBox();
            this.textBox_customerAddress = new System.Windows.Forms.TextBox();
            this.textBox_customerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_machineModel = new System.Windows.Forms.TextBox();
            this.textBox_machineSerialNumber = new System.Windows.Forms.TextBox();
            this.textBox_machineManufacturer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_measurements = new System.Windows.Forms.DataGridView();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.button_saveHtml = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_measurements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_protocolDate);
            this.groupBox1.Controls.Add(this.textBox_protocolNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mereni";
            // 
            // dateTimePicker_protocolDate
            // 
            this.dateTimePicker_protocolDate.Location = new System.Drawing.Point(107, 45);
            this.dateTimePicker_protocolDate.Name = "dateTimePicker_protocolDate";
            this.dateTimePicker_protocolDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_protocolDate.TabIndex = 3;
            // 
            // textBox_protocolNumber
            // 
            this.textBox_protocolNumber.Location = new System.Drawing.Point(107, 13);
            this.textBox_protocolNumber.Name = "textBox_protocolNumber";
            this.textBox_protocolNumber.Size = new System.Drawing.Size(202, 20);
            this.textBox_protocolNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum mereni:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cislo protokolu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_customerIC);
            this.groupBox2.Controls.Add(this.textBox_customerZIP);
            this.groupBox2.Controls.Add(this.textBox_customerAddress);
            this.groupBox2.Controls.Add(this.textBox_customerName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(348, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zakaznik";
            // 
            // textBox_customerIC
            // 
            this.textBox_customerIC.Location = new System.Drawing.Point(63, 173);
            this.textBox_customerIC.Name = "textBox_customerIC";
            this.textBox_customerIC.Size = new System.Drawing.Size(207, 20);
            this.textBox_customerIC.TabIndex = 7;
            // 
            // textBox_customerZIP
            // 
            this.textBox_customerZIP.Location = new System.Drawing.Point(63, 141);
            this.textBox_customerZIP.Name = "textBox_customerZIP";
            this.textBox_customerZIP.Size = new System.Drawing.Size(207, 20);
            this.textBox_customerZIP.TabIndex = 6;
            // 
            // textBox_customerAddress
            // 
            this.textBox_customerAddress.Location = new System.Drawing.Point(63, 39);
            this.textBox_customerAddress.Multiline = true;
            this.textBox_customerAddress.Name = "textBox_customerAddress";
            this.textBox_customerAddress.Size = new System.Drawing.Size(207, 90);
            this.textBox_customerAddress.TabIndex = 5;
            // 
            // textBox_customerName
            // 
            this.textBox_customerName.Location = new System.Drawing.Point(63, 13);
            this.textBox_customerName.Name = "textBox_customerName";
            this.textBox_customerName.Size = new System.Drawing.Size(207, 20);
            this.textBox_customerName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "IC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "PSC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jmeno:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_machineModel);
            this.groupBox3.Controls.Add(this.textBox_machineSerialNumber);
            this.groupBox3.Controls.Add(this.textBox_machineManufacturer);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(13, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zarizeni";
            // 
            // textBox_machineModel
            // 
            this.textBox_machineModel.Location = new System.Drawing.Point(107, 49);
            this.textBox_machineModel.Name = "textBox_machineModel";
            this.textBox_machineModel.Size = new System.Drawing.Size(202, 20);
            this.textBox_machineModel.TabIndex = 5;
            // 
            // textBox_machineSerialNumber
            // 
            this.textBox_machineSerialNumber.Location = new System.Drawing.Point(107, 77);
            this.textBox_machineSerialNumber.Name = "textBox_machineSerialNumber";
            this.textBox_machineSerialNumber.Size = new System.Drawing.Size(202, 20);
            this.textBox_machineSerialNumber.TabIndex = 4;
            // 
            // textBox_machineManufacturer
            // 
            this.textBox_machineManufacturer.Location = new System.Drawing.Point(107, 17);
            this.textBox_machineManufacturer.Name = "textBox_machineManufacturer";
            this.textBox_machineManufacturer.Size = new System.Drawing.Size(202, 20);
            this.textBox_machineManufacturer.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Seriove cislo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vyrobce:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_measurements);
            this.groupBox4.Location = new System.Drawing.Point(13, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(631, 203);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mereni";
            // 
            // dataGridView_measurements
            // 
            this.dataGridView_measurements.AllowUserToAddRows = false;
            this.dataGridView_measurements.AllowUserToDeleteRows = false;
            this.dataGridView_measurements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_measurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_measurements.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_measurements.Location = new System.Drawing.Point(7, 20);
            this.dataGridView_measurements.Name = "dataGridView_measurements";
            this.dataGridView_measurements.ReadOnly = true;
            this.dataGridView_measurements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_measurements.Size = new System.Drawing.Size(618, 177);
            this.dataGridView_measurements.TabIndex = 0;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(13, 444);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Ulozit";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(94, 444);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 5;
            this.button_load.Text = "Nacist";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(569, 443);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 6;
            this.button_show.Text = "Nahled";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_saveHtml
            // 
            this.button_saveHtml.Location = new System.Drawing.Point(488, 443);
            this.button_saveHtml.Name = "button_saveHtml";
            this.button_saveHtml.Size = new System.Drawing.Size(75, 23);
            this.button_saveHtml.TabIndex = 7;
            this.button_saveHtml.Text = "Ulozit Html";
            this.button_saveHtml.UseVisualStyleBackColor = true;
            this.button_saveHtml.Click += new System.EventHandler(this.button_saveHtml_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(306, 439);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(16, 23);
            this.button_remove.TabIndex = 8;
            this.button_remove.Text = "-";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(328, 439);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(18, 23);
            this.button_edit.TabIndex = 9;
            this.button_edit.Text = "O";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(358, 439);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(22, 23);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 474);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_saveHtml);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Servisni protokol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_measurements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_protocolDate;
        private System.Windows.Forms.TextBox textBox_protocolNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_customerIC;
        private System.Windows.Forms.TextBox textBox_customerZIP;
        private System.Windows.Forms.TextBox textBox_customerAddress;
        private System.Windows.Forms.TextBox textBox_customerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_machineModel;
        private System.Windows.Forms.TextBox textBox_machineSerialNumber;
        private System.Windows.Forms.TextBox textBox_machineManufacturer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_measurements;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_saveHtml;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

