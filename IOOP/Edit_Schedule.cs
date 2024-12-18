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
    public partial class Edit_Schedule : Form
    {
        public static string email;
        public static string name;
        public static string level;

        public Edit_Schedule()
        {
            InitializeComponent();
        }

        public Edit_Schedule(string em)
        {
            InitializeComponent();
            email = em;
        }

        private void datePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timePicker.Focus();
            }
        }

        private void timePicker_MouseDown(object sender, MouseEventArgs e)
        {
            timePicker.CustomFormat = "HH:mm";
        }

        private void timePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbDuration.Focus();
            }
        }

        private void Edit_Schedule_Load(object sender, EventArgs e)
        {
            UpdateP obj = new UpdateP(email);
            UpdateP.profilecheck(obj);

            name = obj.Name;
            level = obj.Level;
            ArrayList sc = new ArrayList();

            sc = coach.viewschedule(name, level);
            foreach (var item in sc)
            {
                cbDisplay.Items.Add(item);
            }
        }

        private void Reload()
        {
            cbDisplay.Items.Clear();

            ArrayList remainings = coach.viewschedule(name, level);
            foreach (var item in remainings)
            {
                cbDisplay.Items.Add(item);
            }
            txtVenue.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sche = cbDisplay.SelectedItem.ToString();
            string[] parts = sche.Split('|');
            string date = parts[0].Trim();
            string oldTime = parts[1].Trim();

            string time = timePicker.Value.ToString("HH:mm:00");
            string duration = cbDuration.Text.ToString();
            string venue = txtVenue.Text.ToString();

            if (MessageBox.Show("Are you sure to edit selected training schedule?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                coach edit = new coach();
                MessageBox.Show(edit.editschedule(date, time, duration, venue, level, oldTime));

                Reload();
            }

            else
                MessageBox.Show("Training schedule remains.");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Coach_Main back = new Coach_Main();
            back.Show();
        }
    }
}
