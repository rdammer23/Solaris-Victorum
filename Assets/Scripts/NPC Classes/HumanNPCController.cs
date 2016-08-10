using Assets.Scripts.NPC_Classes.PoolManagers;
using Assets.Scripts.NPC_Classes.StateManager;
using Assets.Scripts.Player;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class HumanNPCController:MonoBehaviour
    {
        HumanPoolManager _humanPoolManager;
        StatesAllowed _statesAllowed;
        PlayerLeveling _playerLeveling;
        NPCSpeedAdjust _adjustSpeed;

        //This sits on each Human NPC

        private int npcType;
        private int npcHobby;
        private float currentHealth;
        private float maxHealth;
        private int currentMovementState;
        public string currentMovementStateString;
        public float viewWindow = 90f;

        private int sign;

        private List<string> movementStatesAllowed;

        static private RaycastHit hit;

        RandomNumber randNum;

        private bool canIdle = false;
        private bool canFollow = false;
        private bool canPatrol = false;
        private bool canWander = false;
        private bool canAttack = false;
        private bool canAvoidance = false;
        private bool canAssist = false;
        private bool canIfAttacked = false;
        private bool canFlee = false;
        private bool canDie = false;
        private bool canCollide = false;
        private bool canFlyHome = false;
        private bool canFlyDeepSpace = false;

        #region Wander Variables
        private float wanderSpeed;
        private float wanderTurnSpeedFactor;
        private float wanderTurnSpeed;

        private int wanderTurnTimeMin = 20;
        private int wanderTurnTimeMax = 45;
        private int wanderTurnTime;
        private float turnTimeCounter = 0;
        private int wanderMinTurn = 0;
        private int wanderMaxTurn = 90;
        private int wanderHowManyTimesTurned = 0;
        private int wanderMaxNumTurnsBeforeCheck = 3;

        private Vector3 wanderNewDirection;
        private Quaternion wanderRotate;

        private bool timeForTurn = true;
        private bool inWander = false;
        #endregion

        #region Patrol Variables
        private Transform previousPatrolPoint;
        private Transform newPatrolPoint;
        private Quaternion patrolRotate;
        private Vector3 patrolDirection;
        private Vector3 patrolHeading;

        private bool needNewPatrolPoint = true;

        private float patrolSpeed;
        private float patrolTurnSpeedFactor;
        private float patrolTurnSpeed;
        private float patrolDistance;

        PatrolPointManagerHuman _npcPatrolPoints;
        #endregion

        #region FlyHome
        Transform homePlanet;

        private bool tooFar = false;

        private int maxDistAway = 25000;
        private int minFlyHomeDist = 20000;

        private float standardSpeed;
        private float standardTurnSpeedFactor;
        private float standardTurnSpeed;

        private Quaternion standardRotate;
        #endregion

        #region FlyDeepSpace
        private int maxDistFromPlanet = 10000; //If X, Y or Z less than this, then can fly to deep space
        private Transform deepSpaceLocation;
        private Vector3 deepSpaceLocationV3;
        private bool deepSpaceLocationSet = false;
        #endregion

        #region IDLE
        private int idleHowLong;
        private int minIdleTime = 1;
        private int maxIdleTime = 5;
        private float idleTimeCounter;
        #endregion

        #region Avoidance
        NPCAvoidanceRayCast _npcAvoid;
        static private GameObject hitAvoidanceGO;
        private Transform newAvoidancePoint;

        private float avoidanceDistance;
        private float avoidanceSpeed;
        private float avoidanceTurnSpeedFactor;
        private float avoidanceTurnSpeed;
        private float maxTimeInAvoidance = 7f;
        private float timeInAvoidance;
        private bool newAvoidanceDirection = false;
        private bool checkAvoidance = true;

        private Vector3 avoidanceDirection;
        private Vector3 avoidanceHeading;
        private Quaternion avoidanceRotate;

        private float rayCastOffset = 50f; //TODO may need a better way of doing this as ships get bigger this offset may not work

        #endregion

        #region Follow
        FollowManager _npcFollow;

        private Transform playerToFollow;

        private Vector3 followHeading;
        private Vector3 followDirection;
        private Quaternion followRotate;



        private int playerAlignment;
        private int followAlignment = 750;
        private float followMaxDistance;
        private float followMinDistance;
        private float followMaxSpeed;
        private float followSpeedTurnFactor;
        private float followTurnSpeed;
        private float findPlayerDistance;

        //Calculated in game
        private float followDistance;
        private float followSpeed;
        private bool following = false;

        NPCFollow _follow;

        #endregion

        #region Attack Variable
        private int attackAlignment = 400; //-99;
        private float attackTurnDistance;
        private float attackSpeed;
        private float maxAttackSpeed;
        private float attackMaxWeaponDistance;
        private float attackMinWeaponDistance;

        private float attackTurnSpeedFactor = .5f;
        private float attackTurnSpeed;
        private float attackDistance; //Distance to Player
        private float resetDistance; //Too close to player in attack, need to reset the distance
        private float attackReset = 3f;
        private float attackTimer = 3f; //Should make this variable based on ship
        private float attackReadyTimer = 3f; //Should make this variable based on ship

        private bool attackReady = true;
        private bool resetAttackDirection = false;
        private bool attacking = false;

        private Transform playerToAttack;
        private Vector3 attackHeading;
        private Vector3 attackDirection;
        private Vector3 newDirection;
        private Vector3 npcPosToPlayer;
        private Vector3 resetDirection;
        public List<Transform> laserMount;
        private Quaternion attackRotate;

        NPCLaserInstantiate _fireLaser;
        NPCAttack _npcAttack;

        #endregion


        #region AutoHeal
        float timeToHeal = 30f;
        float healTimer = 0f;
        float healAmount = 0.1f;
        #endregion


        void Start()
        {
            randNum = new RandomNumber();
            _humanPoolManager = new HumanPoolManager();
            _statesAllowed = new StatesAllowed();
            _npcPatrolPoints = new PatrolPointManagerHuman();
            _npcAvoid = new NPCAvoidanceRayCast();
            _playerLeveling = new PlayerLeveling();
            _npcFollow = new FollowManager();
            _fireLaser = new NPCLaserInstantiate();
            _npcAttack = new NPCAttack();
            _adjustSpeed = new NPCSpeedAdjust();
            _follow = new NPCFollow();

            movementStatesAllowed = new List<string>();
            npcType = (_humanPoolManager.NPCType(this.transform.name));
            npcHobby = (_humanPoolManager.NPCHobbyID(this.transform.name));
            maxHealth = _humanPoolManager.GetMaxHealth(this.transform.name);
            currentHealth = maxHealth;

            previousPatrolPoint = this.gameObject.transform;
            avoidanceDistance = _humanPoolManager.GetAvoidanceDistance(this.transform.name);
            avoidanceSpeed = _humanPoolManager.GetAvoidanceSpeed(this.transform.name);
            avoidanceTurnSpeedFactor = _humanPoolManager.GetAvoidanceTurnSpeedFactor(this.transform.name);
            avoidanceTurnSpeed = avoidanceSpeed / avoidanceTurnSpeedFactor;
            homePlanet = HomePlanet();
            States();
            playerToFollow = _npcFollow.GetPlayerToFollow(this.transform);
            playerToAttack = playerToFollow;

            laserMount = new List<Transform>();

            Transform[] ts = gameObject.GetComponentsInChildren<Transform>();
            foreach (Transform t in ts)
            {
                if(t.name == "LaserMount")
                {
                    laserMount.Add(t);
                }
            }


            InitializeStates();
            InitialMovementState();

        }

        void Update()
        {
            if (checkAvoidance)
            {
                //Debug.Log("NPC " + avoidanceDistance);
                //Debug.Log("NPC " + this.transform);
                //Debug.Log("NPC " + rayCastOffset);
                hitAvoidanceGO = _npcAvoid.NPCAvoidance(avoidanceDistance, this.transform, rayCastOffset);
                if (hitAvoidanceGO != null)
                {
                    newAvoidanceDirection = true;
                    checkAvoidance = false;
                    currentMovementStateString = "canAvoid";
                }
            }

            if (playerToFollow == null)
            {
                playerToFollow = _npcFollow.GetPlayerToFollow(this.transform);
                playerToAttack = playerToFollow;
            }

            ActivateState();
            AutoHeal();
        }

        private void AutoHeal()
        {
            if(healTimer >= timeToHeal)
            {
                healTimer = 0;
                currentHealth = currentHealth + (_humanPoolManager.GetMaxHealth(this.transform.name)* healAmount);
                if(currentHealth > _humanPoolManager.GetMaxHealth(this.transform.name))
                {
                    currentHealth = _humanPoolManager.GetMaxHealth(this.transform.name);
                }
                GetComponentInChildren<NPCNameLable>().UpdateHealth((int)currentHealth);
            }
            else
            {
                healTimer += Time.deltaTime;
            }
        }

        public void DecreaseHealth(int healthChange)
        {
            currentHealth -= healthChange;
            GetComponentInChildren<NPCNameLable>().UpdateHealth((int)currentHealth);
            if (currentHealth <= 0)
            {
                GetComponentInChildren<NPCNameLable>().UpdateHealth((int)maxHealth);
                currentHealth = maxHealth; //This is to have health reset to max on respawn
                Debug.Log("YOU ARE DEAD YOU BASTARD!");
                GetComponentInChildren<NPCExplosion>().ShipExplosion(this.transform);
                
                //Type Level is currently = NPC Level
                _playerLeveling.DetermineXPEarned(_humanPoolManager.GetLevel(this.transform.name), 
                    npcType, 
                    _humanPoolManager.GetLevel(this.transform.name), 
                    npcHobby, 
                    _humanPoolManager.NPCHobbyLevel(this.transform.name));

                this.gameObject.SetActive(false);
            }
        }

        public void IncreaesHealth(int healthChange)
        {
            currentHealth += healthChange;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }

        private void InitialMovementState()
        {
            if (npcType == 1)
            {
                currentMovementStateString = "canPatrol";
            }
            else
            {
                currentMovementStateString = "canWander";
            }
        }

        private void SelectMovementState()
        {
            if (FlyHomeDistance())
            {
                currentMovementStateString = "canFlyHome";
                tooFar = true;
            }
            else
            {
                currentMovementState = (randNum.RandomNumberInt(1, movementStatesAllowed.Count)) - 1;
                currentMovementStateString = movementStatesAllowed[currentMovementState];
                if (currentMovementStateString == "canFlyHome")
                {
                    //Debug.Log("Checking CAN FLY HOME");
                    if (Math.Abs(this.transform.position.x) > minFlyHomeDist || Math.Abs(this.transform.position.y) > minFlyHomeDist || Math.Abs(this.transform.position.x) > minFlyHomeDist)
                    {
                        if(randNum.RandomNumberInt(1,100) < 11)
                        {
                            tooFar = true;
                        }
                        else
                        {
                            SelectMovementState();
                        }
                    }
                    else
                    {
                        SelectMovementState();
                    }
                }
                else if(currentMovementStateString == "canFlyDeepSpace")
                {
                    if (randNum.RandomNumberInt(1, 100) < 11)
                    {
                    }
                    else
                    {
                        SelectMovementState();
                    }
                }
            }
        }

        private void InitializeStates()
        {
            patrolSpeed = _humanPoolManager.GetPatrolSpeed(this.gameObject.name);
            patrolTurnSpeedFactor = _humanPoolManager.GetPatrolTurnSpeedFactor(this.gameObject.name);
            patrolTurnSpeed = patrolSpeed / (patrolTurnSpeedFactor);

            wanderSpeed = _humanPoolManager.GetWanderSpeed(this.gameObject.name);
            wanderTurnSpeedFactor = _humanPoolManager.GetWanderTurnSpeedFactor(this.gameObject.name);
            wanderTurnSpeed = wanderSpeed / (wanderTurnSpeedFactor);

            standardSpeed = wanderSpeed * 2;
            standardTurnSpeedFactor = wanderTurnSpeedFactor;
            standardTurnSpeed = standardSpeed / (standardTurnSpeedFactor);

            attackSpeed = (_humanPoolManager.GetAttackSpeed(this.gameObject.name));
            maxAttackSpeed = attackSpeed;
            attackTurnDistance = (_humanPoolManager.GetAttackTurnDistance(this.gameObject.name));
            attackMaxWeaponDistance = (_humanPoolManager.GetAttackMaxDistance(this.gameObject.name));
            attackMinWeaponDistance = (_humanPoolManager.GetAttackMinDistance(this.gameObject.name));
            attackTurnSpeedFactor = (_humanPoolManager.GetAttackSpeedTurnFactor(this.gameObject.name));
            attackTurnSpeed = attackSpeed / attackTurnSpeedFactor;
            attackReadyTimer = (_humanPoolManager.GetAttackWeaponCoolDown(this.gameObject.name));
            attackTimer = attackReadyTimer;


            followMaxDistance = _humanPoolManager.GetFollowMaxDistance(this.gameObject.name);
            followMinDistance = _humanPoolManager.GetFollowMinDistance(this.gameObject.name);
            followMaxSpeed = _humanPoolManager.GetFollowMaxSpeed(this.gameObject.name);
            followSpeedTurnFactor = _humanPoolManager.GetFollowTurnSpeedFactor(this.gameObject.name);
            followTurnSpeed = followMaxSpeed / followSpeedTurnFactor;
            findPlayerDistance = _humanPoolManager.GetFollowMaxFindPlayerDistance(this.gameObject.name);
            followSpeed = followMaxSpeed;
        }

        private void ActivateState()
        {
            switch (currentMovementStateString)
            {
                case "canIdle":
                    NPCIdle();
                    break;
                case "canPatrol":
                    NPCPatrol();
                    break;
                case "canWander":
                    NPCWander();
                    break;
                case "canFlyHome":
                    //Use Wander Speed to fly home * 2
                    NPCFlyHome();
                    break;
                case "canFlyDeepSpace":
                    NPCFlyDeepSpace();
                    break;
                case "canAttack":
                    Attack();
                    break;
                case "canFollow":
                    NPCFollow();
                    break;
                case "canIfAttacked":
                    NPCWasAttacked();
                    break;
                case "canAvoid":
                    //Looked up stats in start routine.
                    //May want to move all to start and only
                    //look up again when NPC Levels
                    NPCAvoidance();
                    break;


                default:
                    SelectMovementState();
                    break;
            }
        }

        private Transform HomePlanet()
        {
            homePlanet = GameObject.Find("HumanPatrolPoint(Clone)").transform.parent.transform;
            return homePlanet;
        }

        private void Attack()
        {
            /* TODO
            I think eventually, if NPC cannot kill player, all NPC will end up
            right behind the player colliding with each other
            Need to test this and determine the chances of it happening.
            */
            attackHeading = _npcAttack.AttackHeading(this.transform, playerToAttack.transform);
            attackDistance = attackHeading.magnitude;
            attackDirection = attackHeading / attackDistance;
            attackTimer += Time.deltaTime;

            if (attackTimer >= attackReadyTimer)
            {
                //Debug.Log("passed Time Test");
                //Cast Ray forward to see if player in front and is playerToAttack and distance < attackMaxWeaponDistance
                //If Yes, fire weapon and reset attackTimer
                //If No, do not fire
                Debug.DrawRay(transform.position, this.transform.forward * attackMaxWeaponDistance, Color.white);
                if (Physics.Raycast(laserMount[0].position, this.transform.forward * attackMaxWeaponDistance, out hit, attackMaxWeaponDistance))
                {
                    //Debug.Log("Player, " + hit.transform.name + " in front of " + this.transform.name + " at a distance of " + hit.distance);
                    if (hit.transform.parent.transform.tag == "Player")
                    {
                        _fireLaser.FireYellowLaser(laserMount);
                        Debug.Log("FIRED LASER");
                    }
                    attackTimer = 0;
                }
            }


            if (attackDistance < attackMaxWeaponDistance && attackDistance > attackMinWeaponDistance && !resetAttackDirection)
            {
                //Debug.Log("In Range");
                attackTimer += Time.deltaTime;
                if (Vector3.Angle(transform.forward, attackHeading) < viewWindow)
                {
                    //Debug.Log("I can see player");
                    _npcAttack.AttackRotate(this.transform, attackDirection, attackTurnSpeed);
                    _npcAttack.MoveForward(this.transform, attackSpeed);
                    if (_npcAttack.AheadOrBehind(this.transform, playerToAttack.transform) < 0) //This represents behind NPC
                    {
                        if (attackDistance > (attackMaxWeaponDistance * .5) && attackSpeed < maxAttackSpeed)
                        {
                            attackSpeed = _adjustSpeed.SpeedUp(attackSpeed);
                        }
                        if (attackDistance < (attackMinWeaponDistance * 1.1) && attackSpeed > 0)
                        {
                            attackSpeed = _adjustSpeed.SlowDown(attackSpeed);
                        }
                    }
                }
            }
            else if (attackDistance <= attackMinWeaponDistance && !resetAttackDirection)
            {
                if (_npcAttack.AheadOrBehind(this.transform, playerToAttack.transform) > 0)
                {
                    //Debug.Log("NPC In front of Player ");
                    /*TODO
                    Will need to improve this later
                    Currently it randomly picks a new direction
                    Will want to modify so it tries to get
                    behind player
                    */
                    resetAttackDirection = true;
                    var whatDirection = randNum.RandomNumberInt(1, 3);
                    switch (whatDirection)
                    {
                        case 1:
                            newDirection = new Vector3(attackDirection.x * -1, attackDirection.y * -1, attackDirection.z);
                            break;

                        case 2:
                            newDirection = new Vector3(attackDirection.x * -1, attackDirection.y, attackDirection.z * -1);
                            break;
                        case 3:
                            newDirection = new Vector3(attackDirection.x, attackDirection.y * -1, attackDirection.z * -1);
                            break;
                        default:
                            newDirection = new Vector3(attackDirection.x * -1, attackDirection.y * -1, attackDirection.z);
                            break;
                    }
                    attackRotate = Quaternion.LookRotation(newDirection);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, attackRotate, Time.deltaTime * attackTurnSpeed);
                    
                }
                else
                {
                    Debug.Log("I am behind the player and for Some Reason I got too close");
                }
            }

            if (resetAttackDirection)
            {
                resetDistance = newDirection.magnitude;
                resetDirection = newDirection / resetDistance;
               
                _npcAttack.MoveForward(this.transform, attackSpeed);

                if (attackDistance > attackMinWeaponDistance * 1.5)
                {
                    _npcAttack.AttackRotate(this.transform, attackDirection, attackTurnSpeed);

                    if (Vector3.Angle(transform.forward, attackHeading) < viewWindow/5) 
                        //Made view window extra small here to make sure NPC out of turn
                        //before heading back to the full Attack Routine
                    {
                        resetAttackDirection = false;
                    }
                }
                else
                {
                    _npcAttack.AttackRotate(this.transform, resetDirection, attackTurnSpeed);
                }
            }
        }

        public bool IfPlayerToFollow()
        {
            return (Physics.Linecast(transform.position, playerToFollow.transform.position, out hit));
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
            if (Vector3.Distance(transform.position, playerToFollow.position) < findPlayerDistance)
            {
                currentMovementStateString = "canFollow";
                following = true;
                Debug.DrawLine(transform.position, playerToFollow.transform.position, Color.yellow);
                playerAlignment = GameData.AlignmentHuman;

                if (playerAlignment < followAlignment)
                {
                    if (playerAlignment < attackAlignment)
                    {
                        currentMovementStateString = "canAttack";
                        attackReady = true;
                        Attack();
                        return;
                    }
                    //Debug.Log("Alignment and Distance Passed Checks");
                    FollowSpeedAdjust();

                    followHeading = _follow.FollowHeading(this.transform, playerToFollow.transform);
                    followDistance = followHeading.magnitude;
                    followDirection = followHeading / followDistance;
                    Debug.DrawRay(transform.position, followHeading, Color.blue);

                    _follow.MoveForward(this.transform, followSpeed);
                    //transform.localPosition += transform.forward * followSpeed * Time.deltaTime;
                    _follow.FollowRotate(this.transform, followDirection, followTurnSpeed);
                    followRotate = Quaternion.LookRotation(followDirection);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, followRotate, Time.deltaTime * followSpeedTurnFactor);
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
            //Debug.Log("In ADJ Follow Speed");
            var currentDistance = Vector3.Distance(transform.position, playerToFollow.position);
            //Debug.Log("current Distance = " + currentDistance + " " + this.transform.name);
            //Debug.Log(currentDistance);
            //Debug.Log(followMaxDistance);
            if (currentDistance < followMinDistance && followSpeed > 0)
            {
                
                followSpeed =  _adjustSpeed.SlowDown(followSpeed);
                //Debug.Log("In ADJ Follow Speed down: " + followSpeed);
                if (followSpeed < 0)
                {
                    followSpeed = 0;
                }
            }
            else if (currentDistance > followMaxDistance/2)
            {
                if (followSpeed >= followMaxSpeed)
                {
                    Debug.Log("Wander on");
                    currentMovementStateString = "canWander";
                }
                else
                {
                    Debug.Log("should speed up " + followSpeed);
                    followSpeed = _adjustSpeed.SpeedUp(followSpeed);
                }
            }
        }
        
        private void NPCWasAttacked()
        {
            Debug.Log(currentMovementStateString);
            _npcAttack.AttackRotate(this.transform, playerToAttack.transform.position, attackTurnSpeed);
            _npcAttack.MoveForward(this.transform, attackSpeed);
        }

        public void WasAttacked()
        {
            if(currentMovementStateString != "canAttack")
            {
                Debug.Log("I was hit!");
                currentMovementStateString = "canIfAttacked";
            }
        }

        private void NPCAvoidance()
        {
            /*
            if Object to avoid is a star, planet or moon, perform around a 90 degree turn
            Otherwise perform around a 45 degree turn

            Set new point to rotate toward
            Rotate toward that new point

            reset these
            newAvoidanceDirection = false;
            checkAvoidance = true;
            Go back into standard movement routine.
            SelectMovementState()
            */
            if (newAvoidanceDirection)
            {
                //avoidanceHeading = new Vector3(NumSign() * randNum.RandomNumberInt(75, 145), NumSign() * randNum.RandomNumberInt(0, 1) * randNum.RandomNumberInt(75, 145), NumSign() * randNum.RandomNumberInt(0, 1) * randNum.RandomNumberInt(75, 145));
                avoidanceDirection = new Vector3(NumSign() * randNum.RandomNumberInt(75, 145), NumSign() * randNum.RandomNumberInt(0, 1) * randNum.RandomNumberInt(75, 145), NumSign() * randNum.RandomNumberInt(0, 1) * randNum.RandomNumberInt(75, 145));
                newAvoidanceDirection = false;
            }
            
            //avoidanceHeading = newAvoidancePoint.transform.position - this.transform.position;
            transform.localPosition += transform.forward * avoidanceSpeed * Time.deltaTime;
            avoidanceRotate = Quaternion.LookRotation(avoidanceDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, avoidanceRotate, Time.deltaTime * avoidanceTurnSpeed);
            if(transform.rotation == avoidanceRotate)
            {
                checkAvoidance = true;
                SelectMovementState();
            }
            timeInAvoidance += 1 * Time.deltaTime;
            //Debug.Log(this.transform.name + " " + timeInAvoidance);
            if(timeInAvoidance >= maxTimeInAvoidance)
            {
                timeInAvoidance = 0f;
                checkAvoidance = true;
                SelectMovementState();
            }
        }

        private void NPCIdle()
        {
            idleTimeCounter = 0;
            idleHowLong = randNum.RandomNumberInt(minIdleTime, maxIdleTime);
            while (idleTimeCounter < idleHowLong)
            {
                idleTimeCounter += Time.deltaTime;
            }
            SelectMovementState();
        }

        private void NPCFlyDeepSpace()
        {
            /*
            This is used to push NPCs into Deep Space
            Will be a random X, Y and Z 
            if more than 1000 in any direction from planet, should not activate
            use same speed setup as NPCFlyHome
            */
            //Debug.Log("DEEP SPACE Active" + this.transform.name);
            if (!deepSpaceLocationSet)
            {
                float tempX = (NumSign() * randNum.RandomNumberInt(15000, 20000));
                float tempY = (NumSign() * randNum.RandomNumberInt(15000, 20000));
                float tempZ = (NumSign() * randNum.RandomNumberInt(15000, 20000));
                deepSpaceLocationV3 = new Vector3(tempX, tempY, tempZ);
                //deepSpaceLocation.position = deepSpaceLocationV3;
                //deepSpaceLocation.position = new Vector3((NumSign() * randNum.RandomNumberInt(15000, 20000)),(NumSign() * randNum.RandomNumberInt(15000, 20000)), (NumSign() * randNum.RandomNumberInt(15000, 20000)));
                deepSpaceLocationSet = true;
            }
            transform.localPosition += transform.forward * standardSpeed * Time.deltaTime;
            patrolHeading = deepSpaceLocationV3 - transform.position;
            patrolDistance = patrolHeading.magnitude;
            patrolDirection = patrolHeading / patrolDistance;
            Debug.DrawRay(transform.position, patrolHeading, Color.blue);
            standardRotate = Quaternion.LookRotation(patrolDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, standardRotate, Time.deltaTime * standardTurnSpeed);

            if (patrolDistance < 250f) //TODO Make this random
            {
                deepSpaceLocationSet = false;
                SelectMovementState();
            }
        }

        private bool FlyHomeDistance()
        {
            if(Math.Abs(this.transform.position.x) > maxDistAway || Math.Abs(this.transform.position.y) > maxDistAway || Math.Abs(this.transform.position.x) > maxDistAway)
            {
                return true;
            }
            return false;
        }

        private void NPCFlyHome()
        {
            /*
            If NPC gets too far out, this is used to have them head back toward
            their planet. 
            Current distance is 25000 in any of the 3 directions
            */

            transform.localPosition += transform.forward * standardSpeed * Time.deltaTime;
            patrolHeading = homePlanet.transform.position - transform.position;
            patrolDistance = patrolHeading.magnitude;
            patrolDirection = patrolHeading / patrolDistance;
            Debug.DrawRay(transform.position, patrolHeading, Color.red);
            standardRotate = Quaternion.LookRotation(patrolDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, standardRotate, Time.deltaTime * wanderTurnSpeed);
            if(patrolDistance < 250f) //TODO Make this random
            {
                tooFar = false;
                SelectMovementState();
            }
        }

        private void NPCPatrol()
        {
            /*
            NPC will travel between random PatrolPoints that surround the planet
            and the moon.
            */
            if (needNewPatrolPoint)
            {
                newPatrolPoint = _npcPatrolPoints.HumanNPCPatrolPoint(previousPatrolPoint);
                needNewPatrolPoint = false;
            }
            #region Basic Patrol
            //Used if NPC is just to go to a random patrol point
            patrolHeading = newPatrolPoint.position - transform.position;
            patrolDistance = patrolHeading.magnitude;
            patrolDirection = patrolHeading / patrolDistance;
            Debug.DrawRay(transform.position, patrolHeading, Color.yellow);
            //Debug.Log(this.transform.name + " PH:" + patrolHeading + " PD:" + patrolDirection + " PS:" + patrolSpeed);
            transform.localPosition += transform.forward * patrolSpeed * Time.deltaTime;

            patrolRotate = Quaternion.LookRotation(patrolDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, patrolRotate, Time.deltaTime * patrolTurnSpeed);
            
            #endregion
            /*
            This is used if I want to make sure the patrol point is in NPC view
            if (Physics.Linecast(transform.position, newPatrolPoint.position, out hit))
            {
                Debug.Log("In IF");
                patrolHeading = newPatrolPoint.position - transform.position;
                patrolDistance = patrolHeading.magnitude;
                patrolDirection = patrolHeading / patrolDistance;
                Debug.DrawRay(transform.position, patrolHeading, Color.yellow);

                transform.localPosition += transform.forward * patrolSpeed * Time.deltaTime;

                patrolRotate = Quaternion.LookRotation(patrolDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, patrolRotate, Time.deltaTime * patrolTurnSpeed);
            }
            */
            if (patrolDistance < 1f)
            {
                if(npcType == 1)
                {
                    needNewPatrolPoint = true;
                }
                else
                {
                    SelectMovementState();
                }
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
                wanderTurnTime = randNum.RandomNumberInt(wanderTurnTimeMin, wanderTurnTimeMax);
                timeForTurn = false;
                wanderNewDirection = new Vector3(transform.rotation.x - randNum.RandomNumberInt(wanderMinTurn, wanderMaxTurn) * NumSign(),
                    transform.rotation.y - randNum.RandomNumberInt(wanderMinTurn, wanderMaxTurn) * NumSign(), transform.rotation.z - randNum.RandomNumberInt(wanderMinTurn, wanderMaxTurn) * NumSign());
                if (NumSign() == 1)
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
                if (wanderHowManyTimesTurned > wanderMaxNumTurnsBeforeCheck)
                {
                    SelectMovementState();
                }
                turnTimeCounter = 0;
                timeForTurn = true;
            }
            transform.rotation = Quaternion.RotateTowards(transform.rotation, wanderRotate, Time.deltaTime * wanderTurnSpeed);
            turnTimeCounter += Time.deltaTime;

        }

        private void States()
        {
            /* TODO
            Need to take into consideration the states allowed based on Type of NPC
            Currently not looking at this.
            */
            canIdle = _statesAllowed.Idle(npcType);
            if (canIdle)
            {
                movementStatesAllowed.Add("canIdle");
            }
            canFollow = _statesAllowed.Follow(npcType);
            // Should only activate if Player found
            /*
            canPatrol = _statesAllowed.Patrol(npcType);
            if (canPatrol)
            {
                movementStatesAllowed.Add("canPatrol");
            }
            */
            canWander = _statesAllowed.Wander(npcType);
            if (canWander)
            {
                movementStatesAllowed.Add("canWander");
            }
            canAttack = _statesAllowed.Attack(npcType);
            // Should only activate if Player found and alignment check failed
            canAvoidance = _statesAllowed.Avoid(npcType);
            //Should only activate when potential collision detected and
            //NPC does not want to collide
            canAssist = _statesAllowed.Assist(npcType);
            //Should only activate if NPC Race calls for help and close enough
            canIfAttacked = _statesAllowed.IfAttacked(npcType);
            //Should only activate if NPC is attacked
            canFlee = _statesAllowed.Flee(npcType);
            //Should only activate when NPC is hurt
            canDie = _statesAllowed.Die(npcType);
            //Activate when NPC Health = 0
            canCollide = _statesAllowed.Collide(npcType);
            //Only activate when NPC wants to collide with something
            canFlyHome = _statesAllowed.FlyHome(npcType);
            //Should always be a passive check if distance gets
            //to far from planet.
            if (canFlyHome)
            {
                movementStatesAllowed.Add("canFlyHome");
            }
            canFlyDeepSpace = _statesAllowed.FlyDeepSpace(npcType);
            if (canFlyDeepSpace)
            {
                movementStatesAllowed.Add("canFlyDeepSpace");
            }

        }

        public float NumSign()
        {
            sign = randNum.RandomNumberInt(1, 2);
            if (sign == 1)
            {
                return sign;
            }
            sign = -1;
            return sign;
        }
    }
}
