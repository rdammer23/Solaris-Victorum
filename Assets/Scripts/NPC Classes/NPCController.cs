using Assets.Scripts.NPC_Classes.StateManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class NPCController:MonoBehaviour
    {
        /*
        This sits on each NPC and controls all actions of the NPC
        Make this lean and call out to other classes for bulk of work

        - States Allowed
        - Avoidance
        - Auto Heal
        - Health Change
        - Need to remove Patrol as a possible state
        - Death and auto respawn somewhere away from player
        - Attacking
        
        Upon every state change, NPC should get speeds for that state
        Should be able to reuse the varibale across each state and not have
        different variables for each state type


        Upon Awake, should get type and cache it on this NPC and pass it
        */


        //What is the point of IDLE? Are there special Use Cases for it?
        //Maybe later on in game when I add different attack patterns and NPC needs to wait for 
        //other things to happen?
        private bool canIdle = false;

        //What is the point of FOLLOW? Are there special Use Cases for it?
        //Maybe later on in game when I add different attack patterns and NPC needs to wait
        //for help to arrive, but wants to keep an "eye" on the player?
        private bool canFollow = false;

        private bool canWander = false; //Primary State NPC should be in when not attacking
        private bool canAttack = false;
        private bool canAvoidance = false;
        private bool canAssist = false;
        private bool canIfAttacked = false;
        private bool canFlee = false;
        private bool canDie = false;
        private bool canCollide = false;

        //CANFLYHOME should only engage under 2 scenarios
        //1. NPC is up against the edge of the scene and has been there for a bit of time
        //Maybe triggered if NPC runs into scene edge X times
        //2. Home world under attack and distress call went out for help
        //If this happens, NPC should fly X times faster than indicated speed
        private bool canFlyHome = false;

        //CANFLYDEEPSPACE - Not sure what this state would be used for any longer
        //Could be a good way to scatter the NPCs if they are bunched together
        //Would need to add logic in order to support that  
        private bool canFlyDeepSpace = false;

        private int type;

        GameObject poolManager;

        StatesAllowed statesAllowed;

        void Awake()
        {
            poolManager = GameObject.FindGameObjectWithTag("SolarSystemManager");
            statesAllowed = new StatesAllowed();
        }

        void Start()
        {
            type = poolManager.GetComponentInChildren<NPCPoolManager>().GetTypeInt(this.transform.name);
            GetComponentInParent<NPCWander>().enabled = true;

        }

        private void SetStates()
        {
            canIdle = statesAllowed.Idle(type);
            canFollow = statesAllowed.Follow(type);
            canWander = statesAllowed.Wander(type);
            canAttack = statesAllowed.Attack(type);
            canAvoidance = statesAllowed.Avoid(type);
            canAssist = statesAllowed.Assist(type);
            canIfAttacked = statesAllowed.IfAttacked(type);
            canFlee = statesAllowed.Flee(type);
            canDie = statesAllowed.Die(type);
            canCollide = statesAllowed.Collide(type);
            canFlyHome = statesAllowed.FlyHome(type);
            canFlyDeepSpace = statesAllowed.FlyDeepSpace(type);
        }
    }
}
