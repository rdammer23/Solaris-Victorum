using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class GreenStar:BaseStarColor
    {
        public GreenStar()
        {
            StarName = "Green Star";
            StarColorID = 4;

            //Harvest Rate Adjustments
            TFColorADJGas = 2f;
            TFColorADJCarbon = 1f;
            TFColorADJWater = 1f;
            TFColorADJOrganic = 1f;
            TFColorADJRock = 0.75f;
            TFColorADJWood = 0.5f;
            TFColorADJIron = 1f;
            TFColorADJSilver = 1f;
            TFColorADJGold = 1f;
            TFColorADJRuby = 0.75f;
            TFColorADJEmerald = 0.5f;
            TFColorADJTitanium = 0.75f;
            TFColorADJMithril = 1f;
            TFColorADJLiquidHydrogen = 1f;
            TFColorADJLiquidOxygen = 1f;
            TFColorADJLiquidNitrogen = 1f;
            TFColorADJPlatinum = 1f;
            TFColorADJDiamond = 1f;
            TFColorADJRadioactive = 1.25f;
            TFColorADJBlackMatter = 1.5f;
            TFColorADJRedMatter = 0.75f;
            TFColorADJGreyMatter = 1f;
            TFColorADJWhiteMatter = 1.25f;
            TFColorADJMana = 1f;

        }
    }
}
