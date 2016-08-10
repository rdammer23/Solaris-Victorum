using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes.Ships
{
    class NPCTinyShipClass:BaseNPCShip
    {
        public NPCTinyShipClass()
        {
            NpcShipName = "Tiny Ship";
            NpcShipID = 11;

            FindPlayerMaxDistance = 1050f;

            WanderSpeed = 10.5f;
            WanderSpeedTurnSpeedFactor = 3.75f;

            PatrolSpeed = 13.5f;
            PatrolSpeedTurnFactor = 2.75f;

            FollowMaxSpeed = 16.5f;
            FollowTurnSpeedFactor = 1.5f;
            FollowMaxDistance = 800f; //This will need to be adjusted based on weapon range
            FollowMinDistance = 300f;

            AttackSpeed = 18f;
            AttackTurnSpeedFactor = 0.5f;
            AttackTurnDistance = 250f;
            AttackMaxDistance = 750f;
            AttackMinDistance = 200f;

            AvoidanceDistance = 150f;
            AvoidanceSpeed = 18f;
            AvoidanceTurnSpeedFactor = 0.5f;

            Hull = 1000;

            MaxWeaponDamage = 60f;
            MinWeaponDamage = 30f;
            WeaponCoolDown = 5.1f;

            MaxShipVolume = 5000f;

            EvasionModifier = .90f;

            IfCloak = false;
            IfStealth = false;
        }
    }
}
