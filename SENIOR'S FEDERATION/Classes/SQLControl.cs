using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace SENIOR_S_FEDERATION.Classes
{
    public class SQLControl
    {
        Classes.connection obj = new Classes.connection();



        public string LoginAccount(string username, string password)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM users_tbl WHERE username = '" + (username) + "' AND password = '" + (password) + "'", obj.Activecon());
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NewMethodAccount(dt);
            return username;
        }
        private static void NewMethodAccount(DataTable dt)
        {

            if (dt.Rows.Count > 0)
            {

             System.Windows.Forms.MessageBox.Show("WELCOME");


            }
            else
            {
                System.Windows.Forms.MessageBox.Show("wrong username or password");
                Account acc = new Account();
                

            }
        }
        public string Login(string username, string password)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM users_tbl WHERE username = '" + (username) + "' AND password = '" + (password) + "'", obj.Activecon());
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NewMethod(dt);
            return username;
        }
        private static void NewMethod(DataTable dt)
        {

            if (dt.Rows.Count > 0)
            {
                
               // System.Windows.Forms.MessageBox.Show("WELCOME");
                MainForm mform = new MainForm();
                mform.Show();


            }
            else
            {
                System.Windows.Forms.MessageBox.Show("wrong username or password");
                Login login = new Login();
                login.Show();

            }
        }      
        public string fetchSeniors(string sql, DataGridView grid)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, FULLNAME, ADDRESS, BIRTHDAY, FEDERATION_ID, ADMISSION_DATE, OSCA_ID FROM seniors_tbl ORDER BY FULLNAME ASC;", obj.Activecon());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;

            return sql;

        }
        public string findingMonitoring(string search, DataGridView grid)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM seniors_tbl WHERE FULLNAME || FEDERATION_ID || OSCA_ID  LIKE '%" + search + "%'  ", obj.Activecon());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;
            return search;

        }
        public string InsertSenior(string fullname, string address, string birthday, string federationid, string addmissiondate, string oscaid)
        {

            SQLiteCommand cmdcheck = new SQLiteCommand("SELECT * FROM seniors_tbl WHERE (FULLNAME = '"+(fullname)+"' AND FEDERATION_ID = '"+(federationid)+"');", obj.Activecon());
            SQLiteDataAdapter sdacheck = new SQLiteDataAdapter(cmdcheck);
            DataTable dtcheck = new DataTable();
            // checking if existed
            sdacheck.Fill(dtcheck);
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO seniors_tbl (FULLNAME, ADDRESS, BIRTHDAY, FEDERATION_ID, ADMISSION_DATE, OSCA_ID )VALUES( '" + (fullname) + "','" + (address) + "','" + (birthday) + "','" + (federationid) + "','" + (addmissiondate) + "','" + (oscaid) + "' )", obj.Activecon());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            NewMethodcheck2(dtcheck, cmd);
            return fullname;
            
        }
        private static void NewMethodcheck2(DataTable dtcheck, SQLiteCommand cmd)
        {
            if (dtcheck.Rows.Count > 0)
            {
                System.Windows.Forms.MessageBox.Show("NAME AND FEDERATION ID EXISTED");
            }
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA ADDED");

            }
        }
        public string UpdateSenior( string fullname, string address, string birthday, string federationid, string addmissiondate, string oscaid, int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE seniors_tbl SET FULLNAME = '"+(fullname)+"', ADDRESS = '"+(address)+ "', BIRTHDAY = '" + (birthday) + "', FEDERATION_ID = '" + (federationid) + "', ADMISSION_DATE = '" + (addmissiondate) + "', OSCA_ID = '" + (oscaid) + "' WHERE id = '" + (id)+"'", obj.Activecon());
            
            if (cmd.ExecuteNonQuery() > 0)

            {
                System.Windows.Forms.MessageBox.Show("DATA UPDATED");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("DATA NOT UPDATE");
            }

            return fullname;
        }  
        public int DeleteSenior(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM seniors_tbl WHERE id = '" + (id) + "'", obj.Activecon());
            cmd.ExecuteNonQuery();
            return id;
        }
        public string fetchDecease(string sql, DataGridView grid)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, FULLNAME, ADDRESS, BIRTHDAY, FEDERATION_ID, ADMISSION_DATE, OSCA_ID, CAUSE_OF_DEATH, DATE_OF_DEATH FROM decease_tbl", obj.Activecon());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;
            return sql;

        }
        public string findingDecease(string search, DataGridView grid)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM decease_tbl WHERE FULLNAME || FEDERATION_ID || OSCA_ID  LIKE '%" + search + "%'  ", obj.Activecon());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;
            return search;

        }
        public string InsertDecease(string fullname, string address, string birthday, string federationid, string addmissiondate, string oscaid)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO decease_tbl (FULLNAME, ADDRESS, BIRTHDAY, FEDERATION_ID, ADMISSION_DATE, OSCA_ID )VALUES( '" + (fullname) + "','" + (address) + "','" + (birthday) + "','" + (federationid) + "','" + (addmissiondate) + "','" + (oscaid) + "' )", obj.Activecon());
            if (cmd.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("DATA INSERTED");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("DATA NOT INSERT");
            }

            return fullname;
        }
        public string UpdateDecease(string fullname, string address, string birthday, string federationid, string addmissiondate, string oscaid, string cod, string dod, int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE decease_tbl SET FULLNAME = '" + (fullname) + "', ADDRESS = '" + (address) + "', BIRTHDAY = '" + (birthday) + "', FEDERATION_ID = '" + (federationid) + "', ADMISSION_DATE = '" + (addmissiondate) + "', OSCA_ID = '" + (oscaid) + "', CAUSE_OF_DEATH = '" + (cod) + "', DATE_OF_DEATH = '" + (dod) + "' WHERE id = '" + (id) + "'", obj.Activecon());

            if (cmd.ExecuteNonQuery() > 0)

            {
                System.Windows.Forms.MessageBox.Show("DATA UPDATED");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("DATA NOT UPDATE");
            }

            return fullname;
        }
        public string InsertWithdrawn(string fullname, string address, string birthday, string federationid, string addmissiondate, string oscaid, string dateofwithdrawn)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO withdrawed_tbl (FULLNAME, ADDRESS, BIRTHDAY, FEDERATION_ID, ADMISSION_DATE, OSCA_ID, DATE_OF_WITHDRAWN )VALUES( '" + (fullname) + "','" + (address) + "','" + (birthday) + "','" + (federationid) + "','" + (addmissiondate) + "','" + (oscaid) + "','" + (dateofwithdrawn) + "' )", obj.Activecon());
            if (cmd.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("DATA INSERTED");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("DATA NOT INSERT");
            }

            return fullname;
        }
        public string fetchWithdrawn(string sql, DataGridView grid)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, FULLNAME, ADDRESS, BIRTHDAY, FEDERATION_ID, ADMISSION_DATE, OSCA_ID, DATE_OF_WITHDRAWN FROM withdrawed_tbl ORDER BY FULLNAME ASC;", obj.Activecon());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;

            return sql;

        }
        public int DeleteWithdrawn(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM withdrawed_tbl WHERE id = '" + (id) + "'", obj.Activecon());
            cmd.ExecuteNonQuery();
            return id;
        }
        public string findingWithdrawn(string search, DataGridView grid)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM withdrawed_tbl WHERE FULLNAME || FEDERATION_ID || OSCA_ID  LIKE '%" + search + "%'  ", obj.Activecon());
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;
            return search;

        }
        public int DeleteDecease(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM decease_tbl WHERE id = '" + (id) + "'", obj.Activecon());
            cmd.ExecuteNonQuery();
            return id;
        }



    }
}
