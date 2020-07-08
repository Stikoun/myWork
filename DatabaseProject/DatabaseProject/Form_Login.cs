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
    public partial class Form_Login : Form
    {
        private UserRepository _userRepository = new UserRepository();
        private bool success = false;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = this.textBox_userName.Text;
            string password = this.textBox_password.Text;

            List<User> _userList = this._userRepository.FindAll();

            if (_userList.Count != 0)
            {
                foreach (User item in _userList)
                {
                    if (item.Username == username && item.Password == password)
                    {
                        DialogResult = DialogResult.OK;
                        this.success = true;                         

                        this.Hide();

                        Form_DoctorInterface frm = new Form_DoctorInterface();

                        if (item.isAdmin)
                            frm.isAdmin = true;

                        frm.ShowDialog();

                        this.Close();
                    }
                }
                    if (!this.success)
                    {
                        DialogResult = DialogResult.Cancel;
                        MessageBox.Show("Incorrect password or username");
                    }
            }
            else
                MessageBox.Show("No users in database");
               
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox_userName.Text = "Administrator";
            this.textBox_password.Text = "admin123";
        }
    }
}
