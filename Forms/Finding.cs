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
    public partial class Finding : Form
    {
        public Finding()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Findings finding = new Findings(int.Parse(siticoneTextBox1.Text),siticoneTextBox2.Text);
            finding.saveUser();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TIDFO3J\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select laborder_id,laborder_order from tblLaborder where laborder_id = " + siticoneTextBox1.Text, con);
            cmd.Parameters.AddWithValue("laborder_id", siticoneTextBox1.Text);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                siticoneTextBox3.Text = reader["laborder_order"].ToString();
            }
            con.Close();
        }
    }
}
