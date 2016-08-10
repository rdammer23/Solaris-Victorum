using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class YellowGreenStar : BaseStarColor
    {
        public YellowGreenStar()
        {
            StarName = "Yellow Green Star";
            StarColorID = 10;

            //Harvest Rate Adjustments
            TFColorADJGas = 0.75f;
            TFColorADJCarbon = 0.75f;
            TFColorADJWater = 2f;
            TFColorADJOrganic = 0.75f;
            TFColorADJRock = 0.75f;
            TFColorADJWood = 1f;
            TFColorADJIron = 1f;
            TFColorADJSilver = 1f;
            TFColorADJGold = 1f;
            TFColorADJRuby = 1f;
            TFColorADJEmerald = 1f;
            TFColorADJTitanium = 1f;
            TFColorADJMithril = 1f;
            TFColorADJLiquidHydrogen = 1f;
            TFColorADJLiquidOxygen = 1f;
            TFColorADJLiquidNitrogen = 2f;
            TFColorADJPlatinum = 0.75f;
            TFColorADJDiamond = 0.75f;
            TFColorADJRadioactive = 0.75f;
            TFColorADJBlackMatter = 0.75f;
            TFColorADJRedMatter = 1.75f;
            TFColorADJGreyMatter = 0.25f;
            TFColorADJWhiteMatter = 1f;
            TFColorADJMana = 1f;

        }
    }
}
