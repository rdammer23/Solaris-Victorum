using Assets.Scripts.Solar_System_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.NPC_Classes
{
    class NPCInstantiate:MonoBehaviour
    {
        //TODO There has to be a better way of Instantiation NPCs
        //Currently need to go to every scene and set the prefabs
        //This also gets reloaded every scene

        /*
        1. Determine What Solar System
        2. Instantiate X number NPC
        3. 50% will be race associated with Solar System
        4. 5% will be associated to each of the other 10 races
        5. Call Pool Manager

            1	Humans	Human
            2	Feline	Karakal
            3	Bird	Aves
            4	Mystic	Esoteric
            5	Cyborgs	Nische
            6	Insect	Tricho
            7	Brains	Mavin
            8	Metal	Estati
            9	Lizard	Teiid
            10	Tree	Roidal
            11	Gaseous	Aerifo
            99	Dragon	

        */

        GameObject tempGO;
        RandomNumber randNum;

        //Human
        public GameObject humanShip1;
        public GameObject humanShip2;
        public GameObject humanShip3;

        //Feline
        public GameObject karakalShip1;
        public GameObject karakalShip2;
        public GameObject karakalShip3;

        //Birds
        public GameObject avesShip1;
        public GameObject avesShip2;
        public GameObject avesShip3;

        //Mystics
        public GameObject esotericShip1;
        public GameObject esotericShip2;
        public GameObject esotericShip3;

        //Cyborgs
        public GameObject nischeShip1;
        public GameObject nischeShip2;
        public GameObject nischeShip3;

        //Insect
        public GameObject trichoShip1;
        public GameObject trichoShip2;
        public GameObject trichoShip3;

        //Brains
        public GameObject mavinShip1;
        public GameObject mavinShip2;
        public GameObject mavinShip3;

        //Metal
        public GameObject estatiShip1;
        public GameObject estatiShip2;
        public GameObject estatiShip3;

        //Lizard
        public GameObject teiidShip1;
        public GameObject teiidShip2;
        public GameObject teiidShip3;

        //Tree
        public GameObject roidalShip1;
        public GameObject roidalShip2;
        public GameObject roidalShip3;

        //Gaseous
        public GameObject aerifoShip1;
        public GameObject aerifoShip2;
        public GameObject aerifoShip3;

        //PoolManagers
        private GameObject humanPoolManager;
        private GameObject karakalPoolManager;
        private GameObject avesPoolManager;
        private GameObject esotericPoolManager;
        private GameObject nischePoolManager;
        private GameObject trichoPoolManager;
        private GameObject mavinPoolManager;
        private GameObject estatiPoolManager;
        private GameObject teiidPoolManager;
        private GameObject roidalPoolManager;
        private GameObject aerifoPoolManager;

        void Awake()
        {
            //randNum = new RandomNumber();
        }

        void Start()
        {
            humanPoolManager = GameObject.Find("HumanPoolManager");
            karakalPoolManager = GameObject.Find("KarakalPoolManager");
            avesPoolManager = GameObject.Find("AvesPoolManager");
            esotericPoolManager = GameObject.Find("EsotericPoolManager");
            nischePoolManager = GameObject.Find("NischePoolManager");
            trichoPoolManager = GameObject.Find("TrichoPoolManager");
            mavinPoolManager = GameObject.Find("MavinPoolManager");
            estatiPoolManager = GameObject.Find("EstatiPoolManager");
            teiidPoolManager = GameObject.Find("TeiidPoolManager");
            roidalPoolManager = GameObject.Find("RoidalPoolManager");
            aerifoPoolManager = GameObject.Find("AerifoPoolManager");

        }

        public void CreateNPC(int shipID, int raceID, string npcName, int ssid)
        {
            switch (raceID)
            {
                case 1:
                    InstantiateHuman(shipID, npcName, ssid);
                    break;
                case 2:
                    InstantiateKarakal(shipID, npcName, ssid);
                    break;
                case 3:
                    InstantiateAves(shipID, npcName, ssid);
                    break;
                case 4:
                    InstantiateEsoteric(shipID, npcName, ssid);
                    break;
                case 5:
                    InstantiateNische(shipID, npcName, ssid);
                    break;
                case 6:
                    InstantiateTricho(shipID, npcName, ssid);
                    break;
                case 7:
                    InstantiateMavin(shipID, npcName, ssid);
                    break;
                case 8:
                    InstantiateEstati(shipID, npcName, ssid);
                    break;
                case 9:
                    InstantiateTeiid(shipID, npcName, ssid);
                    break;
                case 10:
                    InstantiateRoidal(shipID, npcName, ssid);
                    break;
                case 11:
                    InstantiateAerifo(shipID, npcName, ssid);
                    break;
            }
            /*
            GameObject shipGO = ShipGO(n.ShipID);
            instantiateNPC.InstantiateShip(tempShipName, raceName, count, poolManager, shipIDer, n.NpcName);
            */
        }
/*
        public void CreateNPC(int ssid)
        {
            Debug.Log(ssid);
            switch (ssid)
            {
                case 1001:
                    InstantiateHuman(numberPrimaryNPCInstantiate);
                    InstantiateKarakal(numberSecondaryNPCInstantiate);
                    InstantiateAves(numberSecondaryNPCInstantiate);
                    InstantiateEsoteric(numberSecondaryNPCInstantiate);
                    InstantiateNische(numberSecondaryNPCInstantiate);
                    InstantiateTricho(numberSecondaryNPCInstantiate);
                    InstantiateMavin(numberSecondaryNPCInstantiate);
                    InstantiateEstati(numberSecondaryNPCInstantiate);
                    InstantiateTeiid(numberSecondaryNPCInstantiate);
                    InstantiateRoidal(numberSecondaryNPCInstantiate);
                    InstantiateAerifo(numberSecondaryNPCInstantiate);
                    break;
                case 1002:
                    InstantiateHuman(numberSecondaryNPCInstantiate);
                    InstantiateKarakal(numberPrimaryNPCInstantiate);
                    InstantiateAves(numberSecondaryNPCInstantiate);
                    InstantiateEsoteric(numberSecondaryNPCInstantiate);
                    InstantiateNische(numberSecondaryNPCInstantiate);
                    InstantiateTricho(numberSecondaryNPCInstantiate);
                    InstantiateMavin(numberSecondaryNPCInstantiate);
                    InstantiateEstati(numberSecondaryNPCInstantiate);
                    InstantiateTeiid(numberSecondaryNPCInstantiate);
                    InstantiateRoidal(numberSecondaryNPCInstantiate);
                    InstantiateAerifo(numberSecondaryNPCInstantiate);
                    break;
                case 1003:
                    InstantiateHuman(numberSecondaryNPCInstantiate);
                    InstantiateKarakal(numberSecondaryNPCInstantiate);
                    InstantiateAves(numberPrimaryNPCInstantiate);
                    InstantiateEsoteric(numberSecondaryNPCInstantiate);
                    InstantiateNische(numberSecondaryNPCInstantiate);
                    InstantiateTricho(numberSecondaryNPCInstantiate);
                    InstantiateMavin(numberSecondaryNPCInstantiate);
                    InstantiateEstati(numberSecondaryNPCInstantiate);
                    InstantiateTeiid(numberSecondaryNPCInstantiate);
                    InstantiateRoidal(numberSecondaryNPCInstantiate);
                    InstantiateAerifo(numberSecondaryNPCInstantiate);
                    break;
                case 1004:
                    InstantiateHuman(numberSecondaryNPCInstantiate);
                    InstantiateKarakal(numberSecondaryNPCInstantiate);
                    InstantiateAves(numberSecondaryNPCInstantiate);
                    InstantiateEsoteric(numberPrimaryNPCInstantiate);
                    InstantiateNische(numberSecondaryNPCInstantiate);
                    InstantiateTricho(numberSecondaryNPCInstantiate);
                    InstantiateMavin(numberSecondaryNPCInstantiate);
                    InstantiateEstati(numberSecondaryNPCInstantiate);
                    InstantiateTeiid(numberSecondaryNPCInstantiate);
                    InstantiateRoidal(numberSecondaryNPCInstantiate);
                    InstantiateAerifo(numberSecondaryNPCInstantiate);
                    break;
                case 1005:
                    InstantiateHuman(numberSecondaryNPCInstantiate);
                    InstantiateKarakal(numberSecondaryNPCInstantiate);
                    InstantiateAves(numberSecondaryNPCInstantiate);
                    InstantiateEsoteric(numberSecondaryNPCInstantiate);
                    InstantiateNische(numberPrimaryNPCInstantiate);
                    InstantiateTricho(numberSecondaryNPCInstantiate);
                    InstantiateMavin(numberSecondaryNPCInstantiate);
                    InstantiateEstati(numberSecondaryNPCInstantiate);
                    InstantiateTeiid(numberSecondaryNPCInstantiate);
                    InstantiateRoidal(numberSecondaryNPCInstantiate);
                    InstantiateAerifo(numberSecondaryNPCInstantiate);
                    break;
                case 1006:
                    InstantiateHuman(numberSecondaryNPCInstantiate);
                    InstantiateKarakal(numberSecondaryNPCInstantiate);
                    InstantiateAves(numberSecondaryNPCInstantiate);
                    InstantiateEsoteric(numberSecondaryNPCInstantiate);
                    InstantiateNische(numberSecondaryNPCInstantiate);
                    InstantiateTricho(numberPrimaryNPCInstantiate);
                    InstantiateMavin(numberSecondaryNPCInstantiate);
                    InstantiateEstati(numberSecondaryNPCInstantiate);
                    InstantiateTeiid(numberSecondaryNPCInstantiate);
                    InstantiateRoidal(numberSecondaryNPCInstantiate);
                    InstantiateAerifo(numberSecondaryNPCInstantiate);
                    break;
                case 1007:
                    InstantiateHuman(numberSecondaryNPCInstantiate);
                    InstantiateKarakal(numberSecondaryNPCInstantiate);
                    InstantiateAves(numberSecondaryNPCInstantiate);
                    InstantiateEsoteric(numberSecondaryNPCInstantiate);
                    InstantiateNische(numberSecondaryNPCInstantiate);
                    InstantiateTricho(numberSecondaryNPCInstantiate);
                    InstantiateMavin(numberPrimaryNPCInstantiate);
                    InstantiateEstati(numberSecondaryNPCInstantiate);
                    InstantiateTeiid(numberSecondaryNPCInstantiate);
                    InstantiateRoidal(numberSecondaryNPCInstantiate);
                    InstantiateAerifo(numberSecondaryNPCInstantiate);
                    break;
                case 1008:
                    InstantiateHuman(numberSecondaryNPCInstantiate);
                    InstantiateKarakal(numberSecondaryNPCInstantiate);
                    InstantiateAves(numberSecondaryNPCInstantiate);
                    InstantiateEsoteric(numberSecondaryNPCInstantiate);
                    InstantiateNische(numberSecondaryNPCInstantiate);
                    InstantiateTricho(numberSecondaryNPCInstantiate);
                    InstantiateMavin(numberSecondaryNPCInstantiate);
                    InstantiateEstati(numberPrimaryNPCInstantiate);
                    InstantiateTeiid(numberSecondaryNPCInstantiate);
                    InstantiateRoidal(numberSecondaryNPCInstantiate);
                    InstantiateAerifo(numberSecondaryNPCInstantiate);
                    break;
                case 1009:
                    InstantiateHuman(numberSecondaryNPCInstantiate);
                    InstantiateKarakal(numberSecondaryNPCInstantiate);
                    InstantiateAves(numberSecondaryNPCInstantiate);
                    InstantiateEsoteric(numberSecondaryNPCInstantiate);
                    InstantiateNische(numberSecondaryNPCInstantiate);
                    InstantiateTricho(numberSecondaryNPCInstantiate);
                    InstantiateMavin(numberSecondaryNPCInstantiate);
                    InstantiateEstati(numberSecondaryNPCInstantiate);
                    InstantiateTeiid(numberPrimaryNPCInstantiate);
                    InstantiateRoidal(numberSecondaryNPCInstantiate);
                    InstantiateAerifo(numberSecondaryNPCInstantiate);
                    break;
                case 1010:
                    InstantiateHuman(numberSecondaryNPCInstantiate);
                    InstantiateKarakal(numberSecondaryNPCInstantiate);
                    InstantiateAves(numberSecondaryNPCInstantiate);
                    InstantiateEsoteric(numberSecondaryNPCInstantiate);
                    InstantiateNische(numberSecondaryNPCInstantiate);
                    InstantiateTricho(numberSecondaryNPCInstantiate);
                    InstantiateMavin(numberSecondaryNPCInstantiate);
                    InstantiateEstati(numberSecondaryNPCInstantiate);
                    InstantiateTeiid(numberSecondaryNPCInstantiate);
                    InstantiateRoidal(numberPrimaryNPCInstantiate);
                    InstantiateAerifo(numberSecondaryNPCInstantiate);
                    break;
                case 1011:
                    InstantiateHuman(numberSecondaryNPCInstantiate);
                    InstantiateKarakal(numberSecondaryNPCInstantiate);
                    InstantiateAves(numberSecondaryNPCInstantiate);
                    InstantiateEsoteric(numberSecondaryNPCInstantiate);
                    InstantiateNische(numberSecondaryNPCInstantiate);
                    InstantiateTricho(numberSecondaryNPCInstantiate);
                    InstantiateMavin(numberSecondaryNPCInstantiate);
                    InstantiateEstati(numberSecondaryNPCInstantiate);
                    InstantiateTeiid(numberSecondaryNPCInstantiate);
                    InstantiateRoidal(numberSecondaryNPCInstantiate);
                    InstantiateAerifo(numberPrimaryNPCInstantiate);
                    break;
            }
        }
        */
        private int GetRandom(int min, int max)
        {
            return GetComponentInParent<RandomNumber>().RandomNumberInt(min, max);
        }

        private int GetRandomSign()
        {
            return GetComponentInParent<RandomNumber>().Sign();
        }
        private Vector3 NPCHomeLocation()
        {
            var temp = new Vector3((GetRandomSign() * (GetRandom(0, 17000))), ((GetRandomSign() * GetRandom(0, 17000))), ((GetRandomSign() * GetRandom(0, 5000))));
            return temp;
        }

        private Vector3 NPCNonHomeLocation()
        {
            var temp = new Vector3((GetRandomSign() * (GetRandom(10000, 25000))), ((GetRandomSign() * GetRandom(10000, 25000))), ((GetRandomSign() * GetRandom(6000, 25000))));
            return temp;
        }

        private void InstantiateHuman(int shipID, string npcName, int ssid)
        {
            if(ssid == 1001)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(humanShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(humanShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(humanShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(humanShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(humanShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(humanShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            
            tempGO.transform.name = npcName;
            tempGO.transform.parent = humanPoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0,359), GetRandom(0, 359), GetRandom(0, 359)));
        }

        private void InstantiateKarakal(int shipID, string npcName, int ssid)
        {
            if (ssid == 1002)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(karakalShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(karakalShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(karakalShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(karakalShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(karakalShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(karakalShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }

            tempGO.transform.name = npcName;
            tempGO.transform.parent = karakalPoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0, 359), GetRandom(0, 359), GetRandom(0, 359)));
        }

        private void InstantiateAves(int shipID, string npcName, int ssid)
        {
            if (ssid == 1003)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(avesShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(avesShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(avesShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(avesShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(avesShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(avesShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }

            tempGO.transform.name = npcName;
            tempGO.transform.parent = avesPoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0, 359), GetRandom(0, 359), GetRandom(0, 359)));
        }

        private void InstantiateEsoteric(int shipID, string npcName, int ssid)
        {
            if (ssid == 1004)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(esotericShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(esotericShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(esotericShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(esotericShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(esotericShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(esotericShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }

            tempGO.transform.name = npcName;
            tempGO.transform.parent = esotericPoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0, 359), GetRandom(0, 359), GetRandom(0, 359)));
        }

        private void InstantiateNische(int shipID, string npcName, int ssid)
        {
            if (ssid == 1005)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(nischeShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(nischeShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(nischeShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(nischeShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(nischeShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(nischeShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }

            tempGO.transform.name = npcName;
            tempGO.transform.parent = nischePoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0, 359), GetRandom(0, 359), GetRandom(0, 359)));
        }

        private void InstantiateTricho(int shipID, string npcName, int ssid)
        {
            if (ssid == 1006)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(trichoShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(trichoShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(trichoShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(trichoShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(trichoShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(trichoShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }

            tempGO.transform.name = npcName;
            tempGO.transform.parent = trichoPoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0, 359), GetRandom(0, 359), GetRandom(0, 359)));
        }

        private void InstantiateMavin(int shipID, string npcName, int ssid)
        {
            if (ssid == 1007)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(mavinShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(mavinShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(mavinShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(mavinShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(mavinShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(mavinShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }

            tempGO.transform.name = npcName;
            tempGO.transform.parent = mavinPoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0, 359), GetRandom(0, 359), GetRandom(0, 359)));
        }

        private void InstantiateEstati(int shipID, string npcName, int ssid)
        {
            if (ssid == 1008)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(estatiShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(estatiShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(estatiShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(estatiShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(estatiShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(estatiShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }

            tempGO.transform.name = npcName;
            tempGO.transform.parent = estatiPoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0, 359), GetRandom(0, 359), GetRandom(0, 359)));
        }

        private void InstantiateTeiid(int shipID, string npcName, int ssid)
        {
            if (ssid == 1009)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(teiidShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(teiidShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(teiidShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(teiidShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(teiidShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(teiidShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }

            tempGO.transform.name = npcName;
            tempGO.transform.parent = teiidPoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0, 359), GetRandom(0, 359), GetRandom(0, 359)));
        }

        private void InstantiateRoidal(int shipID, string npcName, int ssid)
        {
            if (ssid == 1010)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(roidalShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(roidalShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(roidalShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(roidalShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(roidalShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(roidalShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }

            tempGO.transform.name = npcName;
            tempGO.transform.parent = roidalPoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0, 359), GetRandom(0, 359), GetRandom(0, 359)));
        }

        private void InstantiateAerifo(int shipID, string npcName, int ssid)
        {
            if (ssid == 1011)
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(aerifoShip1, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(aerifoShip2, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(aerifoShip3, NPCHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            else
            {
                switch (shipID)
                {
                    case 1:
                        tempGO = Instantiate(aerifoShip1, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 2:
                        tempGO = Instantiate(aerifoShip2, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                    case 3:
                        tempGO = Instantiate(aerifoShip3, NPCNonHomeLocation(), Quaternion.identity) as GameObject;
                        break;
                }
            }
            tempGO.transform.name = npcName;
            tempGO.transform.parent = aerifoPoolManager.transform;
            tempGO.transform.LookAt(new Vector3(GetRandom(0, 359), GetRandom(0, 359), GetRandom(0, 359)));
        }
    }
}
