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
using System.Xml.Linq;

namespace Assignment
{
    public partial class Recommendation : Form
    {
        public static string email;
        public static string name;
        public static string level;

        public Recommendation()
        {
            InitializeComponent();
        }

        public Recommendation(string em)
        {
            InitializeComponent();
            email = em;
        }

        private void Recommendation_Load(object sender, EventArgs e)
        {
            UpdateP obj = new UpdateP(email);
            UpdateP.profilecheck(obj);
            name = obj.Name;
            level = obj.Level;
            ArrayList vw = new ArrayList();
            vw = coach.viewToRecommend(level);
            foreach (var i in vw)
            {
                clbView.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to recommend these students to manager?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var item in clbView.CheckedItems)
                {
                    string selectedstud = item.ToString();
                    string[] parts = selectedstud.Split('|');
                    string studname = parts[0].Trim();
                    string performances = parts[1].Trim();

                    coach rcmd = new coach();
                    MessageBox.Show(rcmd.recommendation(name, studname, performances, level));
                }
                Reload();
            }

            else
                MessageBox.Show("Recommendation cancelled.");

        }

        private void Reload()
        {
            clbView.Items.Clear();
            ArrayList refresh = new ArrayList();
            refresh = coach.viewToRecommend(level);
            foreach (var i in refresh)
            {
                clbView.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Coach_Main back = new Coach_Main();
            back.Show();
        }
    }
}
