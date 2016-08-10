using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class NPCLaserInstantiate:MonoBehaviour
    {
        /*
        Need to determine what LaserBeams to Instantiate
        Build a Pool Manager for each type
        Move Laser and Destroy Laser will be on the Laser GO Already
        */

        //Yellow Laser Beams
        public GameObject yellowLaser;
        private GameObject spawnedYellowLaser;

        public List<GameObject> yellowLaserList;
        GameObject yellowLaserGO;

        private int pooledYellowLaser = 20;

        //General Variable
        static bool fireYellowLaser = false;
        static List<Transform> laserMountPosition;

        void Start()
        {
            for (int i = 0; i < pooledYellowLaser; i++)
            {
                spawnedYellowLaser = Instantiate(yellowLaser, Vector3.zero, Quaternion.identity) as GameObject;
                yellowLaserList.Add(spawnedYellowLaser);
                spawnedYellowLaser.SetActive(false);
            }
        }

        void Update()
        {
            if (fireYellowLaser)
            {
                //Get Laser from Pool
                //Set Position
                //Activate
                //Set fireYellowLaser = false
                //Debug.Log("2nd check" + laserMountPosition.Count);
                foreach (Transform t in laserMountPosition)
                {
                    //Debug.Log("IN for");
                    yellowLaserGO = GetPooledYellowLaser();

                    if (yellowLaserList == null)
                    {
                        return;
                    }
                    else
                    {
                        //Debug.Log("I should have fired");
                        yellowLaserGO.transform.position = t.position;
                        //Debug.Log("pew Pew " + yellowLaserGO.transform.position);
                        yellowLaserGO.transform.rotation = t.transform.rotation;
                        yellowLaserGO.SetActive(true);
                        yellowLaserGO.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                        fireYellowLaser = false;
                    }
                }
            }
        }

        public void FireYellowLaser(List<Transform> mountPosition)
        {
            //Debug.Log("pew");
            laserMountPosition = new List<Transform>();
            foreach (Transform t in mountPosition)
            {
                laserMountPosition.Add(t);
            }
            fireYellowLaser = true;
        }

        public GameObject GetPooledYellowLaser()
        {
            for (int i = 0; i < yellowLaserList.Count; i++)
            {
                if (!yellowLaserList[i].activeInHierarchy)
                {
                    return yellowLaserList[i];
                }
            }
            return null;
        }
    }
}
