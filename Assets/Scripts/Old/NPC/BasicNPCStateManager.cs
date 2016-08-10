using Assets.Scripts.NPC_Classes;
using Assets.Scripts.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC
{ //TODO Condense all roates into 1 function
    //TODO condense all movement into 1 function
    class BasicNPCStateManager:MonoBehaviour
    {
        public enum NPCState
        {
            Idle,
            Follow,
            Patrol,
            Wander,
            Attack,
            Avoidance,
            Assist,
            ifAttacked,
            Flee,
            Dead,
            Spawning
        }

        public NPCState _npcState;

        private Transform shipChildName;

        public bool canIdle;
        public bool canFollow;
        public bool canPatrol;
        public bool canWander;
        public bool canAttack;
        public bool canAvoidance;
        public bool canAssist;
        public bool canIfAttacked;
        public bool canFlee;
        public bool canDie;
        public bool canSpawn;

        RandomNumber _randNum;
        BasicNPCManager _basicNPCManager;

        int sign; //Used to make random positive and negative number for random num generator
        int npcRaceID = 1; //This is the race ID of this NPC race

        string playerLayerName = "Player";
        string npcLayerName = "Enemy";
        string obstacleLayerName = "Obstacle";


        #region Wander Variables
        private int wanderTurnTimeMin = 15;
        private int wanderTurnTimeMax = 25;
        private int wanderTurnTime;
        private float wanderSpeed = 15;
        private float turnTimeCounter = 0;
        private int wanderMinTurn = 0;
        private int wanderMaxTurn = 90;
        private float wanderTurnSpeedFactor = 2;
        private float wanderTurnSpeed;
        private int wanderHowManyTimesTurned = 0;
        private int wanderMaxNumTurnsBeforeCheck = 3;

        private Vector3 wanderNewDirection;
        private Quaternion wanderRotate;

        private bool timeForTurn = true;
        #endregion

        #region Patrol Variables
        private Transform previousPatrolPoint;
        private Transform newPatrolPoint;
        public Transform patrolPointName;
        private Quaternion patrolRotate;
        private Vector3 patrolDirection;
        private Vector3 patrolHeading;

        private string whatPatrolPoints = "BasicNPCPatrolPoint";
        private bool needNewPatrolPoint = true;

        private int patrolSpeed = 20;
        private float patrolTurnSpeedFactor = 1f;
        private float patrolTurnSpeed;
        private float patrolDistance;

        static private RaycastHit hit;
        private Ray targetPlayer;

        NPCPatrolPointManager _npcPatrolPoints;
        #endregion

        #region Follow Variables
        private int followPlayerLayerMask;
        private float followPlayerFindMaxDistance = 2500f;
        private int alignment;
        private float followMaxDistance = 500f;
        private float followMinDistance = 250f;
        private int followMaxSpeed = 25;
        private float followSpeed = 12.5f;
        private float followTurnSpeedFactor = .75f;
        private float followTurnSpeed;
        private int followAlignment = -50;
        private int playerAlignment;

        private Vector3 followHeading;
        private float followDistance;
        private Vector3 followDirection;
        private Transform playerToFollow; //TODONetwork needs to be a list when networking added
        private Quaternion followRotate;

        PlayerAlignment _playerAlignment;
        NPCFollowManager _npcFollow;

        #endregion

        #region Attack Variable
        private int attackAlignment = -99;
        private int attackTurnDistance = 100;
        private int attackSpeed = 35;
        private int attackMaxWeaponDistance = 300;

        private float attackTurnSpeedFactor = .5f;
        private float attackTurnSpeed;
        private float attackDistance; //Distance to Player
        private float attackReset = 3f;
        private float attackTimer = 5f;
        private float attackReadyTimer = 5f;

        private bool attackReady = true;
        private bool attackNeedNewDirection = true;

        private Transform playerToAttack;
        private Vector3 attackHeading;
        private Vector3 attackDirection;
        private Vector3 newDirection;
        public List<Transform> laserMount;
        private Quaternion attackRotate;

        NPCLaserInstantiate _fireLaser;

        #endregion

        #region Dead Variables
        private float deadCounter = 0;
        int stayDeadHowLong = 20;
        public bool dead = false;
        private int npcHealth;
        #endregion

        void Awake()
        {
            _randNum = new RandomNumber();
            _npcPatrolPoints = new NPCPatrolPointManager();
            _playerAlignment = new PlayerAlignment();
            _npcFollow = new NPCFollowManager(); //This gets the list of players available to follow
            _fireLaser = new NPCLaserInstantiate();
            _basicNPCManager = new BasicNPCManager();
            _fireLaser = new NPCLaserInstantiate();

            wanderTurnSpeed = wanderSpeed / wanderTurnSpeedFactor;
            patrolTurnSpeed = patrolSpeed / patrolTurnSpeedFactor;
            followTurnSpeed = followMaxSpeed / followTurnSpeedFactor;
            attackTurnSpeed = attackSpeed / attackTurnSpeedFactor;

            previousPatrolPoint = this.transform;

            foreach (Transform t in transform)
            {
                if(t.name == "LaserMount")
                {
                    laserMount.Add(t.transform);
                }
            }
            shipChildName = GetComponentInChildren<NPCCollissionManager>().transform;
            _npcState = NPCState.Wander;
        }

        /* private IEnumerator Start()
        {

            while (true)
            {
                Debug.Log(this.transform.name + " is dead = " + dead);
                if (dead)
                {
                    _npcState = NPCState.Dead;
                }
                //Debug.Log(this.transform.name + " My State is " + _npcState);
                
                switch (_npcState)
                {
                    case NPCState.Idle:
                        StateCheck();
                        break;
                    case NPCState.Follow:
                        NPCFollow();
                        break;
                    case NPCState.Patrol:
                        NPCPatrol();
                        break;
                    case NPCState.Wander:
                        NPCWander();
                        break;
                    case NPCState.Attack:
                        NPCAttack();
                        break;
                    case NPCState.Avoidance:
                        break;
                    case NPCState.Assist:
                        break;
                    case NPCState.ifAttacked:
                        break;
                    case NPCState.Flee:
                        break;
                    case NPCState.Dead:
                        NPCDead();
                        break;
                    case NPCState.Spawning:
                        NPCSpawning();
                        break;

                }
                yield return 0;
            }
        }
        */

       public void Update()
        {
            if(_basicNPCManager.GetHealth(this.transform.name) <= 0)
            {
                _npcState = NPCState.Dead;
                _basicNPCManager.ResetHealth(this.transform.name);
            }
            switch (_npcState)
            {
                case NPCState.Idle:
                    StateCheck();
                    break;
                case NPCState.Follow:
                    NPCFollow();
                    break;
                case NPCState.Patrol:
                    NPCPatrol();
                    break;
                case NPCState.Wander:
                    NPCWander();
                    break;
                case NPCState.Attack:
                    NPCAttack();
                    break;
                case NPCState.Avoidance:
                    break;
                case NPCState.Assist:
                    break;
                case NPCState.ifAttacked:
                    break;
                case NPCState.Flee:
                    break;
                case NPCState.Dead:
                    NPCDead();
                    break;
                case NPCState.Spawning:
                    NPCSpawning();
                    break;                
            }
        }



        private void StateCheck()
        {
            /*
            Add to this everytime I add a new state in order to check it
            */
            //Debug.Log("Made State Check for " + this.transform.name);

            int x = _randNum.RandomNumberInt(1,10);
            if(x < 7)
            {
                _npcState = NPCState.Patrol;
            }
            else
            {
                wanderHowManyTimesTurned = 0;
                _npcState = NPCState.Wander;
            }
            //Debug.Log(_npcState);
            
        }

        private void NPCFollow()
        {
            /*
            RayCast to Find Players
            Put All Players Found in a List
            Check Alignment of Player
            Determine if Follow
            Need Max and Min Follow Distance.  Should encompass Weapon Fire Distance
            If Follow, should attempt to circle around Player to Back
                This needs a lot of logic if player fires on NPC before behind

            */

            //followPlayerLayerMask = 1 << LayerMask.NameToLayer(playerLayerName);
            //RaycastHit[] sphereHit = Physics.SphereCastAll(this.transform.position, followPlayerFindMaxDistance, Vector3.forward, 1.0F, followPlayerLayerMask);

            playerToFollow = _npcFollow.GetPlayerToFollow(this.transform);
            playerToAttack = playerToFollow;

            if(playerToFollow == null)
            {
                return;
            }
            else
            {
                if (Physics.Linecast(transform.position, playerToFollow.transform.position, out hit))
                {
                    if (Vector3.Distance(transform.position, playerToFollow.position) < followPlayerFindMaxDistance)
                    {
                        Debug.DrawLine(transform.position, playerToFollow.transform.position);
                        playerAlignment = _playerAlignment.GetAlignment(npcRaceID);
                        if (playerAlignment < followAlignment)
                        {
                            if(playerAlignment < attackAlignment)
                            {
                                _npcState = NPCState.Attack;
                                return;
                            }
                            Debug.Log("Alignment and Distance Passed Checks");
                            FollowSpeedAdjust();
                            followHeading = playerToFollow.transform.position - transform.position;
                            followDistance = followHeading.magnitude;
                            followDirection = followHeading / followDistance;
                            Debug.DrawRay(transform.position, followHeading, Color.blue);

                            transform.localPosition += transform.forward * followSpeed * Time.deltaTime;

                            followRotate = Quaternion.LookRotation(followDirection);
                            transform.rotation = Quaternion.RotateTowards(transform.rotation, followRotate, Time.deltaTime * followTurnSpeed);
                        }
                    }
                }
            }
        }

        void FollowSpeedAdjust()
        {
            /*
            1. Too Close
            2. Too Far
            3. Right Distance
            */

            var currentDistance = Vector3.Distance(transform.position, playerToFollow.position);
            Debug.Log("current Distance = " + currentDistance + " " + this.transform.name);
            if(currentDistance < followMinDistance && followSpeed > 0)
            {
                followSpeed -= .1f;
                if(followSpeed < 0)
                {
                    followSpeed = 0;
                }
            }
            else if(currentDistance > followMaxDistance)
            {
                if(followSpeed >= followMaxSpeed)
                {
                    _npcState = NPCState.Idle;
                }
                else
                {
                    followSpeed += .1f;
                }
            }
        }

        private void NPCPatrol()
        {
            /*
            Get a Random Patrol Point from NPCPatrolPointManager
            Need to pass in a flag to search the correct Patrol Points
            Randomly select a waypoint
            Slow turn towards waypoint

            Need patrol speed, should be a little faster than wander speed
            Can use same Turn routine used for Wander
            */

            if (needNewPatrolPoint)
            {
                newPatrolPoint = _npcPatrolPoints.BasicNPCPatrolPoint(previousPatrolPoint);
                needNewPatrolPoint = false;
            }
            

            if (Physics.Linecast(transform.position, newPatrolPoint.position, out hit)){
                patrolHeading = newPatrolPoint.position - transform.position;
                patrolDistance = patrolHeading.magnitude;
                patrolDirection = patrolHeading / patrolDistance;
                Debug.DrawRay(transform.position, patrolHeading, Color.yellow);

                transform.localPosition += transform.forward * patrolSpeed * Time.deltaTime;

                patrolRotate = Quaternion.LookRotation(patrolDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, patrolRotate, Time.deltaTime * patrolTurnSpeed);
            }
            if(patrolDistance < 1f)
            {
                _npcState = NPCState.Idle;
            }
        }

        private void NPCWander()
        {
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
            */
            transform.localPosition += transform.forward * wanderSpeed * Time.deltaTime;
            if (timeForTurn)
            {
                wanderTurnTime = _randNum.RandomNumberInt(wanderTurnTimeMin, wanderTurnTimeMax);
                timeForTurn = false;
                wanderNewDirection = new Vector3 (transform.rotation.x - _randNum.RandomNumberInt(wanderMinTurn, wanderMaxTurn) * NumSign(),
                    transform.rotation.y - _randNum.RandomNumberInt(wanderMinTurn, wanderMaxTurn) * NumSign(), transform.rotation.z - _randNum.RandomNumberInt(wanderMinTurn, wanderMaxTurn) * NumSign());
                if(NumSign() == 1)
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
                wanderHowManyTimesTurned += 1;
                //Debug.Log("wanderHowManyTimesTurned " + wanderHowManyTimesTurned);
                if(wanderHowManyTimesTurned > wanderMaxNumTurnsBeforeCheck)
                {
                    _npcState = NPCState.Idle;
                }
                turnTimeCounter = 0;
                timeForTurn = true;
            }
            transform.rotation = Quaternion.RotateTowards(transform.rotation, wanderRotate, Time.deltaTime * wanderTurnSpeed);
            turnTimeCounter += Time.deltaTime;
            
        }
        private void NPCAttack()
        {
            attackHeading = playerToAttack.transform.position - transform.position;
            attackDistance = attackHeading.magnitude;
            attackDirection = attackHeading / attackDistance;
            Debug.DrawRay(transform.position, attackHeading, Color.green);

            attackTimer += Time.deltaTime;

            transform.localPosition += transform.forward * attackSpeed * Time.deltaTime;
            if (attackReady)
            {
                attackRotate = Quaternion.LookRotation(attackDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, attackRotate, Time.deltaTime * attackTurnSpeed);

                if (attackTimer >= attackReadyTimer)
                {
                    //Debug.Log("passed Time Test");
                    //Cast Ray forward to see if player in front and is playerToAttack and distance < attackMaxWeaponDistance
                    //If Yes, fire weapon and reset attackTimer
                    //If No, do not fire
                    Debug.DrawRay(transform.position, attackHeading, Color.red);
                    if (Physics.Raycast(transform.position, this.transform.forward, out hit, attackMaxWeaponDistance))
                    {
                        //Debug.Log("Player, " + hit.transform.name + " in front of " + this.transform.name + " at a distance of " + hit.distance);
                        _fireLaser.FireYellowLaser(laserMount);
                        attackTimer = 0;
                    }
                }
            }
            else
            {
                if (attackNeedNewDirection)
                {
                    var whatDirection = _randNum.RandomNumberInt(1, 7);
                    //Debug.Log(whatDirection);
                    switch (whatDirection)
                    {
                        case 1:
                            newDirection = new Vector3(attackDirection.x * -1, attackDirection.y, attackDirection.z);
                            break;

                        case 2:
                            newDirection = new Vector3(attackDirection.x, attackDirection.y * -1, attackDirection.z);
                            break;
                        case 3:
                            newDirection = new Vector3(attackDirection.x, attackDirection.y, attackDirection.z * -1);
                            break;
                        case 4:
                            newDirection = new Vector3(attackDirection.x * -1, attackDirection.y * -1, attackDirection.z);
                            break;
                        case 5:
                            newDirection = new Vector3(attackDirection.x * -1, attackDirection.y, attackDirection.z * -1);
                            break;
                        case 6:
                            newDirection = new Vector3(attackDirection.x, attackDirection.y * -1, attackDirection.z * -1);
                            break;
                        case 7:
                            newDirection = new Vector3(attackDirection.x * -1, attackDirection.y * -1, attackDirection.z * -1);
                            break;
                        default:
                            newDirection = new Vector3(attackDirection.x * -1, attackDirection.y * -1, attackDirection.z * -1);
                            break;
                    }
                }
                attackNeedNewDirection = false;
                attackRotate = Quaternion.LookRotation(newDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, attackRotate, Time.deltaTime * attackTurnSpeed);
            }
            if(attackDistance < attackTurnDistance)
            {
                attackReady = false;
                
            }
            else if(attackDistance > (attackTurnDistance * attackReset))
            {
                attackReady = true;
                attackNeedNewDirection = true;
            }
        }

        private void NPCDead()
        {
            //Stop all Movement
            //Deactivate Ship Layer
            //Start Counter
            //Debug.Log("Dead");
            shipChildName.gameObject.SetActive(false);
            if(deadCounter > stayDeadHowLong)
            {
                _npcState = NPCState.Spawning;
            }
            deadCounter += Time.deltaTime;
        }

        private void NPCSpawning()
        {
            shipChildName.gameObject.SetActive(true);
            deadCounter = 0f;
            _npcState = NPCState.Wander;
        }

        private void NPCAvoidance()
        {
            /*
            LineCast in front X Distance
            If Hit something on Player, Enemy or Onstacle Layer
            Take Evasive Action
            
            Once complete, determine if should return to old state or pick new one
            */
        }
        private void NPCAssist()
        {

        }
        private void NPCFlee()
        {

        }

        public void Dead()
        {
            _npcState = NPCState.Dead;
        }

        public float NumSign()
        {
            sign = _randNum.RandomNumberInt(1, 2);
            if (sign == 1)
            {
                return sign;
            }
            sign = -1;
            return sign;
        }
    }
}
