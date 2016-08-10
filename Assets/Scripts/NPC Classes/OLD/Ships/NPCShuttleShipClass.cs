using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes.Ships
{
    class NPCShuttleShipClass:BaseNPCShip
    {
        public NPCShuttleShipClass()
        {
            NpcShipName = "Shuttle";
            NpcShipID = 10;

            FindPlayerMaxDistance = 1000f;

            WanderSpeed = 10f;
            WanderSpeedTurnSpeedFactor = 5f;

            PatrolSpeed = 12.5f;
            PatrolSpeedTurnFactor = 3f;

            FollowMaxSpeed = 15f;
            FollowTurnSpeedFactor = 1.5f;
            FollowMaxDistance = 750f; //This will need to be adjusted based on weapon range
            FollowMinDistance = 300f;

            AttackSpeed = 17.5f;
            AttackTurnSpeedFactor = 0.5f;
            AttackTurnDistance = 200f;
            AttackMaxDistance = 750f;
            AttackMinDistance = 200f;

            AvoidanceDistance = 150f;
            AvoidanceSpeed = 17.5f;
            AvoidanceTurnSpeedFactor = 0.5f;

            Hull = 800;

            MaxWeaponDamage = 50f;
            MinWeaponDamage = 25f;
            WeaponCoolDown = 5.5f;

            MaxShipVolume = 2500f;

            EvasionModifier = .95f;

            IfCloak = false;
            IfStealth = false;
        }
    }
}
