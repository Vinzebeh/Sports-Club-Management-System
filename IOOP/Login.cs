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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat;
            users us1 = new users(txtEmail.Text, txtPW.Text);
            stat = us1.login(txtEmail.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            txtEmail.Focus();
            txtEmail.Text = string.Empty;
            txtPW.Text = string.Empty;
            //this.Hide();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPW.Focus();
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}

