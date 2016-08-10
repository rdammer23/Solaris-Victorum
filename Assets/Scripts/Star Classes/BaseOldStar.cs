using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class BaseOldStar : BaseStarAge
    {
        public BaseOldStar()
        {
            StarAge = 4;

            //Harvest Rate Adjustments
            TFStarAgeADJGas = 0.5f;
            TFStarAgeADJCarbon = 0.5f;
            TFStarAgeADJWater = 0.75f;
            TFStarAgeADJOrganic = 0.75f;
            TFStarAgeADJRock = 1f;
            TFStarAgeADJWood = 1f;
            TFStarAgeADJIron = 1f;
            TFStarAgeADJSilver = 1f;
            TFStarAgeADJGold = 1.75f;
            TFStarAgeADJRuby = 1.75f;
            TFStarAgeADJEmerald = 0.25f;
            TFStarAgeADJTitanium = 0.65f;
            TFStarAgeADJMithril = 1f;
            TFStarAgeADJLiquidHydrogen = 1f;
            TFStarAgeADJLiquidOxygen = 1f;
            TFStarAgeADJLiquidNitrogen = 1.05f;
            TFStarAgeADJPlatinum = 1.1f;
            TFStarAgeADJDiamond = 1.2f;
            TFStarAgeADJRadioactive = 1.25f;
            TFStarAgeADJBlackMatter = 1.5f;
            TFStarAgeADJRedMatter = 0.75f;
            TFStarAgeADJGreyMatter = 1f;
            TFStarAgeADJWhiteMatter = 1.25f;
            TFStarAgeADJMana = 1f;

        }
    }
}
