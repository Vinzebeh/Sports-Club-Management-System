using System;
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
    public partial class editComp : Form
    {
        
        public static string name;
        public editComp()

        {
            InitializeComponent();
        }


        

        public editComp(string n)
        {
            InitializeComponent();
            name = n;
            
        }

        private void editComp_Load(object sender, EventArgs e)
        {
            competition obj1 = new competition(name);
            competition.viewProfile(obj1);

            txtDate.Text = obj1.Date.ToShortDateString();
        }
       

        private void Update_Click(object sender, EventArgs e)
        {
            competition obj1 = new competition(name);
            MessageBox.Show(obj1.updateProfile(txtDate.Value));
        }


        private void editdate_ValueChanged(object sender, EventArgs e)
        {
            txtDate.CustomFormat = "yyyy-MM-dd";
        }
    }
}
