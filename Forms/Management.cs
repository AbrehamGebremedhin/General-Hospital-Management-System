using System;
using Term_Project.Forms;
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
    public partial class Management : Form
    {
        public Management()
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
            Management_Dashboard Main = new Management_Dashboard();
            Main.Closed += (s, args) => this.Close();
            Main.Show();
        }
    }
}
