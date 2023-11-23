using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENIOR_S_FEDERATION.Classes
{
    public class DeleteWithdrawn
    {
        private int getID;

        public DeleteWithdrawn()
        {
        }
        public DeleteWithdrawn(int _getID)
        {
            this.getID = _getID;
        }

        public int GetID()
        {
            return getID;
        }
    }
}
