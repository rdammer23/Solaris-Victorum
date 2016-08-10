using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Security.Cryptography;

namespace Assets.Scripts.CreatePlayer
{
    class CreationVerifyName:MonoBehaviour
    {
        private string playerName = null;
        //Need a way to confirm after name is verified
        //Player did not add to it and try to submit an unverified name. 
        //Will use GameData.PlayerName for that
        

        public string checkingNameURL = "http://solarisvictorum.space/solarisvictorum/php/CreateAccount.php?"; //be sure to add a ? to your url

        private Text nameValidation;
        private bool namePassed = false;
        private GameObject nameConfirmed;

        void Awake()
        {
            nameValidation = GameObject.FindWithTag("CheckName").GetComponentInChildren<Text>();
            nameConfirmed = GameObject.Find("NameConfirmed");
        }

        void Start()
        {
            nameValidation.transform.parent.gameObject.SetActive(false);
            nameConfirmed.SetActive(false);
        }

        void Update()
        {
            if (!namePassed)
            {
                playerName = GameObject.FindWithTag("PlayerName").GetComponent<Text>().text;
            }
            if(playerName.Length >= 3 && !namePassed)
            {
                nameValidation.transform.parent.gameObject.SetActive(true);
            }
            else if(playerName.Length < 3 && !namePassed)
            {
                nameValidation.transform.parent.gameObject.SetActive(false);
            }
            if(GameData.PlayerName != playerName)
            {
                Debug.Log(GameData.PlayerName + " " + playerName);
                nameConfirmed.SetActive(false);
            }
        }

        public void CheckName()
        {
            playerName = GameObject.FindWithTag("PlayerName").GetComponent<Text>().text;
            GetCheckName(playerName);
        }

        public WWW GetCheckName(string wantedName)
        {
            

            string post_url = checkingNameURL + "name=" + WWW.EscapeURL(wantedName);
            WWW validName = new WWW(post_url);

            StartCoroutine(WaitForRequest(validName));
            return(validName);
        }

        private IEnumerator WaitForRequest(WWW validName)
        {
            yield return validName;

            // check for errors
            if (validName.error == null)
            {
                if (validName.text == "1")
                {
                    nameValidation.text = "Change Name";
                    GameData.PlayerName = playerName;
                    nameConfirmed.SetActive(true);
                    namePassed = true;
                }
                else
                {
                    nameValidation.text = "Not Available! \nTry Again";
                    if (nameConfirmed.activeInHierarchy)
                    {
                        nameConfirmed.SetActive(false);
                    }
                    namePassed = false;
                }
            }
            else
            {
                Debug.Log(validName.error);
            }
        }
    }
}
