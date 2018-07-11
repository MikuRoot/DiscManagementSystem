using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Bussiness;
using Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class frmlogin : Form
    {
        LoginBLL loginbll;
        public frmlogin()
        {
            loginbll = new LoginBLL();
            InitializeComponent();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
            }
            txtpassword.PasswordChar = '*';
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin formnhanvien = new frmAdmin();
            formnhanvien.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (loginbll.IsAccess(txtusername.Text, txtpassword.Text))
            {
                this.Hide();
                frmAdmin adminpage = new frmAdmin();
                frmAdmin.signal = "Access grand";
                adminpage.ShowDialog();
            }
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            if(txtusername.Text=="User name")
            {
                txtusername.Clear();
            }
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
            }
            txtpassword.PasswordChar = '*';
        }
    }
}
