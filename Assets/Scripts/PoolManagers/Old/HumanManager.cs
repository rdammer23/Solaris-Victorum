/*using Assets.Scripts.NPC_Classes.Ships;
using Assets.Scripts.Race_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.PoolManagers
{
    class HumanManager:MonoBehaviour
    {
        NPC_Classes.NPC newNPC;

        List<BaseNPCShip> _npcShip;

        public GameObject humanNPCPooler;

        private string poolerName = "NPCHuman";

        InitializePoolManagers poolManager;
        HumanRace _humanRace;

        int raceID = 1;

        public void Start()
        {
            newNPC = new NPC_Classes.NPC(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _npcShip, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            
            poolManager = new InitializePoolManagers();
            _humanRace = new HumanRace();
            

            GameObject[] gos = MultiTags.FindGameObjectsWithMultiTag(poolerName);

            int x = 1; //Used to rename NPC
            foreach (GameObject g in gos)
            {
                g.transform.name = poolManager.RenameNPC(g.transform, x);
                poolManager.AddToCorrectPooler(g, humanNPCPooler);

                newNPC.RaceID = raceID;

                if (x < 6)
                {
                    newNPC.TypeID = 5;
                }
                else
                {
                    newNPC.TypeID = poolManager.SetType();
                }

                newNPC.HobbyID = poolManager.SetHobby();

                newNPC.ShipID = poolManager.SetShipID(g);

                newNPC.NpcLevel = poolManager.SetNPCLevel();

                newNPC.HobbyLevel = poolManager.SetNPCHobbyLevel(newNPC.NpcLevel);

                //Set Attributes

                newNPC.Strength = poolManager.SetAttributeValues(_humanRace.RaceStrength, newNPC.NpcLevel);

                newNPC.Intelligence = poolManager.SetAttributeValues(_humanRace.RaceIntelligence, newNPC.NpcLevel);

                newNPC.Dexterity = poolManager.SetAttributeValues(_humanRace.RaceDexterity, newNPC.NpcLevel);

                newNPC.Wisdom = poolManager.SetAttributeValues(_humanRace.RaceWisdom, newNPC.NpcLevel);

                newNPC.Health = poolManager.SetAttributeValues(_humanRace.RaceHealth, newNPC.NpcLevel);

                newNPC.EagleEyes = poolManager.SetAttributeValues(_humanRace.RaceEagleEyes, newNPC.NpcLevel);

                newNPC.Speed = poolManager.SetAttributeValues(_humanRace.RaceSpeed, newNPC.NpcLevel);

                newNPC.Endurance = poolManager.SetAttributeValues(_humanRace.RaceEndurance, newNPC.NpcLevel);

                newNPC.NervesOfSteel = poolManager.SetAttributeValues(_humanRace.RaceNervesOfSteel, newNPC.NpcLevel);

                newNPC.Charisma = poolManager.SetAttributeValues(_humanRace.RaceCharisma, newNPC.NpcLevel);

                //Stats that need Attribute
                newNPC.NpcToHit = poolManager.ToHit(newNPC.EagleEyes, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);
                
//This requires a ship modifier
                newNPC.NpcEvasionIncrease = poolManager.Evasion(newNPC.Dexterity, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcHullIncrease = poolManager.HullIncrease(newNPC.Health, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcDamageIncrease = poolManager.DamageIncrease(newNPC.Strength, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcShipSpeedIncrease = poolManager.ShipSpeedIncrease(newNPC.Endurance, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcWeaponCoolDown = poolManager.WeaponCoolDownDecrease(newNPC.Speed, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcCritHitChance = poolManager.CritChanceIncrease(newNPC.NervesOfSteel, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                //Stats that DO NOT Need Attributes
                newNPC.NpcCriticalDamageIncrease = poolManager.CritDamageIncrease(newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcExtraShotChance = poolManager.ExtraShotChance(newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcStunChanceIncrease = poolManager.StunChanceIncrease(newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcStunDurationIncrease = poolManager.StunDurationIncrease(newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcTractorBeamIncreaseChance = poolManager.TractorBeamChanceIncrease(newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcEnergyConversion = poolManager.EnergyConversion(newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcCloakChanceIncrease = poolManager.CloakChanceIncrease(newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcCloakAllChanceIncrease = poolManager.CloakAllChanceIncrease(newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcInstantKillIncrease = poolManager.InstantKillChanceIncrease(newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);


                /*
                Debug.Log("newNPC.NpcToHit " + newNPC.NpcToHit);

                Debug.Log("newNPC.NpcEvasionIncrease" + newNPC.NpcEvasionIncrease);

                Debug.Log("newNPC.NpcHullIncrease" + newNPC.NpcHullIncrease);

                Debug.Log("newNPC.NpcDamageIncrease" + newNPC.NpcDamageIncrease);

                Debug.Log("newNPC.NpcShipSpeedIncrease" + newNPC.NpcShipSpeedIncrease);

                Debug.Log("newNPC.NpcWeaponCoolDown" + newNPC.NpcWeaponCoolDown);

                Debug.Log("newNPC.NpcCritHitChance" + newNPC.NpcCritHitChance);

                Debug.Log("newNPC.NpcCriticalDamageIncrease" + newNPC.NpcCriticalDamageIncrease);

                Debug.Log("newNPC.NpcExtraShotChance" + newNPC.NpcExtraShotChance);

                Debug.Log("newNPC.NpcStunChanceIncrease" + newNPC.NpcStunChanceIncrease);

                Debug.Log("newNPC.NpcStunDurationIncrease" + newNPC.NpcStunDurationIncrease);

                Debug.Log("newNPC.NpcTractorBeamIncreaseChance" + newNPC.NpcTractorBeamIncreaseChance);

                Debug.Log("newNPC.NpcEnergyConversion" + newNPC.NpcEnergyConversion);

                Debug.Log("newNPC.NpcCloakChanceIncrease" + newNPC.NpcCloakChanceIncrease);

                Debug.Log("newNPC.NpcCloakAllChanceIncrease" + newNPC.NpcCloakAllChanceIncrease);

                Debug.Log("newNPC.NpcInstantKillIncrease" + newNPC.NpcInstantKillIncrease);
                */

                //Stats that Need Ship and Possibly Attribute Adjustments
                /*
                _npcShip = poolManager.SetShipStats(g);
                

                foreach (var s in _npcShip)
                {
                    newNPC.MaxHealth = poolManager.MaxHealth(newNPC.NpcHullIncrease, s.Hull);

                    newNPC.WanderSpeed = poolManager.SpeedAdjustment(newNPC.NpcShipSpeedIncrease, s.WanderSpeed);
                    newNPC.WanderTurnSpeed = poolManager.TurnSpeedAdjustment(s.WanderSpeedTurnSpeedFactor, newNPC.WanderSpeed);

                    newNPC.PatrolSpeed = poolManager.SpeedAdjustment(newNPC.NpcShipSpeedIncrease, s.PatrolSpeed);
                    newNPC.PatrolTurnSpeed = poolManager.TurnSpeedAdjustment(s.PatrolSpeedTurnFactor, newNPC.PatrolSpeed);


                    newNPC.FollowMaxSpeed = poolManager.SpeedAdjustment(newNPC.NpcShipSpeedIncrease, s.FollowMaxSpeed);
                    newNPC.FollowTurnSpeed = poolManager.TurnSpeedAdjustment(s.FollowTurnSpeedFactor, newNPC.FollowMaxSpeed);

                    newNPC.AttackSpeed = poolManager.SpeedAdjustment(newNPC.NpcShipSpeedIncrease, s.AttackSpeed);
                    newNPC.AttackTurnSpeed = poolManager.TurnSpeedAdjustment(s.AttackTurnSpeedFactor, newNPC.AttackSpeed);

                    newNPC.AvoidanceSpeed = poolManager.SpeedAdjustment(newNPC.NpcShipSpeedIncrease, s.AvoidanceSpeed);
                    newNPC.AvoidanceTurnSpeed = poolManager.TurnSpeedAdjustment(s.AvoidanceTurnSpeedFactor, newNPC.AvoidanceSpeed);
                    newNPC.AvoidanceDistance = s.AvoidanceDistance;

                    newNPC.MaxShipVolume = poolManager.ShipVolume(newNPC.Intelligence, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel, s.MaxShipVolume);

                    newNPC.MaxWeaponDamage = poolManager.MaxDamage(newNPC.NpcDamageIncrease, s.MaxWeaponDamage);
                    Debug.Log(s.MaxWeaponDamage);
                    Debug.Log(newNPC.MaxWeaponDamage);
                }
                /*


                NEED DATA FROM SHIP........DO LAST
                    public float ShipVolumeIncrease(float attributeValue, int typeID, int hobbyID, int hobbyLevel)
                    {
                        return ((attributeValue * _attributeAdj.Intelligence()) + (_hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID));
                    }

                */
                /*

                x++;
            }
        }
    }
}
    */