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
    public partial class Record_Performances : Form
    {
        public static string email;
        public static string level;
        public Record_Performances()
        {
            InitializeComponent();
        }

        public Record_Performances(string em)
        {
            InitializeComponent();
            email = em;
        }

        private void Record_Performances_Load(object sender, EventArgs e)
        {
            UpdateP obj = new UpdateP(email);
            UpdateP.profilecheck(obj);
            level = obj.Level;
            ArrayList name = new ArrayList();
            name = coach.viewMember(level);
            foreach (var item in name)
            {
                cbStud.Items.Add(item);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            string stud = cbStud.SelectedItem.ToString();
            string comment = txtRecord.Text;
            string performance = "";
            if (rbtnWeak.Checked)
            {
                performance = rbtnWeak.Text;
            }

            if (rbtnGood.Checked)
            {
                performance = rbtnGood.Text;
            }

            if (rbtnExcellent.Checked)
            {
                performance = rbtnExcellent.Text;
            }

            coach rc = new coach();
            MessageBox.Show(rc.recordPerformance(stud, performance, comment));


            txtRecord.Clear();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Coach_Main back = new Coach_Main();
            back.Show();
        }
    }
}
