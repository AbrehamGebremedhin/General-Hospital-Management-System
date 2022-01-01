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
    public partial class Rooms_FrontDesk : Form
    {
        public Rooms_FrontDesk()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Roomentry roomentry = new Roomentry(siticoneTextBox1.Text,siticoneTextBox2.Text,siticoneTextBox3.Text,int.Parse(siticoneTextBox4.Text));
            roomentry.saveUser();
        }

        private void Rooms_FrontDesk_Load(object sender, EventArgs e)
        {
            try {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-TIDFO3J\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("select count(room_status) from tblRoom where room_status = 'Occupied'", con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    string count = reader["laborder_order"].ToString();
                    int row = int.Parse(count);
                    guna2CircleProgressBar1.Increment(row);
                }
                con.Close();
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
            
        }
    }
}
