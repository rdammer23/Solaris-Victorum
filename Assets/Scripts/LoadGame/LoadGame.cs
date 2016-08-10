using Assets.Scripts.Login;
using Assets.Scripts.SavingAndLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.LoadGame
{
    class LoadGame:MonoBehaviour
    {
        static GameObject raceMenu;
        static GameObject createMenu;
        static GameObject loginMenu;
        static GameObject passwordGO;
        static GameObject passwordConfirmGO;
        static GameObject passwordVerifyGO;
        static GameObject nameGO;

        CreatePlayer.CreatePlayer createPlayer;

        public void Awake()
        {
            raceMenu = GameObject.FindWithTag("RaceMenu");
            createMenu = GameObject.FindWithTag("SelectName");
            loginMenu = GameObject.Find("Login");
            passwordGO = GameObject.Find("Password");
            passwordConfirmGO = GameObject.Find("Password Confirm");
            passwordVerifyGO = GameObject.Find("PasswordVerification");
            nameGO = GameObject.Find("Name");
        }

        void Start()
        {
            raceMenu.SetActive(false);
            createMenu.SetActive(false);
            loginMenu.SetActive(false);
            GetComponent<CreatePlayer.CreatePlayer>().enabled = false;
        }

        public void CreateNewAccount()
        {
            //GetComponent<CreatePlayer.CreatePlayer>().enabled = true;
            GetComponent<CreatePlayer.CreationVerifyName>().enabled = true;
            var temp = GameObject.FindWithTag("LoadGame");
            temp.SetActive(false);
            createMenu.SetActive(true);

            passwordGO.SetActive(false);
            passwordConfirmGO.SetActive(false);
            passwordVerifyGO.SetActive(false);
        }

        public void ActivatePasswordFields()
        {
            nameGO.SetActive(false);
            GameObject.Find("NameConfirmed").SetActive(false);
            GameObject.Find("CheckName").SetActive(false);
            passwordGO.SetActive(true);
            passwordConfirmGO.SetActive(true);
            passwordVerifyGO.SetActive(true);
        }

        public void DeactivatePasswordFields()
        {
            passwordGO.SetActive(false);
            passwordConfirmGO.SetActive(false);
            passwordVerifyGO.SetActive(false);
            raceMenu.SetActive(true);
            createPlayer = new CreatePlayer.CreatePlayer();
            createPlayer.RaceMenuActivated();
            
        }

        public void Login()
        {
            var temp = GameObject.FindWithTag("LoadGame");
            temp.SetActive(false);
            loginMenu.SetActive(true);
        }

        public void SubmitLogin()
        {
            var loginNameGO = GameObject.FindWithTag("LoginName");
            var loginPasswordGO = GameObject.FindWithTag("LoginPassword");
            //var loginTextGO = GameObject.FindWithTag("LoginText");

            var loginName = loginNameGO.GetComponentInChildren<Text>().text;
            var loginPassword = loginPasswordGO.GetComponentInChildren<Text>().text;
            //loginTextGO.GetComponentInChildren<Text>().text = "System Under Maintenance.  Please Try Later";

            /*
            Debug.Log(loginName);
            Debug.Log(loginPassword);
            */
            //This should now call something that hits the server, waits for reply and does work

            var logPlayerIn = GameObject.Find("Camera").GetComponentInChildren<LoginPlayer>();
            logPlayerIn.AttemptLogin(loginName, loginPassword);
        }
    }
}
