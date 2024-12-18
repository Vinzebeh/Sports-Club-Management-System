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
    public partial class View_Payment : Form
    {
        public static string email;
        public static string level;

        public View_Payment()
        {
            InitializeComponent();
        }

        public View_Payment(string em)
        {
            InitializeComponent();
            email = em;
        }

        private void View_Payment_Load(object sender, EventArgs e)
        {
            UpdateP obj = new UpdateP(email);
            UpdateP.profilecheck(obj);
            level = obj.Level;
            lvPaid.View = View.Details;

            ArrayList vw = new ArrayList();
            ArrayList rm = new ArrayList();
            coach.viewPayment(level, vw, rm);

            lvPaid.Columns.Add("Student Name", 100);
            lvPaid.Columns.Add("Payment", 100);

            for (int i = 0; i < vw.Count; i++)
            {
                ListViewItem item = new ListViewItem((string)vw[i]);
                item.SubItems.Add(rm[i].ToString());
                lvPaid.Items.Add(item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Coach_Main back = new Coach_Main();
            back.Show();
        }
    }
}
