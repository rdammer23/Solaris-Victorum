using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class PurpleStar : BaseStarColor
    {
        public PurpleStar()
        {
            StarName = "Purple Star";
            StarColorID = 7;

            //Harvest Rate Adjustments
            TFColorADJGas = 1f;
            TFColorADJCarbon = 1f;
            TFColorADJWater = 1f;
            TFColorADJOrganic = 1f;
            TFColorADJRock = 1f;
            TFColorADJWood = 0.75f;
            TFColorADJIron = 0.75f;
            TFColorADJSilver = 0.75f;
            TFColorADJGold = 0.75f;
            TFColorADJRuby = 2f;
            TFColorADJEmerald = 1f;
            TFColorADJTitanium = 1f;
            TFColorADJMithril = 1f;
            TFColorADJLiquidHydrogen = 1f;
            TFColorADJLiquidOxygen = 1f;
            TFColorADJLiquidNitrogen = 0.75f;
            TFColorADJPlatinum = 0.75f;
            TFColorADJDiamond = 0.75f;
            TFColorADJRadioactive = 0.75f;
            TFColorADJBlackMatter = 2f;
            TFColorADJRedMatter = 1f;
            TFColorADJGreyMatter = 0.75f;
            TFColorADJWhiteMatter = 1.25f;
            TFColorADJMana = 1f;

        }
    }
}
