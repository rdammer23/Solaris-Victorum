/*using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;
using BeardedManStudios.Network;

namespace Assets.Scripts.NPC
{
    class InstantiateNPC:SimpleNetworkedMonoBehavior
    {
        string npcName;
        public GameObject objectToSpawn;
        public int pooledObjects = 5;

        public Vector3 SpawnPosition = Vector3.zero;

        //This is to make the NPC move when reactivated. 
        //Will be removed once Real NPC functions added to the game
        int x = 100;

        public List<GameObject> basicNPC;

        public int spawnTimer = 0;
        public int timeToSpawn = 250;

        void Start()
        {
            if (Networking.PrimarySocket.IsServer)
            {
                for (int i = 0; i < pooledObjects; i++)
                {
                    npcName = objectToSpawn.name + i.ToString();
                    if (NetworkingManager.Socket == null || NetworkingManager.Socket.Connected)
                    {
                        Networking.Instantiate(objectToSpawn, npcName, Vector3.zero, Quaternion.identity,
                            NetworkReceivers.AllBuffered, NPCSpawned);
                    }
                    else
                    {
                        NetworkingManager.Instance.OwningNetWorker.connected += delegate ()
                        {
                            Networking.Instantiate(objectToSpawn, npcName, Vector3.zero, Quaternion.identity,
                            NetworkReceivers.AllBuffered, NPCSpawned);
                        };
                    }
                }
            }
        }

        void Update()
        {
            if (Networking.PrimarySocket.IsServer)
            {
                if (spawnTimer >= timeToSpawn)
                {
                    GameObject npcGO = GetPooledObject();
                    if (npcGO == null)
                    {
                        return;
                    }
                    else
                    {
                        npcGO.transform.position = new Vector3(x, 0, 0);
                        x = x + 100;
                        npcGO.SetActive(true);
                        spawnTimer = 0;
                    }

                }
                spawnTimer = spawnTimer + 1;
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

        private void NPCSpawned(SimpleNetworkedMonoBehavior obj)
        {
            
            Debug.Log("The NPC with ID " + obj.name + " has spawned at " +
                "X: " + obj.transform.position.x +
                "Y: " + obj.transform.position.y +
                "Z: " + obj.transform.position.z);
            
            GameObject npcName = GameObject.Find(obj.name);
            npcName.SetActive(false);
            basicNPC.Add(npcName);
        }

        [BRPC]
        private void NPCInactive(GameObject npcName)
        {
            if (npcName.activeSelf)
            {
                return;
            }
            else
            {
                npcName.SetActive(false);
            }
        }
    }
}
*/