using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AdminPage : Form
    {
        public static string name;
        public AdminPage(string n)
        {
            InitializeComponent();
            name = n;
        }
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            identitylbl.Text = $"Welcome, {name}";
        }

        private void Addmemberbtn_Click(object sender, EventArgs e)
        {
            AccManagement mm = new AccManagement();
            mm.ShowDialog();
        }

        private void compesumbtn_Click(object sender, EventArgs e)
        {
            viewcomp vc = new viewcomp();
            vc.ShowDialog();
        }

        private void viewsuggbtn_Click(object sender, EventArgs e)
        {
            ViewSuggestion vs = new ViewSuggestion();
            vs.ShowDialog();
        }

        private void viewincomebtn_Click(object sender, EventArgs e)
        {
            viewincome vi = new viewincome();
            vi.ShowDialog();
        }

        private void Updateprofilebtn_Click(object sender, EventArgs e)
        {
            Update_Profile up = new Update_Profile();
            up.ShowDialog();
        }
    }
}
