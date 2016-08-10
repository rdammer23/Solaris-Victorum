using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class PinkStar : BaseStarColor
    {
        public PinkStar()
        {
            StarName = "Pink Star";
            StarColorID = 9;

            //Harvest Rate Adjustments
            TFColorADJGas = 0.75f;
            TFColorADJCarbon = 2f;
            TFColorADJWater = 0.75f;
            TFColorADJOrganic = 0.75f;
            TFColorADJRock = 0.75f;
            TFColorADJWood = 1f;
            TFColorADJIron = 1f;
            TFColorADJSilver = 1f;
            TFColorADJGold = 1f;
            TFColorADJRuby = 1f;
            TFColorADJEmerald = 1f;
            TFColorADJTitanium = 1f;
            TFColorADJMithril = 2f;
            TFColorADJLiquidHydrogen = 0.75f;
            TFColorADJLiquidOxygen = 0.75f;
            TFColorADJLiquidNitrogen = 0.75f;
            TFColorADJPlatinum = 0.75f;
            TFColorADJDiamond = 1f;
            TFColorADJRadioactive = 1f;
            TFColorADJBlackMatter = 1f;
            TFColorADJRedMatter = 1.25f;
            TFColorADJGreyMatter = 1f;
            TFColorADJWhiteMatter = 1f;
            TFColorADJMana = 0.75f;

        }
    }
}
