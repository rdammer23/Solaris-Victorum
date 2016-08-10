using Assets.Scripts.PoolManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Solar_System_Manager
{
    class NPCInitializer:MonoBehaviour
    {
        /*
        *. Will need to know the Planet Race owner of each planet
        *. For each race create 3-5 Type 5 NPC
        *. For each race create 5-7 T1-4 NPC
        *. Determine the correct Ship
        *. Pool The NPCs and deactivate them
        *. Need to add colliders to all ships
        *. Need to add Gun Mount Locations to all ships
        *. Figure out Patrol points, etc.

        *. The below is all used when NPC is reactivated from NPCManager
        *. Determine NPC Level
        *. Determine NPC Hobby
        *. Determine Hobby Level
        *. Determine Attribute Bonuses and apply
        *. Determine Spawn Location
        */

        //Ships
        private GameObject tempNPC;

        public GameObject humanShip1;
        public GameObject humanShip2;
        public GameObject humanShip3;

        public GameObject felineShip1;
        public GameObject felineShip2;
        public GameObject felineShip3;

        int maxPlanet = 2;  //This is really RaceID for testing purposes

        RandomNumber randNum;

        private void Awake()
        {
            randNum = new RandomNumber();
            
            for (int i = 0; i < maxPlanet; i++)
            {
                int numShip = randNum.RandomNumberInt(10, 15);
                for (int numShips = 0; numShips < numShip; numShips++)
                {
                    GetCorrectShip(i);
                }
            }
            

            //GetComponentInChildren<HumanManager>().enabled = true;
            //GetComponentInChildren<FelineManager>().enabled = true;
        }

        public void GetCorrectShip(int i)
        {
            i++; //i is the planet ID, which gives me race of planet
            int r;
            switch (i)
            {
                case 1:
                    //int r = GameData.Planet1PlanetOriginalOwnerRace;
                    r = 1;
                    InstantiateShip(r);
                    break;

                case 2:
                    //int r = GameData.Planet1PlanetOriginalOwnerRace;
                    r = 2;
                    InstantiateShip(r);
                    break;
            }

        }

        public void InstantiateShip(int r)
        {
            switch (r)
            {

                case 1:
                    switch (randNum.RandomNumberInt(1, 3))
                    {
                        case 1:

                            tempNPC = (GameObject)Instantiate(humanShip1);
                            tempNPC.AddTag("NPCHuman");
                            tempNPC.AddTag("Ship1");
                            break;
                        case 2:
                            tempNPC = (GameObject)Instantiate(humanShip2);
                            tempNPC.AddTag("NPCHuman");
                            tempNPC.AddTag("Ship2");
                            break;
                        case 3:
                            tempNPC = (GameObject)Instantiate(humanShip3);
                            tempNPC.AddTag("NPCHuman");
                            tempNPC.AddTag("Ship3");
                            break;
                    }
                    break;
                case 2:
                    switch (randNum.RandomNumberInt(1, 3))
                    {
                        case 1:
                            tempNPC = (GameObject)Instantiate(felineShip1);
                            tempNPC.AddTag("NPCFeline");
                            tempNPC.AddTag("Ship1");
                            break;
                        case 2:
                            tempNPC = (GameObject)Instantiate(felineShip2);
                            tempNPC.AddTag("NPCFeline");
                            tempNPC.AddTag("Ship2");
                            break;
                        case 3:
                            tempNPC = (GameObject)Instantiate(felineShip3);
                            tempNPC.AddTag("NPCFeline");
                            tempNPC.AddTag("Ship3");
                            break;
                    }
                    break;
            }
        }
    }
}
