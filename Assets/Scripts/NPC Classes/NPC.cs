using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes
{
    class NPC
    {
        private int raceID;
        private string npcName;  
        private int level;
        private float maxHealth;
        private float currentHealth;

        private int shipID;//Don't think I need the ship name as I can easily look that up

        private int hobbyID;
        private int hobbyLevel;

        private int typeID;
        private string typeName;

        private float xpBonus; //Allows the NPC to Level Faster
        private float resources;
        private float shipVolume;

        private float toHit;
        private float maxDamage;
        private float minDamage;
        private float damageReduction;

        private float critHitChance;
        private float critDamage;
        private float critHitResist;
        private float critHitReduction; //This reduces the amount of damage taken when critical hit happens

        private float weaponCoolDown;

        private float findPlayerRange;

        private float evasion;

        private float tractorBeamChance;
        private float tractorBeamResist;

        private float stunChance;
        private float stunDuration;
        private float stunResist;

        private float extraShotChance;

        private float energyConversion;

        private float majorBreakThrough;
        private float invention;

        private float cloakChance;
        private float cloakAllChance;

        private float instantKillChance;

        private float wanderSpeed;
        private float wanderSpeedTurnFactor;

        private float patrolSpeed;
        private float patrolSpeedTurnFactor;

        private float followMaxSpeed;
        private float followSpeedTurnFactor;
        private float followMaxDistance;
        private float followMinDistance;

        private float attackSpeed;
        private float attackSpeedTurnFactor;
        private float attackTurnDistance;
        private float attackMaxDistance;
        private float attackMinDistance;

        private float avoidanceDistance;
        private float avoidanceSpeed;
        private float avoidanceSpeedTurnFactor;
        private List<NPC> list;

        public NPC(int raceID, string npcName, int level, float maxHealth, float currentHealth, int shipID, int hobbyID, int hobbyLevel, int typeID, string typeName, float xpBonus, float resources, float shipVolume, float toHit, float maxDamage, float minDamage, float damageReduction, float critHitChance, float critDamage, float critHitResist, float critHitReduction, float weaponCoolDown, float findPlayerRange, float evasion, float tractorBeamChance, float tractorBeamResist, float stunChance, float stunDuration, float stunResist, float extraShotChance, float energyConversion, float majorBreakThrough, float invention, float cloakChance, float cloakAllChance, float instantKillChance, float wanderSpeed, float wanderSpeedTurnFactor, float patrolSpeed, float patrolSpeedTurnFactor, float followMaxSpeed, float followSpeedTurnFactor, float followMaxDistance, float followMinDistance, float attackSpeed, float attackSpeedTurnFactor, float attackTurnDistance, float attackMaxDistance, float attackMinDistance, float avoidanceDistance, float avoidanceSpeed, float avoidanceSpeedTurnFactor)
        {
            this.raceID = raceID;
            this.npcName = npcName;
            this.Level = level;
            this.MaxHealth = maxHealth;
            this.CurrentHealth = currentHealth;
            this.ShipID = shipID;
            this.HobbyID = hobbyID;
            this.HobbyLevel = hobbyLevel;
            this.TypeID = typeID;
            this.TypeName = typeName;
            this.XpBonus = xpBonus;
            this.Resources = resources;
            this.ShipVolume = shipVolume;
            this.ToHit = toHit;
            this.MaxDamage = maxDamage;
            this.MinDamage = minDamage;
            this.DamageReduction = damageReduction;
            this.CritHitChance = critHitChance;
            this.CritDamage = critDamage;
            this.CritHitResist = critHitResist;
            this.CritHitReduction = critHitReduction;
            this.WeaponCoolDown = weaponCoolDown;
            this.FindPlayerRange = findPlayerRange;
            this.Evasion = evasion;
            this.TractorBeamChance = tractorBeamChance;
            this.TractorBeamResist = tractorBeamResist;
            this.StunChance = stunChance;
            this.StunDuration = stunDuration;
            this.StunResist = stunResist;
            this.ExtraShotChance = extraShotChance;
            this.EnergyConversion = energyConversion;
            this.MajorBreakThrough = majorBreakThrough;
            this.Invention = invention;
            this.CloakChance = cloakChance;
            this.CloakAllChance = cloakAllChance;
            this.InstantKillChance = instantKillChance;
            this.WanderSpeed = wanderSpeed;
            this.WanderSpeedTurnFactor = wanderSpeedTurnFactor;
            this.PatrolSpeed = patrolSpeed;
            this.PatrolSpeedTurnFactor = patrolSpeedTurnFactor;
            this.FollowMaxSpeed = followMaxSpeed;
            this.FollowSpeedTurnFactor = followSpeedTurnFactor;
            this.FollowMaxDistance = followMaxDistance;
            this.FollowMinDistance = followMinDistance;
            this.AttackSpeed = attackSpeed;
            this.AttackSpeedTurnFactor = attackSpeedTurnFactor;
            this.AttackTurnDistance = attackTurnDistance;
            this.AttackMaxDistance = attackMaxDistance;
            this.AttackMinDistance = attackMinDistance;
            this.AvoidanceDistance = avoidanceDistance;
            this.AvoidanceSpeed = avoidanceSpeed;
            this.AvoidanceSpeedTurnFactor = avoidanceSpeedTurnFactor;
        }

        public NPC(List<NPC> list)
        {
            this.list = list;
        }

        #region GETs and Sets

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

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
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

        public string TypeName
        {
            get
            {
                return typeName;
            }

            set
            {
                typeName = value;
            }
        }

        public float XpBonus
        {
            get
            {
                return xpBonus;
            }

            set
            {
                xpBonus = value;
            }
        }

        public float Resources
        {
            get
            {
                return resources;
            }

            set
            {
                resources = value;
            }
        }

        public float ShipVolume
        {
            get
            {
                return shipVolume;
            }

            set
            {
                shipVolume = value;
            }
        }

        public float ToHit
        {
            get
            {
                return toHit;
            }

            set
            {
                toHit = value;
            }
        }

        public float MaxDamage
        {
            get
            {
                return maxDamage;
            }

            set
            {
                maxDamage = value;
            }
        }

        public float MinDamage
        {
            get
            {
                return minDamage;
            }

            set
            {
                minDamage = value;
            }
        }

        public float DamageReduction
        {
            get
            {
                return damageReduction;
            }

            set
            {
                damageReduction = value;
            }
        }

        public float CritHitChance
        {
            get
            {
                return critHitChance;
            }

            set
            {
                critHitChance = value;
            }
        }

        public float CritDamage
        {
            get
            {
                return critDamage;
            }

            set
            {
                critDamage = value;
            }
        }

        public float CritHitResist
        {
            get
            {
                return critHitResist;
            }

            set
            {
                critHitResist = value;
            }
        }

        public float CritHitReduction
        {
            get
            {
                return critHitReduction;
            }

            set
            {
                critHitReduction = value;
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

        public float FindPlayerRange
        {
            get
            {
                return findPlayerRange;
            }

            set
            {
                findPlayerRange = value;
            }
        }

        public float Evasion
        {
            get
            {
                return evasion;
            }

            set
            {
                evasion = value;
            }
        }

        public float TractorBeamChance
        {
            get
            {
                return tractorBeamChance;
            }

            set
            {
                tractorBeamChance = value;
            }
        }

        public float TractorBeamResist
        {
            get
            {
                return tractorBeamResist;
            }

            set
            {
                tractorBeamResist = value;
            }
        }

        public float StunChance
        {
            get
            {
                return stunChance;
            }

            set
            {
                stunChance = value;
            }
        }

        public float StunDuration
        {
            get
            {
                return stunDuration;
            }

            set
            {
                stunDuration = value;
            }
        }

        public float StunResist
        {
            get
            {
                return stunResist;
            }

            set
            {
                stunResist = value;
            }
        }

        public float ExtraShotChance
        {
            get
            {
                return extraShotChance;
            }

            set
            {
                extraShotChance = value;
            }
        }

        public float EnergyConversion
        {
            get
            {
                return energyConversion;
            }

            set
            {
                energyConversion = value;
            }
        }

        public float MajorBreakThrough
        {
            get
            {
                return majorBreakThrough;
            }

            set
            {
                majorBreakThrough = value;
            }
        }

        public float Invention
        {
            get
            {
                return invention;
            }

            set
            {
                invention = value;
            }
        }

        public float CloakChance
        {
            get
            {
                return cloakChance;
            }

            set
            {
                cloakChance = value;
            }
        }

        public float CloakAllChance
        {
            get
            {
                return cloakAllChance;
            }

            set
            {
                cloakAllChance = value;
            }
        }

        public float InstantKillChance
        {
            get
            {
                return instantKillChance;
            }

            set
            {
                instantKillChance = value;
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

        public float WanderSpeedTurnFactor
        {
            get
            {
                return wanderSpeedTurnFactor;
            }

            set
            {
                wanderSpeedTurnFactor = value;
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

        public float FollowSpeedTurnFactor
        {
            get
            {
                return followSpeedTurnFactor;
            }

            set
            {
                followSpeedTurnFactor = value;
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

        public float AttackSpeedTurnFactor
        {
            get
            {
                return attackSpeedTurnFactor;
            }

            set
            {
                attackSpeedTurnFactor = value;
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

        public float AvoidanceSpeedTurnFactor
        {
            get
            {
                return avoidanceSpeedTurnFactor;
            }

            set
            {
                avoidanceSpeedTurnFactor = value;
            }
        }

        public string NpcName
        {
            get
            {
                return npcName;
            }

            set
            {
                npcName = value;
            }
        }
        #endregion


    }
}
