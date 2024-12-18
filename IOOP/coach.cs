using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Data.SqlTypes;

namespace Assignment
{
    class coach
    {
        private string date;
        private string time;
        private string venue;
        private string duration;
        private string name;
        private string level;
        private string email;
        private string contactnumber;
        private SqlMoney salary;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Email { get => email; set => email = value; }
        public string Contactnumber { get => contactnumber; set => contactnumber = value; }
        public SqlMoney Salary { get => salary; set => salary = value; }
        public string Level { get => level; set => level = value; }
        public string Name { get => name; set => name = value; }

        public coach () { }

        public coach (string cn)
        {
            name = cn;
        }

        public coach(string cn, string em, string ctn, SqlMoney sl, string level)
        {
            name = cn;
            email = em;
            contactnumber = ctn;
            salary = sl;
            this.level = level;
        }

        public coach(string n, string d, string t, string du, string v, string l)
        {
            this.name = n;
            this.date = d;
            this.time = t;
            this.duration = du;
            this.venue = v;
            this.level = l;
        }

        public static void Viewprofile(coach slec)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from coach where name = @b", con);
            cmd.Parameters.AddWithValue("@b", slec.name);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                slec.email = rd.GetString(2);
                slec.contactnumber = rd.GetString(3);
                slec.salary = rd.GetSqlMoney(4);
                slec.level = rd.GetString(5);
            }
            con.Close();
        }

        public string addschedule()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Training_Schedule(name,date,time,duration,venue,level) values(@name,@date,@time,@duration,@venue,@level)", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue ("@time", time);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@venue", venue);
            cmd.Parameters.AddWithValue("@level", level);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "New training has successfully been added into the schedule ";
            else
                status = "Unavailable to add a new training schedule";
            con.Close();
            return status;
        }

        public static ArrayList viewschedule(string n, string l)
        {
            ArrayList sc = new ArrayList();
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Training_Schedule where name = @a and level = @l order by date", con);
            cmd.Parameters.AddWithValue("@a", n);
            cmd.Parameters.AddWithValue("@l", l);
            SqlDataReader rd = cmd.ExecuteReader();
            
            while (rd.Read())
            {
                string date = ((DateTime)rd["Date"]).ToString("yyyy-MM-dd");
                string data = $"{date} | {rd["Time"]} | {rd["Duration"]} | {rd["Venue"]} | {rd["Level"]}";
                sc.Add(data);
            }
            con.Close();
            return sc;

        }

        public string editschedule(string d, string t, string du, string v, string l, string oldTime)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update Training_Schedule set time = @t, duration = @du, venue = @v, level = @l where date = @d and time = @oldTime", con);
            cmd.Parameters.AddWithValue("@d", d);
            cmd.Parameters.AddWithValue("@t", t);
            cmd.Parameters.AddWithValue("@du", du);
            cmd.Parameters.AddWithValue("@v", v);
            cmd.Parameters.AddWithValue("@l", l);
            cmd.Parameters.AddWithValue("@oldTime", oldTime);


            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Training schedule has sucessfully updated";
            else
                status = "Unavailable to update training schedule";
            con.Close();

            return status;
        }

        public string deleteschedule(string d, string n)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from Training_Schedule where date = @d and name = @n", con);
            cmd.Parameters.AddWithValue("@d", d);
            cmd.Parameters.AddWithValue("@n", n);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Training schedule has been successfully deleted";
            else
                status = "Unavailable to delete training schedule";
            con.Close();

            return status;
        }

        public static void viewPayment(string l, ArrayList stud, ArrayList pay)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select [Student Name], [Payment Amount], Class_Level from Income where [Payment Amount] is not null and Class_Level = @l", con);
            cmd.Parameters.AddWithValue("@l", l);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                stud.Add(rd.GetString(0));
                pay.Add(rd.GetSqlMoney(1));
            }

            con.Close();

        }

        public static ArrayList viewMember(string l)
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select MemberName, LessonType from member where LessonType = @l ", con);
            cmd.Parameters.AddWithValue("@l", l);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                string name = rd.GetString(0);
                nm.Add(name);
            }

            con.Close();
            return nm;
        }

        public static ArrayList viewToRecommend(string l)
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select MemberName, performances, LessonType from member where LessonType = @l AND performances is not null", con);
            cmd.Parameters.AddWithValue("@l", l);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string name = rd.GetString(0);
                string p = rd.GetString(1);
                string t = rd.GetString(2);
                nm.Add($"{name} | {p} | {t}");
            }

            con.Close();
            return nm;
        }

        public string recordPerformance(string n, string p, string c)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update member set Performances = @p , Comment = @c where MemberName = @nm", con);
            cmd.Parameters.AddWithValue("@p", p);
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@nm", n);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Performances has been successfully recorded.";
            else
                status = "Unable to record performances.";
            con.Close();
            return status;
        }

        public string recommendation(string cn, string sn, string p, string l)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Recommendation(CoachName,StudName) values (@cn, @sn)", con);
            cmd.Parameters.AddWithValue("@cn", cn);
            cmd.Parameters.AddWithValue("@sn", sn);
            
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Reccommendation has been successfully sent to manager.";
            else
                status = "Unable to send recommendation";
            con.Close();

            return status;
        }

    }

}
