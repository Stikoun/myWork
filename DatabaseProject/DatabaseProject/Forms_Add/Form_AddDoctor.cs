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
    public partial class Form_AddDoctor : Form
    {
        private DoctorRepository _doctorRepository = new DoctorRepository();
        private UserRepository _userRepository = new UserRepository();

        public Form_AddDoctor()
        {
            InitializeComponent();

            this.FillBoxes();
        }

        private void button_Ok_Click(object sender, EventArgs e)
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

        public Doctor GetData() //metoda pro předání dat z ovladacích prvků do instance 
        {
            Doctor p = new Doctor();

            p.Name = this.textBox_Name.Text;
            p.Surname = this.textBox_Surname.Text;
            p.Nationality = this.textBox_Nationality.Text;
            p.Residence = this.textBox_Residence.Text;
            p.PIN = this.textBox_PIN.Text;
            p.Gender = this.comboBox_Gender.Text;
            p.Birth = this.dateTimePicker_BirthDate.Value;
            p.idUser = this.GetID(this.comboBox_User);
            p.Username = this.GetName(this.comboBox_User);

            return p;
        }

        private void FillBoxes() //nastavení defaultních hodnot ovládacích prvků
        {
            this.comboBox_Gender.Items.Add("Muž");
            this.comboBox_Gender.Items.Add("Žena");

            this.comboBox_Gender.SelectedIndex = 0;

            foreach (User item in _userRepository.FindAll())
            {
                this.comboBox_User.Items.Add(item.idUser + " - " + item.Username);  
            }
        }

        public void FillInfo(Doctor p) //metoda pro předání dat z instance do ovládacích prvků
        {
            if (p != null)
            {
                this.textBox_Name.Text = p.Name;
                this.textBox_Surname.Text = p.Surname;
                this.textBox_PIN.Text = p.PIN;
                this.textBox_Nationality.Text = p.Nationality;
                this.textBox_Residence.Text = p.Residence;
                this.comboBox_Gender.Text = p.Gender;
                this.dateTimePicker_BirthDate.Value = p.Birth;
                this.comboBox_User.Text = p.idUser + " - " + this._userRepository.FindById(p.idUser).Username;               
            }
        }

        private int GetID(ComboBox element)
        {
            string[] split = element.Text.Split('-');

            int id = Convert.ToInt32(split[0]);

            return id;
        }

        private string GetName(ComboBox element)
        {
            string[] split = element.Text.Split('-');

            string name = Convert.ToString(split[1].TrimStart(' '));

            return name;
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
