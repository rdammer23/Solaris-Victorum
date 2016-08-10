using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes
{
    class BaseNPCType
    {
        /*
        This will be the different types of each NPC ie
        Scout
        Miner
        Patrol
        Attack
        but make them real names that are different for each race
        The type will modify stats directly, not attributes
        Make 20 types?
        Make a new class for each Type
        within that class determine the name based on the race
        
        */

        private string npcTypeName; //This is determined once I know the TypeID and the race
        private int npcTypeID;

        private float npcResourceIncrease;
        private float npcEnergyConversion;
        private float npcToHit;
        private float npcCritHitChance;
        private float npcXpBonus;
        private float npcWeaponCoolDown;
        private float npcHullIncrease;
        private float npcShipVolumeIncrease;
        private float npcTractorBeamIncreaseChance;
        private float npcShipSpeedIncrease;
        private float npcEvasionIncrease;
        private float npcDamageIncrease;
        private float npcCriticalDamageIncrease;
        private float npcExtraShotChance;
        private float npcVisionFieldIncrease;
        private float npcStunChanceIncrease;
        private float npcStunDurationIncrease;
        private float npcMajorBreakThroughChance;
        private float npcInventionBonusChance;
        private float npcCloakChanceIncrease;
        private float npcCloakAllChanceIncrease;
        private float npcInstantKillIncrease;

        //Resistance
        private float npcStunResistanceChance;
        private float npcTractorBeamResistanceChance;
        private float npcCriticalHitResistance;
        private float npcCriticalDamageResistance;

        public BaseNPCType()
        {

        }


        public BaseNPCType(string npcTypeName, int npcTypeID, float npcResourceIncrease, float npcEnergyConversion, float npcToHit, float npcCritHitChance, float npcXpBonus, float npcWeaponCoolDown, float npcHullIncrease, float npcShipVolumeIncrease, float npcTractorBeamIncreaseChance, float npcShipSpeedIncrease, float npcEvasionIncrease, float npcDamageIncrease, float npcCriticalDamageIncrease, float npcExtraShotChance, float npcVisionFieldIncrease, float npcStunChanceIncrease, float npcStunDurationIncrease, float npcMajorBreakThroughChance, float npcInventionBonusChance, float npcCloakChanceIncrease, float npcCloakAllChanceIncrease, float npcInstantKillIncrease, float npcStunResistanceChance, float npcTractorBeamResistanceChance, float npcCriticalHitResistance, float npcCriticalDamageResistance)
        {
            this.npcTypeName = npcTypeName;
            this.npcTypeID = npcTypeID;
            this.npcResourceIncrease = npcResourceIncrease;
            this.npcEnergyConversion = npcEnergyConversion;
            this.npcToHit = npcToHit;
            this.npcCritHitChance = npcCritHitChance;
            this.npcXpBonus = npcXpBonus;
            this.npcWeaponCoolDown = npcWeaponCoolDown;
            this.npcHullIncrease = npcHullIncrease;
            this.npcShipVolumeIncrease = npcShipVolumeIncrease;
            this.npcTractorBeamIncreaseChance = npcTractorBeamIncreaseChance;
            this.npcShipSpeedIncrease = npcShipSpeedIncrease;
            this.npcEvasionIncrease = npcEvasionIncrease;
            this.npcDamageIncrease = npcDamageIncrease;
            this.npcCriticalDamageIncrease = npcCriticalDamageIncrease;
            this.npcExtraShotChance = npcExtraShotChance;
            this.npcVisionFieldIncrease = npcVisionFieldIncrease;
            this.npcStunChanceIncrease = npcStunChanceIncrease;
            this.npcStunDurationIncrease = npcStunDurationIncrease;
            this.npcMajorBreakThroughChance = npcMajorBreakThroughChance;
            this.npcInventionBonusChance = npcInventionBonusChance;
            this.npcCloakChanceIncrease = npcCloakChanceIncrease;
            this.npcCloakAllChanceIncrease = npcCloakAllChanceIncrease;
            this.npcInstantKillIncrease = npcInstantKillIncrease;
            this.npcStunResistanceChance = npcStunResistanceChance;
            this.npcTractorBeamResistanceChance = npcTractorBeamResistanceChance;
            this.npcCriticalHitResistance = npcCriticalHitResistance;
            this.npcCriticalDamageResistance = npcCriticalDamageResistance;
        }


        #region GETs and SETs
        public string NpcTypeName
        {
            get
            {
                return npcTypeName;
            }

            set
            {
                npcTypeName = value;
            }
        }

        public int NpcTypeID
        {
            get
            {
                return npcTypeID;
            }

            set
            {
                npcTypeID = value;
            }
        }

        public float NpcResourceIncrease
        {
            get
            {
                return npcResourceIncrease;
            }

            set
            {
                npcResourceIncrease = value;
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

        public float NpcXpBonus
        {
            get
            {
                return npcXpBonus;
            }

            set
            {
                npcXpBonus = value;
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

        public float NpcShipVolumeIncrease
        {
            get
            {
                return npcShipVolumeIncrease;
            }

            set
            {
                npcShipVolumeIncrease = value;
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

        public float NpcVisionFieldIncrease
        {
            get
            {
                return npcVisionFieldIncrease;
            }

            set
            {
                npcVisionFieldIncrease = value;
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

        public float NpcMajorBreakThroughChance
        {
            get
            {
                return npcMajorBreakThroughChance;
            }

            set
            {
                npcMajorBreakThroughChance = value;
            }
        }

        public float NpcInventionBonusChance
        {
            get
            {
                return npcInventionBonusChance;
            }

            set
            {
                npcInventionBonusChance = value;
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

        public float NpcStunResistanceChance
        {
            get
            {
                return npcStunResistanceChance;
            }

            set
            {
                npcStunResistanceChance = value;
            }
        }

        public float NpcTractorBeamResistanceChance
        {
            get
            {
                return npcTractorBeamResistanceChance;
            }

            set
            {
                npcTractorBeamResistanceChance = value;
            }
        }

        public float NpcCriticalHitResistance
        {
            get
            {
                return npcCriticalHitResistance;
            }

            set
            {
                npcCriticalHitResistance = value;
            }
        }

        public float NpcCriticalDamageResistance
        {
            get
            {
                return npcCriticalDamageResistance;
            }

            set
            {
                npcCriticalDamageResistance = value;
            }
        }
        #endregion
    }
}
