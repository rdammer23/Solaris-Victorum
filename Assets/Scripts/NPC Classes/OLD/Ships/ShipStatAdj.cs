using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes.Ships
{
    class ShipStatAdj
    {
        NPCShuttleShipClass _shuttleShip;
        NPCTinyShipClass _tinyShip;
        NPCSmallShipClass _smallShip;

        public float Shuttle(string shipAdjStat)
        {
            _shuttleShip = new NPCShuttleShipClass();
            switch (shipAdjStat)
            {
                case "Hull":
                    return _shuttleShip.Hull;
                case "FindPlayerMaxDistance":
                    return _shuttleShip.FindPlayerMaxDistance;
                case "WanderSpeed":
                    return _shuttleShip.WanderSpeed;
                case "WanderSpeedTurnSpeedFactor":
                    return _shuttleShip.WanderSpeedTurnSpeedFactor;
                case "PatrolSpeed":
                    return _shuttleShip.PatrolSpeed;
                case "PatrolSpeedTurnFactor":
                    return _shuttleShip.PatrolSpeedTurnFactor;
                case "FollowMaxSpeed":
                    return _shuttleShip.FollowMaxSpeed;
                case "FollowTurnSpeedFactor":
                    return _shuttleShip.FollowTurnSpeedFactor;
                case "FollowMaxDistance":
                    return _shuttleShip.FollowMaxDistance;
                case "FollowMinDistance":
                    return _shuttleShip.FollowMinDistance;
                case "AttackSpeed":
                    return _shuttleShip.AttackSpeed;
                case "AttackTurnSpeedFactor":
                    return _shuttleShip.AttackTurnSpeedFactor;
                case "AttackTurnDistance":
                    return _shuttleShip.AttackTurnDistance;
                case "AttackMaxDistance":
                    return _shuttleShip.AttackMaxDistance;
                case "AttackMinDistance":
                    return _shuttleShip.AttackMinDistance;
                case "AvoidanceDistance":
                    return _shuttleShip.AvoidanceDistance;
                case "AvoidanceSpeed":
                    return _shuttleShip.AvoidanceSpeed;
                case "AvoidanceTurnSpeedFactor":
                    return _shuttleShip.AvoidanceTurnSpeedFactor;
                case "MaxWeaponDamage":
                    return _shuttleShip.MaxWeaponDamage;
                case "MinWeaponDamage":
                    return _shuttleShip.MinWeaponDamage;
                case "WeaponCoolDown":
                    return _shuttleShip.WeaponCoolDown;
                case "MaxShipVolume":
                    return _shuttleShip.MaxShipVolume;
            }
            return 1;
        }

        public float Tiny(string shipAdjStat)
        {
            _tinyShip = new NPCTinyShipClass();
            switch (shipAdjStat)
            {
                case "Hull":
                    return _tinyShip.Hull;
                case "FindPlayerMaxDistance":
                    return _tinyShip.FindPlayerMaxDistance;
                case "WanderSpeed":
                    return _tinyShip.WanderSpeed;
                case "WanderSpeedTurnSpeedFactor":
                    return _tinyShip.WanderSpeedTurnSpeedFactor;
                case "PatrolSpeed":
                    return _tinyShip.PatrolSpeed;
                case "PatrolSpeedTurnFactor":
                    return _tinyShip.PatrolSpeedTurnFactor;
                case "FollowMaxSpeed":
                    return _tinyShip.FollowMaxSpeed;
                case "FollowTurnSpeedFactor":
                    return _tinyShip.FollowTurnSpeedFactor;
                case "FollowMaxDistance":
                    return _tinyShip.FollowMaxDistance;
                case "FollowMinDistance":
                    return _tinyShip.FollowMinDistance;
                case "AttackSpeed":
                    return _tinyShip.AttackSpeed;
                case "AttackTurnSpeedFactor":
                    return _tinyShip.AttackTurnSpeedFactor;
                case "AttackTurnDistance":
                    return _tinyShip.AttackTurnDistance;
                case "AttackMaxDistance":
                    return _tinyShip.AttackMaxDistance;
                case "AttackMinDistance":
                    return _tinyShip.AttackMinDistance;
                case "AvoidanceDistance":
                    return _tinyShip.AvoidanceDistance;
                case "AvoidanceSpeed":
                    return _tinyShip.AvoidanceSpeed;
                case "AvoidanceTurnSpeedFactor":
                    return _tinyShip.AvoidanceTurnSpeedFactor;
                case "MaxWeaponDamage":
                    return _tinyShip.MaxWeaponDamage;
                case "MinWeaponDamage":
                    return _tinyShip.MinWeaponDamage;
                case "WeaponCoolDown":
                    return _tinyShip.WeaponCoolDown;
                case "MaxShipVolume":
                    return _tinyShip.MaxShipVolume;
            }
            return 1;
        }

        public float Small(string shipAdjStat)
        {
            _smallShip = new NPCSmallShipClass();
            switch (shipAdjStat)
            {
                case "Hull":
                    return _smallShip.Hull;
                case "FindPlayerMaxDistance":
                    return _smallShip.FindPlayerMaxDistance;
                case "WanderSpeed":
                    return _smallShip.WanderSpeed;
                case "WanderSpeedTurnSpeedFactor":
                    return _smallShip.WanderSpeedTurnSpeedFactor;
                case "PatrolSpeed":
                    return _smallShip.PatrolSpeed;
                case "PatrolSpeedTurnFactor":
                    return _smallShip.PatrolSpeedTurnFactor;
                case "FollowMaxSpeed":
                    return _smallShip.FollowMaxSpeed;
                case "FollowTurnSpeedFactor":
                    return _smallShip.FollowTurnSpeedFactor;
                case "FollowMaxDistance":
                    return _smallShip.FollowMaxDistance;
                case "FollowMinDistance":
                    return _smallShip.FollowMinDistance;
                case "AttackSpeed":
                    return _smallShip.AttackSpeed;
                case "AttackTurnSpeedFactor":
                    return _smallShip.AttackTurnSpeedFactor;
                case "AttackTurnDistance":
                    return _smallShip.AttackTurnDistance;
                case "AttackMaxDistance":
                    return _smallShip.AttackMaxDistance;
                case "AttackMinDistance":
                    return _smallShip.AttackMinDistance;
                case "AvoidanceDistance":
                    return _smallShip.AvoidanceDistance;
                case "AvoidanceSpeed":
                    return _smallShip.AvoidanceSpeed;
                case "AvoidanceTurnSpeedFactor":
                    return _smallShip.AvoidanceTurnSpeedFactor;
                case "MaxWeaponDamage":
                    return _smallShip.MaxWeaponDamage;
                case "MinWeaponDamage":
                    return _smallShip.MinWeaponDamage;
                case "WeaponCoolDown":
                    return _smallShip.WeaponCoolDown;
                case "MaxShipVolume":
                    return _smallShip.MaxShipVolume;
            }
            return 1;
        }
    }
}
