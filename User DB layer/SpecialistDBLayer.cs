using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Term_Project.Classes;

namespace Term_Project.User_DB_layer
{
    class SpecialistDBLayer
    {
        String connectionString = "server = LENOVO-X6801\\MSSQLSERVER1;database = HospitalManagementSystem;Uid = HMS;Password=12345678";


        public void savePatient(NewSpecialist p)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("New_Specialist", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstname", p.firstname);
                    cmd.Parameters.AddWithValue("@middlename", p.middlename);
                    cmd.Parameters.AddWithValue("@lastname", p.lastname);
                    cmd.Parameters.AddWithValue("@phone", p.phonenumber);
                    cmd.Parameters.AddWithValue("@address", p.address);
                    cmd.Parameters.AddWithValue("@gender", p.gender);
                    cmd.Parameters.AddWithValue("@dob", p.dob);
                    cmd.Parameters.AddWithValue("@qualification", p.qualification);
                    cmd.Parameters.AddWithValue("@speciality", p.speciality);
                    cmd.Parameters.AddWithValue("@salary", p.salary);
                    cmd.Parameters.AddWithValue("@joindate", p.joindate);


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
