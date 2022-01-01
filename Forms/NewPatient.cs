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

namespace Term_Project
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontdesk Menu = new Frontdesk();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {

        }

        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Newpatient obj = new Newpatient(textBox1.Text,textBox3.Text,textBox2.Text,dateTimePicker1.Value,float.Parse(textBox5.Text),textBox4.Text,textBox6.Text,comboBox1.Text,textBox7.Text,textBox8.Text,textBox9.Text,comboBox2.Text);
            obj.saveUser();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.ResetText();
        }
    }
}
