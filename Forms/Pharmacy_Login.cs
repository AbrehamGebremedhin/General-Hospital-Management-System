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
    public partial class Pharmacy_Login : Form
    {
        public Pharmacy_Login()
        {
            InitializeComponent();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Pharmacy login = new Pharmacy();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Main = new Home();
            Main.Closed += (s, args) => this.Close();
            Main.Show();
        }
    }
}
