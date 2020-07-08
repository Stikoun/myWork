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
    public partial class Form_Drugs : Form
    {
        private DrugRepository _drugRepository = new DrugRepository();
        private BindingList<Drug> _drugBindingList = new BindingList<Drug>();

        public Form_Drugs()
        {
            InitializeComponent();

            this._drugBindingList = new BindingList<Drug>(this._drugRepository.FindAll());
            this.dataGridView1.DataSource = this._drugBindingList;

            this.RefreshGrid();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_AddDrug frm = new Form_AddDrug();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                Drug p = frm.GetData();

                this._drugRepository.Create(p);
                this._drugBindingList.Add(p);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Form_AddDrug frm = new Form_AddDrug();

            int index = this.dataGridView1.CurrentRow.Index;
            Drug p = this._drugBindingList[index];

            frm.FillInfo(p);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                p.Name = frm.GetData().Name;
                p.Category = frm.GetData().Category;
                p.AdultDosage = frm.GetData().AdultDosage;
                p.KinderDosage = frm.GetData().KinderDosage;

                this._drugRepository.Update(p);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = _drugBindingList;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            int rm_index = this._drugBindingList[index].idDrug;

            this._drugRepository.Delete(this._drugRepository.FindById(rm_index));
            this._drugBindingList.RemoveAt(index);
        }

        private void RefreshGrid()
        {
            this.dataGridView1.Columns["Name"].HeaderText = "Název";
            this.dataGridView1.Columns["Category"].HeaderText = "Kategorie";
            this.dataGridView1.Columns["AdultDosage"].HeaderText = "Dávkování pro dospělé";
            this.dataGridView1.Columns["KinderDosage"].HeaderText = "Dávkování pro děti";

        }
    }
}
