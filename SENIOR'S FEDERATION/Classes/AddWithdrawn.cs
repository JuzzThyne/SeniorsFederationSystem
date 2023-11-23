using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENIOR_S_FEDERATION.Classes
{
    public class AddWithdrawn
    {
        private string fullname;
        private string address;
        private string birthday;
        private string federationid;
        private string addmissiondate;
        private string oscaid;
        private string dateofwithdrawn;


        public AddWithdrawn()
        {

        }
        public AddWithdrawn(string _fullname, string _address, string _birthday, string _federationid, string _addmissiondate, string _oscaid, string _dateofwithdrawn)
        {
            this.fullname = _fullname;
            this.address = _address;
            this.birthday = _birthday;
            this.federationid = _federationid;
            this.addmissiondate = _addmissiondate;
            this.oscaid = _oscaid;
            this.dateofwithdrawn = _dateofwithdrawn;


        }

        public string GetFullname()
        {
            return fullname;
        }
        public string GetAddress()
        {
            return address;
        }
        public string GetBirthday()
        {
            return birthday;
        }
        public string GetFederationid()
        {
            return federationid;
        }
        public string GetAddmissionDate()
        {
            return addmissiondate;
        }
        public string GetOscaid()
        {
            return oscaid;
        }
        public string GetDateOfWithdrawn()
        {
            return dateofwithdrawn;
        }

    }
}
