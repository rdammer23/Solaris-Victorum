using Assets.Scripts.Items;
using Assets.Scripts.Race_Classes;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    class GameData:MonoBehaviour
    {
        void Awake()
        {
            DontDestroyOnLoad(transform.gameObject);
        }
        //Player Data
        private static string playerName;
        private static int playerID;
        private static int playerLevel;
        private static string currentScene;
        private static int currentLevelXP;
        private static int raceID;
        private static int shipID;
        private static int shipRaceID; //This with shipID determines what ship player has.
        private static int maxHealth;
        private static int currentHealth;
        private static int unUsedAttributePoints;
        //private static BaseRace playerRace;
        private static int strength;
        private static int intelligence;
        private static int dexterity;
        private static int wisdom;
        private static int health;
        private static int eagleEyes;
        private static int speed;
        private static int endurance;
        private static int nervesOfSteel;
        private static int charisma;
        
        //Adjustment values
        private static float strengthADJValue;
        private static float intelligenceADJValue;
        private static float dexterityADJValue;
        private static float wisdomADJValue;
        private static float healthADJValue;
        private static float eagleADJValue;
        private static float speedADJValue;
        private static float enduranceADJValue;
        private static float nervesADJValue;
        private static float charismaADJValue;

        private static int minDamage;
        private static int maxDamage;
        private static float damageBonus;
        private static float damageReduction;
        private static float resources;
        private static float toHit;
        private static float evasion;
        private static float crititalHitChance;
        private static float criticalDamage;
        private static float criticalHitResistance;
        private static float criticalDamageReduction;
        private static float shipSpeedADJ;
        private static float hull;
        private static float volume;
        private static float weaponCoolDown;
        private static float extraShot;
        private static float stun;
        private static float stunDuration;
        private static float stunResistance;
        private static float tractorBeam;
        private static float tractorBeamResistance;
        private static float majorBreakThrough;
        private static float inventionBonus;
        private static float cloak;
        private static float cloakAll;
        private static float instantKill;
        private static float energyConversion;
        private static float xpBonus;
        private static float buying;
        private static float selling;
        private static float happiness;

        private static float shipMoveForce;
        private static float shipTurnForce;
        private static float shipTurnRL;
        private static float shipTurnUD;
        private static int shipWeight;
        private static int shipHull;
        private static float shipWeaponViewWidth;
        private static float shipWeaponViewHeight;
        private static int shipMinDamage;
        private static int shipMaxDamage;
        private static float shipEvasion;
        private static int shipVolume;
        private static float shipWeaponCoolDown;

        private static int alignmentHuman;
        private static int alignmentFeline;
        private static int alignmentBird;
        private static int alignmentMystic;
        private static int alignmentCyborgs;
        private static int alignmentInsect;
        private static int alignmentBrains;
        private static int alignmentMetal;
        private static int alignmentLizard;
        private static int alignmentTree;
        private static int alignmentGas;
        private static BaseShipWeapon equipmentOne;

 
        #region Get and Set
        public static BaseShipWeapon EquipmentOne
        {
            get
            {
                return equipmentOne;
            }
            set
            {
                equipmentOne = value;
            }
        }
        public static string PlayerName
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }

        public static int PlayerID
        {
            get
            {
                return playerID;
            }

            set
            {
                playerID = value;
            }
        }

        public static int PlayerLevel
        {
            get
            {
                return playerLevel;
            }

            set
            {
                playerLevel = value;
            }
        }

        public static int CurrentLevelXP
        {
            get
            {
                return currentLevelXP;
            }

            set
            {
                currentLevelXP = value;
            }
        }

        public static string CurrentScene
        {
            get
            {
                return currentScene;
            }

            set
            {
                currentScene = value;
            }
        }


        public static int ShipID
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

        public static int ShipRaceID
        {
            get
            {
                return shipRaceID;
            }

            set
            {
                shipRaceID = value;
            }
        }
        

        public static int RaceID
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
        
        public static int MaxHealth
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

        public static int CurrentHealth
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

        public static int UnUsedAttributePoints
        {
            get
            {
                return unUsedAttributePoints;
            }

            set
            {
                unUsedAttributePoints = value;
            }
        }

        public static int Strength
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

        public static int Intelligence
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

        public static int Dexterity
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

        public static int Wisdom
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

        public static int Health
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

        public static int EagleEyes
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

        public static int Speed
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

        public static int Endurance
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

        public static int NervesOfSteel
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

        public static int Charisma
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

        public static float StrengthADJValue
        {
            get
            {
                return strengthADJValue;
            }

            set
            {
                strengthADJValue = value;
            }
        }

        public static float IntelligenceADJValue
        {
            get
            {
                return intelligenceADJValue;
            }

            set
            {
                intelligenceADJValue = value;
            }
        }

        public static float DexterityADJValue
        {
            get
            {
                return dexterityADJValue;
            }

            set
            {
                dexterityADJValue = value;
            }
        }

        public static float WisdomADJValue
        {
            get
            {
                return wisdomADJValue;
            }

            set
            {
                wisdomADJValue = value;
            }
        }

        public static float HealthADJValue
        {
            get
            {
                return healthADJValue;
            }

            set
            {
                healthADJValue = value;
            }
        }

        public static float EagleADJValue
        {
            get
            {
                return eagleADJValue;
            }

            set
            {
                eagleADJValue = value;
            }
        }

        public static float SpeedADJValue
        {
            get
            {
                return speedADJValue;
            }

            set
            {
                speedADJValue = value;
            }
        }

        public static float EnduranceADJValue
        {
            get
            {
                return enduranceADJValue;
            }

            set
            {
                enduranceADJValue = value;
            }
        }

        public static float NervesADJValue
        {
            get
            {
                return nervesADJValue;
            }

            set
            {
                nervesADJValue = value;
            }
        }

        public static float CharismaADJValue
        {
            get
            {
                return charismaADJValue;
            }

            set
            {
                charismaADJValue = value;
            }
        }

        public static int MinDamage
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

        public static int MaxDamage
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

        public static float DamageBonus
        {
            get
            {
                return damageBonus;
            }

            set
            {
                damageBonus = value;
            }
        }

        public static float DamageReduction
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

        public static float Resources
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

        public static float ToHit
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

        public static float Evasion
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

        public static float CrititalHitChance
        {
            get
            {
                return crititalHitChance;
            }

            set
            {
                crititalHitChance = value;
            }
        }

        public static float CriticalDamage
        {
            get
            {
                return criticalDamage;
            }

            set
            {
                criticalDamage = value;
            }
        }

        public static float CriticalHitResistance
        {
            get
            {
                return criticalHitResistance;
            }

            set
            {
                criticalHitResistance = value;
            }
        }

        public static float CriticalDamageReduction
        {
            get
            {
                return criticalDamageReduction;
            }

            set
            {
                criticalDamageReduction = value;
            }
        }

        public static float ShipSpeedADJ
        {
            get
            {
                return shipSpeedADJ;
            }

            set
            {
                shipSpeedADJ = value;
            }
        }

        public static float Hull
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

        public static float Volume
        {
            get
            {
                return volume;
            }

            set
            {
                volume = value;
            }
        }

        public static float WeaponCoolDown
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

        public static float ExtraShot
        {
            get
            {
                return extraShot;
            }

            set
            {
                extraShot = value;
            }
        }

        public static float Stun
        {
            get
            {
                return stun;
            }

            set
            {
                stun = value;
            }
        }

        public static float StunDuration
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

        public static float StunResistance
        {
            get
            {
                return stunResistance;
            }

            set
            {
                stunResistance = value;
            }
        }

        public static float TractorBeam
        {
            get
            {
                return tractorBeam;
            }

            set
            {
                tractorBeam = value;
            }
        }

        public static float TractorBeamResistance
        {
            get
            {
                return tractorBeamResistance;
            }

            set
            {
                tractorBeamResistance = value;
            }
        }

        public static float MajorBreakThrough
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

        public static float InventionBonus
        {
            get
            {
                return inventionBonus;
            }

            set
            {
                inventionBonus = value;
            }
        }

        public static float Cloak
        {
            get
            {
                return cloak;
            }

            set
            {
                cloak = value;
            }
        }

        public static float CloakAll
        {
            get
            {
                return cloakAll;
            }

            set
            {
                cloakAll = value;
            }
        }

        public static float InstantKill
        {
            get
            {
                return instantKill;
            }

            set
            {
                instantKill = value;
            }
        }

        public static float EnergyConversion
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

        public static float XPBonus
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

        public static float Buying
        {
            get
            {
                return buying;
            }

            set
            {
                buying = value;
            }
        }

        public static float Selling
        {
            get
            {
                return selling;
            }

            set
            {
                selling = value;
            }
        }

        public static float Happiness
        {
            get
            {
                return happiness;
            }

            set
            {
                happiness = value;
            }
        }

        
        public static float ShipMoveForce
        {
            get
            {
                return shipMoveForce;
            }

            set
            {
                shipMoveForce = value;
            }
        }

        public static float ShipTurnForce
        {
            get
            {
                return shipTurnForce;
            }

            set
            {
                shipTurnForce = value;
            }
        }

        public static float ShipTurnRL
        {
            get
            {
                return shipTurnRL;
            }

            set
            {
                shipTurnRL = value;
            }
        }

        public static float ShipTurnUD
        {
            get
            {
                return shipTurnUD;
            }

            set
            {
                shipTurnUD = value;
            }
        }

        public static int ShipWeight
        {
            get
            {
                return shipWeight;
            }

            set
            {
                shipWeight = value;
            }
        }

        public static int ShipHull
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

        public static float ShipWeaponViewWidth
        {
            get
            {
                return shipWeaponViewWidth;
            }

            set
            {
                shipWeaponViewWidth = value;
            }
        }

        public static float ShipWeaponViewHeight
        {
            get
            {
                return shipWeaponViewHeight;
            }

            set
            {
                shipWeaponViewHeight = value;
            }
        }

        public static int ShipMinDamage
        {
            get
            {
                return shipMinDamage;
            }

            set
            {
                shipMinDamage = value;
            }
        }

        public static int ShipMaxDamage
        {
            get
            {
                return shipMaxDamage;
            }

            set
            {
                shipMaxDamage = value;
            }
        }

        public static float ShipEvasion
        {
            get
            {
                return shipEvasion;
            }

            set
            {
                shipEvasion = value;
            }
        }

        public static int ShipVolume
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

        public static float ShipWeaponCoolDown
        {
            get
            {
                return shipWeaponCoolDown;
            }

            set
            {
                shipWeaponCoolDown = value;
            }
        }

        public static int AlignmentHuman
        {
            get
            {
                return alignmentHuman;
            }

            set
            {
                alignmentHuman = value;
            }
        }

        public static int AlignmentFeline
        {
            get
            {
                return alignmentFeline;
            }

            set
            {
                alignmentFeline = value;
            }
        }

        public static int AlignmentBird
        {
            get
            {
                return alignmentBird;
            }

            set
            {
                alignmentBird = value;
            }
        }

        public static int AlignmentMystic
        {
            get
            {
                return alignmentMystic;
            }

            set
            {
                alignmentMystic = value;
            }
        }

        public static int AlignmentCyborgs
        {
            get
            {
                return alignmentCyborgs;
            }

            set
            {
                alignmentCyborgs = value;
            }
        }

        public static int AlignmentInsect
        {
            get
            {
                return alignmentInsect;
            }

            set
            {
                alignmentInsect = value;
            }
        }

        public static int AlignmentBrains
        {
            get
            {
                return alignmentBrains;
            }

            set
            {
                alignmentBrains = value;
            }
        }

        public static int AlignmentMetal
        {
            get
            {
                return alignmentMetal;
            }

            set
            {
                alignmentMetal = value;
            }
        }

        public static int AlignmentLizard
        {
            get
            {
                return alignmentLizard;
            }

            set
            {
                alignmentLizard = value;
            }
        }

        public static int AlignmentTree
        {
            get
            {
                return alignmentTree;
            }

            set
            {
                alignmentTree = value;
            }
        }

        public static int AlignmentGas
        {
            get
            {
                return alignmentGas;
            }

            set
            {
                alignmentGas = value;
            }
        }

        #endregion
    }
}
