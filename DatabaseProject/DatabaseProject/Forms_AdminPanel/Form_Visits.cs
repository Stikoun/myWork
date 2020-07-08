using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms_AdminPanel
{
    public partial class Form_Visits : Form
    {
        private Repository.VisitRepository _visitRepository = new Repository.VisitRepository();
        private BindingList<Visit> _visitBindingList = new BindingList<Visit>();

        public Form_Visits()
        {
            InitializeComponent();

            this._visitBindingList = new BindingList<Visit>(this._visitRepository.FindAll());
            this.dataGridView1.DataSource = this._visitBindingList;

            this.RefreshGrid();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Forms_Add.Form_AddVisit frm = new Forms_Add.Form_AddVisit();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                Visit v = frm.GetData();

                this._visitRepository.Create(v);
                this._visitBindingList.Add(v);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Forms_Add.Form_AddVisit frm = new Forms_Add.Form_AddVisit();

            int index = this.dataGridView1.CurrentRow.Index;
            Visit v = this._visitBindingList[index];

            frm.FillInfo(v);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                v.idCase = frm.GetData().idCase;
                v.VisitDate = frm.GetData().VisitDate;
                v.Description = frm.GetData().Description;

                this._visitRepository.Update(v);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = _visitBindingList;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            int rm_index = this._visitBindingList[index].idVisit;

            this._visitRepository.Delete(this._visitRepository.FindById(rm_index));
            this._visitBindingList.RemoveAt(index);
        }

        private void RefreshGrid()
        {
            this.dataGridView1.Columns["VisitDate"].HeaderText = "Datum";
            this.dataGridView1.Columns["Description"].HeaderText = "Popis";
        }
    }
}
