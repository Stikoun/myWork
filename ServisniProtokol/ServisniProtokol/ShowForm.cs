using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisniProtokol
{
    public partial class ShowForm : Form
    {
        ServiceProtocol _protocol;
        public ShowForm(ServiceProtocol protocol)
        {
            _protocol = protocol;
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            _protocol.Render(e.Graphics);
        }
    }
}
