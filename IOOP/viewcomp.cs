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
    public partial class viewcomp : Form
    {
        public viewcomp()
        {
            InitializeComponent();
        }

        private void viewcomp_Load(object sender, EventArgs e)
        {
            compview.View = View.Details;
            ArrayList comp = new ArrayList();
            ArrayList res = new ArrayList();
            admin.viewcompesum(comp, res);
            compview.Columns.Add("Competition", 100);
            compview.Columns.Add("Result", 100);

            for (int i  = 0; i < res.Count; i++)
            {
                ListViewItem item = new ListViewItem((string)comp[i]);
                item.SubItems.Add((string)res[i]);
                compview.Items.Add(item);
            }
        }
    }
}
