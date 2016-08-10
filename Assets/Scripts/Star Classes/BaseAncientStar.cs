using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class BaseAncientStar : BaseStarAge
    {
        public BaseAncientStar()
        {
            StarAge = 5;

            //Harvest Rate Adjustments
            TFStarAgeADJGas = 0.5f;
            TFStarAgeADJCarbon = 0.5f;
            TFStarAgeADJWater = 0.5f;
            TFStarAgeADJOrganic = 0.5f;
            TFStarAgeADJRock = 1f;
            TFStarAgeADJWood = 1f;
            TFStarAgeADJIron = 1f;
            TFStarAgeADJSilver = 1f;
            TFStarAgeADJGold = 2f;
            TFStarAgeADJRuby = 2f;
            TFStarAgeADJEmerald = 0.1f;
            TFStarAgeADJTitanium = 0.5f;
            TFStarAgeADJMithril = 0.75f;
            TFStarAgeADJLiquidHydrogen = 1f;
            TFStarAgeADJLiquidOxygen = 1f;
            TFStarAgeADJLiquidNitrogen = 1f;
            TFStarAgeADJPlatinum = 1.15f;
            TFStarAgeADJDiamond = 1.25f;
            TFStarAgeADJRadioactive = 1.5f;
            TFStarAgeADJBlackMatter = 1.75f;
            TFStarAgeADJRedMatter = 0.75f;
            TFStarAgeADJGreyMatter = 0.75f;
            TFStarAgeADJWhiteMatter = 1f;
            TFStarAgeADJMana = 1.5f;

        }
    }
}
