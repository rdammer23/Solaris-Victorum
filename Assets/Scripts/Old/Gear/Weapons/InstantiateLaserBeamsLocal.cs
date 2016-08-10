using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Gear.Weapons
{
    class InstantiateLaserBeamsLocal:MonoBehaviour
    {
        public GameObject objectToSpawn;
        private GameObject objectSpawned;
        private Vector3 direction;
        private Ray ray;

        private int pooledObjects = 10;
        static bool fireLaser = false;

        static Vector3 laserPT;
        static Quaternion laserRotation;

        public List<GameObject> laserPulse;

        private float spawnTimer = 1.5f;
        private float timeToSpawn = 1.5f;

        private Transform laser = null;

        Vector3 laserOffset = new Vector3(0, 0, 2);  

        void Start()
        {
            for (int i = 0; i < pooledObjects; i++)
            {
                objectSpawned = Instantiate(objectToSpawn, Vector3.zero, Quaternion.identity) as GameObject;
                laserPulse.Add(objectSpawned);
                objectSpawned.SetActive(false);
            }
        }

        void Update()
        {
            if (spawnTimer >= timeToSpawn && fireLaser)
            {
                if (laser == null)
                {
                    laser = GameObject.FindGameObjectWithTag("LaserMount").transform;
                }
                GameObject pulseGO = GetPooledObject();
                laserPT = new Vector3(laser.position.x, laser.position.y, laser.position.z);
                laserRotation = Quaternion.FromToRotation(this.transform.forward, direction) * this.transform.rotation;
                if (pulseGO == null)
                {
                    return;
                }
                else
                {
                    pulseGO.transform.position = laserPT;
                    pulseGO.transform.rotation = laserRotation;
                    pulseGO.SetActive(true);
                    spawnTimer = 0;
                    fireLaser = false;
                }
            }
            else
            {
                fireLaser = false;
            }
            spawnTimer = spawnTimer + Time.deltaTime;
        }

        public void FireLaser()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            }

            if (Input.touchCount > 0)
            {
                ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            }
            direction = ray.direction;
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
    }
}
