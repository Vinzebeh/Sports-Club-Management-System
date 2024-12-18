using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AccManagement : Form
    {

        public AccManagement()
        {
            InitializeComponent();
        }

        public void Acctype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        private void addaccbtn_Click(object sender, EventArgs e)
        {
            if (Acctype.SelectedIndex == -1)
            {
                MessageBox.Show("Please select one of the role.");
            }
            else
            {
                string accty = Acctype.SelectedItem.ToString();
                Adduser au = new Adduser(accty);
                au.ShowDialog();
            }
        }

        private void viewprofilebtn_Click(object sender, EventArgs e)
        {
            if (Acctype.SelectedIndex == -1)
            {
                MessageBox.Show("Please select one of the role.");
            }
            else
            {
                string accty = Acctype.SelectedItem.ToString();
                Viewmember vm = new Viewmember(accty);
                vm.ShowDialog();
            }
        }

    }
}
