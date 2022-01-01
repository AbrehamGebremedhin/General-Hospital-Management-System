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
using System.Data.SqlClient;

namespace Term_Project.Forms
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox2.Checked)
            {
                siticoneCheckBox2.Checked = false;
            }
        }

        private void siticoneCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox1.Checked)
            {
                siticoneCheckBox1.Checked = false;
            }
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            if (siticoneCheckBox1.Checked)
            {
                Report report = new Report(int.Parse(siticoneTextBox5.Text),siticoneTextBox2.Text,siticoneTextBox3.Text,int.Parse(siticoneTextBox4.Text),siticoneCheckBox1.Text);
                report.saveUser();
            }
            else if (siticoneCheckBox2.Checked)
            {
                Report report = new Report(int.Parse(siticoneTextBox5.Text), siticoneTextBox2.Text, siticoneTextBox3.Text, int.Parse(siticoneTextBox4.Text), siticoneCheckBox2.Text);
                report.saveUser();
            }
            
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TIDFO3J\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select labresult_id,labresult_result from tblLabresult where labresult_id = " + siticoneTextBox5.Text, con);
            cmd.Parameters.AddWithValue("labresult_id", siticoneTextBox5.Text);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                siticoneTextBox1.Text = reader["labresult_result"].ToString();
            }
            con.Close();
        }
    }
}
