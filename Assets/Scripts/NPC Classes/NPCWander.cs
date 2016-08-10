using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class NPCWander:MonoBehaviour
    {
        //TODO Need to make sure when the NPC Levels, Sppeds are recalculated
        /*
            Once in game, this is the default state of a NPC
            if none of the other states are active.
            NPC should not be idle that often.

            NPC will wander randomly
            with no particular destination in mind
            NPC will turn a random direction x, y and z
            Every X seconds between wanderTurnTimeMin/Max

            While in this state, should always be evaluating
            the other states to determine if a change is needed

            This must be deactivated if another state is activated
            */

        private float wanderSpeed;
        private float wanderTurnSpeedFactor;
        private float wanderTurnSpeed;

        private int wanderTurnTimeMin = 20;
        private int wanderTurnTimeMax = 45;
        private int wanderTurnTime;
        private float turnTimeCounter = 0;
        private int wanderMinTurn = 0;
        private int wanderMaxTurn = 90;

        private Vector3 wanderNewDirection;
        private Quaternion wanderRotate;

        private bool timeForTurn = true;

        RandomNumber _randNum;
        NPCPoolManager _poolManager;

        void Awake()
        {
            _randNum = new RandomNumber();
            _poolManager = new NPCPoolManager();
            
        }

        void Start()
        {
            GetWanderSpeeds();
        }

        void Update()
        {
            transform.localPosition += transform.forward * wanderSpeed * Time.deltaTime;
            if (timeForTurn)
            {
                wanderTurnTime = _randNum.RandomNumberInt(wanderTurnTimeMin, wanderTurnTimeMax);
                timeForTurn = false;
                wanderNewDirection = new Vector3(transform.rotation.x - _randNum.RandomNumberInt(wanderMinTurn, wanderMaxTurn) * _randNum.Sign(),
                    transform.rotation.y - _randNum.RandomNumberInt(wanderMinTurn, wanderMaxTurn) * _randNum.Sign(), transform.rotation.z - _randNum.RandomNumberInt(wanderMinTurn, wanderMaxTurn) * _randNum.Sign());
                //Debug.Log("New Direction = " + wanderNewDirection);
                if (_randNum.Sign() == 1)
                {
                    wanderRotate = Quaternion.LookRotation(wanderNewDirection - transform.position);
                }
                else
                {
                    wanderRotate = Quaternion.LookRotation(wanderNewDirection + transform.position);
                }

                timeForTurn = false;
            }
            if (turnTimeCounter >= wanderTurnTime)
            {
                turnTimeCounter = 0;
                timeForTurn = true;
            }
            transform.rotation = Quaternion.RotateTowards(transform.rotation, wanderRotate, Time.deltaTime * wanderTurnSpeed);
            turnTimeCounter += Time.deltaTime;
        }

        public void GetWanderSpeeds()
        {
            wanderSpeed = _poolManager.GetWanderSpeed(this.gameObject.name);
            wanderTurnSpeedFactor = _poolManager.GetWanderTurnSpeedFactor(this.gameObject.name);
            wanderTurnSpeed = wanderSpeed / (wanderTurnSpeedFactor);
            //Debug.Log("***********************");
            //Debug.Log(wanderSpeed);
            //Debug.Log(wanderTurnSpeedFactor);
            //Debug.Log(wanderTurnSpeed);
        }
    }
}
