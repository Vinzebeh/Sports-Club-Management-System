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

namespace Assignment
{
    public partial class ViewCompetition : Form
    {
        public ViewCompetition()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewCompetition_Load(object sender, EventArgs e)
        {
            ArrayList name = new ArrayList();
            name = manager.viewReccomendStudent();
            foreach (var item in name)
            {
                lstComp.Items.Add(item);
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (lstComp.SelectedItems.Count > 0)
            {
                admin o1 = new admin();
                o1.Membername = lstComp.SelectedItem.ToString();
                manager.viewRecLog(o1);
                MessageBox.Show("Student Name:" + o1.Membername + "\n" + "Lesson Type:" + o1.Level + "\n" + "Performance:" + o1.Performances);


            }
            else
            {
                MessageBox.Show("Please select a member name");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }
    }

}
