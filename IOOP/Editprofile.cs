using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment
{
    public partial class Editprofile : Form
    {
        private string slcname;
        private string accty;

        public Editprofile(string slcname, string accty)
        {
            InitializeComponent();
            this.slcname = slcname;
            this.accty = accty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin obj1 = new admin(slcname);
            MessageBox.Show(obj1.editprofile(Emailtxtbox.Text, Contxtbox.Text, Salarytxtbox.Text, coachlevelbox.SelectedItem.ToString(), accty));
        }

        private void Editprofile_Load(object sender, EventArgs e)
        {
            coachlevelbox.SelectedIndex = 0;
            if (accty == "Member")
            {
                admin obj1 = new admin(slcname);
                admin.Viewprofile(obj1);
                label3.Visible = false; label5.Visible = false; coachlevelbox.Visible = false; Salarytxtbox.Visible = false;
                Emailtxtbox.Text = obj1.Email;
                Contxtbox.Text = obj1.Contactnumber;
            }
            else if (accty == "Coach")
            {
                coach obj1 = new coach(slcname);
                coach.Viewprofile(obj1);
                
                Emailtxtbox.Text = obj1.Email;
                Contxtbox.Text = obj1.Contactnumber;
                Salarytxtbox.Text = obj1.Salary.ToString();
                coachlevelbox.Text = obj1.Level.ToString();
            }
            else if (accty == "Manager")
            {
                manager obj1 = new manager(slcname);
                manager.Viewprofile(obj1);
                coachlevelbox.Visible = false; label5.Visible = false;
                Emailtxtbox.Text = obj1.Email;
                Contxtbox.Text = obj1.Contactnumber;
                Salarytxtbox.Text = obj1.Salary.ToString();
            }
        }
    }
}
