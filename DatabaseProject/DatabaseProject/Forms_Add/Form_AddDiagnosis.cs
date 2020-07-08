using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_AddDiagnosis : Form
    {
        private DiagnosisRepository _diagnosisRepository = new DiagnosisRepository();
        public Form_AddDiagnosis()
        {
            InitializeComponent();

            this.FillBoxes();
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

        public Diagnosis GetData() //metoda pro předání dat z ovladacích prvků do instance 
        {
            Diagnosis p = new Diagnosis();

            p.Name = this.textBox_Name.Text;
            p.Category = this.comboBox_Category.Text;
            p.Description = this.textBox_Description.Text;

            return p;
        }

        public void FillInfo(Diagnosis p) //metoda pro předání dat z instance do ovládacích prvků
        {
            if (p != null)
            {
                this.textBox_Name.Text = p.Name;
                this.comboBox_Category.Text = p.Category;
                this.textBox_Description.Text = p.Description;
            }
        }

        private void FillBoxes() //nastavení defaultních hodnot ovládacích prvků
        {
            var diagnosis = _diagnosisRepository.FindAll().Select(d => d.Category).Distinct().ToArray();
            this.comboBox_Category.Items.AddRange(diagnosis);
        }

        private bool ValidateValues() //Validace vstupních hodnot
        {
            errorProvider1.Clear();
            TextBox[] controls = { textBox_Description, textBox_Name };
            bool passing = true;

            foreach (TextBox tb in controls)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    errorProvider1.SetError(tb, "Hodnota musí být vyplněna");
                    passing = false;
                }
            }

            if (string.IsNullOrWhiteSpace(comboBox_Category.Text))
            {
                errorProvider1.SetError(comboBox_Category, "Hodnota musí být vyplněna");
                passing = false;
            }

            return passing;
        }
    }

}


