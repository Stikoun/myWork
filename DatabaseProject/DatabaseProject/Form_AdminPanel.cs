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
    public partial class Form_AdminPanel : Form
    {
        public Form_AdminPanel()
        {
            InitializeComponent();
        }

        private void button_Doctors_Click(object sender, EventArgs e)
        {
            Form_Doctors frm = new Form_Doctors();
            frm.ShowDialog();
        }

        private void button_Diagnosis_Click(object sender, EventArgs e)
        {
            Form_Diagnosis frm = new Form_Diagnosis();
            frm.ShowDialog();
        }

        private void button_Cases_Click(object sender, EventArgs e)
        {
            Form_Cases frm = new Form_Cases();
            frm.ShowDialog();
        }

        private void button_Users_Click(object sender, EventArgs e)
        {
            Form_Users frm = new Form_Users();
            frm.ShowDialog();
        }

        private void button_Patients_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void button_Drugs_Click(object sender, EventArgs e)
        {
            Form_Drugs frm = new Form_Drugs();
            frm.ShowDialog();
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_Login frm = new Form_Login();
            frm.ShowDialog();

            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Visits_Click(object sender, EventArgs e)
        {
            Forms_AdminPanel.Form_Visits frm = new Forms_AdminPanel.Form_Visits();
            frm.ShowDialog();
        }

        public void AdminControl(bool isAdmin)
        {
            if (!isAdmin)
            {
                this.button_Users.Enabled = false;
                this.button_Doctors.Enabled = false;
            }
            else
            {
                this.button_Users.Enabled = true;
                this.button_Doctors.Enabled = true;
            }
        }
    }
}
