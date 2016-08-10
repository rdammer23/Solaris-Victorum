/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BeardedManStudios.Network;
*/
namespace Assets.Scripts.Gear.Weapons
{/*
    class InstantiateLasersBeams:SimpleNetworkedMonoBehavior
    {
        public GameObject objectToSpawn;
        private int pooledObjects = 10;
        static bool fireLaser = false;

        static Vector3 laserPT;
        static Quaternion laserRotation;

        public List<GameObject> laserPulse;

        private float spawnTimer = 5f;
        private float timeToSpawn = .5f;

        Transform laser;

        void Start()
        {
            for (int i = 0; i < pooledObjects; i++)
            {
                if (NetworkingManager.Socket == null || NetworkingManager.Socket.Connected)
                {
                    Networking.Instantiate(objectToSpawn, new Vector3(995.77f, -0.5367f, .57f), Quaternion.identity,
                        NetworkReceivers.AllBuffered, LaserPulseSpawned);
                }
                else
                {
                    NetworkingManager.Instance.OwningNetWorker.connected += delegate ()
                    {
                        Networking.Instantiate(objectToSpawn, new Vector3(995.77f, -0.5367f, .57f), Quaternion.identity,
                        NetworkReceivers.AllBuffered, LaserPulseSpawned);
                    };
                }
            }
            laser = transform.Find("Laser").transform;
            
        }

        void Update()
        {
            if (spawnTimer >= timeToSpawn && fireLaser)
            {
                GameObject pulseGO = GetPooledObject();
                laserPT = new Vector3(laser.position.x, laser.position.y, laser.position.z);
                laserRotation = this.transform.rotation;
                if (pulseGO == null)
                {
                    return;
                }
                else
                {
                    pulseGO.transform.position = laserPT;
                    pulseGO.transform.rotation = laserRotation;
                    Debug.Log("Transform position " + laserPT);
                    Debug.Log("Rotation = " + laserRotation);
                    pulseGO.SetActive(true);
                    spawnTimer = 0;
                    fireLaser = false;
                }
            }
            spawnTimer = spawnTimer + Time.deltaTime;
        }

        public void FireLaser()
        {
            fireLaser = true;
        }

        public GameObject GetPooledObject()
        {
            for (int i = 0; i < laserPulse.Count; i++)
            {
                if (!laserPulse[i].activeInHierarchy)
                {
                    return laserPulse[i];
                }
            }
            return null;
        }

        private void LaserPulseSpawned(SimpleNetworkedMonoBehavior obj)
        {
            
            Debug.Log("The NPC with ID " + obj.name + " has spawned at " +
                "X: " + obj.transform.position.x +
                "Y: " + obj.transform.position.y +
                "Z: " + obj.transform.position.z);
            
            GameObject beam = GameObject.Find(obj.name);
            Debug.Log("This.Transform = " + this.transform);
            //beam.transform.parent = this.transform;
            beam.SetActive(false);
            laserPulse.Add(beam);
        }
    }
*/}
