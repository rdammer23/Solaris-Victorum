using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes.Ships
{
    class BaseNPCShip
    {
        private string npcShipName;
        private int npcShipID;  //Should be a 4 digit number.  First 2 digits is race ID, last 2 are ship ID for that race

        //Next set of variables are non gear modified
        private float findPlayerMaxDistance;

        private float wanderSpeed;
        private float wanderSpeedTurnSpeedFactor; //The larger the TurnSpeedFactors are the slower the turn is.

        private float patrolSpeed;
        private float patrolSpeedTurnFactor;

        private float followMaxSpeed;
        private float followTurnSpeedFactor;
        private float followMaxDistance;
        private float followMinDistance;

        private float attackSpeed;
        private float attackTurnSpeedFactor;
        private float attackTurnDistance;
        private float attackMaxDistance;
        private float attackMinDistance;

        private float avoidanceDistance;
        private float avoidanceSpeed;
        private float avoidanceTurnSpeedFactor;

        private int hull;  //This gets added to NPC health

        //Standard Ship Weapon.  Given this is for NPC, do not need a weapon name
        //Do not need a weapon type as for the first 3 ships all use weapon pulse.
        //After first 3 ships, you must bring your own weapon or there is nothing.
        private float maxWeaponDamage;
        private float minWeaponDamage;
        private float weaponCoolDown;

        private float maxShipVolume;

        //Gear Slots...This is for first 3 ships only, Shuttle, Tiny and Small
        //Currently Not Used.  Should be Used in 0.010
        private int liteGunSlotOneID;
        private int mediumGunSlotOneID;
        private int heavyGunSlotOneID;
        private int storageSlotOneID;
        private int hullSlotOneID;
        private int engineSlotOneID;
        private int missleSlotOneID;



        private float evasionModifier;

        /*
        Not Needed on NPC Ships

        //Officers.  If needed means cannot fly without.  If Available means can use, but not mandatory
        //If Needed = True then If Available has to be TRUE!
        private bool ifFirstOfficerAvailable;
        private bool ifSecondOfficerAvailable;
        private bool ifFirstOffcerAvailable;
        private bool ifHelsmanAvailable;
        private bool ifWeaponsControlAvailable;
        private bool ifChiefEngineerAvailable;
        private bool ifChiefMedicalOfficerAvailable;
        private bool ifCommunicationsOfficerAvailable;

        private bool ifFirstOfficerNeeded;
        private bool ifSecondOfficerNeeded;
        private bool ifFirstOffcerNeeded;
        private bool ifHelsmanNeeded;
        private bool ifWeaponsControlNeeded;
        private bool ifChiefEngineerNeeded;
        private bool ifChiefMedicalOfficerNeeded;
        private bool ifCommunicationsOfficerNeeded;

        private float fieldVisionModifier;

        private int maxCrewSize;
        private int minCrewSize;

        */
        private bool ifCloak;
        private bool ifStealth;

        public BaseNPCShip()
        {

        }

        public BaseNPCShip(string npcShipName, int npcShipID, float findPlayerMaxDistance, float wanderSpeed, float wanderSpeedTurnSpeedFactor, float patrolSpeed, float patrolSpeedTurnFactor, float followMaxSpeed, float followTurnSpeedFactor, float followMaxDistance, float followMinDistance, float attackSpeed, float attackTurnSpeedFactor, float attackTurnDistance, float attackMaxDistance, float attackMinDistance, float avoidanceDistance, float avoidanceSpeed, float avoidanceTurnSpeedFactor, int hull, float maxWeaponDamage, float minWeaponDamage, float weaponCoolDown, float maxShipVolume, float evasionModifier)
        {
            this.npcShipName = npcShipName;
            this.npcShipID = npcShipID;
            this.findPlayerMaxDistance = findPlayerMaxDistance;
            this.wanderSpeed = wanderSpeed;
            this.wanderSpeedTurnSpeedFactor = wanderSpeedTurnSpeedFactor;
            this.patrolSpeed = patrolSpeed;
            this.patrolSpeedTurnFactor = patrolSpeedTurnFactor;
            this.followMaxSpeed = followMaxSpeed;
            this.followTurnSpeedFactor = followTurnSpeedFactor;
            this.followMaxDistance = followMaxDistance;
            this.followMinDistance = followMinDistance;
            this.attackSpeed = attackSpeed;
            this.attackTurnSpeedFactor = attackTurnSpeedFactor;
            this.attackTurnDistance = attackTurnDistance;
            this.attackMaxDistance = attackMaxDistance;
            this.attackMinDistance = attackMinDistance;
            this.avoidanceDistance = avoidanceDistance;
            this.avoidanceSpeed = avoidanceSpeed;
            this.avoidanceTurnSpeedFactor = avoidanceTurnSpeedFactor;
            this.hull = hull;
            this.maxWeaponDamage = maxWeaponDamage;
            this.minWeaponDamage = minWeaponDamage;
            this.weaponCoolDown = weaponCoolDown;
            this.maxShipVolume = maxShipVolume;
            this.evasionModifier = evasionModifier;

        }


        #region GETs and SETs
        public string NpcShipName
        {
            get
            {
                return npcShipName;
            }

            set
            {
                npcShipName = value;
            }
        }

        public int NpcShipID
        {
            get
            {
                return npcShipID;
            }

            set
            {
                npcShipID = value;
            }
        }

        public float FindPlayerMaxDistance
        {
            get
            {
                return findPlayerMaxDistance;
            }

            set
            {
                findPlayerMaxDistance = value;
            }
        }

        public float WanderSpeed
        {
            get
            {
                return wanderSpeed;
            }

            set
            {
                wanderSpeed = value;
            }
        }

        public float WanderSpeedTurnSpeedFactor
        {
            get
            {
                return wanderSpeedTurnSpeedFactor;
            }

            set
            {
                wanderSpeedTurnSpeedFactor = value;
            }
        }

        public float PatrolSpeed
        {
            get
            {
                return patrolSpeed;
            }

            set
            {
                patrolSpeed = value;
            }
        }

        public float PatrolSpeedTurnFactor
        {
            get
            {
                return patrolSpeedTurnFactor;
            }

            set
            {
                patrolSpeedTurnFactor = value;
            }
        }

        public float FollowMaxSpeed
        {
            get
            {
                return followMaxSpeed;
            }

            set
            {
                followMaxSpeed = value;
            }
        }

        public float FollowTurnSpeedFactor
        {
            get
            {
                return followTurnSpeedFactor;
            }

            set
            {
                followTurnSpeedFactor = value;
            }
        }

        public float FollowMaxDistance
        {
            get
            {
                return followMaxDistance;
            }

            set
            {
                followMaxDistance = value;
            }
        }

        public float FollowMinDistance
        {
            get
            {
                return followMinDistance;
            }

            set
            {
                followMinDistance = value;
            }
        }

        public float AttackSpeed
        {
            get
            {
                return attackSpeed;
            }

            set
            {
                attackSpeed = value;
            }
        }

        public float AttackTurnSpeedFactor
        {
            get
            {
                return attackTurnSpeedFactor;
            }

            set
            {
                attackTurnSpeedFactor = value;
            }
        }

        public float AttackTurnDistance
        {
            get
            {
                return attackTurnDistance;
            }

            set
            {
                attackTurnDistance = value;
            }
        }

        public float AttackMaxDistance
        {
            get
            {
                return attackMaxDistance;
            }

            set
            {
                attackMaxDistance = value;
            }
        }

        public float AttackMinDistance
        {
            get
            {
                return attackMinDistance;
            }

            set
            {
                attackMinDistance = value;
            }
        }

        public int Hull
        {
            get
            {
                return hull;
            }

            set
            {
                hull = value;
            }
        }

        public float MaxWeaponDamage
        {
            get
            {
                return maxWeaponDamage;
            }

            set
            {
                maxWeaponDamage = value;
            }
        }

        public float MinWeaponDamage
        {
            get
            {
                return minWeaponDamage;
            }

            set
            {
                minWeaponDamage = value;
            }
        }

        public float WeaponCoolDown
        {
            get
            {
                return weaponCoolDown;
            }

            set
            {
                weaponCoolDown = value;
            }
        }

        public float MaxShipVolume
        {
            get
            {
                return maxShipVolume;
            }

            set
            {
                maxShipVolume = value;
            }
        }

        public int LiteGunSlotOneID
        {
            get
            {
                return liteGunSlotOneID;
            }

            set
            {
                liteGunSlotOneID = value;
            }
        }

        public int MediumGunSlotOneID
        {
            get
            {
                return mediumGunSlotOneID;
            }

            set
            {
                mediumGunSlotOneID = value;
            }
        }

        public int HeavyGunSlotOneID
        {
            get
            {
                return heavyGunSlotOneID;
            }

            set
            {
                heavyGunSlotOneID = value;
            }
        }

        public int StorageSlotOneID
        {
            get
            {
                return storageSlotOneID;
            }

            set
            {
                storageSlotOneID = value;
            }
        }

        public int HullSlotOneID
        {
            get
            {
                return hullSlotOneID;
            }

            set
            {
                hullSlotOneID = value;
            }
        }

        public int EngineSlotOneID
        {
            get
            {
                return engineSlotOneID;
            }

            set
            {
                engineSlotOneID = value;
            }
        }

        public int MissleSlotOneID
        {
            get
            {
                return missleSlotOneID;
            }

            set
            {
                missleSlotOneID = value;
            }
        }

        public float EvasionModifier
        {
            get
            {
                return evasionModifier;
            }

            set
            {
                evasionModifier = value;
            }
        }

        public bool IfCloak
        {
            get
            {
                return ifCloak;
            }

            set
            {
                ifCloak = value;
            }
        }

        public bool IfStealth
        {
            get
            {
                return ifStealth;
            }

            set
            {
                ifStealth = value;
            }
        }

        public float AvoidanceDistance
        {
            get
            {
                return avoidanceDistance;
            }

            set
            {
                avoidanceDistance = value;
            }
        }

        public float AvoidanceSpeed
        {
            get
            {
                return avoidanceSpeed;
            }

            set
            {
                avoidanceSpeed = value;
            }
        }

        public float AvoidanceTurnSpeedFactor
        {
            get
            {
                return avoidanceTurnSpeedFactor;
            }

            set
            {
                avoidanceTurnSpeedFactor = value;
            }
        }

        #endregion
    }
}
