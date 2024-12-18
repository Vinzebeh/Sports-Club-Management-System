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
    public partial class AddCompetition : Form
    {
        public AddCompetition()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            competition obj1 = new competition(txtComp.Text, Datepick.Value);
            MessageBox.Show(obj1.addCompetition());
        }

        private void Datepick_ValueChanged(object sender, EventArgs e)
        {
            Datepick.CustomFormat = "yyyy-MM-dd";
        }
    }
}
