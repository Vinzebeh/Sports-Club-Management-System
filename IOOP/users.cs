using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class users
    {
        private string email;
        private string password;

        public users(string u, string p)
        {
            email = u;
            password = p;
        }

        public string login(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select count(*) from users where email = @a and password = @b", con);
            cmd.Parameters.AddWithValue("@a", email);
            cmd.Parameters.AddWithValue("@b", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("Select role from users where email = @a and password = @b", con);
                cmd2.Parameters.AddWithValue("@a", email);
                cmd2.Parameters.AddWithValue("@b", password);

                string userrole = cmd2.ExecuteScalar().ToString();

                if (userrole == "Coach")
                {
                    SqlCommand cmd3 = new SqlCommand("Select name from users where email = @a", con);
                    cmd3.Parameters.AddWithValue("@a", email);
                    string o = cmd3.ExecuteScalar().ToString();
                    Coach_Main a = new Coach_Main(o);
                    Update_Profile b = new Update_Profile(email);
                    Add_Schedule add = new Add_Schedule(email);
                    Edit_Schedule edit = new Edit_Schedule(email);
                    Delete_Schedule delete = new Delete_Schedule(email);
                    View_Payment view = new View_Payment(email);
                    Recommendation rec = new Recommendation(email);
                    Record_Performances record = new Record_Performances(email);
                    a.ShowDialog();
                }
                else if (userrole == "admin")
                {
                    SqlCommand cmd3 = new SqlCommand("Select name from users where email = @a", con);
                    cmd3.Parameters.AddWithValue("@a", email);
                    string o = cmd3.ExecuteScalar().ToString();
                    Update_Profile b = new Update_Profile(email);
                    AdminPage a = new AdminPage(o);
                    a.ShowDialog();
                }
                else if (userrole == "Manager")
                {
                    SqlCommand cmd3 = new SqlCommand("Select name from users where email = @a", con);
                    cmd3.Parameters.AddWithValue("@a", email);
                    string o = cmd3.ExecuteScalar().ToString();
                    ManagerHome a = new ManagerHome(o);
                    Update_Profile b = new Update_Profile(email);
                    a.ShowDialog();
                }
            }
            else
                status = "Incorrect username/password";
            con.Close();
            return status;
        }
    }
}

