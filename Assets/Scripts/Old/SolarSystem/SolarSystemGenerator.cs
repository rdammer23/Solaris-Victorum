/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

namespace Assets.Scripts.SolarSystem
{
    class SolarSystemGenerator: MonoBehaviour
    {
        //Misc Variables
        public bool generateSolarSystem = false;
        private bool isNegativeLocation = false;
        public bool readyToSave = false;
        int locationX;
        int locationY;
        int locationZ;

        public string ssName = null;

        static string conn;
        private SqliteConnection dbconn = null;
        private SqliteConnection dbconnWrite = null;
        private IDbCommand dbcmd;


        //Star Variables
        public int starColor;
        public int starX = 0;
        public int starY = 0;
        public int starZ = 0;
        private int starSize;
        private int starType; //Concatenate of starColor and StarSize
        private int randomSizeMin = 1;
        private int randomSizeMax = 100;
        private int nextSSID;
        public int sceneID = 0;

        //Planet Variables
        int numberOfPlanets;
        int newPlanetSize;
        int minBlue = 6;
        int maxBlue = 10;
        int minYellow = 8;
        int maxYellow = 15;
        int minRed = 9;
        int maxRed = 17;
        int minOrange = 11;
        int maxOrange = 19;

        int planetRange = 150;
        int planetRangeToUse;

        private int nextPID;

        int[] tempBodyArray;
        int[] bodyArray;


        public List<Planet.Planet> localNewPlanets;

        //Moon Variables
        int numberOfMoons;
        int numberOfMoonsPercent;

        int moonRange = 75;
        int moonRangeToUse;

        private int nextMID;

