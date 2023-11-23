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
    public partial class Withdrawn : Form
    {
        public int id;
        SQLiteDataAdapter pagingAdapter;
        DataSet pagingDS;
        int scrollVal;
        public Withdrawn()
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
            tbDateOfWithdrawn.Clear();

        }
        private void btnEditSenior_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFullname.Text) || (string.IsNullOrEmpty(tbFederationId.Text)))
            {
                MessageBox.Show("Please select you want you want to DELETE");
                clear();
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete Senior's Withdrawn Information " + tbFullname.Text + "", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    DeleteWithdrawn();
                    clear();
                    DisplayMonitoring();
                    WithdrawnCount();
                    tbRefresh.PerformClick();

                }
                if (res == DialogResult.Cancel)
                {
                    clear();
                    DisplayMonitoring();
                    WithdrawnCount();
                    tbRefresh.PerformClick();
                }
            }
            

    }
        public void DisplayMonitoring()
        {
            

                string connectionString = "Data Source=seniorfederation.db;Version=3;";
                string sql = "SELECT id, FULLNAME, ADDRESS, BIRTHDAY, FEDERATION_ID, ADMISSION_DATE, OSCA_ID, DATE_OF_WITHDRAWN FROM withdrawed_tbl";
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                pagingAdapter = new SQLiteDataAdapter(sql, connection);
                pagingDS = new DataSet();
                connection.Open();
                pagingAdapter.Fill(pagingDS, scrollVal, 25, "withdrawed_tbl");
                connection.Close();
                dgvMonitoring.DataSource = pagingDS;
                dgvMonitoring.DataMember = "withdrawed_tbl";
                this.dgvMonitoring.Columns["id"].Visible = false;
                //Classes.SQLControl obj = new Classes.SQLControl();
                //string sql = "";
                //obj.fetchSeniors(sql, dgvMonitoring);
            
        }
        
        public void WithdrawnCount()
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
            string query = "SELECT COUNT(*) FROM withdrawed_tbl;";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            object count = cmd.ExecuteScalar();
            string bilang = count.ToString();
            label12.Text = bilang.ToString();

        }
        private void Withdrawn_Load(object sender, EventArgs e)
        {
            DisplayMonitoring();
            WithdrawnCount();
        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            DisplayMonitoring();
            WithdrawnCount();
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
                string dateofwithdrawn = dgvMonitoring.SelectedRows[0].Cells[7].Value + string.Empty;

                id = int.Parse(aydi.ToString());
                tbFullname.Text = fn;
                tbAddress.Text = add;
                tbBirthday.Text = birth;
                tbFederationId.Text = fedid;
                tbAdmission.Text = adddate;
                tbOscaId.Text = osid;
                tbDateOfWithdrawn.Text = dateofwithdrawn;
                
            }
        }
        public void DeleteWithdrawn()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.DeleteWithdrawn delwithdrawn = new Classes.DeleteWithdrawn(
                id
                );
            obj.DeleteWithdrawn(delwithdrawn.GetID());
            
        }

        private void tbClear_Click(object sender, EventArgs e)
        {
            clear();
            tbRefresh.PerformClick();


        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            
            Classes.SQLControl obj = new Classes.SQLControl();
            obj.findingWithdrawn(tbSearch.Text, dgvMonitoring);
        }

        private void dgvMonitoring_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            scrollVal = scrollVal - 25;

            if (scrollVal < 0)
            {
                scrollVal = 0;

            }
            pagingDS.Clear();
            pagingAdapter.Fill(pagingDS, scrollVal, 25, "withdrawed_tbl");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal + 25;

            if (dgvMonitoring.RowCount < 25)
            {
                btnNext.Enabled = false;
            }

            pagingDS.Clear();

            pagingAdapter.Fill(pagingDS, scrollVal, 25, "withdrawed_tbl");
        }
    }
}
