using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class InstantiatePlayer:MonoBehaviour
    {
        private GameObject player;
        private GameObject homePlanet;
        UpdateDisplay updateDisplay;

        void Awake()
        {
            updateDisplay = new UpdateDisplay();
        }

        void Start()
        {
            
        }

        public void LoadPlayerShip()
        {
            switch (GameData.RaceID)
            {
                case 1:
                    player = Resources.Load("PlayerShips/Human1Player") as GameObject;
                    break;
                case 2:
                    player = Resources.Load("PlayerShips/Feline1Player") as GameObject;
                    break;
                case 3:
                    player = Resources.Load("PlayerShips/Bird1Player") as GameObject;
                    break;
                case 4:
                    player = Resources.Load("PlayerShips/Mystic1Player") as GameObject;
                    break;
                case 5:
                    player = Resources.Load("PlayerShips/Cyborg1Player") as GameObject;
                    break;
                case 6:
                    player = Resources.Load("PlayerShips/Insect1Player") as GameObject;
                    break;
                case 7:
                    player = Resources.Load("PlayerShips/Brain1Player") as GameObject;
                    break;
                case 8:
                    player = Resources.Load("PlayerShips/Metal1Player") as GameObject;
                    break;
                case 9:
                    player = Resources.Load("PlayerShips/Lizard1Player") as GameObject;
                    break;
                case 10:
                    player = Resources.Load("PlayerShips/Tree1Player") as GameObject;
                    break;
                case 11:
                    player = Resources.Load("PlayerShips/Gas1Player") as GameObject;
                    break;
                default:
                    break;
            }

            //Update Instantiate Location
            //FindHomePlanet();
            Instantiate(player, new Vector3(-8000,100,0), Quaternion.identity);

            //updateDisplay.HealthUpdate(GameData.)
        }

        private void FindHomePlanet()
        {
            homePlanet = GameObject.Find("Planet 3");
            
        }
    }
}
