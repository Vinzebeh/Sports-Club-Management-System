using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Assignment
{
    internal class manager
    {
        private string studName;
        private string coachName;
        private string mngname;
        private string email;
        private string contactnumber;
        private SqlMoney salary;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());

        public string StudName { get => studName; set => studName = value; }
        public string CoachName { get => coachName; set => coachName = value; }
        public string Email { get => email; set => email = value; }
        public string Contactnumber { get => contactnumber; set => contactnumber = value; }
        public string Mngname { get => mngname; set => mngname = value; }
        public SqlMoney Salary { get => salary; set => salary = value; }

        public manager()
        { 
        
        }

        public manager(string c)
        {
            coachName = c;
        }
        

        public static implicit operator UserControl(manager v)
        {
            throw new NotImplementedException();
        }

        public static void Viewprofile(manager o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from manager where name = @b", con);
            cmd.Parameters.AddWithValue("@b", o1.mngname);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.email = rd.GetString(2);
                o1.contactnumber = rd.GetString(3);
                o1.salary = rd.GetSqlMoney(4);
            }
            con.Close();

        }

        public static ArrayList viewReccomendStudent()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select studname from Recommendation", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static void viewRecLog(admin o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select LessonType, Performances from member where MemberName = @a", con);
            cmd.Parameters.AddWithValue("@a", o1.Membername);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.Level = rd.GetString(0);
                o1.Performances = rd.GetString(1);
            }
            con.Close();
        }

    }

}


 
