using Assets.Scripts.NPC_Classes.NPC_Hobby;

namespace Assets.Scripts.NPC_Classes
{
    class BaseNPCHobby
    {
        /*
        This holds the adjustment that each hobby 
        has on a stat at a level 1 hobby level

        Need to determine the formula for when the
        hobby value is greater than 1

        */

        private string npcHobbyName;
        private int npcHobbyId;
        private int npcHobbyLevel;

        private bool isMiner;
        private bool isNecromancy;
        private bool isMarksman;
        private bool isSniper;
        private bool isMonk;
        private bool isWeaponsMaker;
        private bool isDefensiveSpecialist;
        private bool isIntellectual;
        private bool isCowboy;
        private bool isThrillSeeker;
        private bool isAsteroidBeltRacer;
        private bool isExterminator;
        private bool isMartialArtsExpert;
        private bool isOpportunist;
        private bool isPhotographer;
        private bool isKnockoutArtist;
        private bool isScientist;
        private bool isInventor;
        private bool isTaserSpecialist;
        private bool isAssassin;

        private float minerAdjGas;
        private float minerAdjCarbon;
        private float minerAdjWater;
        private float minerAdjOrganic;
        private float minerAdjRock;
        private float minerAdjWood;
        private float minerAdjIron;
        private float minerAdjSilver;
        private float minerAdjGold;
        private float minerAdjRuby;
        private float minerAdjEmerald;
        private float minerAdjTitanium;
        private float minerAdjMithril;
        private float minerAdjLiquidHydrogen;
        private float minerAdjLiquidOxygen;
        private float minerAdjLiquidNitrogen;
        private float minerAdjPlatinum;
        private float minerAdjDiamond;
        private float minerAdjRadioactive;
        private float minerAdjBlackMatter;
        private float minerAdjRedMatter;
        private float minerAdjGreyMatter;
        private float minerAdjWhiteMatter;
        private float minerAdjMana;
        private float energyConversion;
        private float toHit;
        private float critHitChance;
        private float xpBonus;
        private float weaponCoolDown;
        private float hullIncrease;
        private float shipVolumeIncrease;
        private float tractorBeamIncreaseChance;
        private float shipSpeedIncrease;
        private float evasionIncrease;
        private float damageIncrease;
        private float criticalDamageIncrease;
        private float extraShotChance;
        private float visionFieldIncrease;
        private float stunChanceIncrease;
        private float stunDurationIncrease;
        private float majorBreakThroughChance;
        private float inventionBonusChance;
        private float cloakChanceIncrease;
        private float cloakAllChanceIncrease;
        private float instantKillIncrease;

        public BaseNPCHobby()
        {

        }

