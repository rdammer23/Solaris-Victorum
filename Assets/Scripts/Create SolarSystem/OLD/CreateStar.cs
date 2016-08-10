using Assets.Scripts.Star;
using Assets.Scripts.Star_Classes;
using Assets.Scripts.SavingAndLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Create_SolarSystem
{
    class CreateStar:MonoBehaviour
    {
        //TODO I DONT THINK THIS IS NEEDED ANYMORE!
        
        /*
        This should only run if Solar System Does Not Exist
        If Player picks load, then check if SS exist
        if Player picks new, then run after player saves
        Need Race ID of Player: GOT IT
        This will allow me to set the Star Color
        This will allow me to determine the StarColor TF Adj
        This will allow me to determine the StarColor Population Adj
        Need to determine StarAge
        This will allow me to determine StarAge TF Adj
        Need to set the age of the star as this will be random per solar system.
        */


        /*
        private BaseStar newStar;
        //private SaveData saveStar;
        static bool starColor = false;
        static int starColorID;
        static RandomNumber randNum;
        
        void Awake()
        {
            newStar = new BaseStar();
            randNum = new RandomNumber();     
        }

        private void Update()
        {
            if (starColor)
            {
                switch (starColorID)
                {
                    case 1:
                        YellowStarTFRates();
                        starColor = false;
                        break;
                    case 2:
                        RedStarTFRates();
                        starColor = false;
                        break;
                    case 3:
                        OrangeStarTFRates();
                        starColor = false;
                        break;
                    case 4:
                        GreenStarTFRates();
                        starColor = false;
                        break;
                    case 5:
                        WhiteStarTFRates();
                        starColor = false;
                        break;
                    case 6:
                        BlueStarTFRates();
                        starColor = false;
                        break;
                    case 7:
                        PurpleStarTFRates();
                        starColor = false;
                        break;
                    case 8:
                        BrightRedStarTFRates();
                        starColor = false;
                        break;
                    case 9:
                        PinkStarTFRates();
                        starColor = false;
                        break;
                    case 10:
                        YellowGreenStarTFRates();
                        starColor = false;
                        break;
                    case 11:
                        LightPurpleStarTFRates();
                        starColor = false;
                        break;
                }
                switch (randNum.RandomNumberInt(1, 5))//For some reason I had this at 7, changed to 5
                {
                    case 1:
                        NewStarTFRates();
                        break;
                    case 2:
                        YoungStarTFRates();
                        break;
                    case 3:
                        MidStarTFRates();
                        break;
                    case 4:
                        OldStarTFRates();
                        break;
                    case 5:
                        AncientStarTFRates();
                        break;
                }
                SetStarHarvestRates();
                StoreNewStarData();
                //SaveData.SaveStar();
                //GetComponent<CreatePlanet>().CreateThePlanets();
            }

        }

        private void StoreNewStarData()
        {
            GameData.StarName = newStar.StarName;
            switch (newStar.StarColorAdjustments.StarColorID)
            {
                case 1:
                    GameData.StarColor = "Yellow Star";
                    break;
                case 2:
                    GameData.StarColor = "Red Star";
                    break;
                case 3:
                    GameData.StarColor = "Orange Star";
                    break;
                case 4:
                    GameData.StarColor = "Green Star";
                    break;
                case 5:
                    GameData.StarColor = "White Star";
                    break;
                case 6:
                    GameData.StarColor = "Blue Star";
                    break;
                case 7:
                    GameData.StarColor = "Purple Star";
                    break;
                case 8:
                    GameData.StarColor = "Bright Red Star";
                    break;
                case 9:
                    GameData.StarColor = "Pink Star";
                    break;
                case 10:
                    GameData.StarColor = "Yellow Green Star";
                    break;
                case 11:
                    GameData.StarColor = "Light Purple Star";
                    break;
            }
            GameData.StarColorID = newStar.StarColorAdjustments.StarColorID;
            GameData.HarvestRateStarGas = newStar.HarvestRateStarGas;
            GameData.HarvestRateStarCarbon = newStar.HarvestRateStarCarbon;
            GameData.HarvestRateStarWater = newStar.HarvestRateStarWater;
            GameData.HarvestRateStarOrganic = newStar.HarvestRateStarOrganic;
            GameData.HarvestRateStarRock = newStar.HarvestRateStarRock;
            GameData.HarvestRateStarWood = newStar.HarvestRateStarWood;
            GameData.HarvestRateStarIron = newStar.HarvestRateStarIron;
            GameData.HarvestRateStarSilver = newStar.HarvestRateStarSilver;
            GameData.HarvestRateStarGold = newStar.HarvestRateStarGold;
            GameData.HarvestRateStarRuby = newStar.HarvestRateStarRuby;
            GameData.HarvestRateStarEmerald = newStar.HarvestRateStarEmerald;
            GameData.HarvestRateStarTitanium = newStar.HarvestRateStarTitanium;
            GameData.HarvestRateStarMithril = newStar.HarvestRateStarMithril;
            GameData.HarvestRateStarLiquidHydrogen = newStar.HarvestRateStarLiquidHydrogen;
            GameData.HarvestRateStarLiquidOxygen = newStar.HarvestRateStarLiquidOxygen;
            GameData.HarvestRateStarLiquidNitrogen = newStar.HarvestRateStarLiquidNitrogen;
            GameData.HarvestRateStarPlatinum = newStar.HarvestRateStarPlatinum;
            GameData.HarvestRateStarDiamond = newStar.HarvestRateStarDiamond;
            GameData.HarvestRateStarRadioactive = newStar.HarvestRateStarRadioactive;
            GameData.HarvestRateStarBlackMatter = newStar.HarvestRateStarBlackMatter;
            GameData.HarvestRateStarRedMatter = newStar.HarvestRateStarRedMatter;
            GameData.HarvestRateStarGreyMatter = newStar.HarvestRateStarGreyMatter;
            GameData.HarvestRateStarWhiteMatter = newStar.HarvestRateStarWhiteMatter;
            GameData.HarvestRateStarMana = newStar.HarvestRateStarMana;
        }

        private void SetStarHarvestRates()
        {
            newStar.HarvestRateStarGas = newStar.StarColorAdjustments.TFColorADJGas * newStar.StarAgeAdjustments.TFStarAgeADJGas;
            newStar.HarvestRateStarCarbon = newStar.StarColorAdjustments.TFColorADJCarbon * newStar.StarAgeAdjustments.TFStarAgeADJCarbon;
            newStar.HarvestRateStarWater = newStar.StarColorAdjustments.TFColorADJWater * newStar.StarAgeAdjustments.TFStarAgeADJWater;
            newStar.HarvestRateStarOrganic = newStar.StarColorAdjustments.TFColorADJOrganic * newStar.StarAgeAdjustments.TFStarAgeADJOrganic;
            newStar.HarvestRateStarRock = newStar.StarColorAdjustments.TFColorADJRock * newStar.StarAgeAdjustments.TFStarAgeADJRock;
            newStar.HarvestRateStarWood = newStar.StarColorAdjustments.TFColorADJWood * newStar.StarAgeAdjustments.TFStarAgeADJWood;
            newStar.HarvestRateStarIron = newStar.StarColorAdjustments.TFColorADJIron * newStar.StarAgeAdjustments.TFStarAgeADJIron;
            newStar.HarvestRateStarSilver = newStar.StarColorAdjustments.TFColorADJSilver * newStar.StarAgeAdjustments.TFStarAgeADJSilver;
            newStar.HarvestRateStarGold = newStar.StarColorAdjustments.TFColorADJGold * newStar.StarAgeAdjustments.TFStarAgeADJGold;
            newStar.HarvestRateStarRuby = newStar.StarColorAdjustments.TFColorADJRuby * newStar.StarAgeAdjustments.TFStarAgeADJRuby;
            newStar.HarvestRateStarEmerald = newStar.StarColorAdjustments.TFColorADJEmerald * newStar.StarAgeAdjustments.TFStarAgeADJEmerald;
            newStar.HarvestRateStarTitanium = newStar.StarColorAdjustments.TFColorADJTitanium * newStar.StarAgeAdjustments.TFStarAgeADJTitanium;
            newStar.HarvestRateStarMithril = newStar.StarColorAdjustments.TFColorADJMithril * newStar.StarAgeAdjustments.TFStarAgeADJMithril;
            newStar.HarvestRateStarLiquidHydrogen = newStar.StarColorAdjustments.TFColorADJLiquidHydrogen * newStar.StarAgeAdjustments.TFStarAgeADJLiquidHydrogen;
            newStar.HarvestRateStarLiquidOxygen = newStar.StarColorAdjustments.TFColorADJLiquidOxygen * newStar.StarAgeAdjustments.TFStarAgeADJLiquidOxygen;
            newStar.HarvestRateStarLiquidNitrogen = newStar.StarColorAdjustments.TFColorADJLiquidNitrogen * newStar.StarAgeAdjustments.TFStarAgeADJLiquidNitrogen;
            newStar.HarvestRateStarPlatinum = newStar.StarColorAdjustments.TFColorADJPlatinum * newStar.StarAgeAdjustments.TFStarAgeADJPlatinum;
            newStar.HarvestRateStarDiamond = newStar.StarColorAdjustments.TFColorADJDiamond * newStar.StarAgeAdjustments.TFStarAgeADJDiamond;
            newStar.HarvestRateStarRadioactive = newStar.StarColorAdjustments.TFColorADJRadioactive * newStar.StarAgeAdjustments.TFStarAgeADJRadioactive;
            newStar.HarvestRateStarBlackMatter = newStar.StarColorAdjustments.TFColorADJBlackMatter * newStar.StarAgeAdjustments.TFStarAgeADJBlackMatter;
            newStar.HarvestRateStarRedMatter = newStar.StarColorAdjustments.TFColorADJRedMatter * newStar.StarAgeAdjustments.TFStarAgeADJRedMatter;
            newStar.HarvestRateStarGreyMatter = newStar.StarColorAdjustments.TFColorADJGreyMatter * newStar.StarAgeAdjustments.TFStarAgeADJGreyMatter;
            newStar.HarvestRateStarWhiteMatter = newStar.StarColorAdjustments.TFColorADJWhiteMatter * newStar.StarAgeAdjustments.TFStarAgeADJWhiteMatter;
            newStar.HarvestRateStarMana = newStar.StarColorAdjustments.TFColorADJMana * newStar.StarAgeAdjustments.TFStarAgeADJMana;
        }

        public void SetStarColor(int raceID)
        {
            switch (raceID)
            {
                case 1:
                    starColorID = 1;
                    starColor = true;
                    break;
                case 2:
                    starColorID = 2;
                    starColor = true;
                    break;
                case 3:
                    starColorID = 3;
                    starColor = true;
                    break;
                case 4:
                    starColorID = 4;
                    starColor = true;
                    break;
                case 5:
                    starColorID = 5;
                    starColor = true;
                    break;
                case 6:
                    starColorID = 6;
                    starColor = true;
                    break;
                case 7:
                    starColorID = 7;
                    starColor = true;
                    break;
                case 8:
                    starColorID = 8;
                    starColor = true;
                    break;
                case 9:
                    starColorID = 9;
                    starColor = true;
                    break;
                case 10:
                    starColorID = 10;
                    starColor = true;
                    break;
                case 11:
                    starColorID = 11;
                    starColor = true;
                    break;
            }
        }

        #region Star Color Harvest Rate Adjustments
        private void YellowStarTFRates()
        {
            newStar.StarColorAdjustments = new YellowStar();
        }

        private void RedStarTFRates()
        {
            newStar.StarColorAdjustments = new RedStar();
        }

        private void OrangeStarTFRates()
        {
            newStar.StarColorAdjustments = new OrangeStar();
        }

        private void GreenStarTFRates()
        {
            newStar.StarColorAdjustments = new GreenStar();
        }

        private void WhiteStarTFRates()
        {
            newStar.StarColorAdjustments = new WhiteStar();
        }

        private void BlueStarTFRates()
        {
            newStar.StarColorAdjustments = new BlueStar();
        }

        private void PurpleStarTFRates()
        {
            newStar.StarColorAdjustments = new PurpleStar();
        }

        private void BrightRedStarTFRates()
        {
            newStar.StarColorAdjustments = new BrightRedStar();
        }

        private void PinkStarTFRates()
        {
            newStar.StarColorAdjustments = new PinkStar();
        }

        private void YellowGreenStarTFRates()
        {
            newStar.StarColorAdjustments = new YellowGreenStar();
        }

        private void LightPurpleStarTFRates()
        {
            newStar.StarColorAdjustments = new LightPurpleStar();
        }
        #endregion

        #region Star Age Harvest Rate Adjustments
        private void NewStarTFRates()
        {
            newStar.StarAgeAdjustments = new BaseNewStar();
        }

        private void YoungStarTFRates()
        {
            newStar.StarAgeAdjustments = new BaseYoungStar();
        }

        private void MidStarTFRates()
        {
            newStar.StarAgeAdjustments = new BaseMidStar();
        }

        private void OldStarTFRates()
        {
            newStar.StarAgeAdjustments = new BaseOldStar();
        }

        private void AncientStarTFRates()
        {
            newStar.StarAgeAdjustments = new BaseAncientStar();
        }
        #endregion

    */
    }
}
