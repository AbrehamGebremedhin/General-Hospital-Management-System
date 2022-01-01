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

namespace Term_Project.Forms
{
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Customer f = new Customer();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Seller f = new Seller();
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
