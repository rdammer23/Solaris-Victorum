using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Types
{
    class TypesNPC
    {
        public string TypeName(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return "Patrol";

                case 2:
                    return "Miner";

                case 3:
                    return "Sentry";

                case 4:
                    return "Soldier";

                case 5:
                    return "Tank";

                case 6:
                    return "Defender";

                case 7:
                    return "Punisher";

                case 8:
                    return "Mangler";

                case 9:
                    return "Franctireur";

                case 10:
                    return "Squad Leader";

                case 11:
                    return "Infiltrator";

                case 12:
                    return "Dart";

                case 13:
                    return "Scientist";

                case 14:
                    return "Gunner";

                case 15:
                    return "Assassin";

                case 16:
                    return "Peace Keeper";

                case 17:
                    return "Enforcer";

                case 18:
                    return "Inventor";

                case 19:
                    return "Spy";

                case 20:
                    return "General";

                default:
                    return null;
            }
        }

        public float Resources(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 2:
                    return .25f * npcLevel;
                case 13:
                    return .1f * npcLevel;
                case 18:
                    return .1f * npcLevel;
                default:
                    return 0;
            }
        }

        public float ToHit(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 3:
                    return .1f * npcLevel;
                case 4:
                    return .1f * npcLevel;
                case 6:
                    return .1f * npcLevel;
                case 7:
                    return .25f * npcLevel;
                case 8:
                    return .15f * npcLevel;
                case 9:
                    return .5f * npcLevel;
                case 10:
                    return .1f * npcLevel;
                case 12:
                    return -.01f * npcLevel;
                case 14:
                    return .25f * npcLevel;
                case 15:
                    return .1f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float CritHitChance(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 9:
                    return .25f * npcLevel;
                case 11:
                    return .1f * npcLevel;
                case 17:
                    return .1f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float ShipVolume(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 2:
                    return .25f * npcLevel;
                case 13:
                    return .25f * npcLevel;
                case 18:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float WeaponCoolDown(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 4:
                    return .05f * npcLevel;
                case 10:
                    return .05f * npcLevel;
                case 14:
                    return .05f * npcLevel;
                case 17:
                    return .05f * npcLevel;
                case 20:
                    return .05f * npcLevel;
                default:
                    return 0;
            }
        }

        public float Hull(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 5:
                    return .25f * npcLevel;
                case 10:
                    return .1f * npcLevel;
                case 20:
                    return .5f * npcLevel;
                default:
                    return 0;
            }
        }

        public float ShipSpeed(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 1:
                    return .1f * npcLevel;
                case 12:
                    return .1f * npcLevel;
                case 17:
                    return .1f * npcLevel;
                case 20:
                    return .1f * npcLevel;
                default:
                    return 0;
            }
        }

        public float TractorBeamChance(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 16:
                    return .15f * npcLevel;
                case 17:
                    return .1f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float StunChance(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 16:
                    return .15f * npcLevel;
                case 17:
                    return .1f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float Evasion(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 3:
                    return .1f * npcLevel;
                case 6:
                    return .1f * npcLevel;
                case 12:
                    return .5f * npcLevel;
                case 19:
                    return .15f * npcLevel;
                default:
                    return 0;
            }
        }

        public float Damage(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 6:
                    return .1f * npcLevel;
                case 7:
                    return .25f * npcLevel;
                case 12:
                    return -.01f * npcLevel;
                case 17:
                    return .2f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float CriticalDamage(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 7:
                    return .1f * npcLevel;
                case 11:
                    return .1f * npcLevel;
                case 17:
                    return .15f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float ExtraShot(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 9:
                    return .25f * npcLevel;
                case 14:
                    return .05f * npcLevel;
                case 17:
                    return .1f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float FindPlayer(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 1:
                    return .5f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float MajorBreakThrough(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 13:
                    return .25f * npcLevel;
                case 18:
                    return .05f * npcLevel;
                default:
                    return 0;
            }
        }

        public float Invention(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 13:
                    return .05f * npcLevel;
                case 18:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float StunDuration(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 16:
                    return .15f * npcLevel;
                case 17:
                    return .1f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float EnergyConversion(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 16:
                    return .25f * npcLevel;
                case 17:
                    return .05f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float CloakChance(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 15:
                    return .25f * npcLevel;
                case 19:
                    return .15f * npcLevel;
                default:
                    return 0;
            }
        }

        public float CloakAllChance(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 15:
                    return .05f;
                default:
                    return 0;
            }
        }

        public float InstantKillChance(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 15:
                    return .01f * npcLevel;
                default:
                    return 0;
            }
        }

        public float DamageReduction(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 5:
                    return .5f * npcLevel;
                case 17:
                    return .2f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float CriticalHitResistance(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 5:
                    return .25f * npcLevel;
                case 17:
                    return .1f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float CriticalHitReduction(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 5:
                    return .25f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float StunResistance(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 8:
                    return .1f * npcLevel;
                case 10:
                    return .15f * npcLevel;
                case 17:
                    return .1f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

        public float TractorBeamResistance(int typeID, int npcLevel)
        {
            switch (typeID)
            {
                case 16:
                    return .15f * npcLevel;
                case 17:
                    return .1f * npcLevel;
                case 20:
                    return .25f * npcLevel;
                default:
                    return 0;
            }
        }

    }
}
