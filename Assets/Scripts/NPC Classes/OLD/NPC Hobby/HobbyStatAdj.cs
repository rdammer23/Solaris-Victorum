using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes.NPC_Hobby
{
    class HobbyStatAdj:MonoBehaviour
    {
        NPCMiner _hobby1;
        NPCNecromancy _hobby2;
        NPCMarksman _hobby3;
        NPCSniper _hobby4;
        NPCMonk _hobby5;
        NPCWeaponsMaker _hobby6;
        NPCDefensiveSpecialist _hobby7;
        NPCIntellectual _hobby8;
        NPCCowboy _hobby9;
        NPCThrillSeeker _hobby10;
        NPCAsteroidBeltRacer _hobby11;
        NPCExterminator _hobby12;
        NPCMartialArtsExpert _hobby13;
        NPCOpportunist _hobby14;
        NPCPhotographer _hobby15;
        NPCKnockOutArtist _hobby16;
        NPCScientist _hobby17;
        NPCInvention _hobby18;
        NPCTaserSpecialist _hobby19;
        NPCAssassin _hobby20;

        static List<BaseNPCHobby> npcHobby;

        private void Start()
        {
            npcHobby = new List<BaseNPCHobby>();
            _hobby1 = new NPCMiner();
            _hobby2 = new NPCNecromancy();
            _hobby3 = new NPCMarksman();
            _hobby4 = new NPCSniper();
            _hobby5 = new NPCMonk();
            _hobby6 = new NPCWeaponsMaker();
            _hobby7 = new NPCDefensiveSpecialist();
            _hobby8 = new NPCIntellectual();
            _hobby9 = new NPCCowboy();
            _hobby10 = new NPCThrillSeeker();
            _hobby11 = new NPCAsteroidBeltRacer();
            _hobby12 = new NPCExterminator();
            _hobby13 = new NPCMartialArtsExpert();
            _hobby14 = new NPCOpportunist();
            _hobby15 = new NPCPhotographer();
            _hobby16 = new NPCKnockOutArtist();
            _hobby17 = new NPCScientist();
            _hobby18 = new NPCInvention();
            _hobby19 = new NPCTaserSpecialist();
            _hobby20 = new NPCAssassin();

            #region List Adding
            npcHobby.Add(new BaseNPCHobby(_hobby1.NpcHobbyName, _hobby1.NpcHobbyId, _hobby1.NpcHobbyLevel,
                _hobby1.IsMiner, _hobby1.IsNecromancy, _hobby1.IsMarksman, _hobby1.IsSniper, _hobby1.IsMonk,
                _hobby1.IsWeaponsMaker, _hobby1.IsDefensiveSpecialist, _hobby1.IsIntellectual, _hobby1.IsCowboy,
                _hobby1.IsThrillSeeker, _hobby1.IsAsteroidBeltRacer, _hobby1.IsExterminator, _hobby1.IsMartialArtsExpert,
                _hobby1.IsOpportunist, _hobby1.IsPhotographer, _hobby1.IsKnockoutArtist, _hobby1.IsScientist,
                _hobby1.IsInventor, _hobby1.IsTaserSpecialist, _hobby1.IsAssassin, _hobby1.MinerAdjGas,
                _hobby1.MinerAdjCarbon, _hobby1.MinerAdjWater, _hobby1.MinerAdjOrganic, _hobby1.MinerAdjRock,
                _hobby1.MinerAdjWood, _hobby1.MinerAdjIron, _hobby1.MinerAdjSilver, _hobby1.MinerAdjGold,
                _hobby1.MinerAdjRuby, _hobby1.MinerAdjEmerald, _hobby1.MinerAdjTitanium, _hobby1.MinerAdjMithril,
                _hobby1.MinerAdjLiquidHydrogen, _hobby1.MinerAdjLiquidOxygen, _hobby1.MinerAdjLiquidNitrogen,
                _hobby1.MinerAdjPlatinum, _hobby1.MinerAdjDiamond, _hobby1.MinerAdjRadioactive,
                _hobby1.MinerAdjBlackMatter, _hobby1.MinerAdjRedMatter, _hobby1.MinerAdjGreyMatter,
                _hobby1.MinerAdjWhiteMatter, _hobby1.MinerAdjMana, _hobby1.EnergyConversion, _hobby1.ToHit,
                _hobby1.CritHitChance, _hobby1.XpBonus, _hobby1.WeaponCoolDown, _hobby1.HullIncrease,
                _hobby1.ShipVolumeIncrease, _hobby1.TractorBeamIncreaseChance, _hobby1.ShipSpeedIncrease,
                _hobby1.EvasionIncrease, _hobby1.DamageIncrease, _hobby1.CriticalDamageIncrease,
                _hobby1.ExtraShotChance, _hobby1.VisionFieldIncrease, _hobby1.StunChanceIncrease,
                _hobby1.StunDurationIncrease, _hobby1.MajorBreakThroughChance, _hobby1.InventionBonusChance,
                _hobby1.CloakChanceIncrease, _hobby1.CloakAllChanceIncrease, _hobby1.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby2.NpcHobbyName, _hobby2.NpcHobbyId, _hobby2.NpcHobbyLevel,
                _hobby2.IsMiner, _hobby2.IsNecromancy, _hobby2.IsMarksman, _hobby2.IsSniper, _hobby2.IsMonk,
                _hobby2.IsWeaponsMaker, _hobby2.IsDefensiveSpecialist, _hobby2.IsIntellectual,
                _hobby2.IsCowboy, _hobby2.IsThrillSeeker, _hobby2.IsAsteroidBeltRacer, _hobby2.IsExterminator,
                _hobby2.IsMartialArtsExpert, _hobby2.IsOpportunist, _hobby2.IsPhotographer,
                _hobby2.IsKnockoutArtist, _hobby2.IsScientist, _hobby2.IsInventor, _hobby2.IsTaserSpecialist,
                _hobby2.IsAssassin, _hobby2.MinerAdjGas, _hobby2.MinerAdjCarbon, _hobby2.MinerAdjWater,
                _hobby2.MinerAdjOrganic, _hobby2.MinerAdjRock, _hobby2.MinerAdjWood, _hobby2.MinerAdjIron,
                _hobby2.MinerAdjSilver, _hobby2.MinerAdjGold, _hobby2.MinerAdjRuby, _hobby2.MinerAdjEmerald,
                _hobby2.MinerAdjTitanium, _hobby2.MinerAdjMithril, _hobby2.MinerAdjLiquidHydrogen,
                _hobby2.MinerAdjLiquidOxygen, _hobby2.MinerAdjLiquidNitrogen, _hobby2.MinerAdjPlatinum,
                _hobby2.MinerAdjDiamond, _hobby2.MinerAdjRadioactive, _hobby2.MinerAdjBlackMatter,
                _hobby2.MinerAdjRedMatter, _hobby2.MinerAdjGreyMatter, _hobby2.MinerAdjWhiteMatter,
                _hobby2.MinerAdjMana, _hobby2.EnergyConversion, _hobby2.ToHit, _hobby2.CritHitChance,
                _hobby2.XpBonus, _hobby2.WeaponCoolDown, _hobby2.HullIncrease, _hobby2.ShipVolumeIncrease,
                _hobby2.TractorBeamIncreaseChance, _hobby2.ShipSpeedIncrease, _hobby2.EvasionIncrease,
                _hobby2.DamageIncrease, _hobby2.CriticalDamageIncrease, _hobby2.ExtraShotChance,
                _hobby2.VisionFieldIncrease, _hobby2.StunChanceIncrease, _hobby2.StunDurationIncrease,
                _hobby2.MajorBreakThroughChance, _hobby2.InventionBonusChance, _hobby2.CloakChanceIncrease,
                _hobby2.CloakAllChanceIncrease, _hobby2.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby3.NpcHobbyName, _hobby3.NpcHobbyId, _hobby3.NpcHobbyLevel, _hobby3.IsMiner, _hobby3.IsNecromancy, _hobby3.IsMarksman, _hobby3.IsSniper, _hobby3.IsMonk, _hobby3.IsWeaponsMaker, _hobby3.IsDefensiveSpecialist, _hobby3.IsIntellectual, _hobby3.IsCowboy, _hobby3.IsThrillSeeker, _hobby3.IsAsteroidBeltRacer, _hobby3.IsExterminator, _hobby3.IsMartialArtsExpert, _hobby3.IsOpportunist, _hobby3.IsPhotographer, _hobby3.IsKnockoutArtist, _hobby3.IsScientist, _hobby3.IsInventor, _hobby3.IsTaserSpecialist, _hobby3.IsAssassin, _hobby3.MinerAdjGas, _hobby3.MinerAdjCarbon, _hobby3.MinerAdjWater, _hobby3.MinerAdjOrganic, _hobby3.MinerAdjRock, _hobby3.MinerAdjWood, _hobby3.MinerAdjIron, _hobby3.MinerAdjSilver, _hobby3.MinerAdjGold, _hobby3.MinerAdjRuby, _hobby3.MinerAdjEmerald, _hobby3.MinerAdjTitanium, _hobby3.MinerAdjMithril, _hobby3.MinerAdjLiquidHydrogen, _hobby3.MinerAdjLiquidOxygen, _hobby3.MinerAdjLiquidNitrogen, _hobby3.MinerAdjPlatinum, _hobby3.MinerAdjDiamond, _hobby3.MinerAdjRadioactive, _hobby3.MinerAdjBlackMatter, _hobby3.MinerAdjRedMatter, _hobby3.MinerAdjGreyMatter, _hobby3.MinerAdjWhiteMatter, _hobby3.MinerAdjMana, _hobby3.EnergyConversion, _hobby3.ToHit, _hobby3.CritHitChance, _hobby3.XpBonus, _hobby3.WeaponCoolDown, _hobby3.HullIncrease, _hobby3.ShipVolumeIncrease, _hobby3.TractorBeamIncreaseChance, _hobby3.ShipSpeedIncrease, _hobby3.EvasionIncrease, _hobby3.DamageIncrease, _hobby3.CriticalDamageIncrease, _hobby3.ExtraShotChance, _hobby3.VisionFieldIncrease, _hobby3.StunChanceIncrease, _hobby3.StunDurationIncrease, _hobby3.MajorBreakThroughChance, _hobby3.InventionBonusChance, _hobby3.CloakChanceIncrease, _hobby3.CloakAllChanceIncrease, _hobby3.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby4.NpcHobbyName, _hobby4.NpcHobbyId, _hobby4.NpcHobbyLevel, _hobby4.IsMiner, _hobby4.IsNecromancy, _hobby4.IsMarksman, _hobby4.IsSniper, _hobby4.IsMonk, _hobby4.IsWeaponsMaker, _hobby4.IsDefensiveSpecialist, _hobby4.IsIntellectual, _hobby4.IsCowboy, _hobby4.IsThrillSeeker, _hobby4.IsAsteroidBeltRacer, _hobby4.IsExterminator, _hobby4.IsMartialArtsExpert, _hobby4.IsOpportunist, _hobby4.IsPhotographer, _hobby4.IsKnockoutArtist, _hobby4.IsScientist, _hobby4.IsInventor, _hobby4.IsTaserSpecialist, _hobby4.IsAssassin, _hobby4.MinerAdjGas, _hobby4.MinerAdjCarbon, _hobby4.MinerAdjWater, _hobby4.MinerAdjOrganic, _hobby4.MinerAdjRock, _hobby4.MinerAdjWood, _hobby4.MinerAdjIron, _hobby4.MinerAdjSilver, _hobby4.MinerAdjGold, _hobby4.MinerAdjRuby, _hobby4.MinerAdjEmerald, _hobby4.MinerAdjTitanium, _hobby4.MinerAdjMithril, _hobby4.MinerAdjLiquidHydrogen, _hobby4.MinerAdjLiquidOxygen, _hobby4.MinerAdjLiquidNitrogen, _hobby4.MinerAdjPlatinum, _hobby4.MinerAdjDiamond, _hobby4.MinerAdjRadioactive, _hobby4.MinerAdjBlackMatter, _hobby4.MinerAdjRedMatter, _hobby4.MinerAdjGreyMatter, _hobby4.MinerAdjWhiteMatter, _hobby4.MinerAdjMana, _hobby4.EnergyConversion, _hobby4.ToHit, _hobby4.CritHitChance, _hobby4.XpBonus, _hobby4.WeaponCoolDown, _hobby4.HullIncrease, _hobby4.ShipVolumeIncrease, _hobby4.TractorBeamIncreaseChance, _hobby4.ShipSpeedIncrease, _hobby4.EvasionIncrease, _hobby4.DamageIncrease, _hobby4.CriticalDamageIncrease, _hobby4.ExtraShotChance, _hobby4.VisionFieldIncrease, _hobby4.StunChanceIncrease, _hobby4.StunDurationIncrease, _hobby4.MajorBreakThroughChance, _hobby4.InventionBonusChance, _hobby4.CloakChanceIncrease, _hobby4.CloakAllChanceIncrease, _hobby4.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby5.NpcHobbyName, _hobby5.NpcHobbyId, _hobby5.NpcHobbyLevel, _hobby5.IsMiner, _hobby5.IsNecromancy, _hobby5.IsMarksman, _hobby5.IsSniper, _hobby5.IsMonk, _hobby5.IsWeaponsMaker, _hobby5.IsDefensiveSpecialist, _hobby5.IsIntellectual, _hobby5.IsCowboy, _hobby5.IsThrillSeeker, _hobby5.IsAsteroidBeltRacer, _hobby5.IsExterminator, _hobby5.IsMartialArtsExpert, _hobby5.IsOpportunist, _hobby5.IsPhotographer, _hobby5.IsKnockoutArtist, _hobby5.IsScientist, _hobby5.IsInventor, _hobby5.IsTaserSpecialist, _hobby5.IsAssassin, _hobby5.MinerAdjGas, _hobby5.MinerAdjCarbon, _hobby5.MinerAdjWater, _hobby5.MinerAdjOrganic, _hobby5.MinerAdjRock, _hobby5.MinerAdjWood, _hobby5.MinerAdjIron, _hobby5.MinerAdjSilver, _hobby5.MinerAdjGold, _hobby5.MinerAdjRuby, _hobby5.MinerAdjEmerald, _hobby5.MinerAdjTitanium, _hobby5.MinerAdjMithril, _hobby5.MinerAdjLiquidHydrogen, _hobby5.MinerAdjLiquidOxygen, _hobby5.MinerAdjLiquidNitrogen, _hobby5.MinerAdjPlatinum, _hobby5.MinerAdjDiamond, _hobby5.MinerAdjRadioactive, _hobby5.MinerAdjBlackMatter, _hobby5.MinerAdjRedMatter, _hobby5.MinerAdjGreyMatter, _hobby5.MinerAdjWhiteMatter, _hobby5.MinerAdjMana, _hobby5.EnergyConversion, _hobby5.ToHit, _hobby5.CritHitChance, _hobby5.XpBonus, _hobby5.WeaponCoolDown, _hobby5.HullIncrease, _hobby5.ShipVolumeIncrease, _hobby5.TractorBeamIncreaseChance, _hobby5.ShipSpeedIncrease, _hobby5.EvasionIncrease, _hobby5.DamageIncrease, _hobby5.CriticalDamageIncrease, _hobby5.ExtraShotChance, _hobby5.VisionFieldIncrease, _hobby5.StunChanceIncrease, _hobby5.StunDurationIncrease, _hobby5.MajorBreakThroughChance, _hobby5.InventionBonusChance, _hobby5.CloakChanceIncrease, _hobby5.CloakAllChanceIncrease, _hobby5.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby6.NpcHobbyName, _hobby6.NpcHobbyId, _hobby6.NpcHobbyLevel, _hobby6.IsMiner, _hobby6.IsNecromancy, _hobby6.IsMarksman, _hobby6.IsSniper, _hobby6.IsMonk, _hobby6.IsWeaponsMaker, _hobby6.IsDefensiveSpecialist, _hobby6.IsIntellectual, _hobby6.IsCowboy, _hobby6.IsThrillSeeker, _hobby6.IsAsteroidBeltRacer, _hobby6.IsExterminator, _hobby6.IsMartialArtsExpert, _hobby6.IsOpportunist, _hobby6.IsPhotographer, _hobby6.IsKnockoutArtist, _hobby6.IsScientist, _hobby6.IsInventor, _hobby6.IsTaserSpecialist, _hobby6.IsAssassin, _hobby6.MinerAdjGas, _hobby6.MinerAdjCarbon, _hobby6.MinerAdjWater, _hobby6.MinerAdjOrganic, _hobby6.MinerAdjRock, _hobby6.MinerAdjWood, _hobby6.MinerAdjIron, _hobby6.MinerAdjSilver, _hobby6.MinerAdjGold, _hobby6.MinerAdjRuby, _hobby6.MinerAdjEmerald, _hobby6.MinerAdjTitanium, _hobby6.MinerAdjMithril, _hobby6.MinerAdjLiquidHydrogen, _hobby6.MinerAdjLiquidOxygen, _hobby6.MinerAdjLiquidNitrogen, _hobby6.MinerAdjPlatinum, _hobby6.MinerAdjDiamond, _hobby6.MinerAdjRadioactive, _hobby6.MinerAdjBlackMatter, _hobby6.MinerAdjRedMatter, _hobby6.MinerAdjGreyMatter, _hobby6.MinerAdjWhiteMatter, _hobby6.MinerAdjMana, _hobby6.EnergyConversion, _hobby6.ToHit, _hobby6.CritHitChance, _hobby6.XpBonus, _hobby6.WeaponCoolDown, _hobby6.HullIncrease, _hobby6.ShipVolumeIncrease, _hobby6.TractorBeamIncreaseChance, _hobby6.ShipSpeedIncrease, _hobby6.EvasionIncrease, _hobby6.DamageIncrease, _hobby6.CriticalDamageIncrease, _hobby6.ExtraShotChance, _hobby6.VisionFieldIncrease, _hobby6.StunChanceIncrease, _hobby6.StunDurationIncrease, _hobby6.MajorBreakThroughChance, _hobby6.InventionBonusChance, _hobby6.CloakChanceIncrease, _hobby6.CloakAllChanceIncrease, _hobby6.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby7.NpcHobbyName, _hobby7.NpcHobbyId, _hobby7.NpcHobbyLevel, _hobby7.IsMiner, _hobby7.IsNecromancy, _hobby7.IsMarksman, _hobby7.IsSniper, _hobby7.IsMonk, _hobby7.IsWeaponsMaker, _hobby7.IsDefensiveSpecialist, _hobby7.IsIntellectual, _hobby7.IsCowboy, _hobby7.IsThrillSeeker, _hobby7.IsAsteroidBeltRacer, _hobby7.IsExterminator, _hobby7.IsMartialArtsExpert, _hobby7.IsOpportunist, _hobby7.IsPhotographer, _hobby7.IsKnockoutArtist, _hobby7.IsScientist, _hobby7.IsInventor, _hobby7.IsTaserSpecialist, _hobby7.IsAssassin, _hobby7.MinerAdjGas, _hobby7.MinerAdjCarbon, _hobby7.MinerAdjWater, _hobby7.MinerAdjOrganic, _hobby7.MinerAdjRock, _hobby7.MinerAdjWood, _hobby7.MinerAdjIron, _hobby7.MinerAdjSilver, _hobby7.MinerAdjGold, _hobby7.MinerAdjRuby, _hobby7.MinerAdjEmerald, _hobby7.MinerAdjTitanium, _hobby7.MinerAdjMithril, _hobby7.MinerAdjLiquidHydrogen, _hobby7.MinerAdjLiquidOxygen, _hobby7.MinerAdjLiquidNitrogen, _hobby7.MinerAdjPlatinum, _hobby7.MinerAdjDiamond, _hobby7.MinerAdjRadioactive, _hobby7.MinerAdjBlackMatter, _hobby7.MinerAdjRedMatter, _hobby7.MinerAdjGreyMatter, _hobby7.MinerAdjWhiteMatter, _hobby7.MinerAdjMana, _hobby7.EnergyConversion, _hobby7.ToHit, _hobby7.CritHitChance, _hobby7.XpBonus, _hobby7.WeaponCoolDown, _hobby7.HullIncrease, _hobby7.ShipVolumeIncrease, _hobby7.TractorBeamIncreaseChance, _hobby7.ShipSpeedIncrease, _hobby7.EvasionIncrease, _hobby7.DamageIncrease, _hobby7.CriticalDamageIncrease, _hobby7.ExtraShotChance, _hobby7.VisionFieldIncrease, _hobby7.StunChanceIncrease, _hobby7.StunDurationIncrease, _hobby7.MajorBreakThroughChance, _hobby7.InventionBonusChance, _hobby7.CloakChanceIncrease, _hobby7.CloakAllChanceIncrease, _hobby7.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby8.NpcHobbyName, _hobby8.NpcHobbyId, _hobby8.NpcHobbyLevel, _hobby8.IsMiner, _hobby8.IsNecromancy, _hobby8.IsMarksman, _hobby8.IsSniper, _hobby8.IsMonk, _hobby8.IsWeaponsMaker, _hobby8.IsDefensiveSpecialist, _hobby8.IsIntellectual, _hobby8.IsCowboy, _hobby8.IsThrillSeeker, _hobby8.IsAsteroidBeltRacer, _hobby8.IsExterminator, _hobby8.IsMartialArtsExpert, _hobby8.IsOpportunist, _hobby8.IsPhotographer, _hobby8.IsKnockoutArtist, _hobby8.IsScientist, _hobby8.IsInventor, _hobby8.IsTaserSpecialist, _hobby8.IsAssassin, _hobby8.MinerAdjGas, _hobby8.MinerAdjCarbon, _hobby8.MinerAdjWater, _hobby8.MinerAdjOrganic, _hobby8.MinerAdjRock, _hobby8.MinerAdjWood, _hobby8.MinerAdjIron, _hobby8.MinerAdjSilver, _hobby8.MinerAdjGold, _hobby8.MinerAdjRuby, _hobby8.MinerAdjEmerald, _hobby8.MinerAdjTitanium, _hobby8.MinerAdjMithril, _hobby8.MinerAdjLiquidHydrogen, _hobby8.MinerAdjLiquidOxygen, _hobby8.MinerAdjLiquidNitrogen, _hobby8.MinerAdjPlatinum, _hobby8.MinerAdjDiamond, _hobby8.MinerAdjRadioactive, _hobby8.MinerAdjBlackMatter, _hobby8.MinerAdjRedMatter, _hobby8.MinerAdjGreyMatter, _hobby8.MinerAdjWhiteMatter, _hobby8.MinerAdjMana, _hobby8.EnergyConversion, _hobby8.ToHit, _hobby8.CritHitChance, _hobby8.XpBonus, _hobby8.WeaponCoolDown, _hobby8.HullIncrease, _hobby8.ShipVolumeIncrease, _hobby8.TractorBeamIncreaseChance, _hobby8.ShipSpeedIncrease, _hobby8.EvasionIncrease, _hobby8.DamageIncrease, _hobby8.CriticalDamageIncrease, _hobby8.ExtraShotChance, _hobby8.VisionFieldIncrease, _hobby8.StunChanceIncrease, _hobby8.StunDurationIncrease, _hobby8.MajorBreakThroughChance, _hobby8.InventionBonusChance, _hobby8.CloakChanceIncrease, _hobby8.CloakAllChanceIncrease, _hobby8.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby9.NpcHobbyName, _hobby9.NpcHobbyId, _hobby9.NpcHobbyLevel, _hobby9.IsMiner, _hobby9.IsNecromancy, _hobby9.IsMarksman, _hobby9.IsSniper, _hobby9.IsMonk, _hobby9.IsWeaponsMaker, _hobby9.IsDefensiveSpecialist, _hobby9.IsIntellectual, _hobby9.IsCowboy, _hobby9.IsThrillSeeker, _hobby9.IsAsteroidBeltRacer, _hobby9.IsExterminator, _hobby9.IsMartialArtsExpert, _hobby9.IsOpportunist, _hobby9.IsPhotographer, _hobby9.IsKnockoutArtist, _hobby9.IsScientist, _hobby9.IsInventor, _hobby9.IsTaserSpecialist, _hobby9.IsAssassin, _hobby9.MinerAdjGas, _hobby9.MinerAdjCarbon, _hobby9.MinerAdjWater, _hobby9.MinerAdjOrganic, _hobby9.MinerAdjRock, _hobby9.MinerAdjWood, _hobby9.MinerAdjIron, _hobby9.MinerAdjSilver, _hobby9.MinerAdjGold, _hobby9.MinerAdjRuby, _hobby9.MinerAdjEmerald, _hobby9.MinerAdjTitanium, _hobby9.MinerAdjMithril, _hobby9.MinerAdjLiquidHydrogen, _hobby9.MinerAdjLiquidOxygen, _hobby9.MinerAdjLiquidNitrogen, _hobby9.MinerAdjPlatinum, _hobby9.MinerAdjDiamond, _hobby9.MinerAdjRadioactive, _hobby9.MinerAdjBlackMatter, _hobby9.MinerAdjRedMatter, _hobby9.MinerAdjGreyMatter, _hobby9.MinerAdjWhiteMatter, _hobby9.MinerAdjMana, _hobby9.EnergyConversion, _hobby9.ToHit, _hobby9.CritHitChance, _hobby9.XpBonus, _hobby9.WeaponCoolDown, _hobby9.HullIncrease, _hobby9.ShipVolumeIncrease, _hobby9.TractorBeamIncreaseChance, _hobby9.ShipSpeedIncrease, _hobby9.EvasionIncrease, _hobby9.DamageIncrease, _hobby9.CriticalDamageIncrease, _hobby9.ExtraShotChance, _hobby9.VisionFieldIncrease, _hobby9.StunChanceIncrease, _hobby9.StunDurationIncrease, _hobby9.MajorBreakThroughChance, _hobby9.InventionBonusChance, _hobby9.CloakChanceIncrease, _hobby9.CloakAllChanceIncrease, _hobby9.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby10.NpcHobbyName, _hobby10.NpcHobbyId, _hobby10.NpcHobbyLevel, _hobby10.IsMiner, _hobby10.IsNecromancy, _hobby10.IsMarksman, _hobby10.IsSniper, _hobby10.IsMonk, _hobby10.IsWeaponsMaker, _hobby10.IsDefensiveSpecialist, _hobby10.IsIntellectual, _hobby10.IsCowboy, _hobby10.IsThrillSeeker, _hobby10.IsAsteroidBeltRacer, _hobby10.IsExterminator, _hobby10.IsMartialArtsExpert, _hobby10.IsOpportunist, _hobby10.IsPhotographer, _hobby10.IsKnockoutArtist, _hobby10.IsScientist, _hobby10.IsInventor, _hobby10.IsTaserSpecialist, _hobby10.IsAssassin, _hobby10.MinerAdjGas, _hobby10.MinerAdjCarbon, _hobby10.MinerAdjWater, _hobby10.MinerAdjOrganic, _hobby10.MinerAdjRock, _hobby10.MinerAdjWood, _hobby10.MinerAdjIron, _hobby10.MinerAdjSilver, _hobby10.MinerAdjGold, _hobby10.MinerAdjRuby, _hobby10.MinerAdjEmerald, _hobby10.MinerAdjTitanium, _hobby10.MinerAdjMithril, _hobby10.MinerAdjLiquidHydrogen, _hobby10.MinerAdjLiquidOxygen, _hobby10.MinerAdjLiquidNitrogen, _hobby10.MinerAdjPlatinum, _hobby10.MinerAdjDiamond, _hobby10.MinerAdjRadioactive, _hobby10.MinerAdjBlackMatter, _hobby10.MinerAdjRedMatter, _hobby10.MinerAdjGreyMatter, _hobby10.MinerAdjWhiteMatter, _hobby10.MinerAdjMana, _hobby10.EnergyConversion, _hobby10.ToHit, _hobby10.CritHitChance, _hobby10.XpBonus, _hobby10.WeaponCoolDown, _hobby10.HullIncrease, _hobby10.ShipVolumeIncrease, _hobby10.TractorBeamIncreaseChance, _hobby10.ShipSpeedIncrease, _hobby10.EvasionIncrease, _hobby10.DamageIncrease, _hobby10.CriticalDamageIncrease, _hobby10.ExtraShotChance, _hobby10.VisionFieldIncrease, _hobby10.StunChanceIncrease, _hobby10.StunDurationIncrease, _hobby10.MajorBreakThroughChance, _hobby10.InventionBonusChance, _hobby10.CloakChanceIncrease, _hobby10.CloakAllChanceIncrease, _hobby10.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby11.NpcHobbyName, _hobby11.NpcHobbyId, _hobby11.NpcHobbyLevel, _hobby11.IsMiner, _hobby11.IsNecromancy, _hobby11.IsMarksman, _hobby11.IsSniper, _hobby11.IsMonk, _hobby11.IsWeaponsMaker, _hobby11.IsDefensiveSpecialist, _hobby11.IsIntellectual, _hobby11.IsCowboy, _hobby11.IsThrillSeeker, _hobby11.IsAsteroidBeltRacer, _hobby11.IsExterminator, _hobby11.IsMartialArtsExpert, _hobby11.IsOpportunist, _hobby11.IsPhotographer, _hobby11.IsKnockoutArtist, _hobby11.IsScientist, _hobby11.IsInventor, _hobby11.IsTaserSpecialist, _hobby11.IsAssassin, _hobby11.MinerAdjGas, _hobby11.MinerAdjCarbon, _hobby11.MinerAdjWater, _hobby11.MinerAdjOrganic, _hobby11.MinerAdjRock, _hobby11.MinerAdjWood, _hobby11.MinerAdjIron, _hobby11.MinerAdjSilver, _hobby11.MinerAdjGold, _hobby11.MinerAdjRuby, _hobby11.MinerAdjEmerald, _hobby11.MinerAdjTitanium, _hobby11.MinerAdjMithril, _hobby11.MinerAdjLiquidHydrogen, _hobby11.MinerAdjLiquidOxygen, _hobby11.MinerAdjLiquidNitrogen, _hobby11.MinerAdjPlatinum, _hobby11.MinerAdjDiamond, _hobby11.MinerAdjRadioactive, _hobby11.MinerAdjBlackMatter, _hobby11.MinerAdjRedMatter, _hobby11.MinerAdjGreyMatter, _hobby11.MinerAdjWhiteMatter, _hobby11.MinerAdjMana, _hobby11.EnergyConversion, _hobby11.ToHit, _hobby11.CritHitChance, _hobby11.XpBonus, _hobby11.WeaponCoolDown, _hobby11.HullIncrease, _hobby11.ShipVolumeIncrease, _hobby11.TractorBeamIncreaseChance, _hobby11.ShipSpeedIncrease, _hobby11.EvasionIncrease, _hobby11.DamageIncrease, _hobby11.CriticalDamageIncrease, _hobby11.ExtraShotChance, _hobby11.VisionFieldIncrease, _hobby11.StunChanceIncrease, _hobby11.StunDurationIncrease, _hobby11.MajorBreakThroughChance, _hobby11.InventionBonusChance, _hobby11.CloakChanceIncrease, _hobby11.CloakAllChanceIncrease, _hobby11.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby12.NpcHobbyName, _hobby12.NpcHobbyId, _hobby12.NpcHobbyLevel, _hobby12.IsMiner, _hobby12.IsNecromancy, _hobby12.IsMarksman, _hobby12.IsSniper, _hobby12.IsMonk, _hobby12.IsWeaponsMaker, _hobby12.IsDefensiveSpecialist, _hobby12.IsIntellectual, _hobby12.IsCowboy, _hobby12.IsThrillSeeker, _hobby12.IsAsteroidBeltRacer, _hobby12.IsExterminator, _hobby12.IsMartialArtsExpert, _hobby12.IsOpportunist, _hobby12.IsPhotographer, _hobby12.IsKnockoutArtist, _hobby12.IsScientist, _hobby12.IsInventor, _hobby12.IsTaserSpecialist, _hobby12.IsAssassin, _hobby12.MinerAdjGas, _hobby12.MinerAdjCarbon, _hobby12.MinerAdjWater, _hobby12.MinerAdjOrganic, _hobby12.MinerAdjRock, _hobby12.MinerAdjWood, _hobby12.MinerAdjIron, _hobby12.MinerAdjSilver, _hobby12.MinerAdjGold, _hobby12.MinerAdjRuby, _hobby12.MinerAdjEmerald, _hobby12.MinerAdjTitanium, _hobby12.MinerAdjMithril, _hobby12.MinerAdjLiquidHydrogen, _hobby12.MinerAdjLiquidOxygen, _hobby12.MinerAdjLiquidNitrogen, _hobby12.MinerAdjPlatinum, _hobby12.MinerAdjDiamond, _hobby12.MinerAdjRadioactive, _hobby12.MinerAdjBlackMatter, _hobby12.MinerAdjRedMatter, _hobby12.MinerAdjGreyMatter, _hobby12.MinerAdjWhiteMatter, _hobby12.MinerAdjMana, _hobby12.EnergyConversion, _hobby12.ToHit, _hobby12.CritHitChance, _hobby12.XpBonus, _hobby12.WeaponCoolDown, _hobby12.HullIncrease, _hobby12.ShipVolumeIncrease, _hobby12.TractorBeamIncreaseChance, _hobby12.ShipSpeedIncrease, _hobby12.EvasionIncrease, _hobby12.DamageIncrease, _hobby12.CriticalDamageIncrease, _hobby12.ExtraShotChance, _hobby12.VisionFieldIncrease, _hobby12.StunChanceIncrease, _hobby12.StunDurationIncrease, _hobby12.MajorBreakThroughChance, _hobby12.InventionBonusChance, _hobby12.CloakChanceIncrease, _hobby12.CloakAllChanceIncrease, _hobby12.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby13.NpcHobbyName, _hobby13.NpcHobbyId, _hobby13.NpcHobbyLevel, _hobby13.IsMiner, _hobby13.IsNecromancy, _hobby13.IsMarksman, _hobby13.IsSniper, _hobby13.IsMonk, _hobby13.IsWeaponsMaker, _hobby13.IsDefensiveSpecialist, _hobby13.IsIntellectual, _hobby13.IsCowboy, _hobby13.IsThrillSeeker, _hobby13.IsAsteroidBeltRacer, _hobby13.IsExterminator, _hobby13.IsMartialArtsExpert, _hobby13.IsOpportunist, _hobby13.IsPhotographer, _hobby13.IsKnockoutArtist, _hobby13.IsScientist, _hobby13.IsInventor, _hobby13.IsTaserSpecialist, _hobby13.IsAssassin, _hobby13.MinerAdjGas, _hobby13.MinerAdjCarbon, _hobby13.MinerAdjWater, _hobby13.MinerAdjOrganic, _hobby13.MinerAdjRock, _hobby13.MinerAdjWood, _hobby13.MinerAdjIron, _hobby13.MinerAdjSilver, _hobby13.MinerAdjGold, _hobby13.MinerAdjRuby, _hobby13.MinerAdjEmerald, _hobby13.MinerAdjTitanium, _hobby13.MinerAdjMithril, _hobby13.MinerAdjLiquidHydrogen, _hobby13.MinerAdjLiquidOxygen, _hobby13.MinerAdjLiquidNitrogen, _hobby13.MinerAdjPlatinum, _hobby13.MinerAdjDiamond, _hobby13.MinerAdjRadioactive, _hobby13.MinerAdjBlackMatter, _hobby13.MinerAdjRedMatter, _hobby13.MinerAdjGreyMatter, _hobby13.MinerAdjWhiteMatter, _hobby13.MinerAdjMana, _hobby13.EnergyConversion, _hobby13.ToHit, _hobby13.CritHitChance, _hobby13.XpBonus, _hobby13.WeaponCoolDown, _hobby13.HullIncrease, _hobby13.ShipVolumeIncrease, _hobby13.TractorBeamIncreaseChance, _hobby13.ShipSpeedIncrease, _hobby13.EvasionIncrease, _hobby13.DamageIncrease, _hobby13.CriticalDamageIncrease, _hobby13.ExtraShotChance, _hobby13.VisionFieldIncrease, _hobby13.StunChanceIncrease, _hobby13.StunDurationIncrease, _hobby13.MajorBreakThroughChance, _hobby13.InventionBonusChance, _hobby13.CloakChanceIncrease, _hobby13.CloakAllChanceIncrease, _hobby13.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby14.NpcHobbyName, _hobby14.NpcHobbyId, _hobby14.NpcHobbyLevel, _hobby14.IsMiner, _hobby14.IsNecromancy, _hobby14.IsMarksman, _hobby14.IsSniper, _hobby14.IsMonk, _hobby14.IsWeaponsMaker, _hobby14.IsDefensiveSpecialist, _hobby14.IsIntellectual, _hobby14.IsCowboy, _hobby14.IsThrillSeeker, _hobby14.IsAsteroidBeltRacer, _hobby14.IsExterminator, _hobby14.IsMartialArtsExpert, _hobby14.IsOpportunist, _hobby14.IsPhotographer, _hobby14.IsKnockoutArtist, _hobby14.IsScientist, _hobby14.IsInventor, _hobby14.IsTaserSpecialist, _hobby14.IsAssassin, _hobby14.MinerAdjGas, _hobby14.MinerAdjCarbon, _hobby14.MinerAdjWater, _hobby14.MinerAdjOrganic, _hobby14.MinerAdjRock, _hobby14.MinerAdjWood, _hobby14.MinerAdjIron, _hobby14.MinerAdjSilver, _hobby14.MinerAdjGold, _hobby14.MinerAdjRuby, _hobby14.MinerAdjEmerald, _hobby14.MinerAdjTitanium, _hobby14.MinerAdjMithril, _hobby14.MinerAdjLiquidHydrogen, _hobby14.MinerAdjLiquidOxygen, _hobby14.MinerAdjLiquidNitrogen, _hobby14.MinerAdjPlatinum, _hobby14.MinerAdjDiamond, _hobby14.MinerAdjRadioactive, _hobby14.MinerAdjBlackMatter, _hobby14.MinerAdjRedMatter, _hobby14.MinerAdjGreyMatter, _hobby14.MinerAdjWhiteMatter, _hobby14.MinerAdjMana, _hobby14.EnergyConversion, _hobby14.ToHit, _hobby14.CritHitChance, _hobby14.XpBonus, _hobby14.WeaponCoolDown, _hobby14.HullIncrease, _hobby14.ShipVolumeIncrease, _hobby14.TractorBeamIncreaseChance, _hobby14.ShipSpeedIncrease, _hobby14.EvasionIncrease, _hobby14.DamageIncrease, _hobby14.CriticalDamageIncrease, _hobby14.ExtraShotChance, _hobby14.VisionFieldIncrease, _hobby14.StunChanceIncrease, _hobby14.StunDurationIncrease, _hobby14.MajorBreakThroughChance, _hobby14.InventionBonusChance, _hobby14.CloakChanceIncrease, _hobby14.CloakAllChanceIncrease, _hobby14.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby15.NpcHobbyName, _hobby15.NpcHobbyId, _hobby15.NpcHobbyLevel, _hobby15.IsMiner, _hobby15.IsNecromancy, _hobby15.IsMarksman, _hobby15.IsSniper, _hobby15.IsMonk, _hobby15.IsWeaponsMaker, _hobby15.IsDefensiveSpecialist, _hobby15.IsIntellectual, _hobby15.IsCowboy, _hobby15.IsThrillSeeker, _hobby15.IsAsteroidBeltRacer, _hobby15.IsExterminator, _hobby15.IsMartialArtsExpert, _hobby15.IsOpportunist, _hobby15.IsPhotographer, _hobby15.IsKnockoutArtist, _hobby15.IsScientist, _hobby15.IsInventor, _hobby15.IsTaserSpecialist, _hobby15.IsAssassin, _hobby15.MinerAdjGas, _hobby15.MinerAdjCarbon, _hobby15.MinerAdjWater, _hobby15.MinerAdjOrganic, _hobby15.MinerAdjRock, _hobby15.MinerAdjWood, _hobby15.MinerAdjIron, _hobby15.MinerAdjSilver, _hobby15.MinerAdjGold, _hobby15.MinerAdjRuby, _hobby15.MinerAdjEmerald, _hobby15.MinerAdjTitanium, _hobby15.MinerAdjMithril, _hobby15.MinerAdjLiquidHydrogen, _hobby15.MinerAdjLiquidOxygen, _hobby15.MinerAdjLiquidNitrogen, _hobby15.MinerAdjPlatinum, _hobby15.MinerAdjDiamond, _hobby15.MinerAdjRadioactive, _hobby15.MinerAdjBlackMatter, _hobby15.MinerAdjRedMatter, _hobby15.MinerAdjGreyMatter, _hobby15.MinerAdjWhiteMatter, _hobby15.MinerAdjMana, _hobby15.EnergyConversion, _hobby15.ToHit, _hobby15.CritHitChance, _hobby15.XpBonus, _hobby15.WeaponCoolDown, _hobby15.HullIncrease, _hobby15.ShipVolumeIncrease, _hobby15.TractorBeamIncreaseChance, _hobby15.ShipSpeedIncrease, _hobby15.EvasionIncrease, _hobby15.DamageIncrease, _hobby15.CriticalDamageIncrease, _hobby15.ExtraShotChance, _hobby15.VisionFieldIncrease, _hobby15.StunChanceIncrease, _hobby15.StunDurationIncrease, _hobby15.MajorBreakThroughChance, _hobby15.InventionBonusChance, _hobby15.CloakChanceIncrease, _hobby15.CloakAllChanceIncrease, _hobby15.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby16.NpcHobbyName, _hobby16.NpcHobbyId, _hobby16.NpcHobbyLevel, _hobby16.IsMiner, _hobby16.IsNecromancy, _hobby16.IsMarksman, _hobby16.IsSniper, _hobby16.IsMonk, _hobby16.IsWeaponsMaker, _hobby16.IsDefensiveSpecialist, _hobby16.IsIntellectual, _hobby16.IsCowboy, _hobby16.IsThrillSeeker, _hobby16.IsAsteroidBeltRacer, _hobby16.IsExterminator, _hobby16.IsMartialArtsExpert, _hobby16.IsOpportunist, _hobby16.IsPhotographer, _hobby16.IsKnockoutArtist, _hobby16.IsScientist, _hobby16.IsInventor, _hobby16.IsTaserSpecialist, _hobby16.IsAssassin, _hobby16.MinerAdjGas, _hobby16.MinerAdjCarbon, _hobby16.MinerAdjWater, _hobby16.MinerAdjOrganic, _hobby16.MinerAdjRock, _hobby16.MinerAdjWood, _hobby16.MinerAdjIron, _hobby16.MinerAdjSilver, _hobby16.MinerAdjGold, _hobby16.MinerAdjRuby, _hobby16.MinerAdjEmerald, _hobby16.MinerAdjTitanium, _hobby16.MinerAdjMithril, _hobby16.MinerAdjLiquidHydrogen, _hobby16.MinerAdjLiquidOxygen, _hobby16.MinerAdjLiquidNitrogen, _hobby16.MinerAdjPlatinum, _hobby16.MinerAdjDiamond, _hobby16.MinerAdjRadioactive, _hobby16.MinerAdjBlackMatter, _hobby16.MinerAdjRedMatter, _hobby16.MinerAdjGreyMatter, _hobby16.MinerAdjWhiteMatter, _hobby16.MinerAdjMana, _hobby16.EnergyConversion, _hobby16.ToHit, _hobby16.CritHitChance, _hobby16.XpBonus, _hobby16.WeaponCoolDown, _hobby16.HullIncrease, _hobby16.ShipVolumeIncrease, _hobby16.TractorBeamIncreaseChance, _hobby16.ShipSpeedIncrease, _hobby16.EvasionIncrease, _hobby16.DamageIncrease, _hobby16.CriticalDamageIncrease, _hobby16.ExtraShotChance, _hobby16.VisionFieldIncrease, _hobby16.StunChanceIncrease, _hobby16.StunDurationIncrease, _hobby16.MajorBreakThroughChance, _hobby16.InventionBonusChance, _hobby16.CloakChanceIncrease, _hobby16.CloakAllChanceIncrease, _hobby16.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby17.NpcHobbyName, _hobby17.NpcHobbyId, _hobby17.NpcHobbyLevel, _hobby17.IsMiner, _hobby17.IsNecromancy, _hobby17.IsMarksman, _hobby17.IsSniper, _hobby17.IsMonk, _hobby17.IsWeaponsMaker, _hobby17.IsDefensiveSpecialist, _hobby17.IsIntellectual, _hobby17.IsCowboy, _hobby17.IsThrillSeeker, _hobby17.IsAsteroidBeltRacer, _hobby17.IsExterminator, _hobby17.IsMartialArtsExpert, _hobby17.IsOpportunist, _hobby17.IsPhotographer, _hobby17.IsKnockoutArtist, _hobby17.IsScientist, _hobby17.IsInventor, _hobby17.IsTaserSpecialist, _hobby17.IsAssassin, _hobby17.MinerAdjGas, _hobby17.MinerAdjCarbon, _hobby17.MinerAdjWater, _hobby17.MinerAdjOrganic, _hobby17.MinerAdjRock, _hobby17.MinerAdjWood, _hobby17.MinerAdjIron, _hobby17.MinerAdjSilver, _hobby17.MinerAdjGold, _hobby17.MinerAdjRuby, _hobby17.MinerAdjEmerald, _hobby17.MinerAdjTitanium, _hobby17.MinerAdjMithril, _hobby17.MinerAdjLiquidHydrogen, _hobby17.MinerAdjLiquidOxygen, _hobby17.MinerAdjLiquidNitrogen, _hobby17.MinerAdjPlatinum, _hobby17.MinerAdjDiamond, _hobby17.MinerAdjRadioactive, _hobby17.MinerAdjBlackMatter, _hobby17.MinerAdjRedMatter, _hobby17.MinerAdjGreyMatter, _hobby17.MinerAdjWhiteMatter, _hobby17.MinerAdjMana, _hobby17.EnergyConversion, _hobby17.ToHit, _hobby17.CritHitChance, _hobby17.XpBonus, _hobby17.WeaponCoolDown, _hobby17.HullIncrease, _hobby17.ShipVolumeIncrease, _hobby17.TractorBeamIncreaseChance, _hobby17.ShipSpeedIncrease, _hobby17.EvasionIncrease, _hobby17.DamageIncrease, _hobby17.CriticalDamageIncrease, _hobby17.ExtraShotChance, _hobby17.VisionFieldIncrease, _hobby17.StunChanceIncrease, _hobby17.StunDurationIncrease, _hobby17.MajorBreakThroughChance, _hobby17.InventionBonusChance, _hobby17.CloakChanceIncrease, _hobby17.CloakAllChanceIncrease, _hobby17.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby18.NpcHobbyName, _hobby18.NpcHobbyId, _hobby18.NpcHobbyLevel, _hobby18.IsMiner, _hobby18.IsNecromancy, _hobby18.IsMarksman, _hobby18.IsSniper, _hobby18.IsMonk, _hobby18.IsWeaponsMaker, _hobby18.IsDefensiveSpecialist, _hobby18.IsIntellectual, _hobby18.IsCowboy, _hobby18.IsThrillSeeker, _hobby18.IsAsteroidBeltRacer, _hobby18.IsExterminator, _hobby18.IsMartialArtsExpert, _hobby18.IsOpportunist, _hobby18.IsPhotographer, _hobby18.IsKnockoutArtist, _hobby18.IsScientist, _hobby18.IsInventor, _hobby18.IsTaserSpecialist, _hobby18.IsAssassin, _hobby18.MinerAdjGas, _hobby18.MinerAdjCarbon, _hobby18.MinerAdjWater, _hobby18.MinerAdjOrganic, _hobby18.MinerAdjRock, _hobby18.MinerAdjWood, _hobby18.MinerAdjIron, _hobby18.MinerAdjSilver, _hobby18.MinerAdjGold, _hobby18.MinerAdjRuby, _hobby18.MinerAdjEmerald, _hobby18.MinerAdjTitanium, _hobby18.MinerAdjMithril, _hobby18.MinerAdjLiquidHydrogen, _hobby18.MinerAdjLiquidOxygen, _hobby18.MinerAdjLiquidNitrogen, _hobby18.MinerAdjPlatinum, _hobby18.MinerAdjDiamond, _hobby18.MinerAdjRadioactive, _hobby18.MinerAdjBlackMatter, _hobby18.MinerAdjRedMatter, _hobby18.MinerAdjGreyMatter, _hobby18.MinerAdjWhiteMatter, _hobby18.MinerAdjMana, _hobby18.EnergyConversion, _hobby18.ToHit, _hobby18.CritHitChance, _hobby18.XpBonus, _hobby18.WeaponCoolDown, _hobby18.HullIncrease, _hobby18.ShipVolumeIncrease, _hobby18.TractorBeamIncreaseChance, _hobby18.ShipSpeedIncrease, _hobby18.EvasionIncrease, _hobby18.DamageIncrease, _hobby18.CriticalDamageIncrease, _hobby18.ExtraShotChance, _hobby18.VisionFieldIncrease, _hobby18.StunChanceIncrease, _hobby18.StunDurationIncrease, _hobby18.MajorBreakThroughChance, _hobby18.InventionBonusChance, _hobby18.CloakChanceIncrease, _hobby18.CloakAllChanceIncrease, _hobby18.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby19.NpcHobbyName, _hobby19.NpcHobbyId, _hobby19.NpcHobbyLevel, _hobby19.IsMiner, _hobby19.IsNecromancy, _hobby19.IsMarksman, _hobby19.IsSniper, _hobby19.IsMonk, _hobby19.IsWeaponsMaker, _hobby19.IsDefensiveSpecialist, _hobby19.IsIntellectual, _hobby19.IsCowboy, _hobby19.IsThrillSeeker, _hobby19.IsAsteroidBeltRacer, _hobby19.IsExterminator, _hobby19.IsMartialArtsExpert, _hobby19.IsOpportunist, _hobby19.IsPhotographer, _hobby19.IsKnockoutArtist, _hobby19.IsScientist, _hobby19.IsInventor, _hobby19.IsTaserSpecialist, _hobby19.IsAssassin, _hobby19.MinerAdjGas, _hobby19.MinerAdjCarbon, _hobby19.MinerAdjWater, _hobby19.MinerAdjOrganic, _hobby19.MinerAdjRock, _hobby19.MinerAdjWood, _hobby19.MinerAdjIron, _hobby19.MinerAdjSilver, _hobby19.MinerAdjGold, _hobby19.MinerAdjRuby, _hobby19.MinerAdjEmerald, _hobby19.MinerAdjTitanium, _hobby19.MinerAdjMithril, _hobby19.MinerAdjLiquidHydrogen, _hobby19.MinerAdjLiquidOxygen, _hobby19.MinerAdjLiquidNitrogen, _hobby19.MinerAdjPlatinum, _hobby19.MinerAdjDiamond, _hobby19.MinerAdjRadioactive, _hobby19.MinerAdjBlackMatter, _hobby19.MinerAdjRedMatter, _hobby19.MinerAdjGreyMatter, _hobby19.MinerAdjWhiteMatter, _hobby19.MinerAdjMana, _hobby19.EnergyConversion, _hobby19.ToHit, _hobby19.CritHitChance, _hobby19.XpBonus, _hobby19.WeaponCoolDown, _hobby19.HullIncrease, _hobby19.ShipVolumeIncrease, _hobby19.TractorBeamIncreaseChance, _hobby19.ShipSpeedIncrease, _hobby19.EvasionIncrease, _hobby19.DamageIncrease, _hobby19.CriticalDamageIncrease, _hobby19.ExtraShotChance, _hobby19.VisionFieldIncrease, _hobby19.StunChanceIncrease, _hobby19.StunDurationIncrease, _hobby19.MajorBreakThroughChance, _hobby19.InventionBonusChance, _hobby19.CloakChanceIncrease, _hobby19.CloakAllChanceIncrease, _hobby19.InstantKillIncrease));

            npcHobby.Add(new BaseNPCHobby(_hobby20.NpcHobbyName, _hobby20.NpcHobbyId, _hobby20.NpcHobbyLevel, _hobby20.IsMiner, _hobby20.IsNecromancy, _hobby20.IsMarksman, _hobby20.IsSniper, _hobby20.IsMonk, _hobby20.IsWeaponsMaker, _hobby20.IsDefensiveSpecialist, _hobby20.IsIntellectual, _hobby20.IsCowboy, _hobby20.IsThrillSeeker, _hobby20.IsAsteroidBeltRacer, _hobby20.IsExterminator, _hobby20.IsMartialArtsExpert, _hobby20.IsOpportunist, _hobby20.IsPhotographer, _hobby20.IsKnockoutArtist, _hobby20.IsScientist, _hobby20.IsInventor, _hobby20.IsTaserSpecialist, _hobby20.IsAssassin, _hobby20.MinerAdjGas, _hobby20.MinerAdjCarbon, _hobby20.MinerAdjWater, _hobby20.MinerAdjOrganic, _hobby20.MinerAdjRock, _hobby20.MinerAdjWood, _hobby20.MinerAdjIron, _hobby20.MinerAdjSilver, _hobby20.MinerAdjGold, _hobby20.MinerAdjRuby, _hobby20.MinerAdjEmerald, _hobby20.MinerAdjTitanium, _hobby20.MinerAdjMithril, _hobby20.MinerAdjLiquidHydrogen, _hobby20.MinerAdjLiquidOxygen, _hobby20.MinerAdjLiquidNitrogen, _hobby20.MinerAdjPlatinum, _hobby20.MinerAdjDiamond, _hobby20.MinerAdjRadioactive, _hobby20.MinerAdjBlackMatter, _hobby20.MinerAdjRedMatter, _hobby20.MinerAdjGreyMatter, _hobby20.MinerAdjWhiteMatter, _hobby20.MinerAdjMana, _hobby20.EnergyConversion, _hobby20.ToHit, _hobby20.CritHitChance, _hobby20.XpBonus, _hobby20.WeaponCoolDown, _hobby20.HullIncrease, _hobby20.ShipVolumeIncrease, _hobby20.TractorBeamIncreaseChance, _hobby20.ShipSpeedIncrease, _hobby20.EvasionIncrease, _hobby20.DamageIncrease, _hobby20.CriticalDamageIncrease, _hobby20.ExtraShotChance, _hobby20.VisionFieldIncrease, _hobby20.StunChanceIncrease, _hobby20.StunDurationIncrease, _hobby20.MajorBreakThroughChance, _hobby20.InventionBonusChance, _hobby20.CloakChanceIncrease, _hobby20.CloakAllChanceIncrease, _hobby20.InstantKillIncrease));

            #endregion


        }


        public float HobbyAdjHull(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if(h.NpcHobbyId == hobby)
                {
                    return h.HullIncrease;
                }
            }
            return 0;
        }

        public float HobbyAdjSpeed(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if (h.NpcHobbyId == hobby)
                {
                    return h.ShipSpeedIncrease;
                }
            }
            return 0;
        }

        public float HobbyAdjDamage(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if (h.NpcHobbyId == hobby)
                {
                    return h.DamageIncrease;
                }
            }
            return 0;
        }

        public float HobbyAdjWeaponCooldown(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if (h.NpcHobbyId == hobby)
                {
                    return h.WeaponCoolDown;
                }
            }
            return 0;
        }

        public float HobbyAdjShipVolume(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if (h.NpcHobbyId == hobby)
                {
                    return h.ShipVolumeIncrease;
                }
            }
            return 0;
        }

        public float HobbyAdjEnergyConversion(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if (h.NpcHobbyId == hobby)
                {
                    return h.EnergyConversion;
                }
            }
            return 0;
        }

        public float HobbyAdjToHit(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if (h.NpcHobbyId == hobby)
                {
                    return h.ToHit;
                }
            }
            return 0;
        }

        public float HobbyAdjCritHit(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if (h.NpcHobbyId == hobby)
                {
                    return h.CritHitChance;
                }
            }
            return 0;
        }

        public float HobbyAdjTractorBeamChance(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if (h.NpcHobbyId == hobby)
                {
                    return h.TractorBeamIncreaseChance;
                }
            }
            return 0;
        }

        public float HobbyAdjEvasion(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if (h.NpcHobbyId == hobby)
                {
                    return h.EvasionIncrease;
                }
            }
            return 0;
        }

        public float HobbyAdjCritDamageIncrease(int hobby)
        {
            foreach (var h in npcHobby)
            {
                if (h.NpcHobbyId == hobby)
                {
                    return h.CriticalDamageIncrease;
                }
            }
            return 0;
        }
    }
}