        public BaseNPCHobby(string npcHobbyName, int npcHobbyId, int npcHobbyLevel, bool isMiner, bool isNecromancy, bool isMarksman, bool isSniper, bool isMonk, bool isWeaponsMaker, bool isDefensiveSpecialist, bool isIntellectual, bool isCowboy, bool isThrillSeeker, bool isAsteroidBeltRacer, bool isExterminator, bool isMartialArtsExpert, bool isOpportunist, bool isPhotographer, bool isKnockoutArtist, bool isScientist, bool isInventor, bool isTaserSpecialist, bool isAssassin, float minerAdjGas, float minerAdjCarbon, float minerAdjWater, float minerAdjOrganic, float minerAdjRock, float minerAdjWood, float minerAdjIron, float minerAdjSilver, float minerAdjGold, float minerAdjRuby, float minerAdjEmerald, float minerAdjTitanium, float minerAdjMithril, float minerAdjLiquidHydrogen, float minerAdjLiquidOxygen, float minerAdjLiquidNitrogen, float minerAdjPlatinum, float minerAdjDiamond, float minerAdjRadioactive, float minerAdjBlackMatter, float minerAdjRedMatter, float minerAdjGreyMatter, float minerAdjWhiteMatter, float minerAdjMana, float energyConversion, float toHit, float critHitChance, float xpBonus, float weaponCoolDown, float hullIncrease, float shipVolumeIncrease, float tractorBeamIncreaseChance, float shipSpeedIncrease, float evasionIncrease, float damageIncrease, float criticalDamageIncrease, float extraShotChance, float visionFieldIncrease, float stunChanceIncrease, float stunDurationIncrease, float majorBreakThroughChance, float inventionBonusChance, float cloakChanceIncrease, float cloakAllChanceIncrease, float instantKillIncrease)
        {
            this.npcHobbyName = npcHobbyName;
            this.npcHobbyId = npcHobbyId;
            this.npcHobbyLevel = npcHobbyLevel;
            this.isMiner = isMiner;
            this.isNecromancy = isNecromancy;
            this.isMarksman = isMarksman;
            this.isSniper = isSniper;
            this.isMonk = isMonk;
            this.isWeaponsMaker = isWeaponsMaker;
            this.isDefensiveSpecialist = isDefensiveSpecialist;
            this.isIntellectual = isIntellectual;
            this.isCowboy = isCowboy;
            this.isThrillSeeker = isThrillSeeker;
            this.isAsteroidBeltRacer = isAsteroidBeltRacer;
            this.isExterminator = isExterminator;
            this.isMartialArtsExpert = isMartialArtsExpert;
            this.isOpportunist = isOpportunist;
            this.isPhotographer = isPhotographer;
            this.isKnockoutArtist = isKnockoutArtist;
            this.isScientist = isScientist;
            this.isInventor = isInventor;
            this.isTaserSpecialist = isTaserSpecialist;
            this.isAssassin = isAssassin;
            this.minerAdjGas = minerAdjGas;
            this.minerAdjCarbon = minerAdjCarbon;
            this.minerAdjWater = minerAdjWater;
            this.minerAdjOrganic = minerAdjOrganic;
            this.minerAdjRock = minerAdjRock;
            this.minerAdjWood = minerAdjWood;
            this.minerAdjIron = minerAdjIron;
            this.minerAdjSilver = minerAdjSilver;
            this.minerAdjGold = minerAdjGold;
            this.minerAdjRuby = minerAdjRuby;
            this.minerAdjEmerald = minerAdjEmerald;
            this.minerAdjTitanium = minerAdjTitanium;
            this.minerAdjMithril = minerAdjMithril;
            this.minerAdjLiquidHydrogen = minerAdjLiquidHydrogen;
            this.minerAdjLiquidOxygen = minerAdjLiquidOxygen;
            this.minerAdjLiquidNitrogen = minerAdjLiquidNitrogen;
            this.minerAdjPlatinum = minerAdjPlatinum;
            this.minerAdjDiamond = minerAdjDiamond;
            this.minerAdjRadioactive = minerAdjRadioactive;
            this.minerAdjBlackMatter = minerAdjBlackMatter;
            this.minerAdjRedMatter = minerAdjRedMatter;
            this.minerAdjGreyMatter = minerAdjGreyMatter;
            this.minerAdjWhiteMatter = minerAdjWhiteMatter;
            this.minerAdjMana = minerAdjMana;
            this.energyConversion = energyConversion;
            this.toHit = toHit;
            this.critHitChance = critHitChance;
            this.xpBonus = xpBonus;
            this.weaponCoolDown = weaponCoolDown;
            this.hullIncrease = hullIncrease;
            this.shipVolumeIncrease = shipVolumeIncrease;
            this.tractorBeamIncreaseChance = tractorBeamIncreaseChance;
            this.shipSpeedIncrease = shipSpeedIncrease;
            this.evasionIncrease = evasionIncrease;
            this.damageIncrease = damageIncrease;
            this.criticalDamageIncrease = criticalDamageIncrease;
            this.extraShotChance = extraShotChance;
            this.visionFieldIncrease = visionFieldIncrease;
            this.stunChanceIncrease = stunChanceIncrease;
            this.stunDurationIncrease = stunDurationIncrease;
            this.majorBreakThroughChance = majorBreakThroughChance;
            this.inventionBonusChance = inventionBonusChance;
            this.cloakChanceIncrease = cloakChanceIncrease;
            this.cloakAllChanceIncrease = cloakAllChanceIncrease;
            this.instantKillIncrease = instantKillIncrease;
        }


        #region GETs and SETs
        public string NpcHobbyName
        {
            get
            {
                return npcHobbyName;
            }

            set
            {
                npcHobbyName = value;
            }
        }

        public int NpcHobbyId
        {
            get
            {
                return npcHobbyId;
            }

            set
            {
                npcHobbyId = value;
            }
        }

