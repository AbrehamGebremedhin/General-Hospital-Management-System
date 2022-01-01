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

namespace Term_Project.Forms
{
    public partial class BillMenu : Form
    {
        public BillMenu()
        {
            InitializeComponent();
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill(textBox1.Text,siticoneComboBox1.Text,siticoneTextBox1.Text);
            bill.saveUser();

            textBox1.Clear();
            siticoneTextBox1.Clear();
            siticoneComboBox1.ResetText();
        }

        private void siticoneComboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (siticoneComboBox1.Text.Contains("Labratory"))
            {
                siticoneTextBox2.Visible = true;
                label5.Visible = true;
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (siticoneComboBox1.Text.Contains("Labratory"))
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-TIDFO3J\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("select laborder_id,laborder_order from tblLaborder where laborder_id = " + textBox1.Text, con);
                cmd.Parameters.AddWithValue("laborder_id", textBox1.Text);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    siticoneTextBox2.Text = reader["laborder_order"].ToString();
                }
                con.Close();
            }
            else if (siticoneComboBox1.Text.Contains("Semi-Private"))
            {
                string price;
                string total;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-TIDFO3J\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("select price_amount from tblPrice where price_type = Semi-Private", con);
                SqlCommand cmd1 = new SqlCommand("select datediff(DAY,GETDATE(),room_Entrydate) from tblRoom inner join tblPatient on tblRoom.room_number = tblPatient.Room where Patient_ID = " + textBox1.Text, con);
                SqlDataReader reader;
                SqlDataReader reader1;
                reader = cmd.ExecuteReader();
                reader1 = cmd1.ExecuteReader();

                if (reader.Read() && reader1.Read())
                {
                    price = reader["price_amount"].ToString();
                    total = reader1["datediff(DAY,GETDATE(),room_Entrydate)"].ToString();
                    int result = int.Parse(price) * int.Parse(total);
                    siticoneTextBox1.Text = result.ToString();
                }
                con.Close();
            }
            else if (siticoneComboBox1.Text.Contains("Private"))
            {
                string price;
                string total;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-TIDFO3J\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("select price_amount from tblPrice where price_type = Private", con);
                SqlCommand cmd1 = new SqlCommand("select datediff(DAY,GETDATE(),room_Entrydate) from tblRoom inner join tblPatient on tblRoom.room_number = tblPatient.Room where Patient_ID = " + textBox1.Text, con);
                SqlDataReader reader;
                SqlDataReader reader1;
                reader = cmd.ExecuteReader();
                reader1 = cmd1.ExecuteReader();

                if (reader.Read() && reader1.Read())
                {
                    price = reader["price_amount"].ToString();
                    total = reader1["datediff(DAY,GETDATE(),room_Entrydate)"].ToString();
                    int result = int.Parse(price) * int.Parse(total);
                    siticoneTextBox1.Text = result.ToString();
                }
                con.Close();
            }
        }
    }
}
