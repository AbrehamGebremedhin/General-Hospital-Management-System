using System;
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
    public partial class Doctor_DashBoard : Form
    {
        public Doctor_DashBoard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Diagnosis f = new Diagnosis();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Summary s = new Summary();
            s.TopLevel = false;
            panel3.Controls.Add(s);
            s.Show();
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
