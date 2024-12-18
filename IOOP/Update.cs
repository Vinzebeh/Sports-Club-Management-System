using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;

namespace Assignment
{
    class UpdateP
    {
        private string name;
        private string email;
        private string password;
        private string phonNum;
        private string level;
        private string role;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string PhonNum { get => phonNum; set => phonNum = value; }
        public string Name { get => name; set => name = value; }
        public string Level { get => level; set => level = value; }

        public UpdateP(string em)
        {
            email = em;
        }

        public UpdateP(string nm, string em, string num, string pw)
        {
            name = nm;
            email = em;
            phonNum = num;
            password = pw;
        }

        public static void viewProfile(UpdateP obj)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select password, role from users where email = @em", con);
            cmd2.Parameters.AddWithValue("@em", obj.email);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                obj.password = rd2.GetString(0);
                obj.role = rd2.GetString(1);
            }
            SqlCommand cmd = new SqlCommand();
            if (obj.role == "Coach")
            {
                cmd.CommandText = "select * from coach where email = @e";
                cmd.Parameters.AddWithValue("@e", obj.email);
            }
            else if (obj.role == "Manager")
            {
                cmd.CommandText = "select * from manager where email = @e";
                cmd.Parameters.AddWithValue("@e", obj.email);
            }
            else if (obj.role == "admin")
            {
                cmd.CommandText = "select * from users where email = @e";
                cmd.Parameters.AddWithValue("@e", obj.email);
            }
        

            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                obj.name = rd.GetString(1);
                obj.phonNum = rd.GetString(3);
            }
            

            con.Close();
        }

        public static void profilecheck(UpdateP obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Coach where email = @e", con);
            cmd.Parameters.AddWithValue("@e", obj.email);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                obj.name = rd.GetString(1);
                obj.level = rd.GetString(5);
            }
            con.Close();
        }


        public string updateProfile(string nm, string num, string pw)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update Coach set name = @a, contact_number = @p where email = @em", con);
            cmd.Parameters.AddWithValue("@a", nm);
            cmd.Parameters.AddWithValue("@p", num);
            cmd.Parameters.AddWithValue("@em", email);
            SqlCommand cmd2 = new SqlCommand("update users set password = @pw where email = @em", con);
            cmd2.Parameters.AddWithValue("@pw", pw);
            cmd2.Parameters.AddWithValue("@em", email);
            cmd2.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = $"Profile has been successfully updated.\nUser Name: {nm}\nEmail: {email}\nPhone Number: {num}\nPassword: {pw}";
            else
                status = "Unable to update profile.";
            con.Close();

            return status;
        }
    }
}
