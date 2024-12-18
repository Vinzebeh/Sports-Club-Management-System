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
    public partial class viewAssign : Form
    {
        public viewAssign()
        {
            InitializeComponent();
        }

        private void viewAssign_Load(object sender, EventArgs e)
        {
            ArrayList name = new ArrayList();
            name = competition.viewAssignStudent();
            foreach (var item in name)
            {
                lstViewAss.Items.Add(item);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lstViewAss.SelectedItems.Count > 0)
            {
                ArrayList com = new ArrayList();
                competition o1 = new competition ();
                o1.CompID = lstViewAss.SelectedItem.ToString();
                com = competition.AssignLog(o1);

                string message = "Student name:\n";
                foreach (var item in com)
                {
                    message += item.ToString() + "\n";
                }

                MessageBox.Show(message, "Student name");

            }
            else
            {
                MessageBox.Show("Please select a coach name");
            }
        }
    }
}
