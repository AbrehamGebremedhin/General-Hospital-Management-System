
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Term_Project.Classes;

namespace Term_Project.User_DB_layer
{
    class DisplayMedicine
    {
        String connectionString = "server = LENOVO-X6801\\MSSQLSERVER1;database = HospitalManagementSystem;Uid = HMS;Password=12345678";


        public void savePatient(Medicine p)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "dbo.(Medicine)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@id", SqlDbType.Int);
                    cmd.Parameters.Add("@medicine", SqlDbType.VarChar);
                    cmd.Parameters["@medicine"].Direction = ParameterDirection.Output;


                    con.Open();
                    cmd.ExecuteNonQuery();
                    p.medicine = cmd.Parameters["@result"].Value.ToString();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}