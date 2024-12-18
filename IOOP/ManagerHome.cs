using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment 
{
    public partial class ManagerHome : Form
    {
        public static string competitionName;
        public static string date;
        public static string coachName;
        public static string studName;
        
        public ManagerHome(string n)
        {
            InitializeComponent();
            competitionName= n;
        }
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = $"Welcome, {competitionName}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCompetition ad = new AddCompetition();
            ad.ShowDialog();
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            ViewCompetition obj = new ViewCompetition();
            obj.ShowDialog();
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            deleteCompetition ds = new deleteCompetition();
            ds.ShowDialog();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            edit ec = new edit();
            ec.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                AssignStud assignForm = new AssignStud();

                assignForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRec_Click_1(object sender, EventArgs e)
        {
            rec recForm = new rec();
            recForm.ShowDialog();
        }

        private void btnViewAssign_Click(object sender, EventArgs e)
        {
            viewAssign obj = new viewAssign();
            obj.ShowDialog();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Update_Profile up = new Update_Profile();
            up.ShowDialog();
        }
    }
    }
    
  
