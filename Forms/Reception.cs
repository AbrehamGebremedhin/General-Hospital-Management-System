using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term_Project
{
    public partial class Reception : Form
    {
        public Reception()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Main = new Home();
            Main.Closed += (s, args) => this.Close();
            Main.Show();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontdesk Menu = new Frontdesk();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }

        private void siticoneTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
