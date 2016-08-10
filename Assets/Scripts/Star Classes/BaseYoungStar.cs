using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class BaseYoungStar : BaseStarAge
    {
        public BaseYoungStar()
        {
            StarAge = 2;

            //Harvest Rate Adjustments
            TFStarAgeADJGas = 1.75f;
            TFStarAgeADJCarbon = 1.75f;
            TFStarAgeADJWater = 1f;
            TFStarAgeADJOrganic = 1f;
            TFStarAgeADJRock = 1f;
            TFStarAgeADJWood = 1f;
            TFStarAgeADJIron = 0.75f;
            TFStarAgeADJSilver = 0.75f;
            TFStarAgeADJGold = 0.5f;
            TFStarAgeADJRuby = 0.5f;
            TFStarAgeADJEmerald = 1.5f;
            TFStarAgeADJTitanium = 1.25f;
            TFStarAgeADJMithril = 1.2f;
            TFStarAgeADJLiquidHydrogen = 1.1f;
            TFStarAgeADJLiquidOxygen = 1.05f;
            TFStarAgeADJLiquidNitrogen = 1f;
            TFStarAgeADJPlatinum = 1f;
            TFStarAgeADJDiamond = 1f;
            TFStarAgeADJRadioactive = 0.65f;
            TFStarAgeADJBlackMatter = 0.25f;
            TFStarAgeADJRedMatter = 1.25f;
            TFStarAgeADJGreyMatter = 1f;
            TFStarAgeADJWhiteMatter = 1f;
            TFStarAgeADJMana = 0.75f;

        }
    }
}
