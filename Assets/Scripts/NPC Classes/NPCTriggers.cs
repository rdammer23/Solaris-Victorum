using Assets.Scripts.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class NPCTriggers:MonoBehaviour
    {
        /*
        Layer 8 = Player
        Layer 9 = Enemy
        Layer 12 = Weapons
        Layer 14 = HeavenlyBody
        */
        private int heavenlyBody = 14;
        private int enemy = 9;
        private int player = 8;

        LaserDamage laserDamage;
        RandomNumber randNum;

        void OnTriggerEnter(Collider other)
        {
            switch (other.gameObject.layer)
            {
                case 8:
                    //Debug.Log(this.transform.parent.name + " Collided with Player");
                    break;
                case 9:
                    //Debug.Log(this.transform.parent.name + " Collided with: " + other.transform.parent.transform.parent.name);
                    break;
                case 12:
                    //Debug.Log("Was hit by a weapon " + other.transform.parent.transform.name);
                    DetermineLaserDamage((other.transform.parent.transform.name).ToString());
                    Debug.Log(other.transform.position);
                    GetComponentInParent<HumanNPCController>().WasAttacked();
                    break;
                case 14:
                    //Debug.Log(this.transform.parent.name + " Collided with: " + other.transform.parent.name);
                    break;
                default:
                    break;
            }
        }

        private void DetermineLaserDamage(string whatHit)
        {
            laserDamage = new LaserDamage();
            randNum = new RandomNumber();
            //Debug.Log(whatHit);
            int minDamage;
            int maxDamage;
            switch (whatHit)
            {
                case "YellowLaserPlayer":
                    minDamage = laserDamage.YellowLaserMinDamage();
                    maxDamage = laserDamage.YellowLaserMaxDamage();
                    break;
                default:
                    minDamage = laserDamage.YellowLaserMinDamage();
                    maxDamage = laserDamage.YellowLaserMaxDamage();
                    break;
            }
            int damageTaken = randNum.RandomNumberInt(minDamage, maxDamage);
            //int damageTaken = 1000;
            GetComponentInChildren<NPCExplosion>().LaserExplosion(this.transform);
            GetComponentInParent<HumanNPCController>().DecreaseHealth(damageTaken);
        }
    }
}
