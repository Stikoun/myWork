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
    public partial class Form_AddUser : Form
    {
        public Form_AddUser()
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

        public User GetData() //metoda pro předání dat z ovladacích prvků do instance 
        {
            User p = new User();

            p.Username = this.textBox_userName.Text;
            p.Password = this.textBox_Password.Text;
            p.isAdmin = this.checkBox_Administrator.Checked;

            return p;
        }

        public void FillInfo(User p) //metoda pro předání dat z instance do ovládacích prvků
        {
            if (p != null)
            {
                this.textBox_userName.Text = p.Username;
                this.textBox_Password.Text = p.Password;
                this.checkBox_Administrator.Checked = p.isAdmin;
            }
        }

        private bool ValidateValues() //Validace vstupních hodnot
        {
            errorProvider1.Clear();
            TextBox[] controls = { textBox_Password, textBox_userName };
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
