using System;
using Term_Project.Classes;
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
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Laborder order = new Laborder(int.Parse(textBox1.Text),siticoneTextBox2.Text,siticoneTextBox1.Text);

            order.saveUser();

            textBox1.Text = "";
            siticoneTextBox1.Clear();
            siticoneTextBox2.Clear();
        }
    }
}
