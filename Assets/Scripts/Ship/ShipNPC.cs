using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Ship
{
    class ShipNPC
    {

        public string ShipName(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return "Shuttle";
                case 2:
                    return "Tiny";
                case 3:
                    return "Small";
                default:
                    return "ErrorGettingShipName";
            }
        }

        public float FindPlayerDistance(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 1000f;
                case 2:
                    return 1050f;
                case 3:
                    return 1250f;
                default:
                    return 500f;  //If I ever see a NPC with 500 I know it errored out.
            }
        }

        public float WanderSpeed(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 10f;
                case 2:
                    return 10.5f;
                case 3:
                    return 11.5f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }

        public float WanderSpeedTurnFactor(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 5f;
                case 2:
                    return 3.75f;
                case 3:
                    return 3.5f;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float PatrolSpeed(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 12.5f;
                case 2:
                    return 13.5f;
                case 3:
                    return 14.0f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }

        public float PatrolSpeedTurnFactor(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 1.5f;
                case 2:
                    return 1.35f;
                case 3:
                    return 1.5f;
                default:
                    return 10f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float FollowMaxSpeed(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 15f;
                case 2:
                    return 16.5f;
                case 3:
                    return 17.5f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }

        public float FollowSpeedTurnFactor(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 1f;
                case 2:
                    return .951f;
                case 3:
                    return .90f;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float FollowMaxDistance(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 1750;
                case 2:
                    return 2000f;
                case 3:
                    return 2250f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }

        public float FollowMinDistance(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 300f;
                case 2:
                    return 300f;
                case 3:
                    return 300;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float AttackSpeed(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 17.5f;
                case 2:
                    return 18f;
                case 3:
                    return 18.5f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }

        public float AttackSpeedTurnFactor(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return .5f;
                case 2:
                    return .5f;
                case 3:
                    return .5f;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float AttackTurnDistance(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 200f;
                case 2:
                    return 250f;
                case 3:
                    return 275f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }

        public float AttackMaxDistance(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 750f;
                case 2:
                    return 750f;
                case 3:
                    return 1000;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float AttackMinDistance(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 100f;
                case 2:
                    return 125f;
                case 3:
                    return 150;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float AvoidanceDistance(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 100f;
                case 2:
                    return 125f;
                case 3:
                    return 150f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }

        public float AvoidanceSpeed(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 17.5f;
                case 2:
                    return 18.0f;
                case 3:
                    return 18.5f;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float AvoidanceSpeedTurnFactor(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return .5f;
                case 2:
                    return .5f;
                case 3:
                    return .5f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }

        public float MaxWeaponDamage(int shipID)
        {
            //This is without a Weapon Installed.  If Weapon Installed, then use that instead
            switch (shipID)
            {
                case 1:
                    return 50f;
                case 2:
                    return 60f;
                case 3:
                    return 70f;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float MinWeaponDamage(int shipID)
        {
            //This is without a Weapon Installed.  If Weapon Installed, then use that instead
            switch (shipID)
            {
                case 1:
                    return 25f;
                case 2:
                    return 30f;
                case 3:
                    return 35f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }

        public float WeaponCoolDown(int shipID)
        {
            //This is without a Weapon Installed.  If Weapon Installed, then use that instead
            switch (shipID)
            {
                case 1:
                    return 3.0f;
                case 2:
                    return 3.0f;
                case 3:
                    return 3.0f;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float MaxShipVolume(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 2500f;
                case 2:
                    return 5000f;
                case 3:
                    return 10000f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }

        public float ShipHull(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 800f;
                case 2:
                    return 1000f;
                case 3:
                    return 1200f;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float EvasionModifier(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 1.0f;
                case 2:
                    return .95f;
                case 3:
                    return .90f;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }
        /*
        Gear Slots...This is for first 3 ships only, Shuttle, Tiny and Small
        Currently Not Used.  Should be Used in 0.010
        private int liteGunSlotOneID;
        private int mediumGunSlotOneID;
        private int heavyGunSlotOneID;
        private int storageSlotOneID;
        private int hullSlotOneID;
        private int engineSlotOneID;
        private int missleSlotOneID;
        private bool ifCloak;
        private bool ifStealth;
        */
    }
}
