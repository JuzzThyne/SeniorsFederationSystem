﻿using System;
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
    public partial class loading_screen : Form
    {
        public loading_screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel5.Width += 3;
            if (panel5.Width >= 599)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            
            }
        }

    }
}
