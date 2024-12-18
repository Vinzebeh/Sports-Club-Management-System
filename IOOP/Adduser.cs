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
    public partial class Adduser : Form
    {
        private string accty;
        public Adduser(string accty)
        {
            InitializeComponent();
            this.accty = accty;
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            if (nametxtbox.Text == "" | emailtxtbox.Text == "" | cntnmtxtbox.Text == "")
            {
                MessageBox.Show("Please fill in the data.");
            }
            else
            {
                if (accty == "Member")
                {
                    admin obj1 = new admin(nametxtbox.Text, emailtxtbox.Text, cntnmtxtbox.Text, coachlevel.SelectedItem.ToString(), "Member");
                    MessageBox.Show(obj1.addMember());
                }
                else if (accty == "Coach")
                {
                    admin obj2 = new admin(nametxtbox.Text, emailtxtbox.Text, cntnmtxtbox.Text, SqlMoney.Parse(slrtxtbox.Text), coachlevel.SelectedItem.ToString(), "Coach");
                    MessageBox.Show(obj2.addMember());
                }
                else if (accty == "Manager")
                {
                    admin obj3 = new admin(nametxtbox.Text, emailtxtbox.Text, cntnmtxtbox.Text, SqlMoney.Parse(slrtxtbox.Text), "Manager");
                    MessageBox.Show(obj3.addMember());
                }
            }
        }

        private void Adduser_Load(object sender, EventArgs e)
        {
            coachlevel.SelectedIndex = 0;
            if (accty == "Member")
            {
                label5.Visible = false; slrtxtbox.Visible = false;
            }
            else if (accty == "Manager")
            {
                label6.Visible = false; coachlevel.Visible = false;
            }
        }
    }
}
