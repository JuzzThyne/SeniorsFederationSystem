using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SENIOR_S_FEDERATION.Classes
{
    public class connection
    {
        SQLiteConnection conn = new SQLiteConnection("Data Source=seniorfederation.db;Version=3;");

        public SQLiteConnection Activecon()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
    }
}
