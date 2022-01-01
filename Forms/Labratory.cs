using System;
using Term_Project.Forms;
using System.Windows.Forms;

namespace Term_Project
{
    public partial class Labratory : Form
    {
        public Labratory()
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
            Lab Main = new Lab();
            Main.Closed += (s, args) => this.Close();
            Main.Show();
        }
    }
}
