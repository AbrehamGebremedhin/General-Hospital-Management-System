using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using Term_Project.Forms;

namespace Term_Project
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Home Main = new Home();
            Main.Closed += (s, args) => this.Close();
            Main.Show();
        }

        private void siticoneCircleButton1_Click(object sender, System.EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server = LENOVO-X6801\\MSSQLSERVER1;database = dbLogin;Uid = Log;Password=12345678");
            string query = "select count(*) from tbllogin where Username = '" + siticoneTextBox2.Text.Trim() + "' and Password = '" + siticoneTextBox3.Text.Trim() + "'";
            SqlDataAdapter sqa = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (dt.Rows.Count == 1)
            { 
                Doctor_DashBoard Menu = new Doctor_DashBoard();
                this.Hide();
                Menu.Closed += (s, args) => this.Close();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Username/Password is incorrect. Please try again!");
            }



        }

        private void siticoneTextBox2_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
