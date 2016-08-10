using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class BlueStar:BaseStarColor
    {
        public BlueStar()
        {
            StarName = "Blue Star";
            StarColorID = 6;

            //Harvest Rate Adjustments
            TFColorADJGas = 1f;
            TFColorADJCarbon = 0.75f;
            TFColorADJWater = 2f;
            TFColorADJOrganic = 0.75f;
            TFColorADJRock = 0.75f;
            TFColorADJWood = 0.75f;
            TFColorADJIron = 0.5f;
            TFColorADJSilver = 1f;
            TFColorADJGold = 1.5f;
            TFColorADJRuby = 1f;
            TFColorADJEmerald = 0.1f;
            TFColorADJTitanium = 0.25f;
            TFColorADJMithril = 0.5f;
            TFColorADJLiquidHydrogen = 0.75f;
            TFColorADJLiquidOxygen = 1f;
            TFColorADJLiquidNitrogen = 1f;
            TFColorADJPlatinum = 1.25f;
            TFColorADJDiamond = 1.5f;
            TFColorADJRadioactive = 1.75f;
            TFColorADJBlackMatter = 1.9f;
            TFColorADJRedMatter = 0.5f;
            TFColorADJGreyMatter = 0.75f;
            TFColorADJWhiteMatter = 0.75f;
            TFColorADJMana = 2f;

        }
    }
}
