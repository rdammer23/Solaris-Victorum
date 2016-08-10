using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace Assets.Scripts.NPC
{
    class NPCPatrolPointManager:MonoBehaviour
    {
        /*
        Make a collection for each NPC type
        This makes grabing a random patrol point easier
        As new Races and Patrol Points for those races added, need to update
        */
        GameObject[] patrolPointsAll;
        static List<Transform> patrolPointsBasicNPC;

        static int numBasicPatrolPoints;

        Transform nextPatrolPoint;
        Transform previousPt;

        RandomNumber _rand;

        void Awake()
        {
            _rand = new RandomNumber();

            patrolPointsAll = GameObject.FindGameObjectsWithTag("Waypoint");

            patrolPointsBasicNPC = new List<Transform>();

            foreach (GameObject go in patrolPointsAll)
            {
                if(go.gameObject.HasTag("BasicNPCPatrolPoint"))
                {
                    patrolPointsBasicNPC.Add(go.gameObject.transform);
                }
            }
            numBasicPatrolPoints = patrolPointsBasicNPC.Count;
        }

        public Transform BasicNPCPatrolPoint(Transform previousPt)
        {
            _rand = new RandomNumber();
            int x = _rand.RandomNumberInt(0, numBasicPatrolPoints-1);

            nextPatrolPoint = patrolPointsBasicNPC[x];
            if (nextPatrolPoint.transform.position == previousPt.transform.position)
            {
                BasicNPCPatrolPoint(previousPt);
            }
            return nextPatrolPoint;
        }
    }
}
