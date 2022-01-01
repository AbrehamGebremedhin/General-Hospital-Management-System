using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Term_Project.Classes;

namespace Term_Project.Forms
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TIDFO3J\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select Patient_ID,diagnosis_medicine from tblDiagnosis where Patient_ID = " + siticoneTextBox1.Text, con);
            cmd.Parameters.AddWithValue("Patient_ID", siticoneTextBox1.Text);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                siticoneTextBox2.Text = reader["diagnosis_medicine"].ToString();
            }
            con.Close();
        }
    }
}
