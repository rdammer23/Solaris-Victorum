using Assets.Scripts.Moon_Classes;
using Assets.Scripts.SavingAndLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Create_SolarSystem
{
    class CreateMoon:MonoBehaviour
    {
        /*TODO Add Harvest Rate Logic to Moons

        BETA 0.001 Will not include Harvest Rates on the moons or the logice
        Once ready to add look at the Resource Spreadsheets
        Included in this relase is:
        Number Moons per planet
            T, S, M Planets have 1 moon
            L, XL Planets have 2 moons
            G, SG Planets have 3 moons
            Monster Planet has 4 moons
            Tiny: 1 Tiny Moon
            Small: 1 Small Moon
            Medium: 1 Medium Moon
            Large: 1 Large and 1 Medium Moon
            Extra Large: 1 Extra Large and 1 Large Moon
            Giant: 1 Giant, 1 Extra Large and 1 Large Moon
            Super: Giant: 1 SG, 1 G and 1 XL Moon
            Monster: 1 Monster, 1 SG and 2 G Moons

        Will need to set the following:
            MoonID
            PlanetID Moon is tied to
            MoonSize

        Need the Planet Size

        Everything else will be determined when I add resources to the moons.
        */

/*
        static BaseMoon newMoon;

        private LoadGame.LoadGame startGame;

        public static bool oneMoon = false;
        public static bool twoMoon = false;
        public static bool threeMoon = false;
        public static bool fourMoon = false;
        public static bool allPlanetsCreated = false;

        public static int moonID = 1;
        public static int parentPlanetSize;
        public static int parentPlanetID;

        public void Awake()
        {
            newMoon = new BaseMoon();
        }

        public void Update()
        {
            if (allPlanetsCreated)
            {
                //The next section is in the order of the planets in the Solar System, not the size
                TinyPlanet(GameData.Planet1PlanetSize, GameData.Planet1PlanetID);
                MediumPlanet(GameData.Planet2PlanetSize, GameData.Planet2PlanetID);
                LargePlanet(GameData.Planet3PlanetSize, GameData.Planet3PlanetID);
                ExtraLargePlanet(GameData.Planet4PlanetSize, GameData.Planet4PlanetID);
                GiantPlanet(GameData.Planet5PlanetSize, GameData.Planet5PlanetID);
                MonsterPlanet(GameData.Planet6PlanetSize, GameData.Planet6PlanetID);
                SuperGiantPlanet(GameData.Planet7PlanetSize, GameData.Planet7PlanetID);
                ExtraLargePlanet(GameData.Planet8PlanetSize, GameData.Planet8PlanetID);
                LargePlanet(GameData.Planet9PlanetSize, GameData.Planet9PlanetID);
                MediumPlanet(GameData.Planet10PlanetSize, GameData.Planet10PlanetID);
                SmallPlanet(GameData.Planet11PlanetSize, GameData.Planet11PlanetID);

                allPlanetsCreated = false;

                startGame = new LoadGame.LoadGame();
                startGame.StartGame();
            }
            
        }

        private void TinyPlanet(int parentPlanetSize, int parentPlanetID)
        {
            OneMoonPlanet(parentPlanetSize, parentPlanetID);
        }

        private void SmallPlanet(int parentPlanetSize, int parentPlanetID)
        {
            OneMoonPlanet(parentPlanetSize, parentPlanetID);
        }

        private void MediumPlanet(int parentPlanetSize, int parentPlanetID)
        {
            OneMoonPlanet(parentPlanetSize, parentPlanetID);
        }

        private void LargePlanet(int parentPlanetSize, int parentPlanetID)
        {
            TwoMoonPlanet(parentPlanetSize, parentPlanetID);
        }

        private void ExtraLargePlanet(int parentPlanetSize, int parentPlanetID)
        {
            TwoMoonPlanet(parentPlanetSize, parentPlanetID);
        }

        private void GiantPlanet(int parentPlanetSize, int parentPlanetID)
        {
            ThreeMoonPlanet(parentPlanetSize, parentPlanetID);
        }

        private void SuperGiantPlanet(int parentPlanetSize, int parentPlanetID)
        {
            ThreeMoonPlanet(parentPlanetSize, parentPlanetID);
        }

        private void MonsterPlanet(int parentPlanetSize, int parentPlanetID)
        {
            FourMoonPlanet(parentPlanetSize, parentPlanetID);
        }



        private void OneMoonPlanet(int parentPlanetSize, int parentPlanetID)
        {
            CreateAMoon(parentPlanetSize, parentPlanetID);
        }

        private void TwoMoonPlanet(int parentPlanetSize, int parentPlanetID)
        {
            CreateAMoon(parentPlanetSize, parentPlanetID);
            CreateAMoon(parentPlanetSize-1, parentPlanetID);
        }


        private void ThreeMoonPlanet(int parentPlanetSize, int parentPlanetID)
        {
            CreateAMoon(parentPlanetSize, parentPlanetID);
            CreateAMoon(parentPlanetSize - 1, parentPlanetID);
            CreateAMoon(parentPlanetSize - 2, parentPlanetID);
        }

        private void FourMoonPlanet(int parentPlanetSize, int parentPlanetID)
        {
            CreateAMoon(parentPlanetSize, parentPlanetID);
            CreateAMoon(parentPlanetSize - 1, parentPlanetID);
            CreateAMoon(parentPlanetSize - 2, parentPlanetID);
            CreateAMoon(parentPlanetSize - 2, parentPlanetID);
        }


        private void CreateAMoon(int moonSize, int parentPlanetID)
        {
            newMoon.MoonSize = moonSize;
            newMoon.MoonPlanetID = parentPlanetID;
            newMoon.MoonID = moonID;

            newMoon.MoonStartLocationX = 200;
            newMoon.MoonStartLocationY = 200;
            newMoon.MoonStartLocationZ = 200;


            switch (moonID)
            {
                case 1:
                    SaveMoon1();
                    break;
                case 2:
                    SaveMoon2();
                    break;
                case 3:
                    SaveMoon3();
                    break;
                case 4:
                    SaveMoon4();
                    break;
                case 5:
                    SaveMoon5();
                    break;
                case 6:
                    SaveMoon6();
                    break;
                case 7:
                    SaveMoon7();
                    break;
                case 8:
                    SaveMoon8();
                    break;
                case 9:
                    SaveMoon9();
                    break;
                case 10:
                    SaveMoon10();
                    break;
                case 11:
                    SaveMoon11();
                    break;
                case 12:
                    SaveMoon12();
                    break;
                case 13:
                    SaveMoon13();
                    break;
                case 14:
                    SaveMoon14();
                    break;
                case 15:
                    SaveMoon15();
                    break;
                case 16:
                    SaveMoon16();
                    break;
                case 17:
                    SaveMoon17();
                    break;
                case 18:
                    SaveMoon18();
                    break;
                case 19:
                    SaveMoon19();
                    break;
                case 20:
                    SaveMoon20();
                    break;
                case 21:
                    SaveMoon21();
                    break;
                case 22:
                    SaveMoon22();
                    break;
            }
            moonID += 1;
        }
        #region SAVE MOONS
        public void SaveMoon1()
        {
            GameData.Moon1MoonID = newMoon.MoonID;
            GameData.Moon1MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon1MoonSize = newMoon.MoonSize;
            GameData.Moon1MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon1MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon1MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon1();
        }

        public void SaveMoon2()
        {
            GameData.Moon2MoonID = newMoon.MoonID;
            GameData.Moon2MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon2MoonSize = newMoon.MoonSize;
            GameData.Moon2MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon2MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon2MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon2();
        }

        public void SaveMoon3()
        {
            GameData.Moon3MoonID = newMoon.MoonID;
            GameData.Moon3MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon3MoonSize = newMoon.MoonSize;
            GameData.Moon3MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon3MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon3MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon3();
        }

        public void SaveMoon4()
        {
            GameData.Moon4MoonID = newMoon.MoonID;
            GameData.Moon4MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon4MoonSize = newMoon.MoonSize;
            GameData.Moon4MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon4MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon4MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon4();
        }

        public void SaveMoon5()
        {
            GameData.Moon5MoonID = newMoon.MoonID;
            GameData.Moon5MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon5MoonSize = newMoon.MoonSize;
            GameData.Moon5MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon5MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon5MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon5();
        }

        public void SaveMoon6()
        {
            GameData.Moon6MoonID = newMoon.MoonID;
            GameData.Moon6MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon6MoonSize = newMoon.MoonSize;
            GameData.Moon6MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon6MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon6MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon6();
        }

        public void SaveMoon7()
        {
            GameData.Moon7MoonID = newMoon.MoonID;
            GameData.Moon7MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon7MoonSize = newMoon.MoonSize;
            GameData.Moon7MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon7MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon7MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon7();
        }

        public void SaveMoon8()
        {
            GameData.Moon8MoonID = newMoon.MoonID;
            GameData.Moon8MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon8MoonSize = newMoon.MoonSize;
            GameData.Moon8MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon8MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon8MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon8();
        }

        public void SaveMoon9()
        {
            GameData.Moon9MoonID = newMoon.MoonID;
            GameData.Moon9MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon9MoonSize = newMoon.MoonSize;
            GameData.Moon9MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon9MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon9MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon9();
        }

        public void SaveMoon10()
        {
            GameData.Moon10MoonID = newMoon.MoonID;
            GameData.Moon10MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon10MoonSize = newMoon.MoonSize;
            GameData.Moon10MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon10MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon10MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon10();
        }

        public void SaveMoon11()
        {
            GameData.Moon11MoonID = newMoon.MoonID;
            GameData.Moon11MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon11MoonSize = newMoon.MoonSize;
            GameData.Moon11MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon11MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon11MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon11();
        }

        public void SaveMoon12()
        {
            GameData.Moon12MoonID = newMoon.MoonID;
            GameData.Moon12MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon12MoonSize = newMoon.MoonSize;
            GameData.Moon12MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon12MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon12MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon12();
        }

        public void SaveMoon13()
        {
            GameData.Moon13MoonID = newMoon.MoonID;
            GameData.Moon13MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon13MoonSize = newMoon.MoonSize;
            GameData.Moon13MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon13MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon13MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon13();
        }

        public void SaveMoon14()
        {
            GameData.Moon14MoonID = newMoon.MoonID;
            GameData.Moon14MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon14MoonSize = newMoon.MoonSize;
            GameData.Moon14MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon14MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon14MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon14();
        }

        public void SaveMoon15()
        {
            GameData.Moon15MoonID = newMoon.MoonID;
            GameData.Moon15MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon15MoonSize = newMoon.MoonSize;
            GameData.Moon15MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon15MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon15MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon15();
        }

        public void SaveMoon16()
        {
            GameData.Moon16MoonID = newMoon.MoonID;
            GameData.Moon16MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon16MoonSize = newMoon.MoonSize;
            GameData.Moon16MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon16MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon16MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon16();
        }

        public void SaveMoon17()
        {
            GameData.Moon17MoonID = newMoon.MoonID;
            GameData.Moon17MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon17MoonSize = newMoon.MoonSize;
            GameData.Moon17MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon17MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon17MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon17();
        }

        public void SaveMoon18()
        {
            GameData.Moon18MoonID = newMoon.MoonID;
            GameData.Moon18MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon18MoonSize = newMoon.MoonSize;
            GameData.Moon18MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon18MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon18MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon18();
        }

        public void SaveMoon19()
        {
            GameData.Moon19MoonID = newMoon.MoonID;
            GameData.Moon19MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon19MoonSize = newMoon.MoonSize;
            GameData.Moon19MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon19MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon19MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon19();
        }

        public void SaveMoon20()
        {
            GameData.Moon20MoonID = newMoon.MoonID;
            GameData.Moon20MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon20MoonSize = newMoon.MoonSize;
            GameData.Moon20MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon20MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon20MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon20();
        }

        public void SaveMoon21()
        {
            GameData.Moon21MoonID = newMoon.MoonID;
            GameData.Moon21MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon21MoonSize = newMoon.MoonSize;
            GameData.Moon21MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon21MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon21MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon21();
        }

        public void SaveMoon22()
        {
            GameData.Moon22MoonID = newMoon.MoonID;
            GameData.Moon22MoonPlanetID = newMoon.MoonPlanetID;
            GameData.Moon22MoonSize = newMoon.MoonSize;
            GameData.Moon22MoonStartLocationX = newMoon.MoonStartLocationX;
            GameData.Moon22MoonStartLocationY = newMoon.MoonStartLocationY;
            GameData.Moon22MoonStartLocationZ = newMoon.MoonStartLocationZ;
            SaveData.SaveMoon22();
        }
        #endregion
        */
    }
}
