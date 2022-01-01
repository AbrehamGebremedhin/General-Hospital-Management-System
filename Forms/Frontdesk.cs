using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Term_Project.Forms;

namespace Term_Project
{
    public partial class Frontdesk : Form
    {
        public Frontdesk()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPatient Register = new NewPatient();
            Register.Closed += (s, args) => this.Close();
            Register.Show();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            NewPatient f = new NewPatient();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Appointement a = new Appointement();
            a.TopLevel = false;
            panel2.Controls.Add(a);
            a.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            BillMenu b = new BillMenu();
            b.TopLevel = false;
            panel2.Controls.Add(b);
            b.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home logout = new Home();
            logout.Closed += (s, args) => this.Close();
            logout.Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Rooms_FrontDesk rf = new Rooms_FrontDesk();
            rf.TopLevel = false;
            panel2.Controls.Add(rf);
            rf.Show();
        }
    }
}
