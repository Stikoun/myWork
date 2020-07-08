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
    public partial class Form_Users : Form
    {
        private UserRepository _userRepository = new UserRepository();
        private BindingList<User> _userBindingList = new BindingList<User>();

        public Form_Users()
        {
            InitializeComponent();

            this._userBindingList = new BindingList<User>(this._userRepository.FindAll());
            this.dataGridView1.DataSource = this._userBindingList;

            this.RefreshGrid();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_AddUser frm = new Form_AddUser();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                User p = frm.GetData();

                this._userRepository.Create(p);
                this._userBindingList.Add(p);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Form_AddUser frm = new Form_AddUser();

            int index = this.dataGridView1.CurrentRow.Index;
            User p = this._userBindingList[index];

            frm.FillInfo(p);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                p.Username = frm.GetData().Username;
                p.Password = frm.GetData().Password;
                p.isAdmin = frm.GetData().isAdmin;

                this._userRepository.Update(p);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = _userBindingList;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            int rm_index = this._userBindingList[index].idUser;

            this._userRepository.Delete(this._userRepository.FindById(rm_index));
            this._userBindingList.RemoveAt(index);
        }

        private void RefreshGrid()
        {
            this.dataGridView1.Columns["Password"].HeaderText = "Heslo";
            this.dataGridView1.Columns["isAdmin"].HeaderText = "Administrátor";
            this.dataGridView1.Columns["Username"].HeaderText = "Uživatelské jméno";
        }
    }
}
