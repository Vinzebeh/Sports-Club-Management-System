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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class viewincome : Form
    {
        public viewincome()
        {
            InitializeComponent();
        }

        private void viewincome_Load(object sender, EventArgs e)
        {
            ArrayList mn = new ArrayList();
            ArrayList bt = new ArrayList();
            ArrayList it = new ArrayList();
            ArrayList at = new ArrayList();
            ArrayList tl = new ArrayList();
            incomelist.View = View.Details;
            incomelist.Columns.Add("Month", 150);
            incomelist.Columns.Add("Beginner", 100);
            incomelist.Columns.Add("Intermediate", 100);
            incomelist.Columns.Add("Advance", 100);
            incomelist.Columns.Add("Total", 100);
            admin.viewincome(mn,bt,it,at,tl);
            while (mn.Count > bt.Count) { bt.Add(0); }
            while (mn.Count > it.Count) { it.Add(0); }
            while (mn.Count > at.Count) { at.Add(0); }

            for (int i = 0; i < mn.Count; i++)
            {
                ListViewItem item = new ListViewItem(mn[i].ToString());
                item.SubItems.Add(bt[i].ToString());
                item.SubItems.Add(it[i].ToString());
                item.SubItems.Add(at[i].ToString());
                item.SubItems.Add(tl[i].ToString());
                incomelist.Items.Add(item);
            }
        }


    }
}
