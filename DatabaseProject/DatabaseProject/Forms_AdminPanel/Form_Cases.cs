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
    public partial class Form_Cases : Form
    {
        private CaseRepository _caseRepository = new CaseRepository();
        private BindingList<Case> _caseBindingList = new BindingList<Case>();

        public Form_Cases()
        {
            InitializeComponent();

            this._caseBindingList = new BindingList<Case>(this._caseRepository.FindAll()); 
            this.dataGridView1.DataSource = this._caseBindingList;

            this.RefreshGrid();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_AddCase frm = new Form_AddCase();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                Case p = frm.GetData();

                this._caseRepository.Create(p);
                this._caseBindingList.Add(p);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Form_AddCase frm = new Form_AddCase();

            int index = this.dataGridView1.CurrentRow.Index;
            Case p = this._caseBindingList[index];

            frm.FillInfo(p);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                p.Name = frm.GetData().Name;
                p.idPatient = frm.GetData().idPatient;
                p.idDoctor = frm.GetData().idDoctor;
                p.Description = frm.GetData().Description;
                p.Doctor = frm.GetData().Doctor;
                p.Patient = frm.GetData().Patient;
                p.idDiagnosis = frm.GetData().idDiagnosis;
                    
                this._caseRepository.Update(p);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = _caseBindingList;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            int rm_index = this._caseBindingList[index].idCase;

            this._caseRepository.Delete(this._caseRepository.FindById(rm_index));
            this._caseBindingList.RemoveAt(index);
        }

        private void RefreshGrid()
        {
            this.dataGridView1.Columns["idCase"].Visible = false;
            this.dataGridView1.Columns["Patient"].HeaderText = "Pacient";
            this.dataGridView1.Columns["Doctor"].HeaderText = "Doktor";
            this.dataGridView1.Columns["Name"].HeaderText = "Jméno";
            this.dataGridView1.Columns["Description"].HeaderText = "Popis";
        }
    }
}
