using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes.NPC_Hobby
{

    class NPCAsteroidBeltRacer:BaseNPCHobby
    {
        BaseNPCHobby baseNPCHobby;

        public NPCAsteroidBeltRacer()
        {
            NpcHobbyName = "Asteroid Belt Racer";
            NpcHobbyId = 11;
            NpcHobbyLevel = 1;

            IsMiner = false;
            IsNecromancy = false;
            IsMarksman = false;
            IsSniper = false;
            IsMonk = false;
            IsWeaponsMaker = false;
            IsDefensiveSpecialist = false;
            IsIntellectual = false;
            IsCowboy = false;
            IsThrillSeeker = false;
            IsAsteroidBeltRacer = true;
            IsExterminator = false;
            IsMartialArtsExpert = false;
            IsOpportunist = false;
            IsPhotographer = false;
            IsKnockoutArtist = false;
            IsScientist = false;
            IsInventor = false;
            IsTaserSpecialist = false;
            IsAssassin = false;

            MinerAdjGas = 0f;
            MinerAdjCarbon = 0f;
            MinerAdjWater = 0f;
            MinerAdjOrganic = 0f;
            MinerAdjRock = 0f;
            MinerAdjWood = 0f;
            MinerAdjIron = 0f;
            MinerAdjSilver = 0f;
            MinerAdjGold = 0f;
            MinerAdjRuby = 0f;
            MinerAdjEmerald = 0f;
            MinerAdjTitanium = 0f;
            MinerAdjMithril = 0f;
            MinerAdjLiquidHydrogen = 0f;
            MinerAdjLiquidOxygen = 0f;
            MinerAdjLiquidNitrogen = 0f;
            MinerAdjPlatinum = 0f;
            MinerAdjDiamond = 0f;
            MinerAdjRadioactive = 0f;
            MinerAdjBlackMatter = 0f;
            MinerAdjRedMatter = 0f;
            MinerAdjGreyMatter = 0f;
            MinerAdjWhiteMatter = 0f;
            MinerAdjMana = 0f;
            EnergyConversion = 0f;
            ToHit = 0f;
            CritHitChance = 0f;
            XpBonus = 0f;
            WeaponCoolDown = 0f;
            HullIncrease = 0f;
            ShipVolumeIncrease = 0f;
            TractorBeamIncreaseChance = 0f;
            ShipSpeedIncrease = 0f;
            EvasionIncrease = 0.1f;
            DamageIncrease = 0f;
            CriticalDamageIncrease = 0f;
            ExtraShotChance = 0f;
            VisionFieldIncrease = 0f;
            StunChanceIncrease = 0f;
            MajorBreakThroughChance = 0f;
            InventionBonusChance = 0f;
            StunDurationIncrease = 0f;
            CloakChanceIncrease = 0f;
            CloakAllChanceIncrease = 0f;
            InstantKillIncrease = 0f;
        }
    }
}
