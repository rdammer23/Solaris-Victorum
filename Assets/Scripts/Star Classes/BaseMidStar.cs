using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class BaseMidStar : BaseStarAge
    {
        public BaseMidStar()
        {
            StarAge = 3;

            //Harvest Rate Adjustments
            TFStarAgeADJGas = 1f;
            TFStarAgeADJCarbon = 1f;
            TFStarAgeADJWater = 1f;
            TFStarAgeADJOrganic = 1f;
            TFStarAgeADJRock = 1f;
            TFStarAgeADJWood = 1f;
            TFStarAgeADJIron = 1f;
            TFStarAgeADJSilver = 1f;
            TFStarAgeADJGold = 1f;
            TFStarAgeADJRuby = 1f;
            TFStarAgeADJEmerald = 1f;
            TFStarAgeADJTitanium = 1f;
            TFStarAgeADJMithril = 1f;
            TFStarAgeADJLiquidHydrogen = 1f;
            TFStarAgeADJLiquidOxygen = 1f;
            TFStarAgeADJLiquidNitrogen = 1f;
            TFStarAgeADJPlatinum = 1f;
            TFStarAgeADJDiamond = 1f;
            TFStarAgeADJRadioactive = 1f;
            TFStarAgeADJBlackMatter = 1f;
            TFStarAgeADJRedMatter = 1f;
            TFStarAgeADJGreyMatter = 1f;
            TFStarAgeADJWhiteMatter = 1f;
            TFStarAgeADJMana = 1f;

        }
    }
}
