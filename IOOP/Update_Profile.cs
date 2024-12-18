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
    public partial class Update_Profile : Form
    {
        public static string email;

        public Update_Profile()
        {
            InitializeComponent();
        }

        public Update_Profile(string em)
        {
            InitializeComponent();
            email = em;
        }

        private void Update_Profile_Load(object sender, EventArgs e)
        {
            UpdateP obj = new UpdateP(email);

            UpdateP.viewProfile(obj);

            txtName.Text = obj.Name;
            txtPnum.Text = obj.PhonNum;
            txtPW.Text = obj.Password;

            if (email == "admin@gmail.com")
            {
                lblName.Visible = false; lblPnum.Visible = false; txtName.Visible = false; txtPnum.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to update your file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateP obj = new UpdateP(email);
                MessageBox.Show(obj.updateProfile(txtName.Text, txtPnum.Text, txtPW.Text));
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
