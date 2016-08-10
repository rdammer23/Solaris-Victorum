using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class BaseNewStar:BaseStarAge
    {
        public BaseNewStar()
        {
            StarAge = 1;

            //Harvest Rate Adjustments
            TFStarAgeADJGas = 2f;
            TFStarAgeADJCarbon = 2f;
            TFStarAgeADJWater = 1f;
            TFStarAgeADJOrganic = 1f;
            TFStarAgeADJRock = 1f;
            TFStarAgeADJWood = 1f;
            TFStarAgeADJIron = 0.5f;
            TFStarAgeADJSilver = 0.5f;
            TFStarAgeADJGold = 0.5f;
            TFStarAgeADJRuby = 0.5f;
            TFStarAgeADJEmerald = 1.75f;
            TFStarAgeADJTitanium = 1.5f;
            TFStarAgeADJMithril = 1.25f;
            TFStarAgeADJLiquidHydrogen = 1.15f;
            TFStarAgeADJLiquidOxygen = 1f;
            TFStarAgeADJLiquidNitrogen = 1f;
            TFStarAgeADJPlatinum = 1f;
            TFStarAgeADJDiamond = 0.75f;
            TFStarAgeADJRadioactive = 0.5f;
            TFStarAgeADJBlackMatter = 0.1f;
            TFStarAgeADJRedMatter = 1.25f;
            TFStarAgeADJGreyMatter = 1.25f;
            TFStarAgeADJWhiteMatter = 0.75f;
            TFStarAgeADJMana = 0.75f;

        }
    }
}
