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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure you close this application", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            if (res == DialogResult.Cancel)
            {

            }
           

        }
        public void loadform(object Form)
        {
            if (this.PanelBody.Controls.Count > 0)
                this.PanelBody.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelBody.Controls.Add(f);
            this.PanelBody.Tag = f;
            f.Show();

        }


        private void btnMasterlist_Click(object sender, EventArgs e)
        {
            loadform(new MasterlistForm());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterlistForm ml = new MasterlistForm();
            ml.Hide();
            loadform(new DeceaseMaterlist());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeceaseMaterlist dm = new DeceaseMaterlist();
            dm.Hide();
            loadform(new Withdrawn());
        }

        private void PanelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            //DeceaseMaterlist dm = new DeceaseMaterlist();
            //dm.Hide();
            loadform(new Account());
        }
    }
}
