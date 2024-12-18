using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class AssignStud : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());
        public AssignStud()
        {
            InitializeComponent();
            
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string status = null;
            string selectedcomp = lstComp.SelectedItem.ToString();
            ArrayList slcsstud = new ArrayList();

            if (selectedcomp != null && lstStud.CheckedItems.Count > 0)
            {
                con.Open();
                for (int it = 0; it < lstStud.CheckedItems.Count; it++)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO assignstud ([Competition Name], [Student Name]) VALUES (@cn, @sn)",con);
                    cmd.Parameters.AddWithValue("@cn", selectedcomp);
                    cmd.Parameters.AddWithValue("@sn", lstStud.CheckedItems[it]);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        status = "Add Successful";
                    else
                        status = "Add Unsuccessful";
                }
                con.Close();
            }
            else
            {
                status = "Please select both a competition and a student.";
            }

            MessageBox.Show(status);

        }



        private void lstComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstStud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssignStud_Load(object sender, EventArgs e)
        {
            ArrayList name = new ArrayList();
            name = competition.viewCompetition();
            foreach (var item in name)
            {
                lstComp.Items.Add(item);
            }

            ArrayList studName = new ArrayList();
            studName = competition.viewStudent();
            foreach (var item in studName)
            {
                lstStud.Items.Add(item);
            }
        }
    }
}
    
    

