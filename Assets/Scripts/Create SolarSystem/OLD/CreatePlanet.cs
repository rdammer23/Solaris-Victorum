using Assets.Scripts.Planet_Classes;
using Assets.Scripts.SavingAndLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Create_SolarSystem
{
    class CreatePlanet:MonoBehaviour
    {
        /*
        Need to create 11 Planets
        Player's Race owns 3rd planet by default, player does not own the planet,
        must earn it in the next release
        Randomly assigning different race to other 10
        Sizes should be in this order T, Med, L, XL, G, Mon, SG, XL, L, M, S
        Determine Each Planet Density
        Set Planet Level = 1
        Need planet workforce allocation.  Though this will only be used for
        harvesting when harvesting is calculated, so can wait until later.
        Determine Planet Harvest Rate: Based on size of planet and Density only, there are no other factors used
        Determine planet population increase
        After each planet is created, should create the moons (4 moons maximum in order to save space in the scene.

        Need base file for each planet size: Harvest rate and population increase
        Need base file for each planet density: Harvest Rate
        */

        //Work Force, planet size, planet density all impact harvest rate

        //Planet Size and Planet Density are Constant across all resource type
        //Workforce Allocation is per resource type
        //24 resources in total, only 20 found on starting planets

        //Must Allocate workforce in 1% increments, which is a .25 adjustment in harvesting
        //5% allocation means no impact to harvesting that particular resource
        //DO NOT TAKE Work Force Allocation into consideration for Planet Harvest Rate
        //Use Allocation as last step in determining hourly/daily harvest rate.

        //This then should mean I do not need a harvest rate for each resource on the planet
        //And only a single planet adjustment, which will be Planet Size * Planet Density
        //Still need a basefile for each size and for each density as they will impact more than just the harvest rates

        //Each resource will require a "build" level of 1 - 5 for each planet level
        //A 3 is average, each change from 3 is a 25% change in harvesting capabilities
        //Each time a planet is leveled all harvesting capabilities decrease by 2

        /*
        int playerRace;

        BasePlanet newPlanet;
        RandomNumber randNum;

        static bool isCreatePlanet = false;

        TinyPlanet tinyPlanet;
        SmallPlanet smallPlanet;
        MediumPlanet mediumPlanet;
        LargePlanet largePlanet;
        ExtraLargePlanet exLargePlanet;
        GiantPlanet giantPlanet;
        SuperGiantPlanet superGiantPlanet;
        MonsterPlanet monsterPlanet;

        DensityLowestPlanet lowestDensity;
        DensityLowPlanet lowDensity;
        DensityMedPlanet medDensity;
        DensityHighPlanet highDensity;
        DensityHighestPlanet highestDensity;

        public void Awake()  //Will have this deactivated and will activate once Star Created and Saved
        {
            newPlanet = new BasePlanet();
            randNum = new RandomNumber();
        }

        private void Update()
        {
            if (isCreatePlanet)
            {
                playerRace = GameData.PlayerRace.RaceID;

                tinyPlanet = new TinyPlanet();
                smallPlanet = new SmallPlanet();
                mediumPlanet = new MediumPlanet();
                largePlanet = new LargePlanet();
                exLargePlanet = new ExtraLargePlanet();
                giantPlanet = new GiantPlanet();
                superGiantPlanet = new SuperGiantPlanet();
                monsterPlanet = new MonsterPlanet();

                lowestDensity = new DensityLowestPlanet();
                lowDensity = new DensityLowPlanet();
                medDensity = new DensityMedPlanet();
                highDensity = new DensityHighPlanet();
                highestDensity = new DensityHighestPlanet();

                //Constants Across All Planet Sizes

                newPlanet.PlanetLevel = 1;
                newPlanet.PlanetCurrentTFValue = 0;
                newPlanet.PlanetTFValueNeeded = 10000;
                newPlanet.PlanetPlayerOwned = false;
                newPlanet.PlanetPopulation = .75;
                newPlanet.PopulationIncreaseRate = 1.1f;


                CreatePlanet1();
                SavePlanet1();
                CreatePlanet2();
                SavePlanet2();
                CreatePlanet3();
                SavePlanet3();
                CreatePlanet4();
                SavePlanet4();
                CreatePlanet5();
                SavePlanet5();
                CreatePlanet6();
                SavePlanet6();
                CreatePlanet7();
                SavePlanet7();
                CreatePlanet8();
                SavePlanet8();
                CreatePlanet9();
                SavePlanet9();
                CreatePlanet10();
                SavePlanet10();
                CreatePlanet11();
                SavePlanet11();
                isCreatePlanet = false;
            }
        }

        public void CreateThePlanets()
        {
            isCreatePlanet = true;
        }

        private void CreatePlanet1() //Tiny
        {
            newPlanet.PlanetID = 1;
            newPlanet.PlanetSize = 1;
            newPlanet.MaxPopulation = 1.5;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);
            
            if (newPlanet.PlanetID >= playerRace)
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID + 1;
            }
            else
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID;
            }
        }

        private void CreatePlanet2() //Medium
        {
            newPlanet.PlanetID = 2;
            newPlanet.PlanetSize = 3;
            newPlanet.MaxPopulation = 3.0;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);

            if (newPlanet.PlanetID >= playerRace)
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID + 1;
            }
            else
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID;
            }

        }

        private void CreatePlanet3() //Large This should be the same race as the player, but not owned by them.
        {

            newPlanet.PlanetID = 3;
            newPlanet.PlanetSize = 4;
            newPlanet.MaxPopulation = 4.5;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);

            newPlanet.PlanetOriginalOwnerRace = playerRace;
        }

        private void CreatePlanet4()
        {
            newPlanet.PlanetID = 4;
            newPlanet.PlanetSize = 5;
            newPlanet.MaxPopulation = 6.0;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);

            if (newPlanet.PlanetID <= playerRace) //This is the if that should be used for Planet 4 through 11
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID - 1;
            }
            else
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID;
            }
        }

        private void CreatePlanet5() 
        {
            newPlanet.PlanetID = 5;
            newPlanet.PlanetSize = 6;
            newPlanet.MaxPopulation = 7.5;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);

            if (newPlanet.PlanetID <= playerRace) //This is the if that should be used for Planet 4 through 11
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID - 1;  
            }
            else
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID;
            }
        }

        private void CreatePlanet6() 
        {
            newPlanet.PlanetID = 6;
            newPlanet.PlanetSize = 8;
            newPlanet.MaxPopulation = 12.0;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);

            if (newPlanet.PlanetID <= playerRace) //This is the if that should be used for Planet 4 through 11
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID - 1;
            }
            else
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID;
            }
        }

        private void CreatePlanet7() 
        {
            newPlanet.PlanetID = 7;
            newPlanet.PlanetSize = 7;
            newPlanet.MaxPopulation = 9.0;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);

            if (newPlanet.PlanetID <= playerRace) //This is the if that should be used for Planet 4 through 11
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID - 1;
            }
            else
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID;
            }
        }

        private void CreatePlanet8() 
        {
            newPlanet.PlanetID = 8;
            newPlanet.PlanetSize = 5;
            newPlanet.MaxPopulation = 6.0;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);

            if (newPlanet.PlanetID <= playerRace) //This is the if that should be used for Planet 4 through 11
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID - 1;
            }
            else
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID;
            }
        }

        private void CreatePlanet9() 
        {
            newPlanet.PlanetID = 9;
            newPlanet.PlanetSize = 4;
            newPlanet.MaxPopulation = 4.5;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);

            if (newPlanet.PlanetID <= playerRace) //This is the if that should be used for Planet 4 through 11
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID - 1;
            }
            else
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID;
            }
        }

        private void CreatePlanet10() 
        {
            newPlanet.PlanetID = 10;
            newPlanet.PlanetSize = 3;
            newPlanet.MaxPopulation = 3.0;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);

            if (newPlanet.PlanetID <= playerRace) //This is the if that should be used for Planet 4 through 11
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID - 1;
            }
            else
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID;
            }
        }

        private void CreatePlanet11() 
        {
            newPlanet.PlanetID = 11;
            newPlanet.PlanetSize = 2;
            newPlanet.MaxPopulation = 2.25;
            newPlanet.PlanetSizeHarvestRateAdjustment = PlanetSizeHR(newPlanet.PlanetSize);

            newPlanet.PlanetStartLocationX = 100;
            newPlanet.PlanetStartLocationY = 100;
            newPlanet.PlanetStartLocationZ = 100;

            newPlanet.PlanetDensity = randNum.RandomNumberInt(1, 5);
            newPlanet.PlanetDensityHarvestRateAdjustment = PlanetDensityHR(newPlanet.PlanetDensity);

            if (newPlanet.PlanetID <= playerRace) //This is the if that should be used for Planet 4 through 11
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID - 1;
            }
            else
            {
                newPlanet.PlanetOriginalOwnerRace = newPlanet.PlanetID;
            }
        }

        private void SavePlanet1()
        {

            GameData.Planet1PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet1PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet1PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet1PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet1PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet1PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet1PlanetID = newPlanet.PlanetID;
            GameData.Planet1PlanetSize = newPlanet.PlanetSize;
            GameData.Planet1MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet1PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet1PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet1PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet1PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet1PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet1PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet1PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet1();
            //CreateMoon.OneMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }

        private void SavePlanet2()
        {
            GameData.Planet2PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet2PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet2PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet2PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet2PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet2PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet2PlanetID = newPlanet.PlanetID;
            GameData.Planet2PlanetSize = newPlanet.PlanetSize;
            GameData.Planet2MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet2PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet2PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet2PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet2PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet2PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet2PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet2PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet2();
            //CreateMoon.OneMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }

        private void SavePlanet3()
        {
            GameData.Planet3PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet3PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet3PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet3PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet3PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet3PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet3PlanetID = newPlanet.PlanetID;
            GameData.Planet3PlanetSize = newPlanet.PlanetSize;
            GameData.Planet3MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet3PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet3PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet3PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet3PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet3PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet3PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet3PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet3();
            //CreateMoon.TwoMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }

        private void SavePlanet4()
        {
            GameData.Planet4PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet4PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet4PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet4PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet4PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet4PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet4PlanetID = newPlanet.PlanetID;
            GameData.Planet4PlanetSize = newPlanet.PlanetSize;
            GameData.Planet4MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet4PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet4PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet4PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet4PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet4PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet4PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet4PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet4();
            //CreateMoon.TwoMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }

        private void SavePlanet5()
        {
            GameData.Planet5PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet5PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet5PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet5PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet5PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet5PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet5PlanetID = newPlanet.PlanetID;
            GameData.Planet5PlanetSize = newPlanet.PlanetSize;
            GameData.Planet5MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet5PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet5PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet5PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet5PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet5PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet5PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet5PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet5();
            //CreateMoon.ThreeMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }

        private void SavePlanet6()
        {
            GameData.Planet6PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet6PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet6PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet6PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet6PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet6PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet6PlanetID = newPlanet.PlanetID;
            GameData.Planet6PlanetSize = newPlanet.PlanetSize;
            GameData.Planet6MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet6PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet6PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet6PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet6PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet6PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet6PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet6PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet6();
            //CreateMoon.FourMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }

        private void SavePlanet7()
        {
            GameData.Planet7PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet7PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet7PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet7PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet7PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet7PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet7PlanetID = newPlanet.PlanetID;
            GameData.Planet7PlanetSize = newPlanet.PlanetSize;
            GameData.Planet7MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet7PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet7PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet7PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet7PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet7PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet7PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet7PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet7();
            //CreateMoon.ThreeMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }

        private void SavePlanet8()
        {
            GameData.Planet8PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet8PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet8PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet8PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet8PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet8PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet8PlanetID = newPlanet.PlanetID;
            GameData.Planet8PlanetSize = newPlanet.PlanetSize;
            GameData.Planet8MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet8PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet8PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet8PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet8PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet8PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet8PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet8PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet8();
            //CreateMoon.TwoMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }

        private void SavePlanet9()
        {
            GameData.Planet9PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet9PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet9PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet9PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet9PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet9PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet9PlanetID = newPlanet.PlanetID;
            GameData.Planet9PlanetSize = newPlanet.PlanetSize;
            GameData.Planet9MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet9PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet9PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet9PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet9PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet9PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet9PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet9PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet9();
            //CreateMoon.TwoMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }

        private void SavePlanet10()
        {
            GameData.Planet10PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet10PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet10PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet10PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet10PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet10PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet10PlanetID = newPlanet.PlanetID;
            GameData.Planet10PlanetSize = newPlanet.PlanetSize;
            GameData.Planet10MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet10PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet10PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet10PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet10PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet10PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet10PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet10PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet10();
            //CreateMoon.OneMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }

        private void SavePlanet11()
        {
            GameData.Planet11PlanetLevel = newPlanet.PlanetLevel;
            GameData.Planet11PlanetCurrentTFValue = newPlanet.PlanetCurrentTFValue;
            GameData.Planet11PlanetTFValueNeeded = newPlanet.PlanetTFValueNeeded;
            GameData.Planet11PlanetPlayerOwned = newPlanet.PlanetPlayerOwned;
            GameData.Planet11PlanetPopulation = newPlanet.PlanetPopulation;
            GameData.Planet11PopulationIncreaseRate = newPlanet.PopulationIncreaseRate;
            GameData.Planet11PlanetID = newPlanet.PlanetID;
            GameData.Planet11PlanetSize = newPlanet.PlanetSize;
            GameData.Planet11MaxPopulation = newPlanet.MaxPopulation;
            GameData.Planet11PlanetSizeHarvestRateAdjustment = newPlanet.PlanetSizeHarvestRateAdjustment;
            GameData.Planet11PlanetDensity = newPlanet.PlanetDensity;
            GameData.Planet11PlanetDensityHarvestRateAdjustment = newPlanet.PlanetDensityHarvestRateAdjustment;
            GameData.Planet11PlanetStartLocationX = newPlanet.PlanetStartLocationX;
            GameData.Planet11PlanetStartLocationY = newPlanet.PlanetStartLocationY;
            GameData.Planet11PlanetStartLocationZ = newPlanet.PlanetStartLocationZ;
            GameData.Planet11PlanetOriginalOwnerRace = newPlanet.PlanetOriginalOwnerRace;

            SaveData.SavePlanet11();
            CreateMoon.allPlanetsCreated = true;
            //CreateMoon.OneMoonPlanet(newPlanet.PlanetSize, newPlanet.PlanetID);
        }





        private float PlanetDensityHR(int planetDensity)
        {
            switch (planetDensity)
            {
                case 1:
                    return lowestDensity.PlanetDensityHR();
                case 2:
                    return lowDensity.PlanetDensityHR();
                case 3:
                    return medDensity.PlanetDensityHR();
                case 4:
                    return highDensity.PlanetDensityHR();
                case 5:
                    return highestDensity.PlanetDensityHR();
            }
            return 1;
        }
        private float PlanetSizeHR(int planetSize)
        {
            switch (planetSize)
            {
                case 1:
                    return tinyPlanet.HarvestRate();
                case 2:
                    return smallPlanet.HarvestRate();
                case 3:
                    return mediumPlanet.HarvestRate();
                case 4:
                    return largePlanet.HarvestRate();
                case 5:
                    return exLargePlanet.HarvestRate();
                case 6:
                    return giantPlanet.HarvestRate();
                case 7:
                    return superGiantPlanet.HarvestRate();
                case 8:
                    return monsterPlanet.HarvestRate();
            }
            return 1;
        }
        */
    }
}
