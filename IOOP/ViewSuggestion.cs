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
    public partial class ViewSuggestion : Form
    {
        public ViewSuggestion()
        {
            InitializeComponent();
        }

        private void ViewSuggestion_Load(object sender, EventArgs e)
        {
            viewsugglst.View = View.Details;
            ArrayList std = new ArrayList();
            ArrayList sug = new ArrayList();
            admin.viewsuggest(std, sug);
            viewsugglst.Columns.Add("Stduent Name", 100);
            viewsugglst.Columns.Add("Suggestion", 100);

            for (int i = 0; i < std.Count; i++)
            {
                ListViewItem item = new ListViewItem((string)std[i]);
                item.SubItems.Add((string)sug[i]);
                viewsugglst.Items.Add(item);
            }
        }
    }
}
