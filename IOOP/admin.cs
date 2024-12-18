using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    internal class admin
    {
        private string membername;
        private string email;
        private string contactnumber;
        private string role;
        private SqlMoney salary;
        private string level;
        private string performances;
        private string comment;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());

        public string Email { get => email; set => email = value; }
        public string Contactnumber { get => contactnumber; set => contactnumber = value; }

        public string Membername { get => membername; set => membername = value; }
        public SqlMoney Salary { get => salary; set => salary = value; }
        public string Level { get => level; set => level = value; }
        public string Role { get => role; set => role = value; }
        public string Performances { get => performances; set => performances = value; }
        public string Comment { get => comment; set => comment = value; }

        public admin() { }
        public admin(string mbn, string em, string ctn, string tl, string rl)
        {
            membername = mbn;
            email = em;
            contactnumber = ctn;
            level = tl;
            role = rl;
        }

        public admin(string mbn, string em, string ctn, SqlMoney salary)
        {
            membername = mbn;
            email = em;
            contactnumber = ctn;
            this.salary = salary;
        }

        public admin(string mbn2)
        {
            membername = mbn2;
        }

        public admin(string membername, string email, string contactnumber, SqlMoney salary, string role)
        {
            this.membername = membername;
            this.email = email;
            this.contactnumber = contactnumber;
            this.salary = salary;
            this.role = role;
        }

        public admin(string membername, string email, string contactnumber, SqlMoney salary, string level, string role)
        {
            this.membername = membername;
            this.email = email;
            this.contactnumber = contactnumber;
            this.salary = salary;
            this.level = level;
            this.role = role;
        }

        public string addMember()
        {
            string status;
            con.Open();
            
            SqlCommand cmd2 = new SqlCommand("Select count(*) from users where email = @a", con);
            cmd2.Parameters.AddWithValue("@a", email);
            int count = Convert.ToInt32(cmd2.ExecuteScalar());
            if (count > 0)
            {
                status = "Email exist!";
            }
            else
            {
                if (role == "Member")
                {
                    SqlCommand cmd = new SqlCommand("Insert into member(MemberName, Email, Contact_Number, LessonType) values(@name, @email, @contact, @lt)", con);
                    cmd.Parameters.AddWithValue("@name", membername);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contact", contactnumber);
                    cmd.Parameters.AddWithValue("@lt", level);
                    cmd.ExecuteNonQuery();
                }
                else if (role == "Coach")
                {
                    SqlCommand cmd = new SqlCommand("Insert into coach(name, email, contact_number, salary, level) values(@name, @email, @contact, @salary, @level)", con);
                    cmd.Parameters.AddWithValue("@name", membername);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contact", contactnumber);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@level", level);
                    cmd.ExecuteNonQuery();
                }
                else if (role == "Manager")
                {
                    SqlCommand cmd = new SqlCommand("Insert into manager(name, email, contact_number, salary) values(@name, @email, @contact, @salary)", con);
                    cmd.Parameters.AddWithValue("@name", membername);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contact", contactnumber);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.ExecuteNonQuery();
                }
                
                SqlCommand cmd3 = new SqlCommand("Insert into users(email, password, role, name) values(@name, 123, @r, @n)", con);
                cmd3.Parameters.AddWithValue("@name", email);
                cmd3.Parameters.AddWithValue("@r", role);
                cmd3.Parameters.AddWithValue("@n", membername);

                int i = cmd3.ExecuteNonQuery();
                if (i != 0)
                    status = "Registration Seccessful";
                else
                    status = "Unable to register";
            }
            con.Close();
            return status;
        }
        public static ArrayList viewmembername(string role)
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            if (role == "Member")
            {
                cmd.CommandText = "Select membername from member";
            }
            else if (role == "Coach")
            {
                cmd.CommandText = "Select name from coach";
            }
            else if (role == "Manager")
            {   
                cmd.CommandText = "Select name from Manager";
            }
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static void Viewprofile(admin o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Email, Contact_Number from member where MemberName = @b", con);
            cmd.Parameters.AddWithValue("@b", o1.membername);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.email = rd.GetString(0);
                o1.contactnumber = rd.GetString(1);
            }
            con.Close();

        }

        public string editprofile(string em, string num, string sa, string lv, string role)
        {
            string status;
            con.Open();
            if (role == "Member")
            {
                SqlCommand cmd = new SqlCommand("update member set email = @e, Contact_Number = @p where membername = @nm", con);
                cmd.Parameters.AddWithValue("@e", em);
                cmd.Parameters.AddWithValue("@p", num);
                cmd.Parameters.AddWithValue("@nm", membername);
                cmd.ExecuteNonQuery();
            }
            else if (role == "Manager")
            {
                SqlCommand cmd = new SqlCommand("update manager set email = @e, contact_number = @p, salary = @s where name = @nm", con);
                cmd.Parameters.AddWithValue("@e", em);
                cmd.Parameters.AddWithValue("@p", num);
                cmd.Parameters.AddWithValue("@s", SqlMoney.Parse(sa));
                cmd.Parameters.AddWithValue("@nm", membername);
                cmd.ExecuteNonQuery();
            }
            else if (role == "Coach")
            {
                SqlCommand cmd = new SqlCommand("update coach set email = @e, contact_number = @p, salary = @y, level = @l where name = @nm", con);
                cmd.Parameters.AddWithValue("@e", em);
                cmd.Parameters.AddWithValue("@p", num);
                cmd.Parameters.AddWithValue("@y", SqlMoney.Parse(sa));
                cmd.Parameters.AddWithValue("@l", lv);
                cmd.Parameters.AddWithValue("@nm", membername);
                cmd.ExecuteNonQuery();
            }
            SqlCommand cmd2 = new SqlCommand("Update users set email = @e where name = @nm", con);
            cmd2.Parameters.AddWithValue("@e", em);
            cmd2.Parameters.AddWithValue("@nm", membername);

            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Seccessful";
            }
            else
            {
                status = "Unable to update";
            }
            con.Close();
            return status;
        }

        public string deleteuser(string role)
        {
            string status;
            con.Open();
            if (role == "Member")
            {
                SqlCommand cmd = new SqlCommand("Delete from member where membername = @n", con);
                cmd.Parameters.AddWithValue("@n", membername);
                cmd.ExecuteNonQuery();
            }
            else if (role == "Manager")
            {
                SqlCommand cmd = new SqlCommand("Delete from manager where name = @n", con);
                cmd.Parameters.AddWithValue("@n", membername);
                cmd.ExecuteNonQuery();
            }
            else if (role == "Coach")
            {
                SqlCommand cmd = new SqlCommand("Delete from coach where name = @n", con);
                cmd.Parameters.AddWithValue("@n", membername);
                cmd.ExecuteNonQuery();
            }
            SqlCommand cmd2 = new SqlCommand("Delete from users where name = @n", con);
            cmd2.Parameters.AddWithValue("@n", membername);

            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Detele Seccessful";
            }
            else
            {
                status = "Unable to delete";
            }
            con.Close();
            return status;
        }

        public static void viewcompesum(ArrayList comp, ArrayList res)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select competition, result from competition where result is not null", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                comp.Add(r.GetString(0));
                res.Add(r.GetString(1));
            }
            con.Close();
        }
        
        public static void viewsuggest(ArrayList stdn, ArrayList sug)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from suggestion", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                stdn.Add(r.GetString(1));
                sug.Add(r.GetString(2));
            }
            con.Close();
        }

        public static void viewincome(ArrayList mn, ArrayList bt, ArrayList it, ArrayList at, ArrayList tl)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Month(Date), Year(Date), Sum([Payment Amount]) from Income group by Month(Date), Year(Date)", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            { 
                string dm = r.GetInt32(0).ToString() + "/" + r.GetInt32(1).ToString();
                mn.Add(dm);
                tl.Add(r.GetDecimal(2));
            }
            SqlCommand cmd2 = new SqlCommand("Select Month(Date) AS Month, Sum([Payment Amount]) AS totalpayment from Income where Class_Level = 'Beginner' group by Month(Date)", con);
            SqlDataReader rd = cmd2.ExecuteReader();
            while (rd.Read())
            {
                bt.Add(rd.GetDecimal(1));
            }
            SqlCommand cmd3 = new SqlCommand("Select Month(Date) AS Month, Sum([Payment Amount]) AS totalpayment from Income where Class_Level = 'Intermediate' group by Month(Date)", con);
            SqlDataReader red = cmd3.ExecuteReader();
            while (red.Read())
            {
               it.Add(red.GetDecimal(1));
            }
            SqlCommand cmd4 = new SqlCommand("Select Month(Date) AS Month, Sum([Payment Amount]) AS totalpayment from Income where Class_Level = 'Advance' group by Month(Date)", con);
            SqlDataReader read = cmd4.ExecuteReader();
            while (read.Read())
            {
                at.Add(read.GetDecimal(1));
            }
            con.Close();
        }
    }
}
