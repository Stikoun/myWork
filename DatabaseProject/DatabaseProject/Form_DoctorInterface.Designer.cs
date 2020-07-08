namespace WindowsFormsApplication1
{
    partial class Form_DoctorInterface
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
            this.button_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AddPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Add.Location = new System.Drawing.Point(589, 91);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(157, 63);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Správce systému";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(562, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pro otevření pacientovy karty, dvakrát klikněte na požadovaného pacienta";
            // 
            // button_AddPatient
            // 
            this.button_AddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AddPatient.Location = new System.Drawing.Point(589, 171);
            this.button_AddPatient.Name = "button_AddPatient";
            this.button_AddPatient.Size = new System.Drawing.Size(157, 63);
            this.button_AddPatient.TabIndex = 3;
            this.button_AddPatient.Text = "Přidat pacienta";
            this.button_AddPatient.UseVisualStyleBackColor = true;
            this.button_AddPatient.Click += new System.EventHandler(this.button_AddPatient_Click);
            // 
            // Form_DoctorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 258);
            this.Controls.Add(this.button_AddPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_DoctorInterface";
            this.Text = "Form_DoctorInterface";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddPatient;
    }
}