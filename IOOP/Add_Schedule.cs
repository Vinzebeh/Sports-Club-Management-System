using System;
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
    public partial class Add_Schedule : Form
    {
        public static string email;
        public static string name;
        public static string level;

        public Add_Schedule()
        {
            InitializeComponent();
        }

        public Add_Schedule(string em)
        {
            InitializeComponent();
            email = em;
        }

        private void Add_Schedule_Load(object sender, EventArgs e)
        {
            UpdateP obj = new UpdateP(email);
            UpdateP.profilecheck(obj);

            name = obj.Name;
            level = obj.Level;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datePicker.CustomFormat = "yyyy-MM-dd";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                datePicker.CustomFormat = " ";
            }

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
                cboxDuration.Focus();
            }
        }

        private void cboxDuration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtVenue.Focus();
            }
        }

        private void txtVenue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to add a new training schedule", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {

                coach obj1 = new coach(name, datePicker.Value.ToString("yyyy-MM-dd"), timePicker.Value.ToString("HH:mm:00"), cboxDuration.Text.ToString(), txtVenue.Text.ToString(),level);
                MessageBox.Show(obj1.addschedule());
                txtVenue.Clear();
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
