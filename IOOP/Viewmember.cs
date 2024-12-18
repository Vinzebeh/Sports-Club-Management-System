using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment
{
    public partial class Viewmember : Form
    {
        private string accty;
        public Viewmember(string accty)
        {
            InitializeComponent();
            this.accty = accty;
        }

        private void Viewprofile_Load(object sender, EventArgs e)
        {
            ArrayList name = new ArrayList();
            
            name = admin.viewmembername(accty);

            foreach (var item in name)
            {
                profilelist.Items.Add(item);
            }

        }

        private void profilelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            if (profilelist.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select one of the name.");
            }
            else
            {
                if (accty == "Member")
                {
                    admin o1 = new admin();
                    o1.Membername = profilelist.SelectedItem.ToString();
                    admin.Viewprofile(o1);
                    MessageBox.Show("Email :" + o1.Email + "\n" + "Contact Number:" + o1.Contactnumber);
                }
                else if (accty == "Coach")
                {
                    coach slec = new coach();
                    slec.Name = profilelist.SelectedItem.ToString();
                    coach.Viewprofile(slec);
                    MessageBox.Show("Email :" + slec.Email + "\n" + "Contact Number:" + slec.Contactnumber + "\n" + "Salary:" + slec.Salary + "\n" + "Level:" + slec.Level);
                }
                else if (accty == "Manager")
                {
                    manager o1 = new manager();
                    o1.Mngname = profilelist.SelectedItem.ToString();
                    manager.Viewprofile(o1);
                    MessageBox.Show("Email :" + o1.Email + "\n" + "Contact Number:" + o1.Contactnumber + "\n" + "Salary:" + o1.Salary);
                }
            }
        }

        private void editprofilebtn_Click(object sender, EventArgs e)
        {
            if (profilelist.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select one of the name.");
            }
            else
            {
                Editprofile ep = new Editprofile(profilelist.SelectedItem.ToString(), accty);
                ep.ShowDialog();
            }
        }

        private void Dltbtn_Click(object sender, EventArgs e)
        {
            if (profilelist.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select one of the name.");
            }
            else
            {
                admin oj1 = new admin();
                oj1.Membername = profilelist.SelectedItem.ToString();
                MessageBox.Show(oj1.deleteuser(accty));
                profilelist.Items.Remove(oj1.Membername);

            }
        }
    }
}
