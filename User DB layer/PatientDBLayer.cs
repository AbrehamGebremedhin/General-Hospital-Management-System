using Microsoft.SqlServer.Server;
using System;
using Term_Project.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Term_Project.User_DB_layer
{
    class PatientDBLayer
    {
        String connectionString = "server = LENOVO-X6801\\MSSQLSERVER1;database = test;Uid = test;Password=12345678";
        string queryString = "SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];  ";

        public void savePatient(Newpatient p)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("New_patient", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstname",p.firstname);
                    cmd.Parameters.AddWithValue("@middlename", p.middlename);
                    cmd.Parameters.AddWithValue("@lastname", p.lastname);
                    cmd.Parameters.AddWithValue("@dob", p.dob);
                    cmd.Parameters.AddWithValue("@weight", p.weight);
                    cmd.Parameters.AddWithValue("@phone", p.phonenumber);
                    cmd.Parameters.AddWithValue("@email", p.email);
                    cmd.Parameters.AddWithValue("@address", p.address);
                    cmd.Parameters.AddWithValue("@gender", p.gender);
                    cmd.Parameters.AddWithValue("@phone_2", p.alternativephonenumber);
                    cmd.Parameters.AddWithValue("@martial", p.martialstatus);
                    cmd.Parameters.AddWithValue("@doctor_id", p.doctorid);

                    int row = cmd.ExecuteNonQuery();
                    
                    if (row > 0)
                    {
                        MessageBox.Show("save succesfully !");
                    }

                    SqlCommand command = new SqlCommand(queryString, con);

                    SqlDataReader rdr = command.ExecuteReader();


                    if (rdr.Read())
                    {
                        string ID = rdr["SELECT SCOPE_IDENTITY() AS[SCOPE_IDENTITY]"].ToString();
                        MessageBox.Show(ID);
                    }
                    rdr.Close();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private OleDbConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}