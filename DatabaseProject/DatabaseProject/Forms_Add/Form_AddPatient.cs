using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_AddPatient : Form
    {
        private DiagnosisRepository _diagnosisRepository = new DiagnosisRepository();
        private CaseRepository _caseRepository = new CaseRepository();

        public Form_AddPatient()
        {
            InitializeComponent();

            this.FillBoxes();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (ValidateValues())
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

        public Patient GetData() //metoda pro předání dat z ovladacích prvků do instance 
        {
            Patient p = new Patient();

            p.Name = this.textBox_Name.Text;
            p.Surname = this.textBox_Surname.Text;
            p.Insurence = this.comboBox_Insurence.Text;
            p.Nationality = this.textBox_Nationality.Text;
            p.Residence = this.textBox_Residence.Text;
            p.Note = this.textBox_Note.Text;
            p.PIN = this.textBox_PIN.Text;
            p.Gender = this.comboBox_Gender.Text;
            p.Anamnesis = this.textBox_Anamnesis.Text;
            p.Birth = this.dateTimePicker_BirthDate.Value.Date;

            return p;
        }


        public void FillInfo(Patient p) //metoda pro předání dat z instance do ovládacích prvků
        {
            Case c = this._caseRepository.FindById(p.idPatient);

            if (p != null)
            {
                this.textBox_Name.Text = p.Name;
                this.textBox_Surname.Text = p.Surname;
                this.textBox_PIN.Text = p.PIN;
                this.textBox_Nationality.Text = p.Nationality;
                this.textBox_Residence.Text = p.Residence;
                this.textBox_Note.Text = p.Note;
                this.textBox_Anamnesis.Text = p.Anamnesis;
                this.comboBox_Gender.Text = p.Gender;
                this.comboBox_Insurence.Text = p.Insurence;
                this.dateTimePicker_BirthDate.Value = p.Birth.Date;
            }
        }

        private void FillBoxes() //nastavení defaultních hodnot ovládacích prvků
        {
            this.comboBox_Gender.Items.Add("Muž");
            this.comboBox_Gender.Items.Add("Žena");

            this.comboBox_Insurence.Items.Add("Vojenská zdravotní pojišťovna ČR (201)");
            this.comboBox_Insurence.Items.Add("Zdravotní pojišťovna ministerstva vnitra ČR (211)");
            this.comboBox_Insurence.Items.Add("Všeobecná zdravotní pojišťovna ČR (111)");
            this.comboBox_Insurence.Items.Add("Česká průmyslová zdravotní pojišťovna (205)");

            this.comboBox_Gender.SelectedIndex = 0;
            this.comboBox_Insurence.SelectedIndex = 0;
        }

        private bool ValidateValues() //Validace vstupních hodnot
        {
            errorProvider1.Clear();
            TextBox[] controls = { textBox_Name, textBox_Nationality, textBox_PIN, textBox_Residence, textBox_Surname };
            TextBox[] controls_nonumber = { textBox_Name, textBox_Nationality, textBox_Surname };
            bool passing = true;

            foreach (TextBox tb in controls_nonumber)
            {
                if (!Regex.IsMatch(tb.Text, @"^[aA-zZ]+$"))
                {
                    errorProvider1.SetError(textBox_Name, "Nesmí obsahovat čísla");
                    passing = false;
                }
            }

            foreach (TextBox tb in controls)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    errorProvider1.SetError(tb, "Hodnota musí být vyplněna");
                    passing = false;
                }
            }

            if (!Regex.IsMatch(textBox_PIN.Text, @"^[0-9]{6}/[0-9]{4}$"))
            {
                errorProvider1.SetError(textBox_PIN, "Rodné číslo musí být ve formátu (000000/0000)");
                passing = false;
            }

            return passing;
        }
    }
}
