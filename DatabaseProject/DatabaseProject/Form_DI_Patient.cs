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
    public partial class Form_DI_Patient : Form
    {
        private CaseRepository _caseRepository = new CaseRepository();
        private BindingList<Case> _caseBindingList = new BindingList<Case>();
        private PatientRepository _patientRepository = new PatientRepository();

        private Patient _p = null;

        public Form_DI_Patient()
        {
            InitializeComponent();

            this._caseBindingList = new BindingList<Case>(this._caseRepository.FindAll());
            //this.textBox1.ReadOnly = true;
            //this.textBox_Anamnesis.ReadOnly = true;
            this.dateTimePicker_BirthDate.Enabled = false;
        }

        public void FillInfo(Patient p)
        {
            if (p != null)
            {
                _p = p;

                this.label_Name.Text = p.Name;
                this.label_Surname.Text = p.Surname;
                this.label_Gender.Text = p.Gender;
                this.label_Insurence.Text = p.Insurence;
                this.label_Nationality.Text = p.Nationality;
                this.textBox1.Text = p.Note;
                this.label_Residence.Text = p.Residence;
                this.label_PIN.Text = p.PIN;
                this.dateTimePicker_BirthDate.Value = p.Birth;
                this.textBox_Anamnesis.Text = p.Anamnesis;              

                this.RefreshGrid(p.idPatient);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_AddCase frm = new Form_AddCase();

            string value = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            Case c = this._caseRepository.FindByName(value);

            frm.FillInfo(c);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                c.Name = frm.GetData().Name;
                c.idDiagnosis = frm.GetData().idDiagnosis;
                c.idPatient = frm.GetData().idPatient;
                c.idDoctor = frm.GetData().idDoctor;
                c.Description = frm.GetData().Description;
                c.Doctor = frm.GetData().Doctor;
                c.Patient = frm.GetData().Patient;

                this._caseRepository.Update(c);
            }

            this.RefreshGrid(c.idPatient);
        }

        private void button_AddCase_Click(object sender, EventArgs e)
        {
            Form_AddCase frm = new Form_AddCase();

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                Case p = frm.GetData();
                
                this._caseRepository.Create(p);
                this._caseBindingList.Add(p);

                this.RefreshGrid(p.idPatient);
            }
        }

        private void button_SaveNotes_Click(object sender, EventArgs e)
        {
            _p.Note = this.textBox1.Text;
            this._patientRepository.Update(_p);
        }

        private void button_SaveAnamnese_Click(object sender, EventArgs e)
        {
            _p.Anamnesis = this.textBox_Anamnesis.Text;
            this._patientRepository.Update(_p);
        }

        private void RefreshGrid(int idPatient)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource =  _caseRepository.FindByPatientId_List(idPatient);

            this.dataGridView1.Columns["idCase"].Visible = false;
            this.dataGridView1.Columns["Patient"].Visible = false;
            this.dataGridView1.Columns["Doctor"].Visible = false;
            this.dataGridView1.Columns["Description"].Visible = false;
            this.dataGridView1.Columns["Name"].HeaderText = "Název";
        }
    }
}
