using System;
using Term_Project.Forms;
using System.Windows.Forms;

namespace Term_Project.Forms
{
    public partial class Lab : Form
    {
        public Lab()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Finding f = new Finding();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home logout = new Home();
            logout.Closed += (s, args) => this.Close();
            logout.Show();
        }
    }
}
