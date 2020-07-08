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
    public partial class Form_DI_Patient_Drug : Form
    {
        public Form_DI_Patient_Drug()
        {
            InitializeComponent();
        }

        public Drug GetData()
        {
            Drug d = new Drug();

            d.KinderDosage = this.textBox_KinderDosage.Text;
            d.AdultDosage = this.textBox_AdultDosage.Text;

            return d;
        }

        public void FillInfo(Drug d)
        {
            this.textBox_AdultDosage.Text = d.AdultDosage;
            this.textBox_KinderDosage.Text = d.KinderDosage;
            this.label1.Text = d.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
