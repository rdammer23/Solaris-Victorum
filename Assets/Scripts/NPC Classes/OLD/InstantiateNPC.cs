using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class InstantiateNPC:MonoBehaviour 
    {
        private GameObject tempNPC;
        public void InstantiateShip(string shipName, string raceName, GameObject ship, GameObject pooler, int counter, string npcName)
        {
            tempNPC = (GameObject)Instantiate(ship);
            tempNPC.AddTag(raceName);
            tempNPC.AddTag(shipName);
            tempNPC.transform.name = npcName;
            tempNPC.transform.parent = pooler.transform;
            tempNPC.GetComponent<HumanNPCController>().enabled = true;
        }
        

         
}
}
