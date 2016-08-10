using Assets.Scripts.Menu;
using Assets.Scripts.Solar_System_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class TriggerManager: MonoBehaviour
    {
        /*
        Layer 8 = Player
        Layer 9 = Enemy
        Layer 12 = Weapons
        Layer 14 = HeavenlyBody
        Layer 15 = Orbit
        */

        private int player = 8;
        private int enemy = 9;
        private int weapon = 12;
        private int heavenlyBody = 14;
        private int orbit = 15;


        static bool ifOrbit;

        static SolarSystemData solarSystemData;
        PVPStatus pvpState;
        AlertMessageManager newMsg;
        HealthManager healthChange;
        CollisionDirectionChange directionChange;
        CameraShake shake;

        public void Start()
        {
            solarSystemData = new SolarSystemData();
            pvpState = new PVPStatus();
            newMsg = new AlertMessageManager();
            healthChange = new HealthManager();
            directionChange = new CollisionDirectionChange();
            shake = new CameraShake();
        }

        void OnTriggerEnter(Collider other)
        {
            switch (other.gameObject.layer)
            {
                case 8:
                    Debug.Log(this.transform.parent.name + " Collided with Player");
                    break;
                case 9:
                    Debug.Log(this.transform.parent.name + " Collided with: " + other.transform.parent.transform.parent.name);
                    healthChange.ReduceHealth((int)(GameData.MaxHealth * .1f));
                    shake.DoShake(.4f, .02f);
                    directionChange.CollissionHappened();
                    break;
                case 12:
                    Debug.Log("Was hit by a laser ");
                    shake.DoShake(.2f, .02f);
                    other.transform.parent.gameObject.SetActive(false);
                    break;
                case 14:
                    healthChange.ReduceHealth((int)(GameData.MaxHealth * .1f));
                    shake.DoShake(.4f, .02f);
                    directionChange.CollissionHappened();
                    break;
                case 15:
                    /* TODO Need to fix this case
                    if((AlignmentCheck(solarSystemData.GetPlanetOwnerRace(other.transform.parent.transform.name))> 0) && !pvpState.PVPState())
                    {
                        ifOrbit = true;
                        newMsg.NewAlertMessage("You Can Enter Orbit", "Green");
                    }
                    else if(pvpState.PVPState())
                    {
                        ifOrbit = false;
                        newMsg.NewAlertMessage("Cannot Enter Orbit, YOU ARE PVP Flagged!", "Red");
                    }
                    else //This is if an alignment check fail only
                    {
                        ifOrbit = false;
                        newMsg.NewAlertMessage("Cannot Enter Orbit, This is an Enemy World!", "Red");
                    }
                    */
                    break;
                default:
                    break;
            }
        }

        void OnTriggerExit(Collider other)
        {
            switch (other.gameObject.layer)
            {
                case 15:
                    newMsg.NewAlertMessage("Left Orbit Range!", "Green");
                    ifOrbit = false;
                    break;
                default:
                    break;
            }
        }

        public int AlignmentCheck(int race)
        {
            switch (race)
            {
                case 1:
                    return GameData.AlignmentHuman;
                case 2:
                    return GameData.AlignmentFeline;
                case 3:
                    return GameData.AlignmentBird;
                case 4:
                    return GameData.AlignmentMystic;
                case 5:
                    return GameData.AlignmentCyborgs;
                case 6:
                    return GameData.AlignmentInsect;
                case 7:
                    return GameData.AlignmentBrains;
                case 8:
                    return GameData.AlignmentMetal;
                case 9:
                    return GameData.AlignmentLizard;
                case 10:
                    return GameData.AlignmentTree;
                case 11:
                    return GameData.AlignmentGas;
                default:
                    return -1;
            }
        }

        public bool GetIfOrbit()
        {
            newMsg.NewAlertMessage("CANNOT ENTER ORBIT!", "Red");
            return ifOrbit;
        }
    }
}
