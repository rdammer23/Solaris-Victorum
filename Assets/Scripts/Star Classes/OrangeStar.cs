using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class OrangeStar:BaseStarColor
    {
        public OrangeStar()
        {
            StarName = "Orange Star";
            StarColorID = 3;

            //Harvest Rate Adjustments
            TFColorADJGas = 0.5f;
            TFColorADJCarbon = 0.75f;
            TFColorADJWater = 0.75f;
            TFColorADJOrganic = 0.75f;
            TFColorADJRock = 0.75f;
            TFColorADJWood = 2f;
            TFColorADJIron = 1f;
            TFColorADJSilver = 1f;
            TFColorADJGold = 1f;
            TFColorADJRuby = 1.5f;
            TFColorADJEmerald = 1.5f;
            TFColorADJTitanium = 1.25f;
            TFColorADJMithril = 1f;
            TFColorADJLiquidHydrogen = 1f;
            TFColorADJLiquidOxygen = 1f;
            TFColorADJLiquidNitrogen = 1f;
            TFColorADJPlatinum = 1f;
            TFColorADJDiamond = 1f;
            TFColorADJRadioactive = 0.75f;
            TFColorADJBlackMatter = 0.5f;
            TFColorADJRedMatter = 1f;
            TFColorADJGreyMatter = 1.25f;
            TFColorADJWhiteMatter = 1f;
            TFColorADJMana = 0.75f;

        }
    }
}
