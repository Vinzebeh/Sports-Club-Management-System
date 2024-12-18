using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class record
    {
        private string competitionName;
        private string result;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());

        public record(string c, string r) 
        {
            competitionName = c;
            result = r;

        }

        public string recordComp()
        {
            string status;
            con.Open();

            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM competition WHERE competition = @competitionName", con);
            checkCmd.Parameters.AddWithValue("@competitionName", competitionName);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                SqlCommand updateCmd = new SqlCommand("UPDATE competition SET result = @r WHERE competition = @competitionName", con);
                updateCmd.Parameters.AddWithValue("@competitionName", competitionName);
                updateCmd.Parameters.AddWithValue("@r", result);
                int updatedRows = updateCmd.ExecuteNonQuery();

                if (updatedRows > 0)
                    status = "Update Successful";
                else
                    status = "Update Unsuccessful";
            }
            else
            {
                SqlCommand insertCmd = new SqlCommand("INSERT INTO competition (competition, result) VALUES (@competitionName, @r)", con);
                insertCmd.Parameters.AddWithValue("@competitionName", competitionName);
                insertCmd.Parameters.AddWithValue("@r", result);
                int insertedRows = insertCmd.ExecuteNonQuery();

                if (insertedRows > 0)
                    status = "Add Successful";
                else
                    status = "Add Unsuccessful";
            }

            con.Close();
            return status;
        }

        }
    }








