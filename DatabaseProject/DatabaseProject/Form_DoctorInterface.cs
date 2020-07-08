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
    public partial class Form_DoctorInterface : Form
    {
        private PatientRepository _patientRepository = new PatientRepository();
        private BindingList<Patient> _patientBindingList = new BindingList<Patient>();
        public bool isAdmin;

        public Form_DoctorInterface()
        {
            InitializeComponent();

            this._patientBindingList = new BindingList<Patient>(this._patientRepository.FindAll());
            this.dataGridView1.DataSource = this._patientBindingList;

            this.RefreshGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_DI_Patient frm = new Form_DI_Patient();

            int index = this.dataGridView1.CurrentRow.Index;
            Patient p = this._patientBindingList[index];
       
            frm.FillInfo(p);

            frm.ShowDialog();
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_AdminPanel frm = new Form_AdminPanel();

            frm.AdminControl(isAdmin);
            frm.ShowDialog();

            this.RefreshGrid();
            
        }

        private void RefreshGrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this._patientBindingList;

            this.dataGridView1.Columns["Residence"].Visible = false;
            this.dataGridView1.Columns["Nationality"].Visible = false;
            this.dataGridView1.Columns["Anamnesis"].Visible = false;
            this.dataGridView1.Columns["Insurence"].Visible = false;
            this.dataGridView1.Columns["Note"].Visible = false;

            this.dataGridView1.Columns["Name"].HeaderText = "Jméno";
            this.dataGridView1.Columns["Surname"].HeaderText = "Příjmení";
            this.dataGridView1.Columns["Birth"].HeaderText = "Datum narození";
            this.dataGridView1.Columns["Gender"].HeaderText = "Pohlaví";
            this.dataGridView1.Columns["PIN"].HeaderText = "Rodné číslo";
        }

        private void button_AddPatient_Click(object sender, EventArgs e)
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
    }
}
