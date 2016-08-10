using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class RedStar:BaseStarColor
    {
        public RedStar()
        {
            StarName = "Red Star";
            StarColorID = 2;

            //Harvest Rate Adjustments
            TFColorADJGas = 1f;
            TFColorADJCarbon = 0.75f;
            TFColorADJWater = 1f;
            TFColorADJOrganic = 0.75f;
            TFColorADJRock = 2f;
            TFColorADJWood = 1f;
            TFColorADJIron = 1.5f;
            TFColorADJSilver = 0.75f;
            TFColorADJGold = 0.75f;
            TFColorADJRuby = 0.5f;
            TFColorADJEmerald = 1.75f;
            TFColorADJTitanium = 1.5f;
            TFColorADJMithril = 1.25f;
            TFColorADJLiquidHydrogen = 1f;
            TFColorADJLiquidOxygen = 1f;
            TFColorADJLiquidNitrogen = 1f;
            TFColorADJPlatinum = 1f;
            TFColorADJDiamond = 0.75f;
            TFColorADJRadioactive = 0.5f;
            TFColorADJBlackMatter = 0.25f;
            TFColorADJRedMatter = 1.5f;
            TFColorADJGreyMatter = 1f;
            TFColorADJWhiteMatter = 1f;
            TFColorADJMana = 0.5f;

        }
    }
}
