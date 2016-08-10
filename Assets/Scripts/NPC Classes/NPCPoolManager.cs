using Assets.Scripts.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    /*
    This will contain all NPCs in a Solar System
    List NPC
    Need to know what Solar System is active
    in order to determine how many NPC of each race to instantiate
    */

    class NPCPoolManager :MonoBehaviour
    {
        static List<NPC> NPCList;

        int numberOfRaces = 11;
        int numberNPCperRace = 20; //20  
        int npcFactorIncrease = 10; // 5 // This * numberNPCperRace = number NPC for solar system race


        int raceID;
        string raceName;
        string tempShipName;
        private string shuttleShipName = "Shuttle";
        private string tinyShipName = "Tiny Ship";
        private string smallShipName = "Small Ship";

        private InitializeNPC initNPC;
        private RandomNumber randNum;

        void Awake()
        {
            NPCList = new List<NPC>();
            initNPC = new NPC_Classes.InitializeNPC();
            randNum = new RandomNumber();
        }

        public void InitializeNPC(int ssid)
        {
            for (int x = 1; x <= numberOfRaces; x++)
            {
                raceID = x;
                raceName = RaceName(raceID);

                for (int i = 1; i <= numberNPCperRace; i++)
                {
                    NPCList = initNPC.BuildNPC(raceID, i, randNum, NPCList, raceName);
                }

                if (raceID == ssid - 1000)
                {
                    for (int z = 1; z <= ((numberNPCperRace * npcFactorIncrease) - numberNPCperRace); z++)
                    {
                        NPCList = initNPC.BuildNPC(raceID, z+numberNPCperRace, randNum, NPCList, raceName);
                    }
                }

            }
            int counter = 1;
            foreach (NPC n in NPCList)
            {
                GetComponentInParent<NPCInstantiate>().CreateNPC(n.ShipID, n.RaceID, n.NpcName, ssid);
                counter++;
            }
            //After all NPCs Instantiated, need to Launch Player Ship
            GetComponentInParent<InstantiatePlayer>().LoadPlayerShip();
        }

        private string ShipName(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return shuttleShipName;
                case 2:
                    return tinyShipName;
                case 3:
                    return smallShipName;
                default:
                    return "Error Getting Ship Name";
            }
        }

        private string RaceName(int raceID)
        {
            switch (raceID)
            {
                case 1:
                    return "Human";
                case 2:
                    return "Karakal";
                case 3:
                    return "Aves";
                case 4:
                    return "Esoteric";
                case 5:
                    return "Nische";
                case 6:
                    return "Tricho";
                case 7:
                    return "Mavin";
                case 8:
                    return "Estati";
                case 9:
                    return "Teiid";
                case 10:
                    return "Roidal";
                case 11:
                    return "Aerifo";
                default:
                    return "UNK";
            }
        }

        public int GetLevel(string npcName)
        {
            foreach (NPC n in NPCList)
            {
                if (n.NpcName == npcName)
                {
                    return n.Level;
                }
            }
            return 0;
        }

        public string GetRaceName(string npcName)
        {
            foreach (NPC n in NPCList)
            {
                if (n.NpcName == npcName)
                {
                    return raceName;
                }
            }
            return "UNK";
        }

        public string GetTypeName(string npcName)
        {
            foreach (NPC n in NPCList)
            {
                if (n.NpcName == npcName)
                {
                    return n.TypeName;
                }
            }
            return "No Type";
        }

        public int GetTypeInt(string npcName)
        {
            foreach (NPC n in NPCList)
            {
                if (n.NpcName == npcName)
                {
                    return n.TypeID;
                }
            }
            return 0;
        }

        public float GetMaxHealth(string npcName)
        {
            foreach (NPC n in NPCList)
            {
                if (n.NpcName == npcName)
                {
                    return n.MaxHealth;
                }
            }
            return 0;
        }

        public float GetWanderSpeed(string npcName)
        {
            foreach (NPC n in NPCList)
            {
                if (n.NpcName == npcName)
                {
                    //Debug.Log("BAM");
                    return n.WanderSpeed;
                }
            }
            return 0f;
        }

        public float GetWanderTurnSpeedFactor(string npcName)
        {
            foreach (NPC n in NPCList)
            {
                if (n.NpcName == npcName)
                {
                    return n.WanderSpeedTurnFactor;
                }
            }
            return 0f;
        }
    }
}
