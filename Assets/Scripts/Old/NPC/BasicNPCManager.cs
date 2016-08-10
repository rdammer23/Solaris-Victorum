using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC
{
    class BasicNPCManager:MonoBehaviour
    {
        //Setup and Spawning Variables
        string npcName;
        public GameObject objectToSpawn;
        private int pooledObjects = 5;
        private int numNPCOnStart = 1;
        private int numNPCToActivate = 1;
        private int minNPCHealth = 50;
        private int maxNPCHealth = 100;

        static RandomNumber _randNum;

        public List<GameObject> basicNPC;
        public List<Vector3> basicNPCSpawnPTs;
        static List<NPC> _npc;  //I changed this to static to get health to state manager

        

        public GameObject basicNPCPooler;
        GameObject npcGO;

        private float spawnTimer = 0;
        private int timeToSpawn = 3; //10;

        private int randSpawnPt;

        //Damage Variables
        private float damageMultiplier;
        static int damageTaken;
        static string damagedNPC;

        public Transform explosion;
        public Transform LaserHitEffect;
        Transform smallLaserHitExplosion;
        Transform largeExplosion;

        static private bool laserBeamHit = false;

        BasicNPCStateManager _npcStateManager;



        void Awake()
        {
            _randNum = new RandomNumber();
            _npcStateManager = new BasicNPCStateManager();
        }

        void Start()
        {
            _npc = new List<NPC>();

            GameObject[] basicNPCSpawn = MultiTags.FindGameObjectsWithMultiTag("BasicNPCSpawn");
            foreach (GameObject spawn in basicNPCSpawn)
            {
                basicNPCSpawnPTs.Add(spawn.transform.position);
            }

            for (int i = 0; i < pooledObjects; i++)
            {
                randSpawnPt = _randNum.RandomNumberInt(1, basicNPCSpawnPTs.Count)-1;
                Instantiate(objectToSpawn, basicNPCSpawnPTs[randSpawnPt], Quaternion.identity);
            }

            GameObject[] gos = MultiTags.FindGameObjectsWithMultiTag("BasicNPC");
            int x = 0;
            foreach (GameObject g in gos)
            {
                basicNPC.Add(g);
                g.transform.name = g.transform.name + x;
                g.transform.parent = basicNPCPooler.transform;
                g.SetActive(false);
                _npc.Add(new NPC(g.transform.name, _randNum.RandomNumberInt(minNPCHealth, maxNPCHealth)));
                x++;
            }

            ActivateNPC(numNPCOnStart);

            smallLaserHitExplosion = Instantiate(LaserHitEffect, transform.position, Quaternion.identity) as Transform; // Make Effect.
            smallLaserHitExplosion.gameObject.SetActive(false);

            largeExplosion = Instantiate(explosion, transform.position, Quaternion.identity) as Transform;
            largeExplosion.gameObject.SetActive(false);
        }
        
        void Update()
        {
            if (spawnTimer >= timeToSpawn)
            {
                ActivateNPC(numNPCToActivate);
            }
            spawnTimer = spawnTimer + Time.deltaTime;

            if (laserBeamHit)
            {
                ReduceHealth();
                laserBeamHit = false;
            }
        }

        public void ActivateNPC(int numToActivate)
        {
            for (int i = 0; i < numToActivate; i++)
            {
                npcGO = GetPooledObject();
                if (npcGO == null)
                {
                    return;
                }
                else
                {
                    randSpawnPt = _randNum.RandomNumberInt(1, basicNPCSpawnPTs.Count) - 1;
                    npcGO.transform.position = basicNPCSpawnPTs[randSpawnPt];
                    foreach (NPC npc in _npc)
                    {
                        if(npcGO.transform.name == npc.NpcName)
                        {
                            npc.HitPoints = _randNum.RandomNumberInt(minNPCHealth, maxNPCHealth);
                        }
                    }
                    npcGO.SetActive(true);
                    spawnTimer = 0;
                }
            }
        }

        public GameObject GetPooledObject()
        {
            for (int i = 0; i < basicNPC.Count; i++)
            {
                if (!basicNPC[i].activeInHierarchy)
                {
                    return basicNPC[i];
                }
            }
            return null;
        }

        public void HitByLaser(int laserDamageMultiplier, string damagedNpcName)
        {
            damageMultiplier = laserDamageMultiplier;
            laserBeamHit = true;
            damagedNPC = damagedNpcName;
            damageTaken = (int)(_randNum.RandomNumberInt(10, 20) * damageMultiplier);

            //TODO Will need to add some rounding here in order to handle decimals properly.
        }

        public int GetHealth(string npcName)
        {
            foreach (NPC npc in _npc)
            {
                if(npc.NpcName == npcName)
                {
                    return npc.HitPoints;
                }
            }
            return 0;
        }

        public void ResetHealth(string npcName)
        {
            foreach (NPC npc in _npc)
            {
                if (npc.NpcName == npcName)
                {
                    npc.HitPoints = _randNum.RandomNumberInt(minNPCHealth, maxNPCHealth);
                }
            }
        }

        public void ReduceHealth()
        {
            foreach (NPC npc in _npc)
            {
                if(npc.NpcName == damagedNPC)
                {
                    smallLaserHitExplosion.gameObject.SetActive(false);
                    var npcLocation = GameObject.Find(npc.NpcName).transform;
                    LaserExplosion(npcLocation);
                    npc.HitPoints = npc.HitPoints - damageTaken;
                    Debug.Log(npc.HitPoints + " " + npc.NpcName);
                    if(npc.HitPoints <= 0)
                    {
                        largeExplosion.gameObject.SetActive(false);
                        ShipExplosion(npcLocation);
                    }
                }
            }
        }

        private void LaserExplosion(Transform npcTransofrm)
        {
            smallLaserHitExplosion.transform.position = npcTransofrm.position;
            smallLaserHitExplosion.gameObject.SetActive(true);
        }

        private void ShipExplosion(Transform npcTransofrm)
        {
            largeExplosion.transform.position = npcTransofrm.position;
            largeExplosion.gameObject.SetActive(true);
        }
    }
}
