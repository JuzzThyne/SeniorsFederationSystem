using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENIOR_S_FEDERATION.Classes
{
    public class DeleteDecease
    {
        private int getID;

        public DeleteDecease()
        {
        }
        public DeleteDecease(int _getID)
        {
            this.getID = _getID;
        }

        public int GetID()
        {
            return getID;
        }
    }
}
