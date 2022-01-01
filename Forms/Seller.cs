using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Term_Project.Classes;

namespace Term_Project.Forms
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            RequestClass request = new RequestClass(siticoneTextBox1.Text,siticoneTextBox2.Text,int.Parse(siticoneTextBox3.Text));
            request.saveUser();
        }
    }
}
