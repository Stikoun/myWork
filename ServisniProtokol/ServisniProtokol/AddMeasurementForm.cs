using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisniProtokol
{
    public partial class AddMeasurementForm : Form
    {
        public Measurement Measurement { get; set; }

        public AddMeasurementForm()
        {
            InitializeComponent();

            Measurement = new Measurement();
        }
        public AddMeasurementForm(Measurement measurement) : this()
        {
            Measurement = measurement;
            LoadValues();
            button_add.Text = "Upravit";
            this.Text = "Upravit mereni";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (SaveValues())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Zkontroluje vstupni data", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool SaveValues()
        {
            errorProvider1.Clear();
            TextBox[] controls = { textBox_parameter, textBox_unit, textBox_value };
            bool passing = true;

            foreach (TextBox tb in controls)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    errorProvider1.SetError(tb, "Hodnota musi byt vyplnena");
                    passing = false;
                }
            }

            if (!passing)
                return false;
            
            try
            {
                Measurement.Value = Convert.ToDouble(textBox_value.Text);
            }
            catch
            {
                errorProvider1.SetError(textBox_value, "Hodnota musi byt ciselna");
                return false;
            }

            Measurement.Parameter = textBox_parameter.Text;
            Measurement.Unit = textBox_unit.Text;
            Measurement.Passing = checkBox_passing.Checked;

            return true;
        }

        private void LoadValues()
        {
            textBox_parameter.Text = Measurement.Parameter;
            textBox_unit.Text = Measurement.Unit;
            textBox_value.Text = Measurement.Value.ToString();
            checkBox_passing.Checked = Measurement.Passing;
        }
    }
}
