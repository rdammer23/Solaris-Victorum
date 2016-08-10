using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    //This needs to activate after all NPC Patrol Points Instantiated
    class PatrolPointManagerHuman:MonoBehaviour
    {
        RandomNumber _rand;

        static GameObject[] patrolPointsAll;

        private List<Transform> patrolPointsHumanNPC;
        Transform nextPatrolPoint;

        int numberHumanPatrolPoints;

        void Start()
        {
            /*
            _rand = new RandomNumber();

            patrolPointsAll = GameObject.FindGameObjectsWithTag("PatrolPoint");
            patrolPointsHumanNPC = new List<Transform>();

            foreach (GameObject go in patrolPointsAll)
            {
                if (go.gameObject.HasTag("HumanPatrolPoint"))
                {
                    patrolPointsHumanNPC.Add(go.gameObject.transform);
                }
            }
            numberHumanPatrolPoints = patrolPointsHumanNPC.Count;
            Debug.Log("Num Hum PP: " + numberHumanPatrolPoints);
            */
        }

        public Transform HumanNPCPatrolPoint(Transform previousPt)
        {
            if(patrolPointsHumanNPC == null)
            {
                patrolPointsHumanNPC = new List<Transform>();
                patrolPointsAll = GameObject.FindGameObjectsWithTag("PatrolPoint");

                foreach (GameObject go in patrolPointsAll)
                {
                    if (go.gameObject.HasTag("HumanPatrolPoint"))
                    {
                        patrolPointsHumanNPC.Add(go.gameObject.transform);
                    }
                }
                numberHumanPatrolPoints = patrolPointsHumanNPC.Count;
            }
            _rand = new RandomNumber();
            int x = _rand.RandomNumberInt(0, numberHumanPatrolPoints - 1);
            nextPatrolPoint = patrolPointsHumanNPC[x];
            if (nextPatrolPoint.transform.position == previousPt.transform.position)
            {
                HumanNPCPatrolPoint(previousPt);
            }
            return nextPatrolPoint;
        }
    }
}
