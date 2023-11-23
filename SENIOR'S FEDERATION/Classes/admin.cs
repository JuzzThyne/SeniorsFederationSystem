using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SENIOR_S_FEDERATION.Classes
{
    public class admin
    {
        private string username;
        private string password;

        // empty parameter
        public admin()

        {

        }

        public admin(string _username, string _password)
        {
            this.username = _username;
            this.password = _password;
        }
        // properties
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
