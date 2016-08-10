using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Player
{
    class PVPStatus
    {
        static bool ifPVP = false;

        public void PVPActive()
        {
            ifPVP = true;
        }

        public void PVPInactive()
        {
            ifPVP = false;
        }

        public bool PVPState()
        {
            return ifPVP;
        }
    }

 
}
