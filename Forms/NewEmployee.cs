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
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Specialist")
            {
                label13.Visible = true;
                textBox7.Visible = true;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Admission Clerk")
            {
                NewAdmissionClerk clerk = new NewAdmissionClerk(textBox1.Text,textBox3.Text,textBox2.Text,dateTimePicker1.Value,textBox4.Text,textBox6.Text,comboBox1.Text,comboBox2.Text,comboBox3.Text,int.Parse(textBox5.Text),dateTimePicker2.Value);
                clerk.saveUser(); 
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
            }
            else if(comboBox2.Text == "Doctor")
            {
                NewDoctor doctor = new NewDoctor(textBox1.Text, textBox3.Text, textBox2.Text, dateTimePicker1.Value, textBox4.Text, textBox6.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, int.Parse(textBox5.Text), dateTimePicker2.Value);

                doctor.saveUser();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
            }
            else if(comboBox2.Text == "Janitor")
            {
                NewJanitor janitor = new NewJanitor(textBox1.Text, textBox3.Text, textBox2.Text, dateTimePicker1.Value, textBox4.Text, textBox6.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, int.Parse(textBox5.Text), dateTimePicker2.Value);
                janitor.saveUser();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
            }
            else if(comboBox2.Text == "Labratory Technician")
            {
                NewLabratorytech tech = new NewLabratorytech(textBox1.Text, textBox3.Text, textBox2.Text, dateTimePicker1.Value, textBox4.Text, textBox6.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, int.Parse(textBox5.Text), dateTimePicker2.Value);
                tech.saveUser();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
            }
            else if(comboBox2.Text == "Nurse")
            {
                NewNurse nurse = new NewNurse(textBox1.Text, textBox3.Text, textBox2.Text, dateTimePicker1.Value, textBox4.Text, textBox6.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, int.Parse(textBox5.Text), dateTimePicker2.Value);
                nurse.saveUser();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
            }
            else if (comboBox2.Text == "Security")
            {
                NewSecurity security = new NewSecurity(textBox1.Text, textBox3.Text, textBox2.Text, dateTimePicker1.Value, textBox4.Text, textBox6.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, int.Parse(textBox5.Text), dateTimePicker2.Value);

                security.saveUser();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
            }
            else if (comboBox2.Text == "Specialist")
            {
                NewSpecialist specialist = new NewSpecialist(textBox1.Text, textBox3.Text, textBox2.Text, dateTimePicker1.Value, textBox4.Text, textBox6.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, int.Parse(textBox5.Text), dateTimePicker2.Value,textBox7.Text);

                specialist.saveUser();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
            }
            else
            {
                MessageBox.Show("Invalid job position");
            }
        }
    }
}
