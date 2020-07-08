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
    public partial class Form_Diagnosis : Form
    {
        private DiagnosisRepository _diagnosisRepository = new DiagnosisRepository();
        private BindingList<Diagnosis> _diagnosisBindingList = new BindingList<Diagnosis>();

        public Form_Diagnosis()
        {
            InitializeComponent();

            this._diagnosisBindingList = new BindingList<Diagnosis>(this._diagnosisRepository.FindAll());

            this.dataGridView1.DataSource = this._diagnosisBindingList;
            this.RefreshGrid();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_AddDiagnosis frm = new Form_AddDiagnosis();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                Diagnosis p = frm.GetData();

                this._diagnosisRepository.Create(p);
                this._diagnosisBindingList.Add(p);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Form_AddDiagnosis frm = new Form_AddDiagnosis();

            int index = this.dataGridView1.CurrentRow.Index;
            Diagnosis p = this._diagnosisBindingList[index];

            frm.FillInfo(p);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                p.Name = frm.GetData().Name;
                p.Category = frm.GetData().Category;
                p.Description = frm.GetData().Description;

                this._diagnosisRepository.Update(p);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = _diagnosisBindingList;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            int rm_index = this._diagnosisBindingList[index].idDiagnosis;

            this._diagnosisRepository.Delete(this._diagnosisRepository.FindById(rm_index));
            this._diagnosisBindingList.RemoveAt(index);
        }

        private void RefreshGrid()
        {
            this.dataGridView1.Columns["Name"].HeaderText = "Název";
            this.dataGridView1.Columns["Category"].HeaderText = "Kategorie";
            this.dataGridView1.Columns["Description"].HeaderText = "Popis";
        }
    }
}
