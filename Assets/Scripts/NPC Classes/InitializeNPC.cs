using Assets.Scripts.Attributes;
using Assets.Scripts.Hobby;
using Assets.Scripts.Ship;
using Assets.Scripts.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class InitializeNPC:MonoBehaviour
    {
        private HobbyNPC hobby;
        private ShipNPC ship;
        private TypesNPC type;
        private AttributeStatModNPC attributeModifier;
        private AttributeValueNPC attributeValue;

        private int startDefaultAttributeValue = 10;
        private int hobbyCount = 20;
        private int typeCount = 20;
        private int shipCount = 3;

        //public List<NPC> BuildNPC(int numberPatrolShips, int raceID, int npcCount, int numPatrolShips, RandomNumber randNum, List<NPC> npcList, string raceName)
        public List<NPC> BuildNPC(int npcRaceID, int npcCount, RandomNumber randNum, List<NPC> npcList, string raceName)

        {
            //randNum = new RandomNumber();
            hobby = new HobbyNPC();
            ship = new ShipNPC();
            type = new TypesNPC();
            attributeModifier = new AttributeStatModNPC();
            attributeValue = new AttributeValueNPC();
            int raceID = npcRaceID;
            int npcLevel = NPCLevel(randNum);
            //Debug.Log("NPC Level:" + npcLevel);

            //Next we need to figure out the attributes for each NPC
            //This allows the calculation of anything that needs an attribute
            //Need Race ID and NPC Level
            float strength = (startDefaultAttributeValue + (npcLevel - 1)) * attributeValue.NPCStrength(raceID);
            float intelligence = (startDefaultAttributeValue + (npcLevel - 1)) * attributeValue.NPCIntelligence(raceID);
            float dexterity = (startDefaultAttributeValue + (npcLevel - 1)) * attributeValue.NPCDexterity(raceID);
            float wisdom = (startDefaultAttributeValue + (npcLevel - 1)) * attributeValue.NPCWisdom(raceID);
            float health = (startDefaultAttributeValue + (npcLevel - 1)) * attributeValue.NPCHealth(raceID);
            float eagleEyes = (startDefaultAttributeValue + (npcLevel - 1)) * attributeValue.NPCEagleEyes(raceID);
            float speed = (startDefaultAttributeValue + (npcLevel - 1)) * attributeValue.NPCSpeed(raceID);
            float endurance = (startDefaultAttributeValue + (npcLevel - 1)) * attributeValue.NPCEndurance(raceID);
            float nervesSteel = (startDefaultAttributeValue + (npcLevel - 1)) * attributeValue.NPCNervesOfSteel(raceID);
            float charisma = (startDefaultAttributeValue + (npcLevel - 1)) * attributeValue.NPCCharisma(raceID);

            int hobbyID = randNum.RandomNumberInt(1, hobbyCount);
            int shipID = randNum.RandomNumberInt(1, shipCount);
            int typeID = NPCType(randNum);
            int hobbyLevel = npcLevel + randNum.RandomNumberInt(1, 5);

            int maxHealth = (int)(ship.ShipHull(shipID) * (attributeModifier.HealthHull(health) + hobby.Hull(hobbyID, hobbyLevel) + type.Hull(typeID, npcLevel) + 1));
            int currentHealth = maxHealth;

            string typeName = type.TypeName(typeID);

            float xpBonus = 1 + hobby.XPBonus(hobbyID, hobbyLevel) + attributeModifier.WisdomXPBonus(wisdom);
            float resourceBonus = 1 + hobby.Resources(hobbyID, hobbyLevel) + type.Resources(typeID, npcLevel);
            float shipVolume = ship.MaxShipVolume(shipID) * (attributeModifier.IntelligenceShipVolume(intelligence) + hobby.ShipVolume(hobbyID, hobbyLevel) + type.ShipVolume(typeID, npcLevel) + 1);

            float toHit = attributeModifier.NervesOfSteelToHit(nervesSteel) + hobby.ToHit(hobbyID, hobbyLevel) + type.ToHit(typeID, npcLevel) + 1;
            int maxDamage = (int)(ship.MaxWeaponDamage(shipID) * (attributeModifier.StrengthDamage(strength) + hobby.Damage(hobbyID, hobbyLevel) + type.Damage(typeID, npcLevel) + 1));
            int minDamage = (int)(ship.MinWeaponDamage(shipID) * (attributeModifier.StrengthDamage(strength) + hobby.Damage(hobbyID, hobbyLevel) + type.Damage(typeID, npcLevel) + 1));
            float damageReduction = type.DamageReduction(typeID, npcLevel);

            float critHitChance = attributeModifier.EagleEyesCritHitChance(eagleEyes) + hobby.CritHitChance(hobbyID, hobbyLevel) + type.CritHitChance(typeID, npcLevel);
            int critDamage = (int)((hobby.CriticalDamage(hobbyID, hobbyLevel) + type.CriticalDamage(typeID, npcLevel) + 1));
            float critHitResist = type.CriticalHitResistance(typeID, npcLevel);
            float critHitReduction = type.CriticalHitReduction(typeID, npcLevel);

            float weaponCoolDownReduction = ship.WeaponCoolDown(shipID) - (attributeModifier.SpeedWeaponCoolDown(speed) + hobby.WeaponCoolDown(hobbyID, hobbyLevel) + type.WeaponCoolDown(typeID, npcLevel));

            int findPlayerDistance = (int)(ship.FindPlayerDistance(shipID) * (hobby.FindPlayer(hobbyID, hobbyLevel) + type.FindPlayer(typeID, npcLevel) + 1));

            float evasion = (ship.EvasionModifier(shipID) + (attributeModifier.DexterityEvasion(dexterity) + hobby.Evasion(hobbyID, hobbyLevel) + type.Evasion(typeID, npcLevel)));

            float tractorBeamChance = hobby.TractorBeamChance(hobbyID, hobbyLevel) + type.TractorBeamChance(typeID, npcLevel);
            float tractorBeamResist = type.TractorBeamResistance(typeID, npcLevel);

            float stunChance = hobby.StunChance(hobbyID, hobbyLevel) + type.StunChance(typeID, npcLevel);
            float stunDuration = hobby.StunDuration(hobbyID, hobbyLevel) + type.StunDuration(typeID, npcLevel);
            float stunResist = type.StunResistance(typeID, npcLevel);

            float extraShot = hobby.ExtraShot(hobbyID, hobbyLevel) + type.ExtraShot(typeID, npcLevel);
            float energyConversion = hobby.EnergyConversion(hobbyID, hobbyLevel) + type.EnergyConversion(typeID, npcLevel);
            float majorBreakThrough = hobby.MajorBreakThrough(hobbyID, hobbyLevel) + type.MajorBreakThrough(typeID, npcLevel);
            float invention = hobby.Invention(hobbyID, hobbyLevel) + type.Invention(typeID, npcLevel);

            float cloakChance = hobby.CloakChance(hobbyID, hobbyLevel) + type.CloakChance(typeID, npcLevel);
            float cloakAllChance = hobby.CloakAllChance(hobbyID, hobbyLevel) + type.CloakAllChance(typeID, npcLevel);
            float instantKillChance = hobby.InstantKillChance(hobbyID, hobbyLevel) + type.InstantKillChance(typeID, npcLevel);

            float wanderSpeed = (ship.WanderSpeed(shipID) + (attributeModifier.EnduranceShipSpeedIncrease(endurance) + attributeModifier.SpeedShipSpeedIncrease(speed) + hobby.ShipSpeed(hobbyID, hobbyLevel) + type.ShipSpeed(typeID, npcLevel)));
            float wanderSpeedTurnFactor = ship.WanderSpeedTurnFactor(shipID);

            float patrolSpeed = (ship.PatrolSpeed(shipID) + (attributeModifier.EnduranceShipSpeedIncrease(endurance) + attributeModifier.SpeedShipSpeedIncrease(speed) + hobby.ShipSpeed(hobbyID, hobbyLevel) + type.ShipSpeed(typeID, npcLevel)));
            float patrolSpeedTurnFactor = ship.PatrolSpeedTurnFactor(shipID);

            float followMaxSpeed = (ship.FollowMaxSpeed(shipID) + (attributeModifier.EnduranceShipSpeedIncrease(endurance) + attributeModifier.SpeedShipSpeedIncrease(speed) + hobby.ShipSpeed(hobbyID, hobbyLevel) + type.ShipSpeed(typeID, npcLevel)));
            float followSpeedTurnFactor = ship.FollowSpeedTurnFactor(shipID);
            float followMaxDistance = ship.FollowMaxDistance(shipID);
            float followMinDistance = ship.FollowMinDistance(shipID);

            float attackSpeed = (ship.AttackSpeed(shipID) + (attributeModifier.EnduranceShipSpeedIncrease(endurance) + attributeModifier.SpeedShipSpeedIncrease(speed) + hobby.ShipSpeed(hobbyID, hobbyLevel) + type.ShipSpeed(typeID, npcLevel)));
            float attackSpeedTurnFactor = ship.AttackSpeedTurnFactor(shipID);
            float attackTurnDistance = ship.AttackTurnDistance(shipID);
            float attackMaxDistance = ship.AttackMaxDistance(shipID);
            float attackMinDistance = ship.AttackMinDistance(shipID);

            float avoidanceSpeed = (ship.AvoidanceSpeed(shipID) + (attributeModifier.EnduranceShipSpeedIncrease(endurance) + attributeModifier.SpeedShipSpeedIncrease(speed) + hobby.ShipSpeed(hobbyID, hobbyLevel) + type.ShipSpeed(typeID, npcLevel)));
            float avoidanceSpeedTurnFactor = ship.AvoidanceSpeedTurnFactor(shipID);
            float avoidanceDistance = ship.AvoidanceDistance(shipID);

            string npcName = raceName + (npcCount);

            npcList.Add(new NPC(raceID, npcName, npcLevel, maxHealth, currentHealth, shipID, hobbyID, hobbyLevel, typeID, typeName, xpBonus,
                resourceBonus, shipVolume, toHit, maxDamage, minDamage, damageReduction, critHitChance, critDamage, 
                critHitResist, critHitReduction, weaponCoolDownReduction, findPlayerDistance, evasion, tractorBeamChance,
                tractorBeamResist, stunChance, stunDuration, stunResist, extraShot, energyConversion, majorBreakThrough,
                invention, cloakChance, cloakAllChance, instantKillChance, wanderSpeed, wanderSpeedTurnFactor, 
                patrolSpeed, patrolSpeedTurnFactor, followMaxSpeed, followSpeedTurnFactor, followMaxDistance, followMinDistance,
                attackSpeed, attackSpeedTurnFactor, attackTurnDistance, attackMaxDistance, attackMinDistance, 
                avoidanceDistance, avoidanceSpeed, avoidanceSpeedTurnFactor));
            return npcList;
        }

        public int NPCType(RandomNumber randNum)
        {
            return randNum.RandomNumberInt(1, typeCount);
        }
        /* Old Function used when I wanted a certain number of patrol ships around planet
        public int NPCType(int count, int numPatrolShips, RandomNumber randNum)
        {
            if(count < numPatrolShips)
            {
                return 1;
            }
            return randNum.RandomNumberInt(1, typeCount);
        }
        */
        public int NPCLevel(RandomNumber randNum)
        {
            int minNPCLevel;
            if(GameData.PlayerLevel < 5)
            {
                minNPCLevel = 1;
            }
            else
            {
                minNPCLevel = GameData.PlayerLevel;
            }

            int maxNPCLevel = minNPCLevel + 10;
            return randNum.RandomNumberInt(minNPCLevel, maxNPCLevel);
        }
    }
}
