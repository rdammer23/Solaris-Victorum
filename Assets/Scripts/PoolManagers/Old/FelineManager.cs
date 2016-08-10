/*using Assets.Scripts.NPC_Classes.Ships;
using Assets.Scripts.Race_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.PoolManagers
{
    class FelineManager:MonoBehaviour
    {
        NPC_Classes.NPC newNPC;

        List<BaseNPCShip> _npcShip;

        public GameObject felineNPCPooler;

        private string poolerName = "NPCFeline";

        InitializePoolManagers poolManager;
        FelineRace _felineRace;

        int raceID = 2;

        public void Start()
        {
            newNPC = new NPC_Classes.NPC(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _npcShip, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            poolManager = new InitializePoolManagers();
            _felineRace = new FelineRace();

            GameObject[] gos = MultiTags.FindGameObjectsWithMultiTag(poolerName);

            int x = 1; //Used to rename NPC
            foreach (GameObject g in gos)
            {
                g.transform.name = poolManager.RenameNPC(g.transform, x);
                poolManager.AddToCorrectPooler(g, felineNPCPooler);

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

                newNPC.Strength = poolManager.SetAttributeValues(_felineRace.RaceStrength, newNPC.NpcLevel);

                newNPC.Intelligence = poolManager.SetAttributeValues(_felineRace.RaceIntelligence, newNPC.NpcLevel);

                newNPC.Dexterity = poolManager.SetAttributeValues(_felineRace.RaceDexterity, newNPC.NpcLevel);

                newNPC.Wisdom = poolManager.SetAttributeValues(_felineRace.RaceWisdom, newNPC.NpcLevel);

                newNPC.Health = poolManager.SetAttributeValues(_felineRace.RaceHealth, newNPC.NpcLevel);

                newNPC.EagleEyes = poolManager.SetAttributeValues(_felineRace.RaceEagleEyes, newNPC.NpcLevel);

                newNPC.Speed = poolManager.SetAttributeValues(_felineRace.RaceSpeed, newNPC.NpcLevel);

                newNPC.Endurance = poolManager.SetAttributeValues(_felineRace.RaceEndurance, newNPC.NpcLevel);

                newNPC.NervesOfSteel = poolManager.SetAttributeValues(_felineRace.RaceNervesOfSteel, newNPC.NpcLevel);

                newNPC.Charisma = poolManager.SetAttributeValues(_felineRace.RaceCharisma, newNPC.NpcLevel);

                newNPC.NpcToHit = poolManager.ToHit(newNPC.EagleEyes, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcEvasionIncrease = poolManager.Evasion(newNPC.Dexterity, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcHullIncrease = poolManager.HullIncrease(newNPC.Health, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                newNPC.NpcDamageIncrease = poolManager.DamageIncrease(newNPC.Strength, newNPC.TypeID, newNPC.HobbyID, newNPC.HobbyLevel);

                //Debug.Log("Feline NPC Damage Bonus = " + newNPC.NpcDamageIncrease);
                

                x++;
            }
        }
    }
}
*/