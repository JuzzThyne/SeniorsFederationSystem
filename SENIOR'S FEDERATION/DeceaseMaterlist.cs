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


namespace SENIOR_S_FEDERATION
{
    public partial class DeceaseMaterlist : Form
    {
        public int id;
        public int count;
        SQLiteDataAdapter pagingAdapter;
        DataSet pagingDS;
        int scrollVal;
        public DeceaseMaterlist()
        {
            InitializeComponent();
            scrollVal = 0;
        }

        private void btnEditSenior_Click(object sender, EventArgs e)
        {

        }
        public void DisplayMonitoring()
        {

            string connectionString = "Data Source=seniorfederation.db;Version=3;";
            string sql = "SELECT id, FULLNAME, ADDRESS, BIRTHDAY, FEDERATION_ID, ADMISSION_DATE, OSCA_ID, CAUSE_OF_DEATH, DATE_OF_DEATH FROM decease_tbl";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            pagingAdapter = new SQLiteDataAdapter(sql, connection);
            pagingDS = new DataSet();
            connection.Open();
            pagingAdapter.Fill(pagingDS, scrollVal, 100, "decease_tbl");
            connection.Close();
            dgvMonitoring.DataSource = pagingDS;
            dgvMonitoring.DataMember = "decease_tbl";
            this.dgvMonitoring.Columns["id"].Visible = false;
            //Classes.SQLControl obj = new Classes.SQLControl();
            //string sql = "";
            //obj.fetchSeniors(sql, dgvMonitoring);
        }
        private void dgvMonitoring_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void DeceaseCount()
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
            string query = "SELECT COUNT(*) FROM decease_tbl;";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            object count = cmd.ExecuteScalar();
            string bilang = count.ToString();
            label12.Text = bilang.ToString();

        }
        private void DeceaseMaterlist_Load(object sender, EventArgs e)
        {
            DisplayMonitoring();
            DeceaseCount();
            
            
        }

        private void dgvMonitoring_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvMonitoring.SelectedRows.Count > 0)
            {
                string aydi = dgvMonitoring.SelectedRows[0].Cells[0].Value + string.Empty;
                string fn = dgvMonitoring.SelectedRows[0].Cells[1].Value + string.Empty;
                string add = dgvMonitoring.SelectedRows[0].Cells[2].Value + string.Empty;
                string birth = dgvMonitoring.SelectedRows[0].Cells[3].Value + string.Empty;
                string fedid = dgvMonitoring.SelectedRows[0].Cells[4].Value + string.Empty;
                string adddate = dgvMonitoring.SelectedRows[0].Cells[5].Value + string.Empty;
                string osid = dgvMonitoring.SelectedRows[0].Cells[6].Value + string.Empty;
                string cod = dgvMonitoring.SelectedRows[0].Cells[7].Value + string.Empty;
                string dod = dgvMonitoring.SelectedRows[0].Cells[8].Value + string.Empty;

                id = int.Parse(aydi.ToString());
                tbFullname.Text = fn;
                tbAddress.Text = add;
                tbBirthday.Text = birth;
                tbFederationId.Text = fedid;
                tbAdmission.Text = adddate;
                tbOscaId.Text = osid;
                tbCauseOfDeath.Text = cod;
                tbDateOfDeath.Text = dod;

                

                if (string.IsNullOrEmpty(tbCauseOfDeath.Text) && string.IsNullOrEmpty(tbDateOfDeath.Text))
                {
                     btnEditDecease.Enabled = true;
                    tbCauseOfDeath.Enabled = true;
                    tbDateOfDeath.Enabled = true;
                }
                else
                {
                    btnEditDecease.Enabled = false;
                    tbCauseOfDeath.Enabled = false;
                    tbDateOfDeath.Enabled = false;
                }
            }
        }

        public void clear()
        {
            tbFullname.Clear();
            tbAddress.Clear();
            tbBirthday.Clear();
            tbFederationId.Clear();
            tbAdmission.Clear();
            tbOscaId.Clear();
            tbCauseOfDeath.Clear();
            tbDateOfDeath.Clear();
        }

        private void tbClear_Click(object sender, EventArgs e)
        {
            clear();
            DeceaseCount();
            tbRefresh.PerformClick();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            obj.findingDecease(tbSearch.Text, dgvMonitoring);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label12_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void UpdateDecease()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.UpdateDecease updatedecease = new Classes.UpdateDecease(
                tbFullname.Text.ToUpper(),
                tbAddress.Text.ToUpper(),
                tbBirthday.Text.ToUpper(),
                tbFederationId.Text.ToUpper(),
                tbAdmission.Text.ToUpper(),
                tbOscaId.Text.ToUpper(),
                tbCauseOfDeath.Text.ToUpper(),
                tbDateOfDeath.Text.ToUpper(),
                id
                );
            obj.UpdateDecease(updatedecease.GetFullname(), updatedecease.GetAddress(), updatedecease.GetBirthday(), updatedecease.GetFederationid(), updatedecease.GetAddmissionDate(), updatedecease.GetOscaid(), updatedecease.GetCauseOfDeath(), updatedecease.GetDateOfDeath(), updatedecease.GetId());      
        }
        private void btnEditDecease_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullname.Text) || (string.IsNullOrEmpty(tbFederationId.Text)) || (string.IsNullOrEmpty(tbCauseOfDeath.Text)) || (string.IsNullOrEmpty(tbDateOfDeath.Text)))
            {
                MessageBox.Show("Please you want you want to move to UPDATE");
                clear();
                tbRefresh.PerformClick();
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Update Decease Senior's Information" + tbFullname.Text + "", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    UpdateDecease();        
                    clear();
                    DisplayMonitoring();
                    DeceaseCount();
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

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            DisplayMonitoring();
            DeceaseCount();
        }

        private void dgvMonitoring_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal + 100;

            if (dgvMonitoring.RowCount < 100)
            {
                btnNext.Enabled = false;
            }

            pagingDS.Clear();

            pagingAdapter.Fill(pagingDS, scrollVal, 100, "decease_tbl");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            scrollVal = scrollVal - 100;

            if (scrollVal < 0)
            {
                scrollVal = 0;

            }
            pagingDS.Clear();
            pagingAdapter.Fill(pagingDS, scrollVal, 100, "decease_tbl");
        }

        public void DeleteDecease()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.DeleteDecease deldecease = new Classes.DeleteDecease(
                id
                );
            obj.DeleteDecease(deldecease.GetID());
        }
        private void btnDeleteDecease_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullname.Text) || (string.IsNullOrEmpty(tbFederationId.Text)))
            {
                MessageBox.Show("Please you want you want to move to DELETE");
                clear();
                tbRefresh.PerformClick();
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete Decease Senior's Information" + tbFullname.Text + "", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    DeleteDecease();
                    clear();
                    DisplayMonitoring();
                    DeceaseCount();
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
    }
}
