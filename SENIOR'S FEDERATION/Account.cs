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
    public partial class Account : Form
    {


        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
        }

        public void AdminLogin()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.admin admin = new Classes.admin(
                tbUsername.Text,
               tbPass.Text
                );
            obj.LoginAccount(admin.getUsername(), admin.getPassword());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
  
        }
      
        private void bntLogin_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("PLEASE ENTER USERNAME AND PASSWORD");
            }
            else
            {

                //AdminLogin();
                gumanaka();
            }
        }
    }
}
