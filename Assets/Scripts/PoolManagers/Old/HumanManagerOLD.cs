using Assets.Scripts.NPC_Classes;
using Assets.Scripts.NPC_Classes.NPC_Hobby;
using Assets.Scripts.NPC_Classes.Ships;
using Assets.Scripts.NPC_Classes.Types;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.PoolManagers
{
    class HumanManagerOLD:MonoBehaviour
    {
        int numberOfActiveHobbies = 19;

        RandomNumber randNum;
        public List<GameObject> humanNPC;

        public GameObject humanNPCPooler;


        NPC_Classes.NPC newHumanNPC;
        BaseNPC _newBaseNPC;
        BaseNPCType _npcType;
        BaseNPCHobby _npcHobby;
        //BaseNPCRace _npcRace;
        BaseNPCShip _npcShip;

        NPCType1 _type1;
        NPCType2 _type2;
        NPCType3 _type3;
        NPCType4 _type4;
        NPCType5 _type5;

        NPCMiner _miner;
        NPCNecromancy _necromancy;
        NPCMarksman _marksman;
        NPCSniper _sniper;
        NPCMonk _monk;
        NPCWeaponsMaker _weaponsmaker;
        NPCDefensiveSpecialist _defensivespecialist;
        NPCIntellectual _intellectual;
        NPCCowboy _cowboy;
        NPCThrillSeeker _thrillseeker;
        NPCAsteroidBeltRacer _asteroidbeltracer;
        NPCExterminator _exterminator;
        NPCMartialArtsExpert _martialartsexpert;
        NPCOpportunist _opportunist;
        NPCPhotographer _photographer;
        NPCKnockOutArtist _knockoutartist;
        NPCScientist _scientist;
        NPCInvention _inventor;
        NPCTaserSpecialist _taserspecialist;
        NPCAssassin _assassin;


        //NPCStateManager _npcStateManager;

        public void Start()
        {
            /*
            Start is part of game initialization and sets the initial values
            of the NPC

            Update will be used for standard game play
            */
            randNum = new RandomNumber();

            _newBaseNPC = new BaseNPC();
            //_npcRace = new BaseNPCRace();
            _npcShip = new BaseNPCShip();
            _npcType = new BaseNPCType();
            _npcHobby = new BaseNPCHobby();
            //newHumanNPC = new NPC_Classes.NPC();

            _type1 = new NPCType1();
            _type2 = new NPCType2();
            _type3 = new NPCType3();
            _type4 = new NPCType4();
            _type5 = new NPCType5();

            _miner = new NPCMiner();
            _necromancy = new NPCNecromancy();
            _marksman = new NPCMarksman();
            _sniper = new NPCSniper();
            _monk = new NPCMonk();
            _weaponsmaker = new NPCWeaponsMaker();
            _defensivespecialist = new NPCDefensiveSpecialist();
            _intellectual = new NPCIntellectual();
            _cowboy = new NPCCowboy();
            _thrillseeker = new NPCThrillSeeker();
            _asteroidbeltracer = new NPCAsteroidBeltRacer();
            _exterminator = new NPCExterminator();
            _martialartsexpert = new NPCMartialArtsExpert();
            _opportunist = new NPCOpportunist();
            _photographer = new NPCPhotographer();
            _knockoutartist = new NPCKnockOutArtist();
            _scientist = new NPCScientist();
            _inventor = new NPCInvention(); //Still needs to be defined
            _taserspecialist = new NPCTaserSpecialist();
            _assassin = new NPCAssassin(); //Currently Not Used



            GameObject[] gos = MultiTags.FindGameObjectsWithMultiTag("NPCHuman");
            int x = 0;
            foreach (GameObject g in gos)
            {
                _newBaseNPC = new BaseNPC();
                _npcShip = new BaseNPCShip();
                _npcType = new BaseNPCType();
                _npcHobby = new BaseNPCHobby();

               // newHumanNPC = new NPC_Classes.NPC(); //This is where NPC gets stored once created

                SetType(x);
                SetHobby();
                _newBaseNPC.NpcLevel = SetNPCLevel();
                Debug.Log("Level:" + _newBaseNPC.NpcLevel);
                //Debug.Log("********************");
                //Debug.Log("Ship Number: " + x);


                //humanNPC = new NPC_Classes.NPC();
                //humanNPC.Add(NPC_Classes.NPC);

                //humanNPC.Add(g);
                //g.transform.name = g.transform.name + x;
                //g.transform.parent = humanNPCPooler.transform;
                //g.SetActive(false);
                x++;
            }

        }

        public void SetType(int x)
        {
            //If Type = 5 then do not change when activated;
            //Otherwise can change to anything but 5
            if(x < 5)
            {
                _npcType = _type5;
            }
            else
            {
                switch (randNum.RandomNumberInt(1, 4))
                {
                    case 1:
                        _npcType = _type1;
                        break;
                    case 2:
                        _npcType = _type2;
                        break;
                    case 3:
                        _npcType = _type3;
                        break;
                    case 4:
                        _npcType = _type4;
                        break;
                }
            }
        }
        
        public void SetHobby()
        {
            _npcHobby = new BaseNPCHobby();
            //This can change everytime the NPC Activates
            int hobbyLevel = randNum.RandomNumberInt(1, 10);

            switch (randNum.RandomNumberInt(1, numberOfActiveHobbies))
            {
                case 1:
                    _npcHobby.NpcHobbyLevel = hobbyLevel;
                    _npcHobby = _miner;
                    _npcHobby.IsMiner = true;
                    _npcHobby.NpcHobbyLevel = hobbyLevel;


                    break;
                case 2:
                    _npcHobby = _necromancy;
                    break;
                case 3:
                    _npcHobby = _marksman;
                    _npcHobby.IsMarksman = true;
                    break;
                case 4:
                    _npcHobby = _sniper;
                    _npcHobby.IsSniper = true;
                    break;
                case 5:
                    _npcHobby = _monk;
                    _npcHobby.IsMonk = true;
                    break;
                case 6:
                    _npcHobby = _weaponsmaker;
                    _npcHobby.IsWeaponsMaker = true;
                    break;
                case 7:
                    _npcHobby = _defensivespecialist;
                    _npcHobby.IsDefensiveSpecialist = true;
                    break;
                case 8:
                    _npcHobby = _intellectual;
                    _npcHobby.IsIntellectual = true;
                    break;
                case 9:
                    _npcHobby = _cowboy;
                    _npcHobby.IsCowboy = true;
                    break;
                case 10:
                    _npcHobby = _thrillseeker;
                    _npcHobby.IsThrillSeeker = true;
                    break;
                case 11:
                    _npcHobby = _asteroidbeltracer;
                    _npcHobby.IsAsteroidBeltRacer = true;
                    break;
                case 12:
                    _npcHobby = _exterminator;
                    _npcHobby.IsExterminator = true;
                    break;
                case 13:
                    _npcHobby = _martialartsexpert;
                    _npcHobby.IsMartialArtsExpert = true;
                    break;
                case 14:
                    _npcHobby = _opportunist;
                    _npcHobby.IsOpportunist = true;
                    break;
                case 15:
                    _npcHobby = _photographer;
                    _npcHobby.IsPhotographer = true;
                    break;
                case 16:
                    _npcHobby = _knockoutartist;
                    _npcHobby.IsKnockoutArtist = true;
                    break;
                case 17:
                    _npcHobby = _scientist;
                    _npcHobby.IsScientist = true;
                    break;
                case 18:
                    _npcHobby = _inventor;
                    _npcHobby.IsInventor = true;
                    break;
                case 19:
                    _npcHobby = _taserspecialist;
                    _npcHobby.IsTaserSpecialist = true;
                    break;
            }
            _npcHobby.NpcHobbyLevel = hobbyLevel;
            /*
            Debug.Log("Hobby level: " + _npcHobby.NpcHobbyLevel);
            Debug.Log("Hobby ID: " + _npcHobby.NpcHobbyId);
            Debug.Log("original vale:" + _npcHobby.EnergyConversion);
            Debug.Log("some miner value:" + _npcHobby.MinerAdjGas);
            */
        }

        public int SetNPCLevel()
        {
            return (randNum.RandomNumberInt(1, 5));
        }

        public void SetAttributeBonuses()
        {
            //This will change everytime NPC Activates if any of the above change
        }

        public void FinalStats()
        {
            //This will change everytime NPC Activates if any of the above change
        }
    }
}
