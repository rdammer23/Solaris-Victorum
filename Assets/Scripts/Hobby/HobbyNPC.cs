using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Hobby
{
    class HobbyNPC
    {
        public string HobbyName(int hobbyID, int hobbyLevel)
        {
            return null;
        }

        public float Resources(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 1:
                    return .01f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float ToHit(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 2:
                    return .01f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float CritHitChance(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 3:
                    return .001f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float ShipVolume(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 4:
                    return .01f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float WeaponCoolDown(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 5:
                    return .00075f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float XPBonus(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 6:
                    return .001f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float Hull(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 7:
                    return .05f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float ShipSpeed(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 8:
                    return .001f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float TractorBeamChance(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 9:
                    return .01f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float StunChance(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 10:
                    return .001f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float Evasion(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 11:
                    return .001f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float Damage(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 12:
                    return .001f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float CriticalDamage(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 13:
                    return .001f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float ExtraShot(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 14:
                    return .02f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float FindPlayer(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 15:
                    return .01f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float MajorBreakThrough(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 16:
                    return .01f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float Invention(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 17:
                    return .01f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float StunDuration(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 18:
                    return .001f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float EnergyConversion(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 19:
                    return .001f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float CloakChance(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 20:
                    return .01f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float CloakAllChance(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 20:
                    return .01f * hobbyLevel;
                default:
                    return 0;
            }
        }

        public float InstantKillChance(int hobbyID, int hobbyLevel)
        {
            switch (hobbyID)
            {
                case 13:
                    return .002f * hobbyLevel;
                case 20:
                    return .001f * hobbyLevel;
                default:
                    return 0;
            }
        }

    }
}
