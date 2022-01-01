using System;
using Term_Project.Forms;
using System.Windows.Forms;

namespace Term_Project.Forms
{
    public partial class Management_Dashboard : Form
    {
        public Management_Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            NewEmployee n = new NewEmployee();
            n.TopLevel = false;
            panel3.Controls.Add(n);
            n.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Edit_Employee edit = new Edit_Employee();
            edit.TopLevel = false;
            panel3.Controls.Add(edit);
            edit.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Room n = new Room();
            n.TopLevel = false;
            panel3.Controls.Add(n);
            n.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Request r = new Request();
            r.TopLevel = false;
            panel3.Controls.Add(r);
            r.Show();
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
