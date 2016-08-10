using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes.Ships
{
    class NPCSmallShipClass:BaseNPCShip
    {

        public NPCSmallShipClass()
        {
            NpcShipName = "Small Ship";
            NpcShipID = 12;

            FindPlayerMaxDistance = 1250f;

            WanderSpeed = 11.5f;
            WanderSpeedTurnSpeedFactor = 3.5f;

            PatrolSpeed = 14.0f;
            PatrolSpeedTurnFactor = 3.0f;

            FollowMaxSpeed = 17.5f;
            FollowTurnSpeedFactor = 1.45f;
            FollowMaxDistance = 800f; //This will need to be adjusted based on weapon range
            FollowMinDistance = 300f;

            AttackSpeed = 18.5f;
            AttackTurnSpeedFactor = 0.5f;
            AttackTurnDistance = 275f;
            AttackMaxDistance = 1000f;
            AttackMinDistance = 300f;

            AvoidanceDistance = 250f;
            AvoidanceSpeed = 18.5f;
            AvoidanceTurnSpeedFactor = 0.5f;

            Hull = 1200;

            MaxWeaponDamage = 70f;
            MinWeaponDamage = 35f;
            WeaponCoolDown = 5.2f;

            MaxShipVolume = 10000f;

            EvasionModifier = .85f;

            IfCloak = false;
            IfStealth = false;
        }
    }
}
