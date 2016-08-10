/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BeardedManStudios.Network;

namespace Assets.Scripts.NPC
{
    class SetNPCActive:NetworkedMonoBehavior
    {
        //Upon Player Login, set the active state of NPC
        //This is due to the NPC Pooling Manger being used
        //To minimizie the number of instantiates while in gameplay

        NPCHealth _npcHealth;

        bool isInitialSetup = false;

        private void Awake()
        {
            isInitialSetup = true;
        }
           
        private void Start()
        {
            if (!(OwningNetWorker.IsServer))
            {
                RPC("NPCActive", NetworkReceivers.Server);
            }
        }
*/
/*
        private void OnEnable()
        {
            if (!isInitialSetup)
            {
                if (OwningNetWorker.IsServer)
                {
                    bool isActive = true;
                    RPC("NPCSetActiveState", NetworkReceivers.All, isActive);
                }
            }
            isInitialSetup = false;
        }
*/
/*
        [BRPC]
        public void NPCActive()
        {
            //Runs on Server to check the Active State of NPC

            bool isActive;
            Debug.Log("I am in NPCActive");
            if (this.gameObject.activeSelf)
            {
                //Call Set Active on Clinet
                isActive = true;
                Debug.Log(isActive);
                RPC("NPCSetActiveState", isActive);
            }
            else
            {
                //Call Set Not Active on Client
                isActive = false;
                Debug.Log(isActive);
                RPC("NPCSetActiveState", isActive);
            }
        }



        [BRPC]
        public void NPCSetActiveState(bool isActive)
        {
            //Runs on Client once server returns NPC Active state
            if (!(OwningNetWorker.IsServer))
            {
                Debug.Log("NPC State = " + isActive + " " + this.gameObject.name);
                this.gameObject.SetActive(isActive);
                if (isActive)
                {
                    //_npcHealth = new NPCHealth();
                    _npcHealth = this.gameObject.GetComponent<NPCHealth>();
                    _npcHealth.InitializeHealth();
                }
            }
        }
        
    }
}
*/