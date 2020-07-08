using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_AddDrug : Form
    {
        public Form_AddDrug()
        {
            InitializeComponent();
        }


        private void button_OK_Click(object sender, EventArgs e)
        {
            if(ValidateValues())
            { 
            DialogResult = DialogResult.OK;
            this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public Drug GetData() //metoda pro předání dat z ovladacích prvků do instance 
        {
            Drug p = new Drug();

            p.Name = this.textBox_Name.Text;
            p.Category = this.textBox_Category.Text;
            p.AdultDosage = this.textBox_AdultDosage.Text;
            p.KinderDosage = this.textBox_KinderDosage.Text;

            return p;
        }

        public void FillInfo(Drug p) //metoda pro předání dat z instance do ovládacích prvků
        {
            if (p != null)
            {
                this.textBox_Name.Text = p.Name;
                this.textBox_Category.Text = p.Category;
                this.textBox_AdultDosage.Text = p.AdultDosage;
                this.textBox_KinderDosage.Text = p.KinderDosage;
            }
        }

        private bool ValidateValues() //Validace vstupních hodnot
        {
            errorProvider1.Clear();
            TextBox[] controls = { textBox_Category, textBox_Name };
            bool passing = true;

            foreach (TextBox tb in controls)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    errorProvider1.SetError(tb, "Hodnota musí být vyplněna");
                    passing = false;
                }
            }

            return passing;
        }
    }
}
