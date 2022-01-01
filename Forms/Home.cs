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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor login = new Doctor();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reception login = new Reception();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management login = new Management();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Labratory login = new Labratory();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pharmacy_Login login = new Pharmacy_Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
