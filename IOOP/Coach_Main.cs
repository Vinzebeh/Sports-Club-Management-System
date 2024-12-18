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
    public partial class Coach_Main : Form
    {
        public static string name;

        public Coach_Main()
        {
            InitializeComponent();
        }

        public Coach_Main(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void Coach_Main_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = $"Hello, {name}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Schedule ad = new Add_Schedule();
            ad.ShowDialog();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_Schedule ed = new Edit_Schedule();
            ed.ShowDialog();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_Schedule de = new Delete_Schedule();
            de.ShowDialog();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View_Payment vp = new View_Payment();
            vp.ShowDialog();
            this.Hide();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Record_Performances rp = new Record_Performances();
            rp.ShowDialog();
            this.Hide();
        }

        private void btnRcm_Click(object sender, EventArgs e)
        {
            Recommendation re = new Recommendation();
            re.ShowDialog();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Profile up = new Update_Profile();
            up.ShowDialog();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            MessageBox.Show("You have successfully signed out.");
        }
    }
}
