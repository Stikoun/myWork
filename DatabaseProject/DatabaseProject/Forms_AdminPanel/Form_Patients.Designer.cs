namespace WindowsFormsApplication1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_AddPatient = new System.Windows.Forms.Button();
            this.button_EditPatient = new System.Windows.Forms.Button();
            this.button_DeletePatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1338, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_AddPatient
            // 
            this.button_AddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AddPatient.Location = new System.Drawing.Point(12, 344);
            this.button_AddPatient.Name = "button_AddPatient";
            this.button_AddPatient.Size = new System.Drawing.Size(216, 63);
            this.button_AddPatient.TabIndex = 1;
            this.button_AddPatient.Text = "Přidat";
            this.button_AddPatient.UseVisualStyleBackColor = true;
            this.button_AddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // button_EditPatient
            // 
            this.button_EditPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_EditPatient.Location = new System.Drawing.Point(256, 344);
            this.button_EditPatient.Name = "button_EditPatient";
            this.button_EditPatient.Size = new System.Drawing.Size(216, 63);
            this.button_EditPatient.TabIndex = 3;
            this.button_EditPatient.Text = "Změnit";
            this.button_EditPatient.UseVisualStyleBackColor = true;
            this.button_EditPatient.Click += new System.EventHandler(this.button_EditPatient_Click);
            // 
            // button_DeletePatient
            // 
            this.button_DeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_DeletePatient.Location = new System.Drawing.Point(498, 344);
            this.button_DeletePatient.Name = "button_DeletePatient";
            this.button_DeletePatient.Size = new System.Drawing.Size(216, 63);
            this.button_DeletePatient.TabIndex = 4;
            this.button_DeletePatient.Text = "Odstranit";
            this.button_DeletePatient.UseVisualStyleBackColor = true;
            this.button_DeletePatient.Click += new System.EventHandler(this.button_DeletePatient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 419);
            this.Controls.Add(this.button_DeletePatient);
            this.Controls.Add(this.button_EditPatient);
            this.Controls.Add(this.button_AddPatient);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_AddPatient;
        private System.Windows.Forms.Button button_EditPatient;
        private System.Windows.Forms.Button button_DeletePatient;
    }
}

