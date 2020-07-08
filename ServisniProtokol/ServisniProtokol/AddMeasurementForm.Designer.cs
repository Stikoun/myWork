namespace ServisniProtokol
{
    partial class AddMeasurementForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_parameter = new System.Windows.Forms.TextBox();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.textBox_unit = new System.Windows.Forms.TextBox();
            this.checkBox_passing = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parametr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hodnota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vyhovuje:";
            // 
            // textBox_parameter
            // 
            this.textBox_parameter.Location = new System.Drawing.Point(71, 10);
            this.textBox_parameter.Name = "textBox_parameter";
            this.textBox_parameter.Size = new System.Drawing.Size(100, 20);
            this.textBox_parameter.TabIndex = 4;
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(71, 38);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(100, 20);
            this.textBox_value.TabIndex = 5;
            // 
            // textBox_unit
            // 
            this.textBox_unit.Location = new System.Drawing.Point(177, 38);
            this.textBox_unit.Name = "textBox_unit";
            this.textBox_unit.Size = new System.Drawing.Size(40, 20);
            this.textBox_unit.TabIndex = 6;
            // 
            // checkBox_passing
            // 
            this.checkBox_passing.AutoSize = true;
            this.checkBox_passing.Location = new System.Drawing.Point(101, 67);
            this.checkBox_passing.Name = "checkBox_passing";
            this.checkBox_passing.Size = new System.Drawing.Size(15, 14);
            this.checkBox_passing.TabIndex = 7;
            this.checkBox_passing.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(86, 109);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Pridat";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // AddMeasurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 168);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.checkBox_passing);
            this.Controls.Add(this.textBox_unit);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.textBox_parameter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddMeasurementForm";
            this.Text = "Pridat mereni";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_parameter;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.TextBox textBox_unit;
        private System.Windows.Forms.CheckBox checkBox_passing;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button_add;
    }
}