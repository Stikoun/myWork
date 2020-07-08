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
    public partial class Form_Doctors : Form
    {
        private DoctorRepository _doctorRepository = new DoctorRepository();
        private BindingList<Doctor> _doctorBindingList = new BindingList<Doctor>();
        private UserRepository _userRepository = new UserRepository();

        public Form_Doctors()
        {
            InitializeComponent();

            this._doctorBindingList = new BindingList<Doctor>(this._doctorRepository.FindAll());

            this.dataGridView1.DataSource = this._doctorBindingList;
            this.RefreshGrid();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_AddDoctor frm = new Form_AddDoctor();
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                Doctor p = frm.GetData();

                this._doctorRepository.Create(p);
                this._doctorBindingList.Add(p);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Form_AddDoctor frm = new Form_AddDoctor();

            int index = this.dataGridView1.CurrentRow.Index;
            Doctor p = this._doctorBindingList[index];

            frm.FillInfo(p);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                p.Name = frm.GetData().Name;
                p.Surname = frm.GetData().Surname;
                p.Birth = frm.GetData().Birth;
                p.Nationality = frm.GetData().Nationality;
                p.Residence = frm.GetData().Residence;
                p.Gender = frm.GetData().Gender;
                p.PIN = frm.GetData().PIN;
                p.idUser = frm.GetData().idUser;
                p.Username = frm.GetData().Username;

                this._doctorRepository.Update(p);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = _doctorBindingList;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            int rm_index = this._doctorBindingList[index].idDoctor;

            this._doctorRepository.Delete(this._doctorRepository.FindById(rm_index));
            this._doctorBindingList.RemoveAt(index);
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
            this.dataGridView1.Columns["Username"].HeaderText = "Uživatelské jméno";
        }
    }
}
