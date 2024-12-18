using System;
using System.Collections;
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
    public partial class rec : Form
    {
        public rec()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            record obj1 = new record(txtNamecomp.SelectedItem.ToString(), txtResult.SelectedItem.ToString());
            MessageBox.Show(obj1.recordComp());
        }

        private void rec_Load(object sender, EventArgs e)
        {
            ArrayList comp = new ArrayList();
            comp = competition.viewCompetition();
            foreach (var i in comp)
            {
                txtNamecomp.Items.Add(i);
            }
            
        }
    }
}
