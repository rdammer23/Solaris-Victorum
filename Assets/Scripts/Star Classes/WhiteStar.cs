using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class WhiteStar:BaseStarColor
    {
        public WhiteStar()
        {
            StarName = "White Star";
            StarColorID = 5;

            //Harvest Rate Adjustments
            TFColorADJGas = 0.75f;
            TFColorADJCarbon = 2f;
            TFColorADJWater = 0.75f;
            TFColorADJOrganic = 1f;
            TFColorADJRock = 1f;
            TFColorADJWood = 0.75f;
            TFColorADJIron = 0.75f;
            TFColorADJSilver = 1.5f;
            TFColorADJGold = 0.75f;
            TFColorADJRuby = 0.75f;
            TFColorADJEmerald = 0.25f;
            TFColorADJTitanium = 0.5f;
            TFColorADJMithril = 0.75f;
            TFColorADJLiquidHydrogen = 1f;
            TFColorADJLiquidOxygen = 1f;
            TFColorADJLiquidNitrogen = 1f;
            TFColorADJPlatinum = 1f;
            TFColorADJDiamond = 1.25f;
            TFColorADJRadioactive = 1.5f;
            TFColorADJBlackMatter = 1.75f;
            TFColorADJRedMatter = 0.5f;
            TFColorADJGreyMatter = 1f;
            TFColorADJWhiteMatter = 1f;
            TFColorADJMana = 1.5f;

        }
    }
}
