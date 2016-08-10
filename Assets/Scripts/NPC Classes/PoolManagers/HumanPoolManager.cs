using Assets.Scripts.Moon_Classes;
using Assets.Scripts.NPC_Classes.StateManager;
using Assets.Scripts.Planet_Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes.PoolManagers
{
    class HumanPoolManager:MonoBehaviour
    {
        /*
        Start will Initialize the NPCs and Create the Pool
        */
        private int raceID = 1;
        private string homePlanet = "Planet";
        private string raceName = "Human";
        private GameObject homePlanetGO;
        public GameObject spawnPointName;
        public GameObject patrolPointNameGO;

        private string shuttleShipName = "Shuttle";
        private string tinyShipName = "Tiny Ship";
        private string smallShipName = "Small Ship";
        private string tempShipName;

        private string moonTag = "Moon";

        private int numNPCtoStart = 20;
        private int numPatrolShips = 7; //TODO Will need to make this semi random
        private bool increaseNumNPC = false;
        private int npcMaxStartLevel;
        private int numToActivateAtStart = 1;
        private int typeOfNPC = 0;
        private int spawnLocation = 0;
        private int minDist = 10000;
        private int maxDist = 25000;
        private int x;
        private int y;
        private int z;
        private int xSign;
        private int ySign;
        private int zSign;
        private int numPlanetPatrolPoints; //This is determined based on number of moons, more moons, more patrol points out into space
        private int numMoonPatrolPoints = 6; //This is per moon
        private int patrolPointRandomDist; //Used to create a random distanace for Patrol point based on moonDist
        private int patrolPointPathToMoonDistance = 200;

        #region NPC Spawn In Game
        private float spawnTimer = 0;
        private int timeToSpawn = 10000;
        private int numToActivate = 1;
        #endregion

        private float moonDist = 0f; //Distance of moon from planet along X axis only
        private float minPatrolPointDistFactor = .65f;
        private float maxPatrolPointDistFactor = .95f;

        static bool needHumanNPCType = false;
        static string currentHumanNPCName;
        private int currentNPCTypeID;

        //May need to change the name of all these to be unique based on race, hope I do not need to though
        public GameObject shuttleShip;
        public GameObject tinyShip;
        public GameObject smallShip;
        public GameObject poolManager;
        public GameObject npcGO; //This is the NPC to Activate
        private GameObject tempGO; //Used to temp hold a newly instantiated GameObject

        Transform tempLocation;
        Transform[] planetChildren;

        private GameObject[] npcPool;
        private GameObject[] spawnPoints;
        private GameObject[] patrolPoints;
        

        public List<GameObject> pooledNPC;
        public List<GameObject> moons;

        private RandomNumber randNum;
        private InitializeNPC initNPC;
        private InstantiateNPC instantiateNPC;
        private PatrolPointManagerHuman patrolPointManager; //This needs to change name for each race
        private NPCNameLable npcNameLable;

        static List<NPC> humanNPC;

        #region Leveling Stuff
        private float timeToLevelCounter = 0;
        private int timeToLevelCheck = 10;
        LevelNPC levelNPC;
        private bool readyToLevel = false;
        #endregion

        public void Awake()
        {
            humanNPC = new List<NPC>();
            randNum = new RandomNumber();
            initNPC = new InitializeNPC();
            instantiateNPC = new InstantiateNPC();
            patrolPointManager = new PatrolPointManagerHuman();
            levelNPC = new LevelNPC();
           // humanNPC = new List<NPC>();
        }

        public void Start()
        {
            //FindHomePlanet();
            PatrolPoints();
            ActivatePatrolPointManager();
            npcNameLable = new NPCNameLable();

            for (int i = 0; i < numNPCtoStart; i++)
            {
                //humanNPC = initNPC.BuildNPC(numPatrolShips, raceID, i, numPatrolShips, randNum, humanNPC, raceName);
                humanNPC = initNPC.BuildNPC(raceID, i, randNum, humanNPC, raceName);
            }
            int counter = 1;
            foreach (NPC n in humanNPC)
            {
                tempShipName = ShipName(n.ShipID);
                GameObject shipGO = ShipGO(n.ShipID);
                instantiateNPC.InstantiateShip(tempShipName, raceName, shipGO, poolManager, counter, n.NpcName);
                counter++;
            }

            npcPool = MultiTags.FindGameObjectsWithMultiTag(raceName);

            foreach (GameObject g in npcPool)
            {
                pooledNPC.Add(g);
                g.SetActive(false);
            }
            
            SpawnPoints();
            ActivateShip(numToActivateAtStart);
            ActivateOrbits();
            
        }

        void Update()
        {
            CheckIfNPCShouldLevel();

            if (spawnTimer >= timeToSpawn)
            {
                ActivateShip(numToActivate);
                
            }
            spawnTimer = spawnTimer + Time.deltaTime;
        }

        public void CheckIfNPCShouldLevel()
        {
            if(timeToLevelCounter >= timeToLevelCheck)
            {
                //Need to go through each NPC
                timeToLevelCounter = 0;
                for (int i = 0; i < pooledNPC.Count; i++)
                {
                    if (pooledNPC[i].activeInHierarchy)
                    {
                        foreach (NPC n in humanNPC)
                        {
                            if(pooledNPC[i].transform.name == n.NpcName)
                            {
                                NewNPCLevelCheck(n);
                                npcNameLable = pooledNPC[i].GetComponentInChildren<NPCNameLable>();
                                npcNameLable.UpdateDisplay();
                            }
                        }
                    }
                }
            }
            else
            {
                timeToLevelCounter += Time.deltaTime;
            }
        }

        private void NewNPCLevelCheck(NPC n)
        {
            switch ((int)n.Level / 10)
            {
                case 0:
                    readyToLevel = true;
                    break;
                case 1:
                    if(randNum.RandomNumberInt(1, 2) == 1)
                    {
                        readyToLevel = true;
                    }
                    break;
                case 2:
                    if (randNum.RandomNumberInt(1, 3) == 1)
                    {
                        readyToLevel = true;
                    }
                    break;
                case 3:
                    if (randNum.RandomNumberInt(1, 4) == 1)
                    {
                        readyToLevel = true;
                    }
                    break;
                case 4:
                    if (randNum.RandomNumberInt(1, 5) == 1)
                    {
                        readyToLevel = true;
                    }
                    break;
                case 5:
                    if (randNum.RandomNumberInt(1, 6) == 1)
                    {
                        readyToLevel = true;
                    }
                    break;
                default:
                    if (randNum.RandomNumberInt(1, 7) == 1)
                    {
                        readyToLevel = true;
                    }
                    break;
            }
            if (readyToLevel)
            {
                n = levelNPC.LevelingNPC(n, raceID);
                readyToLevel = false;
            }
        }

        public GameObject GetPooledObject()
        {
            for (int i = 0; i < pooledNPC.Count; i++)
            {
                if (!pooledNPC[i].activeInHierarchy)
                {
                    return pooledNPC[i];
                }
            }
            return null;
        }

        private void ActivateShip(int numActivations)
        {
            spawnTimer = 0;
            for (int i = 0; i < numActivations; i++)
            {
                npcGO = GetPooledObject();
                if (npcGO == null)
                {
                    return;
                }
                else //Need to check and see what the type is, if 1 then do this
                {
                    typeOfNPC = 0;
                    foreach (NPC n in humanNPC)
                    {
                        if(this.npcGO.transform.name == n.NpcName)
                        {
                            typeOfNPC = n.TypeID;
                        }
                    }
                    if(typeOfNPC == 1 || typeOfNPC == 3 || typeOfNPC == 6)
                    {
                        InitialSpawnPointLocaiontPlanet(spawnLocation);
                        spawnLocation += 5;
                        if(spawnLocation >= spawnPoints.Length)
                        {
                            spawnLocation = spawnLocation - spawnPoints.Length;
                        }
                    }
                    else
                    {
                        DeepSpaceSpawnLocations();
                    }
                }
            }
        }

        public int NumSign()
        {
            return randNum.RandomNumberInt(1, 2);

        }

        private void ActivatePatrolPointManager()
        {
            GameObject.FindObjectOfType<PatrolPointManagerHuman>().enabled = true;
        }

        private void PatrolPoints()
        {
            planetChildren = homePlanetGO.GetComponentsInChildren<Transform>();
            //Add moons of this planet to a list
            foreach (Transform t in planetChildren)
            {
                if (t.gameObject.tag == moonTag)
                {
                    moons.Add(t.gameObject);
                }
            }
            InstantiatePlanetPatrolPoints();
            InstantiateMoonPatrolPoints();

        }

        private void InstantiateMoonPatrolPoints()
        {
            foreach (GameObject m in moons)
            {
                xSign = 1;
                ySign = 1;
                zSign = 1;
                for (int i = 0; i < 2; i++)
                {
                    patrolPointRandomDist = randNum.RandomNumberInt(50, 150);
                    tempGO = Instantiate(patrolPointNameGO, new Vector3(m.transform.position.x, m.transform.position.y, m.transform.position.z), Quaternion.identity) as GameObject;
                    tempGO.transform.parent = m.transform;
                    tempGO.transform.position = m.transform.position;
                    tempGO.transform.localPosition = new Vector3(patrolPointRandomDist * xSign, 0, 0);
                    tempGO.name = "PP" + m.name;
                    xSign = -1 * xSign;
                }

                for (int i = 0; i < 2; i++)
                {
                    patrolPointRandomDist = randNum.RandomNumberInt(50, 150);
                    tempGO = Instantiate(patrolPointNameGO, new Vector3(m.transform.position.x, m.transform.position.y, m.transform.position.z), Quaternion.identity) as GameObject;
                    tempGO.transform.parent = m.transform;
                    tempGO.transform.position = m.transform.position;
                    tempGO.transform.localPosition = new Vector3(0, patrolPointRandomDist * ySign, 0);
                    tempGO.name = "PP" + m.name;
                    ySign = -1 * ySign;
                }

                for (int i = 0; i < 2; i++)
                {
                    patrolPointRandomDist = randNum.RandomNumberInt(50, 150);
                    tempGO = Instantiate(patrolPointNameGO, new Vector3(m.transform.position.x, m.transform.position.y, m.transform.position.z), Quaternion.identity) as GameObject;
                    tempGO.transform.parent = m.transform;
                    tempGO.transform.position = m.transform.position;
                    tempGO.transform.localPosition = new Vector3(0, 0, patrolPointRandomDist * zSign);
                    tempGO.name = "PP" + m.name;
                    zSign = -1 * zSign;
                }
                InstantiatePatrolPointPathToMoon(m.transform);
            }
        }

        private void InstantiatePatrolPointPathToMoon(Transform currentMoon)
        {
            if ((homePlanetGO.transform.position.x - currentMoon.transform.position.x) > patrolPointPathToMoonDistance)
            {
                int numPatrolPointsToMoon = (int)((homePlanetGO.transform.position.x - currentMoon.transform.position.x) / patrolPointPathToMoonDistance);
                for (int i = 0; i < numPatrolPointsToMoon; i++)
                {
                    tempGO = Instantiate(patrolPointNameGO, new Vector3(currentMoon.transform.position.x, currentMoon.transform.position.y, currentMoon.transform.position.z), Quaternion.identity) as GameObject;
                    tempGO.transform.parent = currentMoon.transform;
                    tempGO.transform.position = currentMoon.transform.position;
                    tempGO.transform.localPosition = new Vector3(tempGO.transform.localPosition.x + (i+1*(patrolPointPathToMoonDistance)), 0, 0);
                    tempGO.name = "PP" + currentMoon.name + "PathToMoon";
                }
            }
        }

        private void InstantiatePlanetPatrolPoints()
        {
            /*
            First Layer of Patrol points should be between planet and first moon
            Instantiate the patrol point, parent to planet and then set in place
            Use distance between planet and first moon as guide.  
            If Dist = 200, take .25 as low range and .75 as upper range
            */
            foreach (GameObject m in moons)
            {
             if (moonDist == 0)
                {
                    moonDist = homePlanetGO.transform.position.x - m.transform.position.x;
                }
             else if (moonDist > homePlanetGO.transform.position.x - m.transform.position.x)
                {
                    moonDist = homePlanetGO.transform.position.x - m.transform.position.x;
                }
            }
            PatrolPointsAroundEquator();
            PatrolPointsAroundPoles();
            PatrolPointsAtCorners();

        }

        private void PatrolPointsAroundEquator()
        {
            xSign = 1;
            for (int i = 0; i < 2; i++)
            {
                zSign = 1;
                for (int o = 0; o < 2; o++)
                {
                    //Debug.Log((tempGO.name + " " + moonDist * minPatrolPointDistFactor) + " " + (moonDist * maxPatrolPointDistFactor));
                    patrolPointRandomDist = randNum.RandomNumberInt((int)(moonDist * minPatrolPointDistFactor), (int)(moonDist * maxPatrolPointDistFactor));
                    tempGO = Instantiate(patrolPointNameGO, new Vector3(homePlanetGO.transform.position.x, homePlanetGO.transform.position.y, homePlanetGO.transform.position.z), Quaternion.identity) as GameObject;
                    tempGO.transform.parent = homePlanetGO.transform;
                    tempGO.transform.position = homePlanetGO.transform.position;
                    tempGO.transform.localPosition = new Vector3(patrolPointRandomDist * xSign, 0, patrolPointRandomDist * zSign);
                    zSign = -1 * zSign;
                }
                xSign = -1 * xSign;
            }
        }

        private void PatrolPointsAroundPoles()
        {
            ySign = 1;
            for (int i = 0; i < 2; i++)
            {
                patrolPointRandomDist = randNum.RandomNumberInt((int)(moonDist * minPatrolPointDistFactor), (int)(moonDist * maxPatrolPointDistFactor));
                tempGO = Instantiate(patrolPointNameGO, new Vector3(homePlanetGO.transform.position.x, homePlanetGO.transform.position.y, homePlanetGO.transform.position.z), Quaternion.identity) as GameObject;
                tempGO.transform.parent = homePlanetGO.transform;
                tempGO.transform.position = homePlanetGO.transform.position;
                tempGO.transform.localPosition = new Vector3(0, patrolPointRandomDist * ySign, 0);
                ySign = -1 * ySign;
            }
        }

        private void PatrolPointsAtCorners()
        {
            xSign = 1;
            ySign = 1;
            zSign = 1;

            for (int i = 0; i < 2; i++)
            {
                for (int o = 0; o < 2; o++)
                {
                    for (int e = 0; e < 2; e++)
                    {
                        patrolPointRandomDist = randNum.RandomNumberInt((int)(moonDist * minPatrolPointDistFactor), (int)(moonDist * maxPatrolPointDistFactor));
                        tempGO = Instantiate(patrolPointNameGO, new Vector3(homePlanetGO.transform.position.x, homePlanetGO.transform.position.y, homePlanetGO.transform.position.z), Quaternion.identity) as GameObject;
                        tempGO.transform.parent = homePlanetGO.transform;
                        tempGO.transform.position = homePlanetGO.transform.position;
                        tempGO.transform.localPosition = new Vector3(patrolPointRandomDist * xSign, patrolPointRandomDist * ySign, patrolPointRandomDist * zSign);
                        zSign = -1 * zSign;
                    }
                    ySign = -1 * ySign;
                }
                xSign = -1 * xSign;
            }
        }

        private void DeepSpaceSpawnLocations()
        {
            if(NumSign() == 1)
            {
                x = (-(randNum.RandomNumberInt(minDist, maxDist)));
            }
            else
            {
                x = randNum.RandomNumberInt(minDist, maxDist);
            }
            if (NumSign() == 1)
            {
                y = (-(randNum.RandomNumberInt(minDist, maxDist)));
            }
            else
            {
                y = randNum.RandomNumberInt(minDist, maxDist);
            }
            if (NumSign() == 1)
            {
                z = (-(randNum.RandomNumberInt(minDist, maxDist)));
            }
            else
            {
                z = randNum.RandomNumberInt(minDist, maxDist);
            }

            npcGO.transform.position = new Vector3(x, y, z);
            npcGO.SetActive(true);
        }

        private void InitialSpawnPointLocaiontPlanet(int spawnLocation)
        {
            tempLocation = spawnPoints.ElementAt(spawnLocation).transform;
            //spawnLocation = randNum.RandomNumberInt(1, spawnPoints.Length);
            //tempLocation = spawnPoints.ElementAt(spawnLocation - 1).transform;
            npcGO.transform.position = tempLocation.position;
            npcGO.SetActive(true);
        }

        private void SpawnPoints()
        {
            spawnPoints = MultiTags.FindGameObjectsWithMultiTag("HumanPatrolPoint");
            /*
            Commented out once SpawnPoints once Patrol Points Doubled as Spawn Points
            
            Instantiate(spawnPointName, new Vector3(homePlanetGO.transform.position.x + 100, homePlanetGO.transform.position.y, homePlanetGO.transform.position.z), Quaternion.identity);
            Instantiate(spawnPointName, new Vector3(homePlanetGO.transform.position.x - 100, homePlanetGO.transform.position.y, homePlanetGO.transform.position.z), Quaternion.identity);
            Instantiate(spawnPointName, new Vector3(homePlanetGO.transform.position.x, homePlanetGO.transform.position.y + 100, homePlanetGO.transform.position.z), Quaternion.identity);
            Instantiate(spawnPointName, new Vector3(homePlanetGO.transform.position.x, homePlanetGO.transform.position.y - 100, homePlanetGO.transform.position.z), Quaternion.identity);
            Instantiate(spawnPointName, new Vector3(homePlanetGO.transform.position.x, homePlanetGO.transform.position.y, homePlanetGO.transform.position.z + 100), Quaternion.identity);
            Instantiate(spawnPointName, new Vector3(homePlanetGO.transform.position.x, homePlanetGO.transform.position.y, homePlanetGO.transform.position.z - 100), Quaternion.identity);
            
            spawnPoints = GameObject.FindGameObjectsWithTag("HumanSpawnPoint");
            foreach (GameObject s in spawnPoints)
            {
                s.transform.parent = homePlanetGO.transform;
            }
            */
        }

        /*       private void FindHomePlanet()
               {
                   if(GameData.Planet1PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet1PlanetID;
                   }
                   else if(GameData.Planet2PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet2PlanetID;
                   }
                   else if (GameData.Planet3PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet3PlanetID;
                   }
                   else if (GameData.Planet4PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet4PlanetID;
                   }
                   else if (GameData.Planet5PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet5PlanetID;
                   }
                   else if (GameData.Planet6PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet6PlanetID;
                   }
                   else if (GameData.Planet7PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet7PlanetID;
                   }
                   else if (GameData.Planet8PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet8PlanetID;
                   }
                   else if (GameData.Planet9PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet9PlanetID;
                   }
                   else if (GameData.Planet10PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet10PlanetID;
                   }
                   else if (GameData.Planet11PlanetOriginalOwnerRace == raceID)
                   {
                       homePlanet += GameData.Planet11PlanetID;
                   }
                   homePlanetGO = GameObject.Find(homePlanet);
               }
       */

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

        private GameObject ShipGO(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return shuttleShip;
                case 2:
                    return tinyShip;
                case 3:
                    return smallShip;
                default:
                    return null;
            }
        }

        public float GetWanderSpeed(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if(n.NpcName == npcName)
                {
                    return n.WanderSpeed;
                }
            }
            return 0f;
        }

        public float GetWanderTurnSpeedFactor(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.WanderSpeedTurnFactor;
                }
            }
            return 0f;
        }

        public float GetPatrolSpeed(string npcName)
        {
            foreach  (NPC n in humanNPC)
            {
                if(n.NpcName == npcName)
                {
                    return n.PatrolSpeed;
                }
            }
            return 0f;
        }

        public float GetPatrolTurnSpeedFactor(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.PatrolSpeedTurnFactor;
                }
            }
            return 0f;
        }

        public float GetFollowMaxDistance(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.FollowMaxDistance;
                }
            }
            return 0f;
        }

        public float GetFollowMinDistance(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.FollowMinDistance;
                }
            }
            return 0f;
        }

        public float GetFollowMaxSpeed(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.FollowMaxSpeed;
                }
            }
            return 0f;
        }

        public float GetFollowTurnSpeedFactor(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.FollowSpeedTurnFactor;
                }
            }
            return 0f;
        }

        public float GetFollowMaxFindPlayerDistance(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.FindPlayerRange;
                }
            }
            return 0f;
        }

        public float GetAttackTurnDistance(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.AttackTurnDistance;
                }
            }
            return 0f;
        }

        public float GetAttackSpeed(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.AttackSpeed;
                }
            }
            return 0f;
        }

        public float GetAttackMaxDistance(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.AttackMaxDistance;
                }
            }
            return 0f;
        }

        public float GetAttackMinDistance(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.AttackMinDistance;
                }
            }
            return 0f;
        }

        public float GetAttackSpeedTurnFactor(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.AttackSpeedTurnFactor;
                }
            }
            return 0f;
        }

        public float GetAttackWeaponCoolDown(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.WeaponCoolDown;
                }
            }
            return 0f;
        }

        public float GetAvoidanceSpeed(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.AvoidanceSpeed;
                }
            }
            return 0f;
        }

        public float GetAvoidanceTurnSpeedFactor(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.AvoidanceSpeedTurnFactor;
                }
            }
            return 0f;
        }

        public float GetAvoidanceDistance(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.AvoidanceDistance;
                }
            }
            return 0f;
        }

        public float GetMaxHealth(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.MaxHealth;
                }
            }
            return 0;
        }

        private void GetNPCType()
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == currentHumanNPCName)
                {
                    currentNPCTypeID = n.TypeID;
                    break;
                }
                else
                {
                    currentNPCTypeID = 0;
                }
            }
            needHumanNPCType = false;
        }

        public int NPCType(string currentName)
        {
            currentHumanNPCName = currentName;
            needHumanNPCType = true;
            GetNPCType();
            return currentNPCTypeID;
        }

        public string GetTypeName(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.TypeName;
                }
            }
            return "No Type";
        }

        public int NPCHobbyID(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.HobbyID;
                }
            }
            return 1;
        }

        public int NPCHobbyLevel(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.HobbyLevel;
                }
            }
            return 1;
        }

        public int GetLevel(string npcName)
        {
            foreach (NPC n in humanNPC)
            {
                if (n.NpcName == npcName)
                {
                    return n.Level;
                }
            }
            return 0;
        }

        public string GetRaceName()
        {
            return raceName;
        }

        private void ActivateOrbits()
        {
            //planetChildren = homePlanetGO.GetComponentsInChildren<Transform>();
            //Add moons of this planet to a list
            foreach (Transform t in planetChildren)
            {
                if (t.gameObject.tag == moonTag)
                {
                    t.gameObject.GetComponent<MoonOrbit>().enabled = true;
                }
            }
            homePlanetGO.GetComponent<PlanetOrbit>().enabled = true;
        }
    }
}
