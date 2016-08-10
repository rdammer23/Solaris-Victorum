using Assets.Scripts.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Orbit
{
    class OrbitMenuControl:MonoBehaviour
    {
        /*
        Control Button Functions of Orbit Menu
        Functionality will be in own Class files
        */
        GameObject mainMenuGO;
        GameObject playerInfoGO;
        GameObject playerGeneralGO;

        SetValues setValue;

        void Awake()
        {
            mainMenuGO = GameObject.Find("MainOrbitMenu");
            playerInfoGO = GameObject.Find("PlayerInformation");
            playerGeneralGO = GameObject.Find("PlayerGeneral");

            setValue = new SetValues();
            setValue.SetPlayerValues();
            
        }

        void Start()
        {

            ActivateMainMenu();
            /*
            Debug.Log(GameData.PlayerName);
            Debug.Log(GameData.PlayerID);
            Debug.Log(GameData.RaceID);
            */

        }

        public void ActivateMainMenu()
        {
            DeactivateAll();
            mainMenuGO.SetActive(true);
        }

        public void ActivatePlayerInfo()
        {
            DeactivateAll();
            playerInfoGO.SetActive(true);
        }

        public void ActivatePlayerGeneral()
        {
            DeactivateAll();
            playerGeneralGO.SetActive(true);
        }

        private void DeactivateAll()
        {
            mainMenuGO.SetActive(false);
            playerInfoGO.SetActive(false);
            playerGeneralGO.SetActive(false);
        }

        public void LeaveOrbit()
        {
            if(GameData.CurrentScene == null)
            {
                //TODO Need to save current solar system when exit
                SetCurrentScene();
            }
            //Debug.Log(GameData.CurrentScene);
            LoadSolarSystem();
        }

        private void SetCurrentScene()
        {
            switch (GameData.RaceID)
            {
                case 1:
                    GameData.CurrentScene = "SolarSystem1";
                    break;
                case 2:
                    GameData.CurrentScene = "SolarSystem2";
                    break;
                case 3:
                    GameData.CurrentScene = "SolarSystem3";
                    break;
                case 4:
                    GameData.CurrentScene = "SolarSystem4";
                    break;
                case 5:
                    GameData.CurrentScene = "SolarSystem5";
                    break;
                case 6:
                    GameData.CurrentScene = "SolarSystem6";
                    break;
                case 7:
                    GameData.CurrentScene = "SolarSystem7";
                    break;
                case 8:
                    GameData.CurrentScene = "SolarSystem8";
                    break;
                case 9:
                    GameData.CurrentScene = "SolarSystem9";
                    break;
                case 10:
                    GameData.CurrentScene = "SolarSystem10";
                    break;
                case 11:
                    GameData.CurrentScene = "SolarSystem11";
                    break;
                case 99:
                    GameData.CurrentScene = "SolarSystem1";
                    break;
                default:
                    break;

            }
        }

        private void LoadSolarSystem()
        {
            switch (GameData.CurrentScene)
            {
                case "SolarSystem1":
                    Application.LoadLevel("SolarSystem1");
                    break;
                case "SolarSystem2":
                    Application.LoadLevel("SolarSystem2");
                    break;
                case "SolarSystem3":
                    Application.LoadLevel("SolarSystem3");
                    break;
                case "SolarSystem4":
                    Application.LoadLevel("SolarSystem4");
                    break;
                case "SolarSystem5":
                    Application.LoadLevel("SolarSystem5");
                    break;
                case "SolarSystem6":
                    Application.LoadLevel("SolarSystem6");
                    break;
                case "SolarSystem7":
                    Application.LoadLevel("SolarSystem7");
                    break;
                case "SolarSystem8":
                    Application.LoadLevel("SolarSystem8");
                    break;
                case "SolarSystem9":
                    Application.LoadLevel("SolarSystem9");
                    break;
                case "SolarSystem10":
                    Application.LoadLevel("SolarSystem10");
                    break;
                case "SolarSystem11":
                    Application.LoadLevel("SolarSystem11");
                    break;
                default:
                    break;
            }
        }
    }
}
