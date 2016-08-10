using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes.NPC_Hobby
{

    class NPCMiner:BaseNPCHobby
    {
        BaseNPCHobby baseNPCHobby;

        public NPCMiner()
        {
            NpcHobbyName = "Miner";
            NpcHobbyId = 1;
            NpcHobbyLevel = 1;

            IsMiner = true;
            IsNecromancy = false;
            IsMarksman = false;
            IsSniper = false;
            IsMonk = false;
            IsWeaponsMaker = false;
            IsDefensiveSpecialist = false;
            IsIntellectual = false;
            IsCowboy = false;
            IsThrillSeeker = false;
            IsAsteroidBeltRacer = false;
            IsExterminator = false;
            IsMartialArtsExpert = false;
            IsOpportunist = false;
            IsPhotographer = false;
            IsKnockoutArtist = false;
            IsScientist = false;
            IsInventor = false;
            IsTaserSpecialist = false;
            IsAssassin = false;

            MinerAdjGas = .5f;
            MinerAdjCarbon = .5f;
            MinerAdjWater = .5f;
            MinerAdjOrganic = .5f;
            MinerAdjRock = .5f;
            MinerAdjWood = .4f;
            MinerAdjIron = .4f;
            MinerAdjSilver = .25f;
            MinerAdjGold = .25f;
            MinerAdjRuby = .2f;
            MinerAdjEmerald = .2f;
            MinerAdjTitanium = .2f;
            MinerAdjMithril = .2f;
            MinerAdjLiquidHydrogen = .15f;
            MinerAdjLiquidOxygen = .15f;
            MinerAdjLiquidNitrogen = .15f;
            MinerAdjPlatinum = .12f;
            MinerAdjDiamond = .11f;
            MinerAdjRadioactive = .1f;
            MinerAdjBlackMatter = .05f;
            MinerAdjRedMatter = .04f;
            MinerAdjGreyMatter = .03f;
            MinerAdjWhiteMatter = .02f;
            MinerAdjMana = .01f;
            EnergyConversion = 0f;
            ToHit = 0f;
            CritHitChance = 0f;
            XpBonus = 0f;
            WeaponCoolDown = 0f;
            HullIncrease = 0f;
            ShipVolumeIncrease = 0f;
            TractorBeamIncreaseChance = 0f;
            ShipSpeedIncrease = 0f;
            EvasionIncrease = 0f;
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
