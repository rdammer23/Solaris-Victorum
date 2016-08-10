using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes.StateManager
{
    class StatesAllowed
    {
        public bool Idle(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return false;
                case 2:
                    return true;
                case 3:
                    return false;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return false;
                case 17:
                    return true;
                case 18:
                    return true;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return false;
            }
        }

        public bool Follow(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return true;
                case 2:
                    return false;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return false;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return true;
                case 17:
                    return true;
                case 18:
                    return false;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return false;
            }
        }

/* Took Patrol Out, left here as I may add in later
        public bool Patrol(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return true;
                case 2:
                    return false;
                case 3:
                    return true;
                case 4:
                    return false;
                case 5:
                    return false;
                case 6:
                    return true;
                case 7:
                    return false;
                case 8:
                    return false;
                case 9:
                    return false;
                case 10:
                    return false;
                case 11:
                    return false;
                case 12:
                    return false;
                case 13:
                    return false;
                case 14:
                    return false;
                case 15:
                    return false;
                case 16:
                    return true;
                case 17:
                    return false;
                case 18:
                    return false;
                case 19:
                    return false;
                case 20:
                    return false;
                default:
                    return true;
            }
        }
*/
        public bool Wander(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return false;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return false;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return false;
                case 17:
                    return true;
                case 18:
                    return true;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return false;
            }
        }

        public bool Attack(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return true;
                case 17:
                    return true;
                case 18:
                    return true;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return true;
            }
        }

        public bool Avoid(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return true;
                case 17:
                    return true;
                case 18:
                    return true;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return true;
            }
        }

        public bool Assist(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return true;
                case 2:
                    return false;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return false;
                case 13:
                    return false;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return true;
                case 17:
                    return true;
                case 18:
                    return false;
                case 19:
                    return false;
                case 20:
                    return true;
                default:
                    return false;
            }
        }

        public bool IfAttacked(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return true;
                case 17:
                    return true;
                case 18:
                    return true;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return true;
            }
        }

        public bool Flee(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return true;
                case 17:
                    return true;
                case 18:
                    return true;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return true;
            }
        }

        public bool Die(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return true;
                case 17:
                    return true;
                case 18:
                    return true;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return true;
            }
        }

        public bool Collide(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return false;
                case 2:
                    return false;
                case 3:
                    return false;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return false;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return false;
                case 11:
                    return false;
                case 12:
                    return true;
                case 13:
                    return false;
                case 14:
                    return false;
                case 15:
                    return true;
                case 16:
                    return true;
                case 17:
                    return false;
                case 18:
                    return false;
                case 19:
                    return true;
                case 20:
                    return false;
                default:
                    return false;
            }
        }

        public bool FlyHome(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return true;
                case 17:
                    return true;
                case 18:
                    return true;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return true;
            }
        }

        public bool FlyDeepSpace(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return false;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6:
                    return true;
                case 7:
                    return true;
                case 8:
                    return true;
                case 9:
                    return true;
                case 10:
                    return true;
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                case 14:
                    return true;
                case 15:
                    return true;
                case 16:
                    return true;
                case 17:
                    return true;
                case 18:
                    return true;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return true;
            }
        }
    }
}
