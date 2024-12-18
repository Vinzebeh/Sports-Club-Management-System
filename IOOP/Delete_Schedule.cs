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
    public partial class Delete_Schedule : Form
    {
        public static string email;
        public static string name;
        public static string level;

        public Delete_Schedule()
        {
            InitializeComponent();
        }
        public Delete_Schedule(string em)
        {
            InitializeComponent();
            email = em;
        }

        private void Delete_Schedule_Load(object sender, EventArgs e)
        {
            UpdateP obj = new UpdateP(email);
            UpdateP.profilecheck(obj);
            name = obj.Name;
            level = obj.Level;

            ArrayList sc = new ArrayList();

            sc = coach.viewschedule(name, level);
            foreach (var item in sc)
            {
                clbDisplay.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure to delete selected training schedule?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var item in clbDisplay.CheckedItems)
                {
                    string selectedItem = item.ToString();
                    string[] parts = selectedItem.Split('|');
                    string date = parts[0].Trim();
                    coach dlt = new coach();
                    MessageBox.Show(dlt.deleteschedule(date, name));
                }

                Reload();
            }

            else
                MessageBox.Show("Training schedule is not deleted");
            
        }

        private void Reload()
        {
            clbDisplay.Items.Clear();

            ArrayList remainings = coach.viewschedule(name, level);
            foreach (var item in remainings)
            {
                clbDisplay.Items.Add(item);
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
