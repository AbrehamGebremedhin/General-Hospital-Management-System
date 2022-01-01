
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
    class DisplayLabRequest
    {
        String connectionString = "server = LENOVO-X6801\\MSSQLSERVER1;database = HospitalManagementSystem;Uid = HMS;Password=12345678";


        public void savePatient(LabratoryRequest p)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@id", p.id);
                    
                    cmd.Parameters["@request"].Direction = ParameterDirection.Output;

                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        p.request = reader["@request"].ToString();
                    }

                   
                    
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