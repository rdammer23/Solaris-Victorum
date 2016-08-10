using Assets.Scripts.Attributes;
using Assets.Scripts.Hobby;
using Assets.Scripts.Ship;
using Assets.Scripts.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes.StateManager
{
    class LevelNPC:MonoBehaviour
    {
        RandomNumber randNum;
        private ShipNPC ship;
        private AttributeStatModNPC attributeModifier;
        private AttributeValueNPC attributeValue;
        private HobbyNPC hobby;
        private TypesNPC type;

        private int startDefaultAttributeValue = 10;

        public NPC LevelingNPC(NPC n, int raceID)
        {
            randNum = new RandomNumber();
            ship = new ShipNPC();
            attributeModifier = new AttributeStatModNPC();
            attributeValue = new AttributeValueNPC();
            hobby = new HobbyNPC();
            type = new TypesNPC();

            n.Level += 1;
            n.HobbyLevel += randNum.RandomNumberInt(0, 2);
            n.MaxHealth = ((int)(ship.ShipHull(n.ShipID) * (attributeModifier.HealthHull((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCHealth(raceID)) + hobby.Hull(n.HobbyID, n.HobbyLevel) + type.Hull(n.TypeID, n.Level) + 1)));
            n.XpBonus = 1 + hobby.XPBonus(n.HobbyID, n.HobbyLevel) + attributeModifier.WisdomXPBonus(startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCWisdom(raceID);
            n.Resources = 1 + hobby.Resources(n.HobbyID, n.HobbyLevel) + type.Resources(n.TypeID, n.Level);
            n.ShipVolume = ship.MaxShipVolume(n.ShipID) * (attributeModifier.IntelligenceShipVolume((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCIntelligence(raceID)) + hobby.ShipVolume(n.HobbyID, n.HobbyLevel) + type.ShipVolume(n.TypeID, n.Level) + 1);
            n.ToHit = attributeModifier.NervesOfSteelToHit((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCNervesOfSteel(raceID)) + hobby.ToHit(n.HobbyID, n.HobbyLevel) + type.ToHit(n.TypeID, n.Level) + 1;
            n.MaxDamage = (int)(ship.MaxWeaponDamage(n.ShipID) * (attributeModifier.StrengthDamage((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCStrength(raceID)) + hobby.Damage(n.HobbyID, n.HobbyLevel) + type.Damage(n.TypeID, n.Level) + 1));
            n.MinDamage = (int)(ship.MinWeaponDamage(n.ShipID) * (attributeModifier.StrengthDamage((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCStrength(raceID)) + hobby.Damage(n.HobbyID, n.HobbyLevel) + type.Damage(n.TypeID, n.Level) + 1));
            n.CritHitChance = attributeModifier.EagleEyesCritHitChance((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCEagleEyes(raceID)) + hobby.CritHitChance(n.HobbyID, n.HobbyLevel) + type.CritHitChance(n.TypeID, n.Level);
            n.CritDamage = (int)((hobby.CriticalDamage(n.HobbyID, n.HobbyLevel) + type.CriticalDamage(n.TypeID, n.Level) + 1));
            n.WeaponCoolDown = ship.WeaponCoolDown(n.ShipID) - (attributeModifier.SpeedWeaponCoolDown((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCSpeed(raceID)) + hobby.WeaponCoolDown(n.HobbyID, n.HobbyLevel) + type.WeaponCoolDown(n.TypeID, n.Level));
            n.FindPlayerRange = (int)(ship.FindPlayerDistance(n.ShipID) * (hobby.FindPlayer(n.HobbyID, n.HobbyLevel) + type.FindPlayer(n.TypeID, n.Level) + 1));
            n.Evasion = (ship.EvasionModifier(n.ShipID) + (attributeModifier.DexterityEvasion((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCDexterity(raceID)) + hobby.Evasion(n.HobbyID, n.HobbyLevel) + type.Evasion(n.TypeID, n.Level)));
            n.TractorBeamChance = hobby.TractorBeamChance(n.HobbyID, n.HobbyLevel) + type.TractorBeamChance(n.TypeID, n.Level);
            n.StunChance = hobby.StunChance(n.HobbyID, n.HobbyLevel) + type.StunChance(n.TypeID, n.Level);
            n.StunDuration = hobby.StunDuration(n.HobbyID, n.HobbyLevel) + type.StunDuration(n.TypeID, n.Level);
            n.ExtraShotChance = hobby.ExtraShot(n.HobbyID, n.HobbyLevel) + type.ExtraShot(n.TypeID, n.Level);
            n.EnergyConversion = hobby.EnergyConversion(n.HobbyID, n.HobbyLevel) + type.EnergyConversion(n.TypeID, n.Level);
            n.MajorBreakThrough = hobby.MajorBreakThrough(n.HobbyID, n.HobbyLevel) + type.MajorBreakThrough(n.TypeID, n.Level);
            n.Invention = hobby.Invention(n.HobbyID, n.HobbyLevel) + type.Invention(n.TypeID, n.Level);
            n.CloakChance = hobby.CloakChance(n.HobbyID, n.HobbyLevel) + type.CloakChance(n.TypeID, n.Level);
            n.CloakAllChance = hobby.CloakAllChance(n.HobbyID, n.HobbyLevel) + type.CloakAllChance(n.TypeID, n.Level);
            n.InstantKillChance = hobby.InstantKillChance(n.HobbyID, n.HobbyLevel) + type.InstantKillChance(n.TypeID, n.Level);
            n.WanderSpeed = (ship.WanderSpeed(n.ShipID) + (attributeModifier.EnduranceShipSpeedIncrease((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCEndurance(raceID)) + attributeModifier.SpeedShipSpeedIncrease((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCSpeed(raceID)) + hobby.ShipSpeed(n.HobbyID, n.HobbyLevel) + type.ShipSpeed(n.TypeID, n.Level)));
            n.PatrolSpeed = (ship.PatrolSpeed(n.ShipID) + (attributeModifier.EnduranceShipSpeedIncrease((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCEndurance(raceID)) + attributeModifier.SpeedShipSpeedIncrease((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCSpeed(raceID)) + hobby.ShipSpeed(n.HobbyID, n.HobbyLevel) + type.ShipSpeed(n.TypeID, n.Level)));
            n.FollowMaxSpeed = (ship.FollowMaxSpeed(n.ShipID) + (attributeModifier.EnduranceShipSpeedIncrease((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCEndurance(raceID)) + attributeModifier.SpeedShipSpeedIncrease((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCSpeed(raceID)) + hobby.ShipSpeed(n.HobbyID, n.HobbyLevel) + type.ShipSpeed(n.TypeID, n.Level)));
            n.AttackSpeed = (ship.AttackSpeed(n.ShipID) + (attributeModifier.EnduranceShipSpeedIncrease((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCEndurance(raceID)) + attributeModifier.SpeedShipSpeedIncrease((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCSpeed(raceID)) + hobby.ShipSpeed(n.HobbyID, n.HobbyLevel) + type.ShipSpeed(n.TypeID, n.Level)));
            n.AvoidanceSpeed = (ship.AvoidanceSpeed(n.ShipID) + (attributeModifier.EnduranceShipSpeedIncrease((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCEndurance(raceID)) + attributeModifier.SpeedShipSpeedIncrease((startDefaultAttributeValue + (n.Level - 1)) * attributeValue.NPCSpeed(raceID)) + hobby.ShipSpeed(n.HobbyID, n.HobbyLevel) + type.ShipSpeed(n.TypeID, n.Level)));
            return n;
        }
    }
}
