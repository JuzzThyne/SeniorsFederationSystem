using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENIOR_S_FEDERATION
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public void AdminLogin()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.admin admin = new Classes.admin(
                tbUsername.Text,
               tbPassword.Text
                );
            obj.Login(admin.getUsername(), admin.getPassword());

            


        }
        public void Clear()
        {
            tbUsername.Clear();
            tbPassword.Clear();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("PLEASE ENTER USERNAME AND PASSWORD");
            }
            else
            {
                username = tbUsername.Text;
                password = tbPassword.Text;

                AdminLogin();
                this.Hide();
                Clear();
            }
            

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to close this application?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            if (res == DialogResult.Cancel)
            {              
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin.PerformClick();
                }        
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