        public List<Moon.Moon> localNewMoons;
        /*
                0 = MoonID
                1 = Parent PlanetID
                2 = Moon Size
                3 = Moon Level
                4 = Location X
                5 = Location Y
                6 = Location Z
        */
        /*
        RandomNumber randNum = new RandomNumber();
        SaveNewSolarSystem saveNewSS = new SaveNewSolarSystem();

        
        public void Update()
        {
            if (generateSolarSystem)
            {
                GenerateSolarSystem();

                
                foreach (Planet.Planet p in localNewPlanets)
                {
                    Debug.Log("Planet ID = " + p.PlanetID);
                    foreach (Moon.Moon m in localNewMoons)
                    {
                        if(m.PlanetID == p.PlanetID)
                        {
                            Debug.Log(m.MoonID + "," + m.PlanetID + "," + m.MoonSize +
                            ",1," + m.LocationX + "," + m.LocationY + "," + m.LocationZ);

                            //Debug.Log("MID = " + m.MoonID + " PID = " + m.PlanetID + " MoonSize = " + m.MoonSize +
                           //" " + m.LocationX + " " + m.LocationY + " " + m.LocationZ);

                        }
                    }
                }
            }

            //Save All To DB
            //Setup a Bool so it goes only when I tell it
            //Save Star First
            //Verify that I have set the Name,
            //Scene ID and X, Y, Z
            //Save Planets Second
            //Need the nextSSID
            //Save Moons third
            //Need the PID
            
            if (readyToSave)
            {
                //Get the next available SolarSystem ID, Planet ID and Moon ID
                nextSSID = saveNewSS.NextSSID() + 1;
                nextPID = saveNewSS.NextPID() + 1;
                nextMID = saveNewSS.NextMID() + 1;

                Debug.Log("HIIIIIIIII " + ssName);
                if (!string.IsNullOrEmpty(ssName))
                {
                    Debug.Log("name not empty");
                    if(!((starX ==0) && (starY == 0) && (starZ == 0)))
                    {
                        Debug.Log("Location Set");
                        if(sceneID != 0)
                        {
                            Debug.Log("Scene ID Set");
                            saveNewSS.InsertNewSolarSystem(nextSSID, sceneID, ssName, starType, starX, starY, starZ);

                            saveNewSS.InsertNewPlanets(localNewPlanets, nextPID, nextSSID, localNewMoons, nextMID);
                            //InsertNewSolarSystem(int ssid, int sceneID, string ssName, int starType, int x, int y, int z)
                            //InsertNewPlanets(List<Planet.Planet> plist, int planetID, int ssid, List<Moon.Moon>mlist, int moonID)
                        }
                    }
                }
                readyToSave = false;
            }

        }

        private void GenerateSolarSystem()
        {
            GenerateStarSize();
            numberOfPlanets = NumberOfPlanets();
            
            tempBodyArray = new int[numberOfPlanets];
            bodyArray = new int[numberOfPlanets];

            for (int x = 0; x < numberOfPlanets; x++)
            {
                tempBodyArray[x] = GeneratePlanetSize();
            }

            SortAndBellCurveArray(numberOfPlanets);

            generateSolarSystem = false;

            localNewPlanets = new List<Planet.Planet>();
            localNewMoons = new List<Moon.Moon>();

            #region For Loop for Planet Location
            for (int i = 0; i < bodyArray.Length; i++)
            {

                if (i == 0)
                {
                    locationX = BodyLocation(50, planetRange);
                    locationY = BodyLocation(50, planetRange);
                    locationZ = BodyLocation(50, planetRange);

                }
                if (bodyArray[i] == 1 || bodyArray[i] == 2)
                {
                    planetRangeToUse = planetRange;
                }
                if (bodyArray[i] == 3 || bodyArray[i] == 4)
                {
                    planetRangeToUse = planetRange * 2;
                }
                if (bodyArray[i] == 5 || bodyArray[i] == 6)
                {
                    planetRangeToUse = planetRange * 3;
                }
                if (bodyArray[i] == 7 || bodyArray[i] == 8)
                {
                    planetRangeToUse = planetRange * 4;
                }
                
                locationX = (BodyLocation(locationX, (planetRangeToUse + locationX))) * DetermineIfNegPosition();
                locationY = (BodyLocation(locationY, (planetRangeToUse + locationY))) * DetermineIfNegPosition();
                locationZ = (BodyLocation(locationZ, (planetRangeToUse + locationZ))) * DetermineIfNegPosition();

                localNewPlanets.Add(new Planet.Planet(i+1, bodyArray[i], locationX, locationY, locationZ));

                locationX = Math.Abs(locationX);
                locationY = Math.Abs(locationY);
                locationZ = Math.Abs(locationZ);
            }
            #endregion


            GenerateMoons();
        }

        private void GenerateMoons()
        {
            //for each planet generate a moon list
            //After Generating the Moon List for a planet, go to next planet 
            foreach (Planet.Planet plist in localNewPlanets)
            {
                bool isMoon = false;


                //Generate Number of Moons
                numberOfMoons = NumberOfMoons(plist.PlanetSize);

                tempBodyArray = new int[numberOfMoons];
                bodyArray = new int[numberOfMoons];

                //Generate Moon Sizes
                for (int i = 0; i < numberOfMoons; i++)
                {
                    tempBodyArray[i] = GenerateMoonSize(plist.PlanetSize);
                    isMoon = true;
                }
                //Sort List in Bell Curve Order
                //May need a bool here to cover 0 moons
                if (isMoon)
                {
                    SortAndBellCurveArray(numberOfMoons);
                    isMoon = false;
                }

                #region For Loop for Moon Location
                for (int i = 0; i < bodyArray.Length; i++)
                {
                    if (i == 0)
                    {
                        locationX = BodyLocation(20, moonRange);
                        locationY = BodyLocation(20, moonRange);
                        locationZ = BodyLocation(20, moonRange);

                    }
                    if (bodyArray[i] == 1 || bodyArray[i] == 2)
                    {
                        moonRangeToUse = moonRange;
                    }
                    if (bodyArray[i] == 3 || bodyArray[i] == 4 || bodyArray[i] == 5)
                    {
                        moonRangeToUse = moonRange * 2;
                    }
                    if (bodyArray[i] == 6 || bodyArray[i] == 7 || bodyArray[i] == 8)
                    {
                        moonRangeToUse = moonRange * 3;
                    }

                    locationX = (BodyLocation(locationX, (moonRangeToUse + locationX))) * DetermineIfNegPosition();
                    locationY = (BodyLocation(locationY, (moonRangeToUse + locationY))) * DetermineIfNegPosition();
                    locationZ = (BodyLocation(locationZ, (moonRangeToUse + locationZ))) * DetermineIfNegPosition();

                    localNewMoons.Add(new Moon.Moon(i + 1, plist.PlanetID, bodyArray[i], locationX, locationY, locationZ));

                    locationX = Math.Abs(locationX);
                    locationY = Math.Abs(locationY);
                    locationZ = Math.Abs(locationZ);
                }
                #endregion
            }
        }

        private int DetermineIfNegPosition()
        {
            isNegativeLocation = (randNum.RandomNumberInt(1, 2) % 2 == 0);
            if (isNegativeLocation)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private int BodyLocation(int previousLocation, int planetRange)
        {
            return (randNum.RandomNumberInt(previousLocation, planetRange));
        }

        private void SortAndBellCurveArray(int numberOfBodies)
        {
            int halfNumberOfBodies = 0;
            int[] smallArray1;
            int[] smallArray2;


            Array.Sort(tempBodyArray);
            bool isEven = (numberOfBodies % 2 == 0);

            if (!isEven)
            {
                halfNumberOfBodies = (numberOfBodies + 1) / 2;
                smallArray2 = new int[halfNumberOfBodies - 1];
            }
            else
            {
                halfNumberOfBodies = numberOfBodies / 2;
                smallArray2 = new int[halfNumberOfBodies];
            }
            smallArray1 = new int[halfNumberOfBodies];

            int x = 0;


            for (int i = 0; i < halfNumberOfBodies; i++)
            {
                smallArray1[i] = tempBodyArray[x];
                if (!(!isEven && i == (halfNumberOfBodies - 1)))
                {
                    smallArray2[i] = tempBodyArray[x + 1];
                }
                x = x + 2;
            }



            for (int i = 0; i < smallArray1.Length; i++)
            {
                bodyArray[i] = smallArray1[i];
            }

            for (int i = 0; i < smallArray2.Length; i++)
            {
                bodyArray[smallArray1.Length + i] = smallArray2[smallArray2.Length - (i + 1)];
            }
        }


        private int GenerateMoonSize(int planetSize)
        {
            int currentMoonSizeRandomNumber = randNum.RandomNumberInt(1, 100);
            switch (planetSize)
            {
                case 1:
                    return MoonSizeTinyPlanet(currentMoonSizeRandomNumber);
                case 2:
                    return MoonSizeSmallPlanet(currentMoonSizeRandomNumber);
                case 3:
                    return MoonSizeMediumPlanet(currentMoonSizeRandomNumber);
                case 4:
                    return MoonSizeLargePlanet(currentMoonSizeRandomNumber);
                case 5:
                    return MoonSizeExtraLargePlanet(currentMoonSizeRandomNumber);
                case 6:
                    return MoonSizeGiantPlanet(currentMoonSizeRandomNumber);
                case 7:
                    return MoonSizeSuperGiantPlanet(currentMoonSizeRandomNumber);
                case 8:
                    return MoonSizeMonsterPlanet(currentMoonSizeRandomNumber);
                default:
                    return 0;
            }
        }

        public int MoonSizeTinyPlanet(int cMSRN)
        {
            if(cMSRN <= 80)
            {
                return 1;
            }
            else if(cMSRN <= 95)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public int MoonSizeSmallPlanet(int cMSRN)
        {
            if (cMSRN <= 45)
            {
                return 1;
            }
            else if (cMSRN <= 80)
            {
                return 2;
            }
            else if (cMSRN <= 95)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        public int MoonSizeMediumPlanet(int cMSRN)
        {
            if (cMSRN <= 25)
            {
                return 1;
            }
            else if (cMSRN <= 55)
            {
                return 2;
            }
            else if (cMSRN <= 80)
            {
                return 3;
            }
            else if (cMSRN <= 95)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        public int MoonSizeLargePlanet(int cMSRN)
        {
            if (cMSRN <= 20)
            {
                return 1;
            }
            else if (cMSRN <= 40)
            {
                return 2;
            }
            else if (cMSRN <= 65)
            {
                return 3;
            }
            else if (cMSRN <= 85)
            {
                return 4;
            }
            else if (cMSRN <= 95)
            {
                return 5;
            }
            else
            {
                return 6;
            }
        }

        public int MoonSizeExtraLargePlanet(int cMSRN)
        {
            if (cMSRN <= 10)
            {
                return 1;
            }
            else if (cMSRN <= 25)
            {
                return 2;
            }
            else if (cMSRN <= 40)
            {
                return 3;
            }
            else if (cMSRN <= 65)
            {
                return 4;
            }
            else if (cMSRN <= 85)
            {
                return 5;
            }
            else if (cMSRN <= 95)
            {
                return 6;
            }
            else
            {
                return 7;
            }
        }

        public int MoonSizeGiantPlanet(int cMSRN)
        {
            if (cMSRN <= 5)
            {
                return 1;
            }
            else if (cMSRN <= 12)
            {
                return 2;
            }
            else if (cMSRN <= 22)
            {
                return 3;
            }
            else if (cMSRN <= 37)
            {
                return 4;
            }
            else if (cMSRN <= 62)
            {
                return 5;
            }
            else if (cMSRN <= 87)
            {
                return 6;
            }
            else if (cMSRN <= 95)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }

        public int MoonSizeSuperGiantPlanet(int cMSRN)
        {
            if (cMSRN <= 3)
            {
                return 1;
            }
            else if (cMSRN <= 7)
            {
                return 2;
            }
            else if (cMSRN <= 14)
            {
                return 3;
            }
            else if (cMSRN <= 24)
            {
                return 4;
            }
            else if (cMSRN <= 54)
            {
                return 5;
            }
            else if (cMSRN <= 84)
            {
                return 6;
            }
            else if (cMSRN <= 94)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }

        public int MoonSizeMonsterPlanet(int cMSRN)
        {
            if (cMSRN <= 2)
            {
                return 2;
            }
            else if (cMSRN <= 6)
            {
                return 3;
            }
            else if (cMSRN <= 13)
            {
                return 4;
            }
            else if (cMSRN <= 43)
            {
                return 5;
            }
            else if (cMSRN <= 78)
            {
                return 6;
            }
            else if (cMSRN <= 93)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }

        private int NumberOfMoons(int planetSize)
        {
            switch (planetSize)
            {
                case 1:
                    return numberOfMoons = NumberMoonsTinyPlanet();
                case 2:
                    return numberOfMoons = NumberMoonsSmallPlanet();
                case 3:
                    return numberOfMoons = NumberMoonsMediumPlanet();
                case 4:
                    return numberOfMoons = NumberMoonsLargePlanet();
                case 5:
                    return numberOfMoons = NumberMoonsExtraLargePlanet();
                case 6:
                    return numberOfMoons = NumberMoonsGiantPlanet();
                case 7:
                    return numberOfMoons = NumberMoonsSuperGiantPlanet();
                case 8:
                    return numberOfMoons = NumberMoonsMonsterPlanet();
                default:
                    return 0;
            }
        }

        private int NumberMoonsTinyPlanet()
        {
            numberOfMoonsPercent = randNum.RandomNumberInt(1, 10000);
            if(numberOfMoonsPercent <= 2000)
            {
                return 0;
            }
            else if(numberOfMoonsPercent <= 9500)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private int NumberMoonsSmallPlanet()
        {
            numberOfMoonsPercent = randNum.RandomNumberInt(1, 10000);
            if (numberOfMoonsPercent <= 500)
            {
                return 0;
            }
            else if (numberOfMoonsPercent <= 6500)
            {
                return 1;
            }
            else if(numberOfMoonsPercent <= 9500)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private int NumberMoonsMediumPlanet()
        {
            numberOfMoonsPercent = randNum.RandomNumberInt(1, 10000);
            if (numberOfMoonsPercent <= 5000)
            {
                return 1;
            }
            else if (numberOfMoonsPercent <= 8000)
            {
                return 2;
            }
            else if (numberOfMoonsPercent <= 9500)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        private int NumberMoonsLargePlanet()
        {
            numberOfMoonsPercent = randNum.RandomNumberInt(1, 10000);
            if (numberOfMoonsPercent <= 5000)
            {
                return 2;
            }
            else if (numberOfMoonsPercent <= 7000)
            {
                return 3;
            }
            else if (numberOfMoonsPercent <= 8000)
            {
                return 4;
            }
            else if(numberOfMoonsPercent <= 8800)
            {
                return 5;
            }
            else if (numberOfMoonsPercent <= 9300)
            {
                return 6;
            }
            else if (numberOfMoonsPercent <= 9700)
            {
                return 7;
            }
            else if (numberOfMoonsPercent <= 9900)
            {
                return 8;
            }
            else
            {
                return 9;
            }
        }

        private int NumberMoonsExtraLargePlanet()
        {
            numberOfMoonsPercent = randNum.RandomNumberInt(1, 10000);
            if (numberOfMoonsPercent <= 3000)
            {
                return 3;
            }
            else if (numberOfMoonsPercent <= 4500)
            {
                return 4;
            }
            else if (numberOfMoonsPercent <= 5500)
            {
                return 5;
            }
            else if (numberOfMoonsPercent <= 6400)
            {
                return 6;
            }
            else if (numberOfMoonsPercent <= 7200)
            {
                return 7;
            }
            else if (numberOfMoonsPercent <= 7900)
            {
                return 8;
            }
            else if (numberOfMoonsPercent <= 8500)
            {
                return 9;
            }
            else if (numberOfMoonsPercent <= 9000)
            {
                return 10;
            }
            else if (numberOfMoonsPercent <= 9400)
            {
                return 11;
            }
            else if (numberOfMoonsPercent <= 9700)
            {
                return 12;
            }
            else if (numberOfMoonsPercent <= 9900)
            {
                return 13;
            }
            else
            {
                return 14;
            }
        }

        private int NumberMoonsGiantPlanet()
        {
            numberOfMoonsPercent = randNum.RandomNumberInt(1, 10000);
            if (numberOfMoonsPercent <= 2600)
            {
                return 4;
            }
            else if (numberOfMoonsPercent <= 4600)
            {
                return 5;
            }
            else if (numberOfMoonsPercent <= 5600)
            {
                return 6;
            }
            else if (numberOfMoonsPercent <= 6500)
            {
                return 7;
            }
            else if (numberOfMoonsPercent <= 7300)
            {
                return 8;
            }
            else if (numberOfMoonsPercent <= 8000)
            {
                return 9;
            }
            else if (numberOfMoonsPercent <= 8600)
            {
                return 10;
            }
            else if (numberOfMoonsPercent <= 9100)
            {
                return 11;
            }
            else if (numberOfMoonsPercent <= 9450)
            {
                return 12;
            }
            else if (numberOfMoonsPercent <= 9675)
            {
                return 13;
            }
            else if (numberOfMoonsPercent <= 9825)
            {
                return 14;
            }
            else if (numberOfMoonsPercent <= 9925)
            {
                return 15;
            }
            else if (numberOfMoonsPercent <= 9975)
            {
                return 16;
            }
            else
            {
                return 17;
            }
        }

        private int NumberMoonsSuperGiantPlanet()
        {
            numberOfMoonsPercent = randNum.RandomNumberInt(1, 10000);
            if (numberOfMoonsPercent <= 1500)
            {
                return 5;
            }
            else if (numberOfMoonsPercent <= 2900)
            {
                return 6;
            }
            else if (numberOfMoonsPercent <= 4150)
            {
                return 7;
            }
            else if (numberOfMoonsPercent <= 5150)
            {
                return 8;
            }
            else if (numberOfMoonsPercent <= 6050)
            {
                return 9;
            }
            else if (numberOfMoonsPercent <= 6850)
            {
                return 10;
            }
            else if (numberOfMoonsPercent <= 7550)
            {
                return 11;
            }
            else if (numberOfMoonsPercent <= 8150)
            {
                return 12;
            }
            else if (numberOfMoonsPercent <= 8650)
            {
                return 13;
            }
            else if (numberOfMoonsPercent <= 9050)
            {
                return 14;
            }
            else if (numberOfMoonsPercent <= 9350)
            {
                return 15;
            }
            else if (numberOfMoonsPercent <= 9600)
            {
                return 16;
            }
            else if (numberOfMoonsPercent <= 9800)
            {
                return 17;
            }
            else if (numberOfMoonsPercent <= 9925)
            {
                return 18;
            }
            else if (numberOfMoonsPercent <= 9975)
            {
                return 19;
            }
            else
            {
                return 20;
            }
        }

        private int NumberMoonsMonsterPlanet()
        {
            numberOfMoonsPercent = randNum.RandomNumberInt(1, 10000);
            if (numberOfMoonsPercent <= 1500)
            {
                return 6;
            }
            else if (numberOfMoonsPercent <= 2900)
            {
                return 7;
            }
            else if (numberOfMoonsPercent <= 4150)
            {
                return 8;
            }
            else if (numberOfMoonsPercent <= 5125)
            {
                return 9;
            }
            else if (numberOfMoonsPercent <= 5925)
            {
                return 10;
            }
            else if (numberOfMoonsPercent <= 6625)
            {
                return 11;
            }
            else if (numberOfMoonsPercent <= 7225)
            {
                return 12;
            }
            else if (numberOfMoonsPercent <= 7725)
            {
                return 13;
            }
            else if (numberOfMoonsPercent <= 8175)
            {
                return 14;
            }
            else if (numberOfMoonsPercent <= 8575)
            {
                return 15;
            }
            else if (numberOfMoonsPercent <= 8925)
            {
                return 16;
            }
            else if (numberOfMoonsPercent <= 9225)
            {
                return 17;
            }
            else if (numberOfMoonsPercent <= 9475)
            {
                return 18;
            }
            else if (numberOfMoonsPercent <= 9675)
            {
                return 19;
            }
            else if (numberOfMoonsPercent <= 9825)
            {
                return 20;
            }
            else if (numberOfMoonsPercent <= 9925)
            {
                return 21;
            }
            else if (numberOfMoonsPercent <= 9975)
            {
                return 22;
            }
            else
            {
                return 23;
            }
        }

        private int GeneratePlanetSize()
        {
            /*
                    0 = Planet Size
                    1 = Location X
                    2 = Location Y
                    3 = Location Z
            */
            /*
            int currentPlanetSizeRandomNumber = randNum.RandomNumberInt(1, 100);
            switch (starSize)
            {
                case 1:
                    return (PlanetSizeBlueStar(currentPlanetSizeRandomNumber));
                case 2:
                    return (PlanetSizeBlueStar(currentPlanetSizeRandomNumber));
                case 3:
                    return (PlanetSizeBlueStar(currentPlanetSizeRandomNumber));
                case 4:
                    return (PlanetSizeBlueStar(currentPlanetSizeRandomNumber));
                default:
                    return (PlanetSizeBlueStar(currentPlanetSizeRandomNumber));
            }
        }

        public int PlanetSizeBlueStar(int cPSRN)
        {
            if(cPSRN <= 10)
            {
                return 1;
            }
            else if(cPSRN <= 25)
            {
                return 2;
            }
            else if (cPSRN <= 75)
            {
                return 3;
            }
            else if (cPSRN <= 85)
            {
                return 4;
            }
            else if (cPSRN <= 92)
            {
                return 5;
            }
            else if (cPSRN <= 97)
            {
                return 6;
            }
            else if (cPSRN <= 99)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }

        public int PlanetSizeYellowStar(int cPSRN)
        {
            if (cPSRN <= 5)
            {
                return 1;
            }
            else if (cPSRN <= 13)
            {
                return 2;
            }
            else if (cPSRN <= 63)
            {
                return 3;
            }
            else if (cPSRN <= 78)
            {
                return 4;
            }
            else if (cPSRN <= 88)
            {
                return 5;
            }
            else if (cPSRN <= 94)
            {
                return 6;
            }
            else if (cPSRN <= 98)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }

        public int PlanetSizeRedStar(int cPSRN)
        {
            if (cPSRN <= 1)
            {
                return 1;
            }
            else if (cPSRN <= 3)
            {
                return 2;
            }
            else if (cPSRN <= 38)
            {
                return 3;
            }
            else if (cPSRN <= 63)
            {
                return 4;
            }
            else if (cPSRN <= 78)
            {
                return 5;
            }
            else if (cPSRN <= 88)
            {
                return 6;
            }
            else if (cPSRN <= 95)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }

        public int PlanetSizeOrangeStar(int cPSRN)
        {
            if (cPSRN <= 1)
            {
                return 1;
            }
            else if (cPSRN <= 3)
            {
                return 2;
            }
            else if (cPSRN <= 23)
            {
                return 3;
            }
            else if (cPSRN <= 48)
            {
                return 4;
            }
            else if (cPSRN <= 69)
            {
                return 5;
            }
            else if (cPSRN <= 84)
            {
                return 6;
            }
            else if (cPSRN <= 93)
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }

        private int NumberOfPlanets()
        {
            switch (starColor)
            {
                case 1:
                    return (randNum.RandomNumberInt(minBlue, maxBlue));
                case 2:
                    return (randNum.RandomNumberInt(minYellow, maxYellow));
                case 3:
                    return (randNum.RandomNumberInt(minRed, maxRed));
                case 4:
                    return (randNum.RandomNumberInt(minOrange, maxOrange));
                default:
                    return (randNum.RandomNumberInt(minYellow, maxYellow));
            }
            
        }

        //Generate a number 1 through 100 to determine Star Size
        private void GenerateStarSize()
        {
            int starSizeRandomNumber = randNum.RandomNumberInt(randomSizeMin, randomSizeMax);
            switch (starColor)
            {
                case 1:
                    starSize = BlueStarSize(starSizeRandomNumber);
                    starType = int.Parse(starColor.ToString() + starSize.ToString());
                    break;
                case 2:
                    starSize = YellowStarSize(starSizeRandomNumber);
                    starType = int.Parse(starColor.ToString() + starSize.ToString());
                    break;
                case 3:
                    starSize = RedStarSize(starSizeRandomNumber);
                    starType = int.Parse(starColor.ToString() + starSize.ToString());
                    break;
                case 4:
                    starSize = OrangeStarSize(starSizeRandomNumber);
                    starType = int.Parse(starColor.ToString() + starSize.ToString());
                    break;
                default:
                    break;
            }
        }

        public int BlueStarSize(int starSizeRandomNumber)
        {
            if (starSizeRandomNumber <= 30)
            {
                return 1;
            }
            else if (starSizeRandomNumber <= 70)
            {
                return 2;
            }
            else if (starSizeRandomNumber <= 85)
                
            {
                return 3;
            }
            else if (starSizeRandomNumber <= 95)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        public int YellowStarSize(int starSizeRandomNumber)
        {
            if (starSizeRandomNumber <= 25)
            {
                return 1;
            }
            else if (starSizeRandomNumber <= 55)
            {
                return 2;
            }
            else if (starSizeRandomNumber <= 75)

            {
                return 3;
            }
            else if (starSizeRandomNumber <= 90)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        public int RedStarSize(int starSizeRandomNumber)
        {
            if (starSizeRandomNumber <= 10)
            {
                return 1;
            }
            else if (starSizeRandomNumber <= 30)
            {
                return 2;
            }
            else if (starSizeRandomNumber <= 60)

            {
                return 3;
            }
            else if (starSizeRandomNumber <= 85)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        public int OrangeStarSize(int starSizeRandomNumber)
        {
            if (starSizeRandomNumber <= 20)
            {
                return 1;
            }
            else if (starSizeRandomNumber <= 40)
            {
                return 2;
            }
            else if (starSizeRandomNumber <= 60)

            {
                return 3;
            }
            else if (starSizeRandomNumber <= 80)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }
    }
}
*/