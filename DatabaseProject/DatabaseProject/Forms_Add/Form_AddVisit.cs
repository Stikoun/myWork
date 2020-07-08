using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms_Add
{
    public partial class Form_AddVisit : Form
    {
        private CaseRepository _caseRepository = new CaseRepository();

        public Form_AddVisit()
        {
            InitializeComponent();
            this.FillBoxes();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (ValidateValues())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public Visit GetData() //metoda pro předání dat z ovladacích prvků do instance 
        {
            Visit v = new Visit();

            v.VisitDate = this.dateTimePicker1.Value.Date;
            v.Description = this.textBox1.Text;
            v.idCase = this.GetID(comboBox1);

            return v;
        }

        public void FillInfo(Visit v) //metoda pro předání dat z instance do ovládacích prvků
        {
            if (v != null)
            {
                this.textBox1.Text = v.Description;
                this.dateTimePicker1.Value = v.VisitDate.Date;
                this.comboBox1.Text = this._caseRepository.FindById(v.idCase).Name;
            }
        }

        public void FillCase(Case c)  //vyplnění comboboxu případem pacienta
        {
            this.comboBox1.Text = c.idCase + " - " + c.Name;
        }

        private void FillBoxes()  //nastavení defaultních hodnot ovládacích prvků
        {
            foreach (Case item in _caseRepository.FindAll())
            {
                this.comboBox1.Items.Add(item.idCase + " - " + item.Name);
            }
        }

        private int GetID(ComboBox element)
        {
            string[] split = element.Text.Split('-');

            int id = Convert.ToInt32(split[0]);

            return id;
        }

        private bool ValidateValues() //Validace vstupních hodnot
        {
            errorProvider1.Clear();
            bool passing = true;

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "Hodnota musí být vyplněna");
                passing = false;
            }

            return passing;
        }
    }
}
