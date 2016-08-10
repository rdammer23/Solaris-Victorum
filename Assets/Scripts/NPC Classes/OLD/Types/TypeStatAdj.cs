using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes.Types
{
    class TypeStatAdj:MonoBehaviour
    {
        NPCType1 _type1;
        NPCType2 _type2;
        NPCType3 _type3;
        NPCType4 _type4;
        NPCType5 _type5;
        NPCType6 _type6;
        NPCType7 _type7;
        NPCType8 _type8;
        NPCType9 _type9;
        NPCType10 _type10;
        NPCType11 _type11;
        NPCType12 _type12;
        NPCType13 _type13;
        NPCType14 _type14;
        NPCType15 _type15;
        NPCType16 _type16;
        NPCType17 _type17;
        NPCType18 _type18;
        NPCType19 _type19;
        NPCType20 _type20;

        static List<BaseNPCType> npcType;

        private void Start()
        {
            npcType = new List<BaseNPCType>();
            _type1 = new NPCType1();
            _type2 = new NPCType2();
            _type3 = new NPCType3();
            _type4 = new NPCType4();
            _type5 = new NPCType5();
            _type6 = new NPCType6();
            _type7 = new NPCType7();
            _type8 = new NPCType8();
            _type9 = new NPCType9();
            _type10 = new NPCType10();
            _type11 = new NPCType11();
            _type12 = new NPCType12();
            _type13 = new NPCType13();
            _type14 = new NPCType14();
            _type15 = new NPCType15();
            _type16 = new NPCType16();
            _type17 = new NPCType17();
            _type18 = new NPCType18();
            _type19 = new NPCType19();
            _type20 = new NPCType20();

            #region List Adding
            npcType.Add(new BaseNPCType(_type1.NpcTypeName, _type1.NpcTypeID, _type1.NpcResourceIncrease, _type1.NpcEnergyConversion, _type1.NpcToHit, _type1.NpcCritHitChance, _type1.NpcXpBonus, _type1.NpcWeaponCoolDown, _type1.NpcHullIncrease, _type1.NpcShipVolumeIncrease, _type1.NpcTractorBeamIncreaseChance, _type1.NpcShipSpeedIncrease, _type1.NpcEvasionIncrease, _type1.NpcDamageIncrease, _type1.NpcCriticalDamageIncrease, _type1.NpcExtraShotChance, _type1.NpcVisionFieldIncrease, _type1.NpcStunChanceIncrease, _type1.NpcStunDurationIncrease, _type1.NpcMajorBreakThroughChance, _type1.NpcInventionBonusChance, _type1.NpcCloakChanceIncrease, _type1.NpcCloakAllChanceIncrease, _type1.NpcInstantKillIncrease, _type1.NpcStunResistanceChance, _type1.NpcTractorBeamResistanceChance, _type1.NpcCriticalHitResistance, _type1.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type2.NpcTypeName, _type2.NpcTypeID, _type2.NpcResourceIncrease, _type2.NpcEnergyConversion, _type2.NpcToHit, _type2.NpcCritHitChance, _type2.NpcXpBonus, _type2.NpcWeaponCoolDown, _type2.NpcHullIncrease, _type2.NpcShipVolumeIncrease, _type2.NpcTractorBeamIncreaseChance, _type2.NpcShipSpeedIncrease, _type2.NpcEvasionIncrease, _type2.NpcDamageIncrease, _type2.NpcCriticalDamageIncrease, _type2.NpcExtraShotChance, _type2.NpcVisionFieldIncrease, _type2.NpcStunChanceIncrease, _type2.NpcStunDurationIncrease, _type2.NpcMajorBreakThroughChance, _type2.NpcInventionBonusChance, _type2.NpcCloakChanceIncrease, _type2.NpcCloakAllChanceIncrease, _type2.NpcInstantKillIncrease, _type2.NpcStunResistanceChance, _type2.NpcTractorBeamResistanceChance, _type2.NpcCriticalHitResistance, _type2.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type3.NpcTypeName, _type3.NpcTypeID, _type3.NpcResourceIncrease, _type3.NpcEnergyConversion, _type3.NpcToHit, _type3.NpcCritHitChance, _type3.NpcXpBonus, _type3.NpcWeaponCoolDown, _type3.NpcHullIncrease, _type3.NpcShipVolumeIncrease, _type3.NpcTractorBeamIncreaseChance, _type3.NpcShipSpeedIncrease, _type3.NpcEvasionIncrease, _type3.NpcDamageIncrease, _type3.NpcCriticalDamageIncrease, _type3.NpcExtraShotChance, _type3.NpcVisionFieldIncrease, _type3.NpcStunChanceIncrease, _type3.NpcStunDurationIncrease, _type3.NpcMajorBreakThroughChance, _type3.NpcInventionBonusChance, _type3.NpcCloakChanceIncrease, _type3.NpcCloakAllChanceIncrease, _type3.NpcInstantKillIncrease, _type3.NpcStunResistanceChance, _type3.NpcTractorBeamResistanceChance, _type3.NpcCriticalHitResistance, _type3.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type4.NpcTypeName, _type4.NpcTypeID, _type4.NpcResourceIncrease, _type4.NpcEnergyConversion, _type4.NpcToHit, _type4.NpcCritHitChance, _type4.NpcXpBonus, _type4.NpcWeaponCoolDown, _type4.NpcHullIncrease, _type4.NpcShipVolumeIncrease, _type4.NpcTractorBeamIncreaseChance, _type4.NpcShipSpeedIncrease, _type4.NpcEvasionIncrease, _type4.NpcDamageIncrease, _type4.NpcCriticalDamageIncrease, _type4.NpcExtraShotChance, _type4.NpcVisionFieldIncrease, _type4.NpcStunChanceIncrease, _type4.NpcStunDurationIncrease, _type4.NpcMajorBreakThroughChance, _type4.NpcInventionBonusChance, _type4.NpcCloakChanceIncrease, _type4.NpcCloakAllChanceIncrease, _type4.NpcInstantKillIncrease, _type4.NpcStunResistanceChance, _type4.NpcTractorBeamResistanceChance, _type4.NpcCriticalHitResistance, _type4.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type5.NpcTypeName, _type5.NpcTypeID, _type5.NpcResourceIncrease, _type5.NpcEnergyConversion, _type5.NpcToHit, _type5.NpcCritHitChance, _type5.NpcXpBonus, _type5.NpcWeaponCoolDown, _type5.NpcHullIncrease, _type5.NpcShipVolumeIncrease, _type5.NpcTractorBeamIncreaseChance, _type5.NpcShipSpeedIncrease, _type5.NpcEvasionIncrease, _type5.NpcDamageIncrease, _type5.NpcCriticalDamageIncrease, _type5.NpcExtraShotChance, _type5.NpcVisionFieldIncrease, _type5.NpcStunChanceIncrease, _type5.NpcStunDurationIncrease, _type5.NpcMajorBreakThroughChance, _type5.NpcInventionBonusChance, _type5.NpcCloakChanceIncrease, _type5.NpcCloakAllChanceIncrease, _type5.NpcInstantKillIncrease, _type5.NpcStunResistanceChance, _type5.NpcTractorBeamResistanceChance, _type5.NpcCriticalHitResistance, _type5.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type6.NpcTypeName, _type6.NpcTypeID, _type6.NpcResourceIncrease, _type6.NpcEnergyConversion, _type6.NpcToHit, _type6.NpcCritHitChance, _type6.NpcXpBonus, _type6.NpcWeaponCoolDown, _type6.NpcHullIncrease, _type6.NpcShipVolumeIncrease, _type6.NpcTractorBeamIncreaseChance, _type6.NpcShipSpeedIncrease, _type6.NpcEvasionIncrease, _type6.NpcDamageIncrease, _type6.NpcCriticalDamageIncrease, _type6.NpcExtraShotChance, _type6.NpcVisionFieldIncrease, _type6.NpcStunChanceIncrease, _type6.NpcStunDurationIncrease, _type6.NpcMajorBreakThroughChance, _type6.NpcInventionBonusChance, _type6.NpcCloakChanceIncrease, _type6.NpcCloakAllChanceIncrease, _type6.NpcInstantKillIncrease, _type6.NpcStunResistanceChance, _type6.NpcTractorBeamResistanceChance, _type6.NpcCriticalHitResistance, _type6.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type7.NpcTypeName, _type7.NpcTypeID, _type7.NpcResourceIncrease, _type7.NpcEnergyConversion, _type7.NpcToHit, _type7.NpcCritHitChance, _type7.NpcXpBonus, _type7.NpcWeaponCoolDown, _type7.NpcHullIncrease, _type7.NpcShipVolumeIncrease, _type7.NpcTractorBeamIncreaseChance, _type7.NpcShipSpeedIncrease, _type7.NpcEvasionIncrease, _type7.NpcDamageIncrease, _type7.NpcCriticalDamageIncrease, _type7.NpcExtraShotChance, _type7.NpcVisionFieldIncrease, _type7.NpcStunChanceIncrease, _type7.NpcStunDurationIncrease, _type7.NpcMajorBreakThroughChance, _type7.NpcInventionBonusChance, _type7.NpcCloakChanceIncrease, _type7.NpcCloakAllChanceIncrease, _type7.NpcInstantKillIncrease, _type7.NpcStunResistanceChance, _type7.NpcTractorBeamResistanceChance, _type7.NpcCriticalHitResistance, _type7.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type8.NpcTypeName, _type8.NpcTypeID, _type8.NpcResourceIncrease, _type8.NpcEnergyConversion, _type8.NpcToHit, _type8.NpcCritHitChance, _type8.NpcXpBonus, _type8.NpcWeaponCoolDown, _type8.NpcHullIncrease, _type8.NpcShipVolumeIncrease, _type8.NpcTractorBeamIncreaseChance, _type8.NpcShipSpeedIncrease, _type8.NpcEvasionIncrease, _type8.NpcDamageIncrease, _type8.NpcCriticalDamageIncrease, _type8.NpcExtraShotChance, _type8.NpcVisionFieldIncrease, _type8.NpcStunChanceIncrease, _type8.NpcStunDurationIncrease, _type8.NpcMajorBreakThroughChance, _type8.NpcInventionBonusChance, _type8.NpcCloakChanceIncrease, _type8.NpcCloakAllChanceIncrease, _type8.NpcInstantKillIncrease, _type8.NpcStunResistanceChance, _type8.NpcTractorBeamResistanceChance, _type8.NpcCriticalHitResistance, _type8.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type9.NpcTypeName, _type9.NpcTypeID, _type9.NpcResourceIncrease, _type9.NpcEnergyConversion, _type9.NpcToHit, _type9.NpcCritHitChance, _type9.NpcXpBonus, _type9.NpcWeaponCoolDown, _type9.NpcHullIncrease, _type9.NpcShipVolumeIncrease, _type9.NpcTractorBeamIncreaseChance, _type9.NpcShipSpeedIncrease, _type9.NpcEvasionIncrease, _type9.NpcDamageIncrease, _type9.NpcCriticalDamageIncrease, _type9.NpcExtraShotChance, _type9.NpcVisionFieldIncrease, _type9.NpcStunChanceIncrease, _type9.NpcStunDurationIncrease, _type9.NpcMajorBreakThroughChance, _type9.NpcInventionBonusChance, _type9.NpcCloakChanceIncrease, _type9.NpcCloakAllChanceIncrease, _type9.NpcInstantKillIncrease, _type9.NpcStunResistanceChance, _type9.NpcTractorBeamResistanceChance, _type9.NpcCriticalHitResistance, _type9.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type10.NpcTypeName, _type10.NpcTypeID, _type10.NpcResourceIncrease, _type10.NpcEnergyConversion, _type10.NpcToHit, _type10.NpcCritHitChance, _type10.NpcXpBonus, _type10.NpcWeaponCoolDown, _type10.NpcHullIncrease, _type10.NpcShipVolumeIncrease, _type10.NpcTractorBeamIncreaseChance, _type10.NpcShipSpeedIncrease, _type10.NpcEvasionIncrease, _type10.NpcDamageIncrease, _type10.NpcCriticalDamageIncrease, _type10.NpcExtraShotChance, _type10.NpcVisionFieldIncrease, _type10.NpcStunChanceIncrease, _type10.NpcStunDurationIncrease, _type10.NpcMajorBreakThroughChance, _type10.NpcInventionBonusChance, _type10.NpcCloakChanceIncrease, _type10.NpcCloakAllChanceIncrease, _type10.NpcInstantKillIncrease, _type10.NpcStunResistanceChance, _type10.NpcTractorBeamResistanceChance, _type10.NpcCriticalHitResistance, _type10.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type11.NpcTypeName, _type11.NpcTypeID, _type11.NpcResourceIncrease, _type11.NpcEnergyConversion, _type11.NpcToHit, _type11.NpcCritHitChance, _type11.NpcXpBonus, _type11.NpcWeaponCoolDown, _type11.NpcHullIncrease, _type11.NpcShipVolumeIncrease, _type11.NpcTractorBeamIncreaseChance, _type11.NpcShipSpeedIncrease, _type11.NpcEvasionIncrease, _type11.NpcDamageIncrease, _type11.NpcCriticalDamageIncrease, _type11.NpcExtraShotChance, _type11.NpcVisionFieldIncrease, _type11.NpcStunChanceIncrease, _type11.NpcStunDurationIncrease, _type11.NpcMajorBreakThroughChance, _type11.NpcInventionBonusChance, _type11.NpcCloakChanceIncrease, _type11.NpcCloakAllChanceIncrease, _type11.NpcInstantKillIncrease, _type11.NpcStunResistanceChance, _type11.NpcTractorBeamResistanceChance, _type11.NpcCriticalHitResistance, _type11.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type12.NpcTypeName, _type12.NpcTypeID, _type12.NpcResourceIncrease, _type12.NpcEnergyConversion, _type12.NpcToHit, _type12.NpcCritHitChance, _type12.NpcXpBonus, _type12.NpcWeaponCoolDown, _type12.NpcHullIncrease, _type12.NpcShipVolumeIncrease, _type12.NpcTractorBeamIncreaseChance, _type12.NpcShipSpeedIncrease, _type12.NpcEvasionIncrease, _type12.NpcDamageIncrease, _type12.NpcCriticalDamageIncrease, _type12.NpcExtraShotChance, _type12.NpcVisionFieldIncrease, _type12.NpcStunChanceIncrease, _type12.NpcStunDurationIncrease, _type12.NpcMajorBreakThroughChance, _type12.NpcInventionBonusChance, _type12.NpcCloakChanceIncrease, _type12.NpcCloakAllChanceIncrease, _type12.NpcInstantKillIncrease, _type12.NpcStunResistanceChance, _type12.NpcTractorBeamResistanceChance, _type12.NpcCriticalHitResistance, _type12.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type13.NpcTypeName, _type13.NpcTypeID, _type13.NpcResourceIncrease, _type13.NpcEnergyConversion, _type13.NpcToHit, _type13.NpcCritHitChance, _type13.NpcXpBonus, _type13.NpcWeaponCoolDown, _type13.NpcHullIncrease, _type13.NpcShipVolumeIncrease, _type13.NpcTractorBeamIncreaseChance, _type13.NpcShipSpeedIncrease, _type13.NpcEvasionIncrease, _type13.NpcDamageIncrease, _type13.NpcCriticalDamageIncrease, _type13.NpcExtraShotChance, _type13.NpcVisionFieldIncrease, _type13.NpcStunChanceIncrease, _type13.NpcStunDurationIncrease, _type13.NpcMajorBreakThroughChance, _type13.NpcInventionBonusChance, _type13.NpcCloakChanceIncrease, _type13.NpcCloakAllChanceIncrease, _type13.NpcInstantKillIncrease, _type13.NpcStunResistanceChance, _type13.NpcTractorBeamResistanceChance, _type13.NpcCriticalHitResistance, _type13.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type14.NpcTypeName, _type14.NpcTypeID, _type14.NpcResourceIncrease, _type14.NpcEnergyConversion, _type14.NpcToHit, _type14.NpcCritHitChance, _type14.NpcXpBonus, _type14.NpcWeaponCoolDown, _type14.NpcHullIncrease, _type14.NpcShipVolumeIncrease, _type14.NpcTractorBeamIncreaseChance, _type14.NpcShipSpeedIncrease, _type14.NpcEvasionIncrease, _type14.NpcDamageIncrease, _type14.NpcCriticalDamageIncrease, _type14.NpcExtraShotChance, _type14.NpcVisionFieldIncrease, _type14.NpcStunChanceIncrease, _type14.NpcStunDurationIncrease, _type14.NpcMajorBreakThroughChance, _type14.NpcInventionBonusChance, _type14.NpcCloakChanceIncrease, _type14.NpcCloakAllChanceIncrease, _type14.NpcInstantKillIncrease, _type14.NpcStunResistanceChance, _type14.NpcTractorBeamResistanceChance, _type14.NpcCriticalHitResistance, _type14.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type15.NpcTypeName, _type15.NpcTypeID, _type15.NpcResourceIncrease, _type15.NpcEnergyConversion, _type15.NpcToHit, _type15.NpcCritHitChance, _type15.NpcXpBonus, _type15.NpcWeaponCoolDown, _type15.NpcHullIncrease, _type15.NpcShipVolumeIncrease, _type15.NpcTractorBeamIncreaseChance, _type15.NpcShipSpeedIncrease, _type15.NpcEvasionIncrease, _type15.NpcDamageIncrease, _type15.NpcCriticalDamageIncrease, _type15.NpcExtraShotChance, _type15.NpcVisionFieldIncrease, _type15.NpcStunChanceIncrease, _type15.NpcStunDurationIncrease, _type15.NpcMajorBreakThroughChance, _type15.NpcInventionBonusChance, _type15.NpcCloakChanceIncrease, _type15.NpcCloakAllChanceIncrease, _type15.NpcInstantKillIncrease, _type15.NpcStunResistanceChance, _type15.NpcTractorBeamResistanceChance, _type15.NpcCriticalHitResistance, _type15.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type16.NpcTypeName, _type16.NpcTypeID, _type16.NpcResourceIncrease, _type16.NpcEnergyConversion, _type16.NpcToHit, _type16.NpcCritHitChance, _type16.NpcXpBonus, _type16.NpcWeaponCoolDown, _type16.NpcHullIncrease, _type16.NpcShipVolumeIncrease, _type16.NpcTractorBeamIncreaseChance, _type16.NpcShipSpeedIncrease, _type16.NpcEvasionIncrease, _type16.NpcDamageIncrease, _type16.NpcCriticalDamageIncrease, _type16.NpcExtraShotChance, _type16.NpcVisionFieldIncrease, _type16.NpcStunChanceIncrease, _type16.NpcStunDurationIncrease, _type16.NpcMajorBreakThroughChance, _type16.NpcInventionBonusChance, _type16.NpcCloakChanceIncrease, _type16.NpcCloakAllChanceIncrease, _type16.NpcInstantKillIncrease, _type16.NpcStunResistanceChance, _type16.NpcTractorBeamResistanceChance, _type16.NpcCriticalHitResistance, _type16.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type17.NpcTypeName, _type17.NpcTypeID, _type17.NpcResourceIncrease, _type17.NpcEnergyConversion, _type17.NpcToHit, _type17.NpcCritHitChance, _type17.NpcXpBonus, _type17.NpcWeaponCoolDown, _type17.NpcHullIncrease, _type17.NpcShipVolumeIncrease, _type17.NpcTractorBeamIncreaseChance, _type17.NpcShipSpeedIncrease, _type17.NpcEvasionIncrease, _type17.NpcDamageIncrease, _type17.NpcCriticalDamageIncrease, _type17.NpcExtraShotChance, _type17.NpcVisionFieldIncrease, _type17.NpcStunChanceIncrease, _type17.NpcStunDurationIncrease, _type17.NpcMajorBreakThroughChance, _type17.NpcInventionBonusChance, _type17.NpcCloakChanceIncrease, _type17.NpcCloakAllChanceIncrease, _type17.NpcInstantKillIncrease, _type17.NpcStunResistanceChance, _type17.NpcTractorBeamResistanceChance, _type17.NpcCriticalHitResistance, _type17.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type18.NpcTypeName, _type18.NpcTypeID, _type18.NpcResourceIncrease, _type18.NpcEnergyConversion, _type18.NpcToHit, _type18.NpcCritHitChance, _type18.NpcXpBonus, _type18.NpcWeaponCoolDown, _type18.NpcHullIncrease, _type18.NpcShipVolumeIncrease, _type18.NpcTractorBeamIncreaseChance, _type18.NpcShipSpeedIncrease, _type18.NpcEvasionIncrease, _type18.NpcDamageIncrease, _type18.NpcCriticalDamageIncrease, _type18.NpcExtraShotChance, _type18.NpcVisionFieldIncrease, _type18.NpcStunChanceIncrease, _type18.NpcStunDurationIncrease, _type18.NpcMajorBreakThroughChance, _type18.NpcInventionBonusChance, _type18.NpcCloakChanceIncrease, _type18.NpcCloakAllChanceIncrease, _type18.NpcInstantKillIncrease, _type18.NpcStunResistanceChance, _type18.NpcTractorBeamResistanceChance, _type18.NpcCriticalHitResistance, _type18.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type19.NpcTypeName, _type19.NpcTypeID, _type19.NpcResourceIncrease, _type19.NpcEnergyConversion, _type19.NpcToHit, _type19.NpcCritHitChance, _type19.NpcXpBonus, _type19.NpcWeaponCoolDown, _type19.NpcHullIncrease, _type19.NpcShipVolumeIncrease, _type19.NpcTractorBeamIncreaseChance, _type19.NpcShipSpeedIncrease, _type19.NpcEvasionIncrease, _type19.NpcDamageIncrease, _type19.NpcCriticalDamageIncrease, _type19.NpcExtraShotChance, _type19.NpcVisionFieldIncrease, _type19.NpcStunChanceIncrease, _type19.NpcStunDurationIncrease, _type19.NpcMajorBreakThroughChance, _type19.NpcInventionBonusChance, _type19.NpcCloakChanceIncrease, _type19.NpcCloakAllChanceIncrease, _type19.NpcInstantKillIncrease, _type19.NpcStunResistanceChance, _type19.NpcTractorBeamResistanceChance, _type19.NpcCriticalHitResistance, _type19.NpcCriticalDamageResistance));
            npcType.Add(new BaseNPCType(_type20.NpcTypeName, _type20.NpcTypeID, _type20.NpcResourceIncrease, _type20.NpcEnergyConversion, _type20.NpcToHit, _type20.NpcCritHitChance, _type20.NpcXpBonus, _type20.NpcWeaponCoolDown, _type20.NpcHullIncrease, _type20.NpcShipVolumeIncrease, _type20.NpcTractorBeamIncreaseChance, _type20.NpcShipSpeedIncrease, _type20.NpcEvasionIncrease, _type20.NpcDamageIncrease, _type20.NpcCriticalDamageIncrease, _type20.NpcExtraShotChance, _type20.NpcVisionFieldIncrease, _type20.NpcStunChanceIncrease, _type20.NpcStunDurationIncrease, _type20.NpcMajorBreakThroughChance, _type20.NpcInventionBonusChance, _type20.NpcCloakChanceIncrease, _type20.NpcCloakAllChanceIncrease, _type20.NpcInstantKillIncrease, _type20.NpcStunResistanceChance, _type20.NpcTractorBeamResistanceChance, _type20.NpcCriticalHitResistance, _type20.NpcCriticalDamageResistance));

            #endregion

        }

        public float TypeAdjHull(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcHullIncrease;
                }
            }
            return 0;
        }

        public float TypeAdjSpeed(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcShipSpeedIncrease;
                }
            }
            return 0;
        }

        public float TypeAdjDamage(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcDamageIncrease;
                }
            }
            return 0;
        }

        public float TypeAdjWeaponCooldown(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcWeaponCoolDown;
                }
            }
            return 0;
        }

        public float TypeAdjShipVolume(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcShipVolumeIncrease;
                }
            }
            return 0;
        }

        public float TypeAdjEnergyConversion(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcEnergyConversion;
                }
            }
            return 0;
        }

        public float TypeAdjToHit(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcToHit;
                }
            }
            return 0;
        }

        public float TypeAdjCritHit(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcCritHitChance;
                }
            }
            return 0;
        }

        public float TypeAdjTractorBeamChance(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcTractorBeamIncreaseChance;
                }
            }
            return 0;
        }

        public float TypeAdjEvasion(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcEvasionIncrease;
                }
            }
            return 0;
        }

        public float TypeAdjCritDamageIncrease(int type)
        {
            foreach (var t in npcType)
            {
                if (t.NpcTypeID == type)
                {
                    return t.NpcCriticalDamageIncrease;
                }
            }
            return 0;
        }
    }
}
