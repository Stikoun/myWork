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
    public partial class Form1 : Form
    {
        private PatientRepository  _patientRepository = new PatientRepository();
        private BindingList<Patient> _patientBindingList = new BindingList<Patient>();

        public Form1()
        {
            InitializeComponent();

            this._patientBindingList = new BindingList<Patient>(this._patientRepository.FindAll());
            this.dataGridView1.DataSource = this._patientBindingList;

            this.RefreshGrid();
        }


        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            Form_AddPatient frm = new Form_AddPatient();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                Patient p = frm.GetData();
                this._patientRepository.Create(p);
                this._patientBindingList.Add(p);
            }
        }

        private void button_EditPatient_Click(object sender, EventArgs e)
        {
            Form_AddPatient frm = new Form_AddPatient();

            int index = this.dataGridView1.CurrentRow.Index;
            Patient p = this._patientBindingList[index];

            frm.FillInfo(p);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                p.Name = frm.GetData().Name;
                p.Surname = frm.GetData().Surname;
                p.Birth = frm.GetData().Birth;
                p.Insurence = frm.GetData().Insurence;
                p.Nationality = frm.GetData().Nationality;
                p.Residence = frm.GetData().Residence;
                p.Note = frm.GetData().Note;
                p.Anamnesis = frm.GetData().Anamnesis;
                p.Gender = frm.GetData().Gender;
                p.PIN = frm.GetData().PIN;

                this._patientRepository.Update(p);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = _patientBindingList;
            }
        }

        private void button_DeletePatient_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            int rm_index = this._patientBindingList[index].idPatient;

            this._patientRepository.Delete(this._patientRepository.FindById(rm_index));
            this._patientBindingList.RemoveAt(index);
        }

        private void RefreshGrid()
        {
            this.dataGridView1.Columns["Name"].HeaderText = "Jméno";
            this.dataGridView1.Columns["Surname"].HeaderText = "Příjmení";
            this.dataGridView1.Columns["Birth"].HeaderText = "Datum narození";
            this.dataGridView1.Columns["PIN"].HeaderText = "Rodné číslo";
            this.dataGridView1.Columns["Residence"].HeaderText = "Bydliště";
            this.dataGridView1.Columns["Nationality"].HeaderText = "Národnost";
            this.dataGridView1.Columns["Gender"].HeaderText = "Pohlaví";
            this.dataGridView1.Columns["Insurence"].HeaderText = "Pojišťovna";
            this.dataGridView1.Columns["Anamnesis"].HeaderText = "Anamnéza";
            this.dataGridView1.Columns["Note"].HeaderText = "Poznámky";
        }
    }
}
