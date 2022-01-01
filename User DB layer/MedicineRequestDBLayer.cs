using Term_Project.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Term_Project.User_DB_layer
{
    class MedicineRequestDBLayer
    {
        String connectionString = "server = LENOVO-X6801\\MSSQLSERVER1;database = HospitalManagementSystem;Uid = HMS;Password=12345678";


        public void savePatient(RequestClass p)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Request", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@medicine", p.medicinename);
                    cmd.Parameters.AddWithValue("@manufactrer", p.manufactrer);
                    cmd.Parameters.AddWithValue("@quantity", p.quantity);

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("save succesfully !");
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