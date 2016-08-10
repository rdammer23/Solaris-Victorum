using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using Assets.Scripts.NPC_Classes.PoolManagers;

namespace Assets.Scripts.NPC_Classes
{
    
    class NPCNameLable:MonoBehaviour
    {
        NPCPoolManager npcPoolManager;
        GameObject mainCamera;
        TextMesh npcInfo;
        TextMesh npcHealth;

        private string race;
        private string type;
        private string health;
        private string level;

        void Start()
        {
            npcPoolManager = new NPCPoolManager();
            mainCamera = GameObject.FindGameObjectWithTag("Player");
            if(mainCamera == null)
            {
                //TODO added this in order to prevent errors while testing
                //Think I will need to make sure this script is not run until after player
                //is instantiated, or just add a function that resets position text should point
                //Function is called PlayerJoined and needs to be called
                mainCamera = GameObject.FindGameObjectWithTag("LocalStar");
            }
            npcInfo = GetComponentInChildren<TextMesh>();

            /*
            Used if I add another textmesh
            var tempStuff = GetComponentsInChildren<TextMesh>();

            foreach (TextMesh t in tempStuff)
            {
                if(t.gameObject.tag == "NPCName")
                {
                    npcInfo = t;
                }
                if (t.gameObject.tag == "NPCHealth")
                {
                    npcHealth = t;
                }
            }
            */
            race = npcPoolManager.GetRaceName(this.transform.parent.transform.name);
            type = npcPoolManager.GetTypeName(this.transform.parent.transform.name);
            level = "Level " + npcPoolManager.GetLevel(this.transform.parent.transform.name).ToString();
            health = "Current Health: " + npcPoolManager.GetMaxHealth(this.transform.parent.transform.name).ToString();

            npcInfo.text = level +" " + race + "\n";
            npcInfo.text += type + "\n";
            npcInfo.text += health + "\n";

            //npcInfo.transform.rotation = Quaternion.LookRotation(transform.position - mainCamera.transform.position);
        }

        void Update()
        {
            //TODO If player is rotated, text shows at camera angle...Make text always display heads up
            npcInfo.transform.rotation = Quaternion.LookRotation(transform.position - mainCamera.transform.position);
        }

        public void UpdateDisplay()
        {
            level = "Level " + npcPoolManager.GetLevel(this.transform.parent.transform.name).ToString();

            npcInfo.text = level + " " + race + "\n";
            npcInfo.text += type + "\n";
            npcInfo.text += "Current Health: " + health + "\n";
        }
        public void UpdateHealth(int newHealth)
        {
            health = newHealth.ToString();
            UpdateDisplay();
        }

        public void PlayerJoined()
        {
            mainCamera = GameObject.FindGameObjectWithTag("Player");
        }
    }
}