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
    public partial class deleteCompetition : Form
    {
        public deleteCompetition()
        {
            InitializeComponent();
        }

        private void deleteCompetition_Load(object sender, EventArgs e)
        {

            ArrayList name = new ArrayList();
            name = competition.viewCompetition();
            foreach (var item in name)
            {
                lstDlt.Items.Add(item);
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            competition obj1 = new competition(lstDlt.SelectedItem.ToString());
            MessageBox.Show(obj1.deleteCompetition());
            lstDlt.Items.Remove(lstDlt.SelectedItem);
        }

        private void lblDlt_Click(object sender, EventArgs e)
        {

        }
    }
}
