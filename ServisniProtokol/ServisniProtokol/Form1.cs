using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisniProtokol
{
    public partial class Form1 : Form
    {
        private static ServiceProtocol _protocol = new ServiceProtocol();

        private MeasurementsDataModel _measurementsDataModel = new MeasurementsDataModel();

        public Form1()
        {
            InitializeComponent();
            dataGridView_measurements.DataSource = _measurementsDataModel;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!ValidateValues())
            {
                MessageBox.Show("Pred ulozenim musi byt formular validni", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveData();

            Stream stream;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "bin file | *.bin";
            try { 
                if (sfd.ShowDialog() == DialogResult.OK && (stream = sfd.OpenFile()) != null)
                {
                    IFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(stream, _protocol);
                    stream.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ulozeni html se nepodarilo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            Stream stream;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "bin file | *.bin";
            try { 
                if (ofd.ShowDialog() == DialogResult.OK && (stream = ofd.OpenFile()) != null)
                {
                    IFormatter serializer = new BinaryFormatter();
                    _protocol = serializer.Deserialize(stream) as ServiceProtocol;
                    stream.Close();
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("Ulozeni html se nepodarilo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveData()
        {
            //protocol
            _protocol.Number = textBox_protocolNumber.Text;
            _protocol.Date = dateTimePicker_protocolDate.Value;

            //customer
            _protocol.Customer.Name = textBox_customerName.Text;
            _protocol.Customer.Address = textBox_customerAddress.Text;
            _protocol.Customer.ZIP = textBox_customerZIP.Text;
            _protocol.Customer.IC = textBox_customerIC.Text;

            //machine
            _protocol.Device.Manufacturer = textBox_machineManufacturer.Text;
            _protocol.Device.Model = textBox_machineModel.Text;
            _protocol.Device.SerialNumber = textBox_machineSerialNumber.Text;

            //measurements
            _protocol.Measurements = _measurementsDataModel.GetList().Cast<Measurement>().ToList();
        }

        private void LoadData()
        {
            //protocol
             textBox_protocolNumber.Text = _protocol.Number;
            dateTimePicker_protocolDate.Value = _protocol.Date;

            //customer
            textBox_customerName.Text = _protocol.Customer.Name;
            textBox_customerAddress.Text = _protocol.Customer.Address;
            textBox_customerZIP.Text = _protocol.Customer.ZIP;
            textBox_customerIC.Text = _protocol.Customer.IC;

            //machine
            textBox_machineManufacturer.Text = _protocol.Device.Manufacturer;
            textBox_machineModel.Text = _protocol.Device.Model;
            textBox_machineSerialNumber.Text = _protocol.Device.SerialNumber;

            //measurements
             _measurementsDataModel.LoadData(_protocol.Measurements);
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            if (!ValidateValues())
            {
                MessageBox.Show("Pred nahledem musi byt formular validni", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveData();

            ShowForm form = new ShowForm(_protocol);
            form.ShowDialog();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddMeasurementForm form = new AddMeasurementForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
                _measurementsDataModel.AddMeasurement(form.Measurement);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_measurements.SelectedRows.Count > 1)
            {
                MessageBox.Show("Nelze editovat vice polozek", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView_measurements.SelectedRows.Count < 1)
            {
                MessageBox.Show("Neni vybrana polozka", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = dataGridView_measurements.SelectedRows[0].Index;

            Measurement measurement = _measurementsDataModel.GetByIndex(selectedIndex);

            AddMeasurementForm form = new AddMeasurementForm(measurement);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
                _measurementsDataModel.EditOnIndex(selectedIndex, form.Measurement);
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_measurements.SelectedRows.Count < 1)
            {
                MessageBox.Show("Neni vybrana polozka", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewBand row in dataGridView_measurements.SelectedRows)
            {
                _measurementsDataModel.RemoveOnIndex(row.Index);
            }
        }

        private bool ValidateValues()
        {
            errorProvider1.Clear();
            TextBox[] controls = { textBox_protocolNumber, textBox_machineSerialNumber, textBox_machineModel, textBox_machineManufacturer, textBox_customerZIP, textBox_customerName, textBox_customerIC, textBox_customerAddress };
            bool passing = true;

            foreach (TextBox tb in controls)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    errorProvider1.SetError(tb, "Hodnota musi byt vyplnena");
                    passing = false;
                }
            }

            if (!Regex.IsMatch(textBox_customerZIP.Text, @"^[0-9]{3} [0-9]{2}$"))
            {
                errorProvider1.SetError(textBox_customerZIP, "PSC musi byt platne");
                passing = false;
            }

            if (!Regex.IsMatch(textBox_customerIC.Text, @"^[0-9]{6}$"))
            {
                errorProvider1.SetError(textBox_customerIC, "IC musi byt platne");
                passing = false;
            }

            return passing;
        }

        private void button_saveHtml_Click(object sender, EventArgs e)
        {
            if (!ValidateValues())
            {
                MessageBox.Show("Pred exportem musi byt formular validni", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveData();

            StreamWriter stream;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "html file | *.html";
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK && (stream = new StreamWriter(sfd.OpenFile())) != null)
                {
                    stream.Write(_protocol.ConvertToHtml());
                    stream.Dispose();
                    stream.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ulozeni html se nepodarilo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