        public int NpcHobbyLevel
        {
            get
            {
                return npcHobbyLevel;
            }

            set
            {
                npcHobbyLevel = value;
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

        public float HullIncrease
        {
            get
            {
                return hullIncrease;
            }

            set
            {
                hullIncrease = value;
            }
        }

        public float ShipVolumeIncrease
        {
            get
            {
                return shipVolumeIncrease;
            }

            set
            {
                shipVolumeIncrease = value;
            }
        }

        public float TractorBeamIncreaseChance
        {
            get
            {
                return tractorBeamIncreaseChance;
            }

            set
            {
                tractorBeamIncreaseChance = value;
            }
        }

        public float ShipSpeedIncrease
        {
            get
            {
                return shipSpeedIncrease;
            }

            set
            {
                shipSpeedIncrease = value;
            }
        }

        public float EvasionIncrease
        {
            get
            {
                return evasionIncrease;
            }

            set
            {
                evasionIncrease = value;
            }
        }

        public float DamageIncrease
        {
            get
            {
                return damageIncrease;
            }

            set
            {
                damageIncrease = value;
            }
        }

        public float CriticalDamageIncrease
        {
            get
            {
                return criticalDamageIncrease;
            }

            set
            {
                criticalDamageIncrease = value;
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

        public float VisionFieldIncrease
        {
            get
            {
                return visionFieldIncrease;
            }

            set
            {
                visionFieldIncrease = value;
            }
        }

        public float StunChanceIncrease
        {
            get
            {
                return stunChanceIncrease;
            }

            set
            {
                stunChanceIncrease = value;
            }
        }

        public float StunDurationIncrease
        {
            get
            {
                return stunDurationIncrease;
            }

            set
            {
                stunDurationIncrease = value;
            }
        }

        public float MajorBreakThroughChance
        {
            get
            {
                return majorBreakThroughChance;
            }

            set
            {
                majorBreakThroughChance = value;
            }
        }

        public float InventionBonusChance
        {
            get
            {
                return inventionBonusChance;
            }

            set
            {
                inventionBonusChance = value;
            }
        }

        public float CloakChanceIncrease
        {
            get
            {
                return cloakChanceIncrease;
            }

            set
            {
                cloakChanceIncrease = value;
            }
        }

        public float CloakAllChanceIncrease
        {
            get
            {
                return cloakAllChanceIncrease;
            }

            set
            {
                cloakAllChanceIncrease = value;
            }
        }

        public float InstantKillIncrease
        {
            get
            {
                return instantKillIncrease;
            }

            set
            {
                instantKillIncrease = value;
            }
        }

        public bool IsMiner
        {
            get
            {
                return isMiner;
            }

            set
            {
                isMiner = value;
            }
        }

        public bool IsNecromancy
        {
            get
            {
                return isNecromancy;
            }

            set
            {
                isNecromancy = value;
            }
        }

        public bool IsMarksman
        {
            get
            {
                return isMarksman;
            }

            set
            {
                isMarksman = value;
            }
        }

        public bool IsSniper
        {
            get
            {
                return isSniper;
            }

            set
            {
                isSniper = value;
            }
        }

        public bool IsMonk
        {
            get
            {
                return isMonk;
            }

            set
            {
                isMonk = value;
            }
        }

        public bool IsWeaponsMaker
        {
            get
            {
                return isWeaponsMaker;
            }

            set
            {
                isWeaponsMaker = value;
            }
        }

        public bool IsDefensiveSpecialist
        {
            get
            {
                return isDefensiveSpecialist;
            }

            set
            {
                isDefensiveSpecialist = value;
            }
        }

        public bool IsIntellectual
        {
            get
            {
                return isIntellectual;
            }

            set
            {
                isIntellectual = value;
            }
        }

        public bool IsCowboy
        {
            get
            {
                return isCowboy;
            }

            set
            {
                isCowboy = value;
            }
        }

        public bool IsThrillSeeker
        {
            get
            {
                return isThrillSeeker;
            }

            set
            {
                isThrillSeeker = value;
            }
        }

        public bool IsAsteroidBeltRacer
        {
            get
            {
                return isAsteroidBeltRacer;
            }

            set
            {
                isAsteroidBeltRacer = value;
            }
        }

        public bool IsExterminator
        {
            get
            {
                return isExterminator;
            }

            set
            {
                isExterminator = value;
            }
        }

        public bool IsMartialArtsExpert
        {
            get
            {
                return isMartialArtsExpert;
            }

            set
            {
                isMartialArtsExpert = value;
            }
        }

        public bool IsOpportunist
        {
            get
            {
                return isOpportunist;
            }

            set
            {
                isOpportunist = value;
            }
        }

        public bool IsPhotographer
        {
            get
            {
                return isPhotographer;
            }

            set
            {
                isPhotographer = value;
            }
        }

        public bool IsKnockoutArtist
        {
            get
            {
                return isKnockoutArtist;
            }

            set
            {
                isKnockoutArtist = value;
            }
        }

        public bool IsScientist
        {
            get
            {
                return isScientist;
            }

            set
            {
                isScientist = value;
            }
        }

        public bool IsInventor
        {
            get
            {
                return isInventor;
            }

            set
            {
                isInventor = value;
            }
        }

        public bool IsTaserSpecialist
        {
            get
            {
                return isTaserSpecialist;
            }

            set
            {
                isTaserSpecialist = value;
            }
        }

        public bool IsAssassin
        {
            get
            {
                return isAssassin;
            }

            set
            {
                isAssassin = value;
            }
        }

        public float MinerAdjGas
        {
            get
            {
                return minerAdjGas;
            }

            set
            {
                minerAdjGas = value;
            }
        }

        public float MinerAdjCarbon
        {
            get
            {
                return minerAdjCarbon;
            }

            set
            {
                minerAdjCarbon = value;
            }
        }

        public float MinerAdjWater
        {
            get
            {
                return minerAdjWater;
            }

            set
            {
                minerAdjWater = value;
            }
        }

        public float MinerAdjOrganic
        {
            get
            {
                return minerAdjOrganic;
            }

            set
            {
                minerAdjOrganic = value;
            }
        }

        public float MinerAdjRock
        {
            get
            {
                return minerAdjRock;
            }

            set
            {
                minerAdjRock = value;
            }
        }

        public float MinerAdjWood
        {
            get
            {
                return minerAdjWood;
            }

            set
            {
                minerAdjWood = value;
            }
        }

        public float MinerAdjIron
        {
            get
            {
                return minerAdjIron;
            }

            set
            {
                minerAdjIron = value;
            }
        }

        public float MinerAdjSilver
        {
            get
            {
                return minerAdjSilver;
            }

            set
            {
                minerAdjSilver = value;
            }
        }

        public float MinerAdjGold
        {
            get
            {
                return minerAdjGold;
            }

            set
            {
                minerAdjGold = value;
            }
        }

        public float MinerAdjRuby
        {
            get
            {
                return minerAdjRuby;
            }

            set
            {
                minerAdjRuby = value;
            }
        }

        public float MinerAdjEmerald
        {
            get
            {
                return minerAdjEmerald;
            }

            set
            {
                minerAdjEmerald = value;
            }
        }

        public float MinerAdjTitanium
        {
            get
            {
                return minerAdjTitanium;
            }

            set
            {
                minerAdjTitanium = value;
            }
        }

        public float MinerAdjMithril
        {
            get
            {
                return minerAdjMithril;
            }

            set
            {
                minerAdjMithril = value;
            }
        }

        public float MinerAdjLiquidHydrogen
        {
            get
            {
                return minerAdjLiquidHydrogen;
            }

            set
            {
                minerAdjLiquidHydrogen = value;
            }
        }

        public float MinerAdjLiquidOxygen
        {
            get
            {
                return minerAdjLiquidOxygen;
            }

            set
            {
                minerAdjLiquidOxygen = value;
            }
        }

        public float MinerAdjLiquidNitrogen
        {
            get
            {
                return minerAdjLiquidNitrogen;
            }

            set
            {
                minerAdjLiquidNitrogen = value;
            }
        }

        public float MinerAdjPlatinum
        {
            get
            {
                return minerAdjPlatinum;
            }

            set
            {
                minerAdjPlatinum = value;
            }
        }

        public float MinerAdjDiamond
        {
            get
            {
                return minerAdjDiamond;
            }

            set
            {
                minerAdjDiamond = value;
            }
        }

        public float MinerAdjRadioactive
        {
            get
            {
                return minerAdjRadioactive;
            }

            set
            {
                minerAdjRadioactive = value;
            }
        }

        public float MinerAdjBlackMatter
        {
            get
            {
                return minerAdjBlackMatter;
            }

            set
            {
                minerAdjBlackMatter = value;
            }
        }

        public float MinerAdjRedMatter
        {
            get
            {
                return minerAdjRedMatter;
            }

            set
            {
                minerAdjRedMatter = value;
            }
        }

        public float MinerAdjGreyMatter
        {
            get
            {
                return minerAdjGreyMatter;
            }

            set
            {
                minerAdjGreyMatter = value;
            }
        }

        public float MinerAdjWhiteMatter
        {
            get
            {
                return minerAdjWhiteMatter;
            }

            set
            {
                minerAdjWhiteMatter = value;
            }
        }

        public float MinerAdjMana
        {
            get
            {
                return minerAdjMana;
            }

            set
            {
                minerAdjMana = value;
            }
        }
        #endregion
    }
}
