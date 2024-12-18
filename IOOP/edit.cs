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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            ArrayList compname = new ArrayList();
            compname = competition.viewCompetition();
            foreach (var item in compname)
            {
                lstEditComp.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstEditComp.SelectedItems.Count > 0)
            {
                competition o = new competition();
                o.CompetitionName = lstEditComp.SelectedItem.ToString();
                editComp ec = new editComp(o.CompetitionName);
                ec.ShowDialog();


            }
            else
            {
                MessageBox.Show("Please select a competition name");
            }
        
        }
    }
}
