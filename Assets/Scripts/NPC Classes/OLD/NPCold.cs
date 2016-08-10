using Assets.Scripts.NPC_Classes.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes
{
    class NPCold
    {

        private int raceID;
        private int typeID; //Modifies stats during game play or resource/gear drop
        private int hobbyID; //Modifies stats during game play or resource/gear drop
        private int shipID; //Not sure if I need this.
        private int npcLevel;
        private int hobbyLevel;

        //Need to get the base attributes from the race classes and adjust for level, then determine the stat changes
        private float strength;
        private float intelligence;
        private float dexterity;
        private float wisdom;
        private float health;
        private float eagleEyes;
        private float speed;
        private float endurance;
        private float nervesOfSteel;
        private float charisma;

        private float maxHealth;
        private float currentHealth;


        //Ship Stuff
        private float findPlayerMaxDistance;

        private int shipHull;

        private float wanderSpeed;
        private float wanderTurnSpeed; 

        private float patrolSpeed;
        private float patrolTurnSpeed;

        private float followMaxSpeed;
        private float followTurnSpeed;
        private float followMaxDistance;
        private float followMinDistance;

        private float attackSpeed;
        private float attackTurnSpeed;
        private float attackTurnDistance;
        private float attackMaxDistance;
        private float attackMinDistance;

        private float avoidanceDistance;
        private float avoidanceSpeed;
        private float avoidanceTurnSpeed;

        private float maxWeaponDamage;
        private float minWeaponDamage;
        private float weaponCoolDown;

        private float maxShipVolume;

        private List<BaseNPCShip> npcShip;

        //Type and Hobby Modifiers Stuff
        private float npcEnergyConversion;
        private float npcToHit;
        private float npcCritHitChance;
        private float npcWeaponCoolDown;
        private float npcHullIncrease;
        private float npcTractorBeamIncreaseChance;
        private float npcShipSpeedIncrease;
        private float npcEvasionIncrease;
        private float npcDamageIncrease;
        private float npcCriticalDamageIncrease;
        private float npcExtraShotChance;
        private float npcStunChanceIncrease;
        private float npcStunDurationIncrease;
        private float npcCloakChanceIncrease;
        private float npcCloakAllChanceIncrease;
        private float npcInstantKillIncrease;



        public NPCold(int raceID, int typeID, int hobbyID, int shipID, int npcLevel, int hobbyLevel,
            float strength, float intelligence, float dexterity, float wisdom, float health, 
            float eagleEyes, float speed, float endurance, float nervesOfSteel, float charisma,
            float npcToHit, float npcEvasionIncrease, float npcHullIncrease, float npcDamageIncrease,
            float npcShipSpeedIncrease, float npcWeaponCoolDown, float npcCritHitChance,
            float npcCriticalDamageIncrease, float npcExtraShotChance, float npcStunChanceIncrease,
            float npcStunDurationIncrease, float npcTractorBeamIncreaseChance, float npcEnergyConversion,
            float npcCloakChanceIncrease, float npcCloakAllChanceIncrease, float npcInstantKillIncrease, List<BaseNPCShip> npcShip,
            float maxHealth, float wanderSpeed, float wanderTurnSpeed, float patrolSpeed, float patrolTurnSpeed,
            float followMaxSpeed, float followTurnSpeed, float followMaxDistance, float followMinDistance,
            float attackSpeed, float attackTurnSpeed, float attackTurnDistance, float attackMaxDistance,
            float attackMinDistance, float avoidanceDistance, float avoidanceSpeed, float avoidanceTurnSpeed,
            float findPlayerMaxDistance, float maxShipVolume, float maxDamage)

        {
            this.raceID = raceID;
            this.typeID = typeID;
            this.hobbyID = hobbyID;
            this.shipID = shipID;
            this.npcLevel = npcLevel;
            this.hobbyLevel = hobbyLevel;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.wisdom = wisdom;
            this.health = health;
            this.eagleEyes = eagleEyes;
            this.speed = speed;
            this.endurance = endurance;
            this.nervesOfSteel = nervesOfSteel;
            this.charisma = charisma;
            this.npcToHit = npcToHit;
            this.npcEvasionIncrease = npcEvasionIncrease;
            this.npcHullIncrease = npcHullIncrease;
            this.npcDamageIncrease = npcDamageIncrease;
            this.npcShipSpeedIncrease = npcShipSpeedIncrease;
            this.npcWeaponCoolDown = npcWeaponCoolDown;
            this.npcCritHitChance = npcCritHitChance;
            this.npcCriticalDamageIncrease = npcCriticalDamageIncrease;
            this.npcExtraShotChance = npcExtraShotChance;
            this.npcStunChanceIncrease = npcStunChanceIncrease;
            this.npcStunDurationIncrease = npcStunDurationIncrease;
            this.npcTractorBeamIncreaseChance = npcTractorBeamIncreaseChance;
            this.npcEnergyConversion = npcEnergyConversion;
            this.npcCloakChanceIncrease = npcCloakChanceIncrease;
            this.npcCloakAllChanceIncrease = npcCloakAllChanceIncrease;
            this.npcInstantKillIncrease = npcInstantKillIncrease;
            this.npcShip = npcShip;
            this.maxHealth = maxHealth;
            
            this.wanderSpeed = wanderSpeed;
            this.wanderTurnSpeed = wanderTurnSpeed;

            this.patrolSpeed = patrolSpeed;
            this.patrolTurnSpeed = patrolTurnSpeed;

            this.followMaxSpeed = followMaxSpeed;
            this.followTurnSpeed = followTurnSpeed;
            this.followMaxDistance = followMaxDistance;
            this.followMinDistance = followMinDistance;

            this.attackSpeed = attackSpeed;
            this.attackTurnSpeed = attackTurnSpeed;
            this.attackTurnDistance = attackTurnDistance;
            this.attackMaxDistance = attackMaxDistance;
            this.attackMinDistance = attackMinDistance;

            this.avoidanceDistance = avoidanceDistance;
            this.avoidanceSpeed = avoidanceSpeed;
            this.avoidanceTurnSpeed = avoidanceTurnSpeed;

            this.findPlayerMaxDistance = findPlayerMaxDistance;
            this.maxShipVolume = maxShipVolume;
        }


        //Once I remove HumanManagerOld2 below can also be removed.
        /*
        public NPC(int raceID, int typeID, int hobbyID, int shipID, int npcLevel, int hobbyLevel, float strength, float intelligence, float dexterity, float wisdom, float health, float eagleEyes, float speed, float endurance, float nervesOfSteel, float charisma, float maxHealth, float currentHealth, int shipHull, float findPlayerMaxDistance, float wanderSpeed, float wanderSpeedTurnSpeedFactor, float patrolSpeed, float patrolSpeedTurnFactor, float followMaxSpeed, float followTurnSpeedFactor, float followMaxDistance, float followMinDistance, float attackSpeed, float attackTurnSpeedFactor, float attackTurnDistance, float attackMaxDistance, float attackMinDistance, float avoidanceDistance, float avoidanceSpeed, float avoidanceTurnSpeedFactor, float maxWeaponDamage, float minWeaponDamage, float weaponCoolDown, float maxShipVolume, float npcEnergyConversion, float npcToHit, float npcCritHitChance, float npcWeaponCoolDown, float npcHullIncrease, float npcTractorBeamIncreaseChance, float npcShipSpeedIncrease, float npcEvasionIncrease, float npcDamageIncrease, float npcCriticalDamageIncrease, float npcExtraShotChance, float npcStunChanceIncrease, float npcStunDurationIncrease, float npcCloakChanceIncrease, float npcCloakAllChanceIncrease, float npcInstantKillIncrease)
        {
            this.raceID = raceID;
            this.typeID = typeID;
            this.hobbyID = hobbyID;
            this.shipID = shipID;
            this.npcLevel = npcLevel;
            this.hobbyLevel = hobbyLevel;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.wisdom = wisdom;
            this.health = health;
            this.eagleEyes = eagleEyes;
            this.speed = speed;
            this.endurance = endurance;
            this.nervesOfSteel = nervesOfSteel;
            this.charisma = charisma;
            this.maxHealth = maxHealth;
            this.currentHealth = currentHealth;
            this.shipHull = shipHull;
            this.findPlayerMaxDistance = findPlayerMaxDistance;
            this.wanderSpeed = wanderSpeed;
            this.wanderTurnSpeed = wanderSpeedTurnSpeedFactor;
            this.patrolSpeed = patrolSpeed;
            this.patrolTurnSpeed = patrolSpeedTurnFactor;
            this.followMaxSpeed = followMaxSpeed;
            this.followTurnSpeed = followTurnSpeedFactor;
            this.followMaxDistance = followMaxDistance;
            this.followMinDistance = followMinDistance;
            this.attackSpeed = attackSpeed;
            this.attackTurnSpeed = attackTurnSpeedFactor;
            this.attackTurnDistance = attackTurnDistance;
            this.attackMaxDistance = attackMaxDistance;
            this.attackMinDistance = attackMinDistance;
            this.avoidanceDistance = avoidanceDistance;
            this.avoidanceSpeed = avoidanceSpeed;
            this.avoidanceTurnSpeed = avoidanceTurnSpeedFactor;
            this.maxWeaponDamage = maxWeaponDamage;
            this.minWeaponDamage = minWeaponDamage;
            this.weaponCoolDown = weaponCoolDown;
            this.maxShipVolume = maxShipVolume;
            this.npcEnergyConversion = npcEnergyConversion;
            this.npcToHit = npcToHit;
            this.npcCritHitChance = npcCritHitChance;
            this.npcWeaponCoolDown = npcWeaponCoolDown;
            this.npcHullIncrease = npcHullIncrease;
            this.npcTractorBeamIncreaseChance = npcTractorBeamIncreaseChance;
            this.npcShipSpeedIncrease = npcShipSpeedIncrease;
            this.npcEvasionIncrease = npcEvasionIncrease;
            this.npcDamageIncrease = npcDamageIncrease;
            this.npcCriticalDamageIncrease = npcCriticalDamageIncrease;
            this.npcExtraShotChance = npcExtraShotChance;
            this.npcStunChanceIncrease = npcStunChanceIncrease;
            this.npcStunDurationIncrease = npcStunDurationIncrease;
            this.npcCloakChanceIncrease = npcCloakChanceIncrease;
            this.npcCloakAllChanceIncrease = npcCloakAllChanceIncrease;
            this.npcInstantKillIncrease = npcInstantKillIncrease;
        }
        */

        #region GETs and SETs
        public int RaceID
        {
            get
            {
                return raceID;
            }

            set
            {
                raceID = value;
            }
        }

        public int TypeID
        {
            get
            {
                return typeID;
            }

            set
            {
                typeID = value;
            }
        }

        public int HobbyID
        {
            get
            {
                return hobbyID;
            }

            set
            {
                hobbyID = value;
            }
        }

        public int ShipID
        {
            get
            {
                return shipID;
            }

            set
            {
                shipID = value;
            }
        }

        public int NpcLevel
        {
            get
            {
                return npcLevel;
            }

            set
            {
                npcLevel = value;
            }
        }

        public int HobbyLevel
        {
            get
            {
                return hobbyLevel;
            }

            set
            {
                hobbyLevel = value;
            }
        }

        public float Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }

        public float Intelligence
        {
            get
            {
                return intelligence;
            }

            set
            {
                intelligence = value;
            }
        }

        public float Dexterity
        {
            get
            {
                return dexterity;
            }

            set
            {
                dexterity = value;
            }
        }

        public float Wisdom
        {
            get
            {
                return wisdom;
            }

            set
            {
                wisdom = value;
            }
        }

        public float Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }

        public float EagleEyes
        {
            get
            {
                return eagleEyes;
            }

            set
            {
                eagleEyes = value;
            }
        }

        public float Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public float Endurance
        {
            get
            {
                return endurance;
            }

            set
            {
                endurance = value;
            }
        }

        public float NervesOfSteel
        {
            get
            {
                return nervesOfSteel;
            }

            set
            {
                nervesOfSteel = value;
            }
        }

        public float Charisma
        {
            get
            {
                return charisma;
            }

            set
            {
                charisma = value;
            }
        }

        public float MaxHealth
        {
            get
            {
                return maxHealth;
            }

            set
            {
                maxHealth = value;
            }
        }

        public float CurrentHealth
        {
            get
            {
                return currentHealth;
            }

            set
            {
                currentHealth = value;
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

        public float WanderTurnSpeed
        {
            get
            {
                return wanderTurnSpeed;
            }

            set
            {
                wanderTurnSpeed = value;
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

        public float PatrolTurnSpeed
        {
            get
            {
                return patrolTurnSpeed;
            }

            set
            {
                patrolTurnSpeed = value;
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

        public float FollowTurnSpeed
        {
            get
            {
                return followTurnSpeed;
            }

            set
            {
                followTurnSpeed = value;
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

        public float AttackTurnSpeed
        {
            get
            {
                return attackTurnSpeed;
            }

            set
            {
                attackTurnSpeed = value;
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

        public float AvoidanceTurnSpeed
        {
            get
            {
                return avoidanceTurnSpeed;
            }

            set
            {
                avoidanceTurnSpeed = value;
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

        public float NpcEnergyConversion
        {
            get
            {
                return npcEnergyConversion;
            }

            set
            {
                npcEnergyConversion = value;
            }
        }

        public float NpcToHit
        {
            get
            {
                return npcToHit;
            }

            set
            {
                npcToHit = value;
            }
        }

        public float NpcCritHitChance
        {
            get
            {
                return npcCritHitChance;
            }

            set
            {
                npcCritHitChance = value;
            }
        }

        public float NpcWeaponCoolDown
        {
            get
            {
                return npcWeaponCoolDown;
            }

            set
            {
                npcWeaponCoolDown = value;
            }
        }

        public float NpcHullIncrease
        {
            get
            {
                return npcHullIncrease;
            }

            set
            {
                npcHullIncrease = value;
            }
        }

        public float NpcTractorBeamIncreaseChance
        {
            get
            {
                return npcTractorBeamIncreaseChance;
            }

            set
            {
                npcTractorBeamIncreaseChance = value;
            }
        }

        public float NpcShipSpeedIncrease
        {
            get
            {
                return npcShipSpeedIncrease;
            }

            set
            {
                npcShipSpeedIncrease = value;
            }
        }

        public float NpcEvasionIncrease
        {
            get
            {
                return npcEvasionIncrease;
            }

            set
            {
                npcEvasionIncrease = value;
            }
        }

        public float NpcDamageIncrease
        {
            get
            {
                return npcDamageIncrease;
            }

            set
            {
                npcDamageIncrease = value;
            }
        }

        public float NpcCriticalDamageIncrease
        {
            get
            {
                return npcCriticalDamageIncrease;
            }

            set
            {
                npcCriticalDamageIncrease = value;
            }
        }

        public float NpcExtraShotChance
        {
            get
            {
                return npcExtraShotChance;
            }

            set
            {
                npcExtraShotChance = value;
            }
        }

        public float NpcStunChanceIncrease
        {
            get
            {
                return npcStunChanceIncrease;
            }

            set
            {
                npcStunChanceIncrease = value;
            }
        }

        public float NpcStunDurationIncrease
        {
            get
            {
                return npcStunDurationIncrease;
            }

            set
            {
                npcStunDurationIncrease = value;
            }
        }

        public float NpcCloakChanceIncrease
        {
            get
            {
                return npcCloakChanceIncrease;
            }

            set
            {
                npcCloakChanceIncrease = value;
            }
        }

        public float NpcCloakAllChanceIncrease
        {
            get
            {
                return npcCloakAllChanceIncrease;
            }

            set
            {
                npcCloakAllChanceIncrease = value;
            }
        }

        public float NpcInstantKillIncrease
        {
            get
            {
                return npcInstantKillIncrease;
            }

            set
            {
                npcInstantKillIncrease = value;
            }
        }

        public int ShipHull
        {
            get
            {
                return shipHull;
            }

            set
            {
                shipHull = value;
            }
        }

        internal List<BaseNPCShip> NpcShip
        {
            get
            {
                return npcShip;
            }

            set
            {
                npcShip = value;
            }
        }

        #endregion

        /*
        These have either no impact on NPC at this time
        Or need to be looked up when NPC is killed

        private float npcResourceIncrease;
        private float npcXpBonus;
        private float npcShipVolumeIncrease;
        private float npcVisionFieldIncrease;
        private float npcMajorBreakThroughChance;
        private float npcInventionBonusChance;
        */

        /*
        private List<BaseNPC> npc;
        private List<BaseNPCShip> npcShip;
        private List<BaseNPCType> npcType;
        private List<BaseNPCHobby> npcHobby;

        
        public NPC(List<BaseNPC> npc, List<BaseNPCShip> npcShip, List<BaseNPCType> npcType, List<BaseNPCHobby> npcHobby)
        {
            this.npc = npc;
            this.npcShip = npcShip;
            this.npcType = npcType;
            this.npcHobby = npcHobby;
        }
        
        #region GETs and SETs
        internal List<BaseNPC> Npc
        {
            get
            {
                return npc;
            }

            set
            {
                npc = value;
            }
        }

        internal List<BaseNPCShip> NpcShip
        {
            get
            {
                return npcShip;
            }

            set
            {
                npcShip = value;
            }
        }

        internal List<BaseNPCType> NpcType
        {
            get
            {
                return npcType;
            }

            set
            {
                npcType = value;
            }
        }

        internal List<BaseNPCHobby> NpcHobby
        {
            get
            {
                return npcHobby;
            }

            set
            {
                npcHobby = value;
            }
        }
        #endregion
        */
    }
}
