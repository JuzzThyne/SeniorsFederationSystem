using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Printing;






namespace SENIOR_S_FEDERATION
{
    public partial class MasterlistForm : Form
    {
        public int id;
        SQLiteDataAdapter pagingAdapter;
        DataSet pagingDS;
        int scrollVal;
        public MasterlistForm()
        {
            InitializeComponent();
            scrollVal = 0;
        }

        public void clear()
        {
            tbFullname.Clear();
            tbAddress.Clear();
            tbBirthday.Clear();
            tbFederationId.Clear();
            tbAdmission.Clear();
            tbOscaId.Clear();
        }

        public void InsertSeniors()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.AddSenior addsenior = new Classes.AddSenior(
                tbFullname.Text.ToUpper(),
                tbAddress.Text.ToUpper(),
                tbBirthday.Text.ToUpper(),
                tbFederationId.Text.ToUpper(),
                tbAdmission.Text.ToUpper(),
                tbOscaId.Text.ToUpper()
                );
                obj.InsertSenior(addsenior.GetFullname(), addsenior.GetAddress(), addsenior.GetBirthday(), addsenior.GetFederationid(), addsenior.GetAddmissionDate(), addsenior.GetOscaid());
    
        }
        public void InsertDecease()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.AddDecease adddecease = new Classes.AddDecease(
                tbFullname.Text.ToUpper(),
                tbAddress.Text.ToUpper(),
                tbBirthday.Text.ToUpper(),
                tbFederationId.Text.ToUpper(),
                tbAdmission.Text.ToUpper(),
                tbOscaId.Text.ToUpper()
                );
            obj.InsertDecease(adddecease.GetFullname(), adddecease.GetAddress(), adddecease.GetBirthday(), adddecease.GetFederationid(), adddecease.GetAddmissionDate(), adddecease.GetOscaid());

        }
        public void InsertWithdrawn()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.AddWithdrawn addwithdrawn = new Classes.AddWithdrawn(
                tbFullname.Text.ToUpper(),
                tbAddress.Text.ToUpper(),
                tbBirthday.Text.ToUpper(),
                tbFederationId.Text.ToUpper(),
                tbAdmission.Text.ToUpper(),
                tbOscaId.Text.ToUpper(),
                tbDateOfWithdrawn.Text.ToUpper()
                );
            obj.InsertWithdrawn(addwithdrawn.GetFullname(), addwithdrawn.GetAddress(), addwithdrawn.GetBirthday(), addwithdrawn.GetFederationid(), addwithdrawn.GetAddmissionDate(), addwithdrawn.GetOscaid(), addwithdrawn.GetDateOfWithdrawn());
        }

        public void DisplayMonitoring()
        {
            
            string connectionString = "Data Source=seniorfederation.db;Version=3;";
            string sql = "SELECT id, FULLNAME, ADDRESS, BIRTHDAY, FEDERATION_ID, ADMISSION_DATE, OSCA_ID FROM seniors_tbl";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            pagingAdapter = new SQLiteDataAdapter(sql, connection);
            pagingDS = new DataSet();
            connection.Open();
            pagingAdapter.Fill(pagingDS, scrollVal, 25, "seniors_tbl");
            connection.Close();
            dgvMonitoring.DataSource = pagingDS;
            dgvMonitoring.DataMember = "seniors_tbl";
            this.dgvMonitoring.Columns["id"].Visible = false;
            //Classes.SQLControl obj = new Classes.SQLControl();
            //string sql = "";
            //obj.fetchSeniors(sql, dgvMonitoring);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullname.Text) || (string.IsNullOrEmpty(tbFederationId.Text))) 
            {
                MessageBox.Show("Please fill the NAME and FEDERATION ID");
                clear();
                tbRefresh.PerformClick();
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Add Senior", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.dgvMonitoring.Columns["id"].Visible = false;
                    InsertSeniors();
                    DisplayMonitoring();
                    MembersCount();
                    clear();
                    tbRefresh.PerformClick();
                }
                if (res == DialogResult.Cancel)
                {
                    clear();
                    DisplayMonitoring();
                    tbRefresh.PerformClick();
                }
            }
            
            
        }
        private void MasterlistForm_Load(object sender, EventArgs e)
        {
            DisplayMonitoring();
            MembersCount();
            label11.Visible = false;
            tbDateOfWithdrawn.Visible = false;

            
        }
        public void MembersCount()
        {
            label12.BackColor = Color.LightGreen;
            SQLiteConnection con = new SQLiteConnection("Data Source = seniorfederation.db; Version = 3;");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
            string query = "SELECT COUNT(*) FROM seniors_tbl;";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            object count = cmd.ExecuteScalar();
            string bilang = count.ToString();
            label12.Text = bilang.ToString();

        }
        private void tbFullname_TextChanged(object sender, EventArgs e)
        {
            this.dgvMonitoring.Columns["id"].Visible = false;
            Classes.SQLControl obj = new Classes.SQLControl();
            obj.findingMonitoring(tbSearch.Text, dgvMonitoring);
        }

        private void dgvMonitoring_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddSenior.Enabled = false;
            if(dgvMonitoring.SelectedRows.Count > 0)
            {
                string aydi = dgvMonitoring.SelectedRows[0].Cells[0].Value + string.Empty;
                string fn = dgvMonitoring.SelectedRows[0].Cells[1].Value + string.Empty;
                string add = dgvMonitoring.SelectedRows[0].Cells[2].Value + string.Empty;
                string birth = dgvMonitoring.SelectedRows[0].Cells[3].Value + string.Empty;
                string fedid = dgvMonitoring.SelectedRows[0].Cells[4].Value + string.Empty;
                string adddate = dgvMonitoring.SelectedRows[0].Cells[5].Value + string.Empty;
                string osid = dgvMonitoring.SelectedRows[0].Cells[6].Value + string.Empty;

                id = int.Parse(aydi.ToString());             
                tbFullname.Text = fn;
                tbAddress.Text = add;
                tbBirthday.Text = birth;
                tbFederationId.Text = fedid;
                tbAdmission.Text = adddate;
                tbOscaId.Text = osid;
            }
           // DisplayMonitoring();

        }

        public void UpdateSeniors()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.UpdateSenior updatesenior = new Classes.UpdateSenior(
                tbFullname.Text.ToUpper(),
                tbAddress.Text.ToUpper(),
                tbBirthday.Text.ToUpper(),
                tbFederationId.Text.ToUpper(),
                tbAdmission.Text.ToUpper(),
                tbOscaId.Text.ToUpper(),
                id
                ) ;
            obj.UpdateSenior(updatesenior.GetFullname(), updatesenior.GetAddress(), updatesenior.GetBirthday(), updatesenior.GetFederationid(), updatesenior.GetAddmissionDate(), updatesenior.GetOscaid(), updatesenior.GetId());       
        }
        public void DeleteSenior()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.DeleteSenior delSenior = new Classes.DeleteSenior(
                id
                );
            obj.DeleteSenior(delSenior.GetID());
        }
        private void tbClear_Click(object sender, EventArgs e)
        {          
            clear();
            MembersCount();
            btnAddSenior.Enabled = true;
            tbRefresh.PerformClick();
        }

        private void btnEditSenior_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullname.Text) || (string.IsNullOrEmpty(tbFederationId.Text)))
            {
                MessageBox.Show("Please you want you want to move to UPDATE");
                clear();
                tbRefresh.PerformClick();
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Update Senior's Information", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.dgvMonitoring.Columns["id"].Visible = false;
                    UpdateSeniors();
                    DisplayMonitoring();
                    MembersCount();
                    clear();
                    tbRefresh.PerformClick();
                }
                if (res == DialogResult.Cancel)
                {
                    clear();
                    DisplayMonitoring();
                    tbRefresh.PerformClick();
                }
            }
               
            
        }

        private void btnDeleteSenior_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullname.Text) || (string.IsNullOrEmpty(tbFederationId.Text)))
            {
                MessageBox.Show("Please you want you want to DELETE");
                clear();
                tbRefresh.PerformClick();
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete Senior's Information " + tbFullname.Text + "", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.dgvMonitoring.Columns["id"].Visible = false;
                    DeleteSenior();
                    clear();
                    DisplayMonitoring();
                    MembersCount();
                    tbRefresh.PerformClick();
                }
                if (res == DialogResult.Cancel)
                {
                    clear();
                    DisplayMonitoring();
                    tbRefresh.PerformClick();
                }
            }
                
            
        }
        private void btnDeceasedSenior_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullname.Text) || (string.IsNullOrEmpty(tbFederationId.Text)))
            {
                MessageBox.Show("Please select you want you want to move to DECEASE");
                clear();
                tbRefresh.PerformClick();
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Move this Senior to Decease? "+ tbFullname.Text + "", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    DeleteSenior();
                    InsertDecease();            
                    clear();
                    DisplayMonitoring();
                    MembersCount();
                    tbRefresh.PerformClick();
                }
                if (res == DialogResult.Cancel)
                {
                    clear();
                    DisplayMonitoring();
                }
            }                                      
        }
        
        private void dgvMonitoring_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvMonitoring.Columns["id"].Visible = false;
        }
        private void dgvMonitoring_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {    
        }
        private void tbRefresh_Click(object sender, EventArgs e)
        {
            this.dgvMonitoring.Columns["id"].Visible = false;
            DisplayMonitoring();
            MembersCount();
        }

        private void btnWithdrawedSenior_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullname.Text) || (string.IsNullOrEmpty(tbFederationId.Text)))
            {
                MessageBox.Show("Please select you want to move to WITHDRAWN");
                clear();
            }
            else if (string.IsNullOrEmpty(tbDateOfWithdrawn.Text))
            {
                label11.Visible = true;
                tbDateOfWithdrawn.Visible = true;
                MessageBox.Show("Please fill the DATE OF WITHDRAWN");            
            }
            else
            {
                label11.Visible = true;
                tbDateOfWithdrawn.Visible = true;
                DialogResult res = MessageBox.Show("Are you sure you want to Move this Senior to Withdrawn? " + tbFullname.Text + "", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.dgvMonitoring.Columns["id"].Visible = false;
                    DeleteSenior();
                    InsertWithdrawn();
                    DisplayMonitoring();
                    MembersCount();
                    clear();
                    label11.Visible = false;
                    tbDateOfWithdrawn.Visible = false;
                    tbRefresh.PerformClick();
                }
                if (res == DialogResult.Cancel)
                {
                    clear();
                    DisplayMonitoring();
                    label11.Visible = false;
                    tbDateOfWithdrawn.Visible = false;
                    tbRefresh.PerformClick();
                }
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        { 
        }

        private void dgvMonitoring_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal + 25;

            if (dgvMonitoring.RowCount < 25)
            {
                btnNext.Enabled = false;
            }

            pagingDS.Clear();

            pagingAdapter.Fill(pagingDS, scrollVal, 25, "seniors_tbl");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            scrollVal = scrollVal - 25;

            if (scrollVal < 0)
            {
                scrollVal = 0;

            }
            pagingDS.Clear();
            pagingAdapter.Fill(pagingDS, scrollVal, 25, "seniors_tbl");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            obj.findingMonitoring(tbSearch.Text, dgvMonitoring);
            this.dgvMonitoring.Columns["id"].Visible = false;
        }
    }
}
