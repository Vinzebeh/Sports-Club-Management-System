using Assignment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class competition
    {
        private string competitionName;
        private DateTime date;
        private string studID;
        private string compID;
        
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());

        public string StudID { get => studID; set => studID = value; }
        public string CompID { get => compID; set => compID = value; }
       
        public DateTime Date { get => date; set => date = value; }
        public string CompetitionName { get => competitionName; set => competitionName = value; }



        public competition(string n, DateTime d)
        {
            competitionName = n;
            date = d;
        }

        public competition(string n)
        {
            competitionName = n;
        }

        public competition()
        {
           
        }

        public string addCompetition()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into competition(competition, date) values(@name, @d)", con);
            cmd.Parameters.AddWithValue("@name", competitionName);
            cmd.Parameters.AddWithValue("@d", date);
           
          
           int i =cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Add Successful";
            else
                status = "Add Unsuccessful";


                con.Close();
            return status;
        }

        public string deleteCompetition()
        {
            string status;
            con.Open();
            SqlCommand cmdDelete = new SqlCommand("Delete from competition where Competition = @name", con);
            cmdDelete.Parameters.AddWithValue("@name", competitionName);
            int rowsAffected = cmdDelete.ExecuteNonQuery();

            if (rowsAffected > 0)
                status = "manager deleted successfully.";
            else
                status = "Manager not found or unable to delete.";
            con.Close();
            return status;

        }
        public static ArrayList viewCompetition()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Competition from competition", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static ArrayList viewStudent()
        {
            ArrayList mn = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select MemberName from member", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                mn.Add(rd.GetString(0));
            }
            con.Close();
            return mn;
        }

        public string View()
        {
            string status = "Profile not found.";
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM competition WHERE competition = @a AND date = @b", con);
            cmd.Parameters.AddWithValue("@a", competitionName);
            cmd.Parameters.AddWithValue("@b", date);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                competitionName = reader.GetString(0);
                status = "Profile data retrieved successfully.";
            }
            con.Close();
            return status;
        }
     
        public static ArrayList viewAssignStudent()
        {
            ArrayList nm = new ArrayList();

            con.Open();
            SqlCommand cmd = new SqlCommand("select distinct [Competition Name] from assignstud", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read()) 
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static ArrayList AssignLog(competition o1)
        {
            ArrayList com = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select [Student Name] from assignstud WHERE [Competition Name] = @compID", con);
            cmd.Parameters.AddWithValue("@compID", o1.compID);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read()) 
            {
                o1.studID = rd.GetString(0);
                com.Add(o1.studID);
            }
            con.Close();
            return com;
        }

        public string updateProfile(DateTime d)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update competition set date=@d where Competition = @cm", con);
            cmd.Parameters.AddWithValue("@d", d);
            cmd.Parameters.AddWithValue("@cm", competitionName);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update";
            con.Close();
            return status;
        }

        public static void viewProfile(competition o)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select date from competition WHERE Competition = @c", con);
            cmd.Parameters.AddWithValue("@c", o.competitionName);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                
                o.date = rd.GetDateTime(0);
            }
            con.Close();
            


        }
    }
}


        






