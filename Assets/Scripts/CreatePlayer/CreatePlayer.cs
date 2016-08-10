using Assets.Scripts.Attributes;
using Assets.Scripts.Base_Player;
using Assets.Scripts.Create_SolarSystem;
using Assets.Scripts.Race_Classes;
using Assets.Scripts.SavingAndLoading;
using Assets.Scripts.Ship;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.CreatePlayer
{
    class CreatePlayer:MonoBehaviour
    {
        private BasePlayer newPlayer;
        AttributeStatModPlayer attributeMods;
        ShipPlayer shipStats;
        SaveData saveData;
        LoadGame.LoadGame loadGame;

        private bool raceSelected = false;

        private int startAttribute = 10;

        private string playerName = null;
        private string password = null;
        private string cPassword = null;

        static Text passwordText;
        static Text cPasswordText;
        static GameObject raceDescription;
        static GameObject finalSaveGO;
        static GameObject saveAndContinue;

        //static GameObject[] raceButtons;

        void Awake()
        {
            newPlayer = new BasePlayer();
            shipStats = new ShipPlayer();
            attributeMods = new AttributeStatModPlayer();
            loadGame = new LoadGame.LoadGame();

            raceDescription = GameObject.FindWithTag("RaceDescription");
            saveAndContinue = GameObject.FindWithTag("SaveAndContinue");
            
            //raceButtons =  GameObject.FindGameObjectsWithTag("RaceButton");
            //foreach (GameObject b in raceButtons)
            //{
            //    b.SetActive(false);
            //}
        }

        void Start()
        {
            saveAndContinue.SetActive(false);
        }

        public void VerifyPassword()
        {
            var passwordMsg = GameObject.Find("PasswordVerification").GetComponentInChildren<Text>();
            passwordText = GameObject.FindWithTag("Password").GetComponent<Text>();
            cPasswordText = GameObject.FindWithTag("PasswordConfirm").GetComponent<Text>();
            password = passwordText.text;
            cPassword = cPasswordText.text;
            Debug.Log(password);
            if(password.Length < 7)
            {
                passwordMsg.text = "Longer Password Needed!";
            }
            else if(password != cPassword)
            {
                passwordMsg.text = "Passwords Don't Match!";
            }
            else if(password == cPassword)
            {
                loadGame.DeactivatePasswordFields();
            }
        }

        public void ActivatePassword()
        {
            loadGame.ActivatePasswordFields();
        }

        public void CreateSolarSystem()
        {
            var saveAllData = GameObject.Find("Camera").GetComponentInChildren<SaveData>();
            saveAllData.SaveNewAccount(password);
            //saveData = new SaveData();
            //saveData.SaveNewAccount(password);
        }

        public void RaceMenuActivated()
        {
            finalSaveGO = GameObject.FindWithTag("SaveAndContinue");
            finalSaveGO.SetActive(false);
        }

        private void ActivateFinalSaveButton()
        {
            //finalSaveGO = GameObject.FindWithTag("SaveAndContinue");
            finalSaveGO.SetActive(true);
        }

        public void HumanSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 1;
            raceDescription.GetComponent<Text>().text = "The Human: Best all around race as all other races are compared to them." +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 10(1)" +
                "\tIntelligence: 10(1)" +
                "\tDexterity: 10(1)" +
                "\r\nWisdom: 10(1)" +
                "\tHealth: 10(1)" +
                "\tEagle Eyes: 10(1)" +
                "\r\nSpeed: 10(1)" +
                "\tEndurance: 10(1)" +
                "\r\nNerves of Steel: 10(1)" +
                "\tChrisma: 10(1)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: 500" +
                "\tKarakal: -100" +
                "\tAves: 100" +
                "\r\nEsoteric: -100" +
                "\tNische: -100" +
                "\tTricho: -100" +
                "\r\nMavin: 100" +
                "\tEstati: 0" +
                "\tTeiid: 100" +
                "\r\nRoidal: -100" +
                "\tAerifo: 0";
            //newPlayer.PlayerRace = new HumanRace();
            //raceSelected = true;
        }

        public void FelineSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 2;
            raceDescription.GetComponent<Text>().text = "The Karakal: A feline-like race." +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 9(.9)" +
                "\tIntelligence: 15(1.5)" +
                "\tDexterity: 7(.7)" +
                "\r\nWisdom: 8(.8)" +
                "\tHealth: 10(1)" +
                "\tEagle Eyes: .5(.5)" +
                "\r\nSpeed: 13(1.3)" +
                "\tEndurance: 10(1)" +
                "\r\nNerves of Steel: 13(1.3)" +
                "\tChrisma: 10(1)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: -100" +
                "\tKarakal: 500" +
                "\tAves: -100" +
                "\r\nEsoteric: 100" +
                "\tNische: 100" +
                "\tTricho: -100" +
                "\r\nMavin: 100" +
                "\tEstati: 0" +
                "\tTeiid: -100" +
                "\r\nRoidal: 0" +
                "\tAerifo: 0";
        }

        public void BirdSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 3;
            raceDescription.GetComponent<Text>().text = "The Aves: A humanoid with the ability of flight." +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 7(.7)" +
                "\tIntelligence: 10(1)" +
                "\tDexterity: 15(1.5)" +
                "\r\nWisdom: 10(1)" +
                "\tHealth: 7(.7)" +
                "\tEagle Eyes: 13(1.3)" +
                "\r\nSpeed: 13(1.3)" +
                "\tEndurance: 10(1)" +
                "\r\nNerves of Steel: 5(.5)" +
                "\tChrisma: 10(1)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: 100" +
                "\tKarakal: -100" +
                "\tAves: 500" +
                "\r\nEsoteric: 100" +
                "\tNische: 100" +
                "\tTricho: -100" +
                "\r\nMavin: 100" +
                "\tEstati: -100" +
                "\tTeiid: -100" +
                "\r\nRoidal: 100" +
                "\tAerifo: 0";
        }

        public void MysticSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 4;
            raceDescription.GetComponent<Text>().text = "The Esoteric: A mystical being with unique powers." +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 7(.7)" +
                "\tIntelligence: 10(1)" +
                "\tDexterity: 10(1)" +
                "\r\nWisdom: 15(1.5)" +
                "\tHealth: 13(1.3)" +
                "\tEagle Eyes: 7(.7)" +
                "\r\nSpeed: 10(1)" +
                "\tEndurance: 5(.5)" +
                "\r\nNerves of Steel: 10(1)" +
                "\tChrisma: 13(1.3)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: -100" +
                "\tKarakal: 100" +
                "\tAves: 100" +
                "\r\nEsoteric: 500" +
                "\tNische: 100" +
                "\tTricho: 0" +
                "\r\nMavin: -100" +
                "\tEstati: 100" +
                "\tTeiid: -100" +
                "\r\nRoidal: -100" +
                "\tAerifo: -100";
        }

        public void CyborgSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 5;
            raceDescription.GetComponent<Text>().text = "The Nische: Half Man, Half Machine, All Power." +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 15(1.5)" +
                "\tIntelligence: 5(.5)" +
                "\tDexterity: 10(1)" +
                "\r\nWisdom: 7(.7)" +
                "\tHealth: 10(1)" +
                "\tEagle Eyes: 10(1)" +
                "\r\nSpeed: 13(1.3)" +
                "\tEndurance: 13(1.3)" +
                "\r\nNerves of Steel: 10(1)" +
                "\tChrisma: 7(.7)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: -100" +
                "\tKarakal: 100" +
                "\tAves: 100" +
                "\r\nEsoteric: 100" +
                "\tNische: 500" +
                "\tTricho: 0" +
                "\r\nMavin: -100" +
                "\tEstati: -100" +
                "\tTeiid: 0" +
                "\r\nRoidal: 0" +
                "\tAerifo: -100";
        }

        public void InsectSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 6;
            raceDescription.GetComponent<Text>().text = "The Tricho: Hard outside, squishy inside, just like a bug" +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 10(1)" +
                "\tIntelligence: 13(1.3)" +
                "\tDexterity: 15(1.5)" +
                "\r\nWisdom: 10(1)" +
                "\tHealth: 5(.5)" +
                "\tEagle Eyes: 10(1)" +
                "\r\nSpeed: 7(.7)" +
                "\tEndurance: 7(.7)" +
                "\r\nNerves of Steel: 13(1.3)" +
                "\tChrisma: 10(1)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: -100" +
                "\tKarakal: -100" +
                "\tAves: -100" +
                "\r\nEsoteric: 0" +
                "\tNische: 0" +
                "\tTricho: 500" +
                "\r\nMavin: 100" +
                "\tEstati: 0" +
                "\tTeiid: -100" +
                "\r\nRoidal: 100" +
                "\tAerifo: 0";
        }

        public void BrainSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 7;
            raceDescription.GetComponent<Text>().text = "The Mavin: Smart and Strong, these nerds know where to use their smarts" +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 13(1.3)" +
                "\tIntelligence: 15(1.5)" +
                "\tDexterity: 10(1)" +
                "\r\nWisdom: 13(1.3)" +
                "\tHealth: 10(1)" +
                "\tEagle Eyes: 7(.7)" +
                "\r\nSpeed: 10(1)" +
                "\tEndurance: 5(.5)" +
                "\r\nNerves of Steel: 10(1)" +
                "\tChrisma: 7(.7)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: 100" +
                "\tKarakal: 100" +
                "\tAves: 100" +
                "\r\nEsoteric: -100" +
                "\tNische: -100" +
                "\tTricho: 100" +
                "\r\nMavin: 500" +
                "\tEstati: 0" +
                "\tTeiid: 0" +
                "\r\nRoidal: 0" +
                "\tAerifo: -100";
        }

        public void MetalSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 8;
            raceDescription.GetComponent<Text>().text = "The Estati: Being made of metal makes you strong, but slow" +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 16(1.6)" +
                "\tIntelligence: 5(.5)" +
                "\tDexterity: 10(1)" +
                "\r\nWisdom: 7(.7)" +
                "\tHealth: 13(1.3)" +
                "\tEagle Eyes: 10(1)" +
                "\r\nSpeed: 6(.6)" +
                "\tEndurance: 10(1)" +
                "\r\nNerves of Steel: 13(1.3)" +
                "\tChrisma: 10(1)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: 0" +
                "\tKarakal: 0" +
                "\tAves: -100" +
                "\r\nEsoteric: 100" +
                "\tNische: -100" +
                "\tTricho: 0" +
                "\r\nMavin: 0" +
                "\tEstati: 500" +
                "\tTeiid: 0" +
                "\r\nRoidal: 100" +
                "\tAerifo: 100";
        }

        public void LizardSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 9;
            raceDescription.GetComponent<Text>().text = "The Teiid: Lizardlike humanoids" +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 7(.7)" +
                "\tIntelligence: 10(1)" +
                "\tDexterity: 6(.6)" +
                "\r\nWisdom: 10(1)" +
                "\tHealth: 10(1)" +
                "\tEagle Eyes: 14(1.4)" +
                "\r\nSpeed: 10(1)" +
                "\tEndurance: 14(1.4)" +
                "\r\nNerves of Steel: 6(.6)" +
                "\tChrisma: 13(1.3)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: 100" +
                "\tKarakal: -100" +
                "\tAves: -100" +
                "\r\nEsoteric: -100" +
                "\tNische: 0" +
                "\tTricho: -100" +
                "\r\nMavin: 0" +
                "\tEstati: 0" +
                "\tTeiid: 500" +
                "\r\nRoidal: 100" +
                "\tAerifo: 0";
        }

        public void TreeSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 10;
            raceDescription.GetComponent<Text>().text = "The Roidal: Mother Nature at her badest" +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 10(1)" +
                "\tIntelligence: 7(.7)" +
                "\tDexterity: 5(.5)" +
                "\r\nWisdom: 15(1.5)" +
                "\tHealth: 15(1.5)" +
                "\tEagle Eyes: 9(.9)" +
                "\r\nSpeed: 6(.6)" +
                "\tEndurance: 10(1)" +
                "\r\nNerves of Steel: 10(1)" +
                "\tChrisma: 13(1.3)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: -100" +
                "\tKarakal: 0" +
                "\tAves: 100" +
                "\r\nEsoteric: -100" +
                "\tNische: 0" +
                "\tTricho: 100" +
                "\r\nMavin: 0" +
                "\tEstati: 100" +
                "\tTeiid: 100" +
                "\r\nRoidal: 500" +
                "\tAerifo: -100";
        }

        public void GasSelected()
        {
            ActivateFinalSaveButton();
            GameData.RaceID = 11;
            raceDescription.GetComponent<Text>().text = "The Aerifo: A Gasous form has advantages, but no one likes you" +
                "\r\n\nStarting Stats. Number in () indicate increase for each attribute point used after leveling" +
                "\r\nStrength: 10(1)" +
                "\tIntelligence: 10(1)" +
                "\tDexterity: 15(1.5)" +
                "\r\nWisdom: 10(1)" +
                "\tHealth: 5(.5)" +
                "\tEagle Eyes: 13(1.3)" +
                "\r\nSpeed: 10(1)" +
                "\tEndurance: 13(1.3)" +
                "\r\nNerves of Steel: 7(.7)" +
                "\tChrisma: 7(.7)" +

                "\r\n\nStarting Alignments(-1000 to 1000)" +
                "\r\nHuman: 0" +
                "\tKarakal: 0" +
                "\tAves: 0" +
                "\r\nEsoteric: -100" +
                "\tNische: -100" +
                "\tTricho: 0" +
                "\r\nMavin: -100" +
                "\tEstati: 100" +
                "\tTeiid: 0" +
                "\r\nRoidal: -100" +
                "\tAerifo: 500";
        }
        
        /*
        private void StoreNewPlayerData()
        {
            GameData.PlayerName = newPlayer.PlayerName;
            GameData.PlayerLevel = newPlayer.PlayerLevel;
            GameData.PlayerRace = newPlayer.PlayerRace;
            GameData.CurrentLevelXP = newPlayer.CurrentXPLevel;
            GameData.ShipID = newPlayer.ShipID;
            GameData.MaxHealth = newPlayer.MaxHealth;
            GameData.CurrentHealth = newPlayer.CurrentHealth;
            GameData.UnUsedAttributePoints = 0;

            GameData.Strength = newPlayer.Strength;
            GameData.Intelligence = newPlayer.Intelligence;
            GameData.Dexterity = newPlayer.Dexterity;
            GameData.Wisdom = newPlayer.Wisdom;
            GameData.Health = newPlayer.Health;
            GameData.EagleEyes = newPlayer.EagleEyes;
            GameData.Speed = newPlayer.Speed;
            GameData.Endurance = newPlayer.Endurance;
            GameData.NervesOfSteel = newPlayer.NervesOfSteel;
            GameData.Charisma = newPlayer.Charisma;

            GameData.AlignmentHuman = newPlayer.AlignmentHuman;
            GameData.AlignmentFeline = newPlayer.AlignmentFeline;
            GameData.AlignmentBird = newPlayer.AlignmentBird;
            GameData.AlignmentMystic = newPlayer.AlignmentMystic;
            GameData.AlignmentCyborgs = newPlayer.AlignmentCyborgs;
            GameData.AlignmentInsect = newPlayer.AlignmentInsect;
            GameData.AlignmentBrains = newPlayer.AlignmentBrains;
            GameData.AlignmentMetal = newPlayer.AlignmentMetal;
            GameData.AlignmentLizard = newPlayer.AlignmentLizard;
            GameData.AlignmentTree = newPlayer.AlignmentTree;
            GameData.AlignmentGas = newPlayer.AlignmentGas;
        }
        */
    }
}
