using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENIOR_S_FEDERATION.Classes
{
    public class UpdateDecease
    {
        private string fullname;
        private string address;
        private string birthday;
        private string federationid;
        private string addmissiondate;
        private string oscaid;
        private string cod;
        private string dod;
        private int id;



        public UpdateDecease()
        {

        }
        public UpdateDecease(string _fullname, string _address, string _birthday, string _federationid, string _addmissiondate, string _oscaid, string _cod, string _dod, int _id)
        {
            this.fullname = _fullname;
            this.address = _address;
            this.birthday = _birthday;
            this.federationid = _federationid;
            this.addmissiondate = _addmissiondate;
            this.oscaid = _oscaid;
            this.cod = _cod;
            this.dod = _dod;
            this.id = _id;
            

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
        public string GetCauseOfDeath()
        {
            return cod;
        }
        public string GetDateOfDeath()
        {
            return dod;
        }
        public int GetId()
        {
            return id;
        }
    }
}
