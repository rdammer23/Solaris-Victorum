using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class BrightRedStar : BaseStarColor
    {
        public BrightRedStar()
        {
            StarName = "Bright Red Star";
            StarColorID = 8;

            //Harvest Rate Adjustments
            TFColorADJGas = 1f;
            TFColorADJCarbon = 1f;
            TFColorADJWater = 1f;
            TFColorADJOrganic = 1f;
            TFColorADJRock = 1f;
            TFColorADJWood = 0.75f;
            TFColorADJIron = 0.75f;
            TFColorADJSilver = 2f;
            TFColorADJGold = 0.75f;
            TFColorADJRuby = 0.75f;
            TFColorADJEmerald = 1f;
            TFColorADJTitanium = 1f;
            TFColorADJMithril = 1f;
            TFColorADJLiquidHydrogen = 1f;
            TFColorADJLiquidOxygen = 1f;
            TFColorADJLiquidNitrogen = 0.75f;
            TFColorADJPlatinum = 2f;
            TFColorADJDiamond = 0.75f;
            TFColorADJRadioactive = 0.75f;
            TFColorADJBlackMatter = 0.75f;
            TFColorADJRedMatter = 1f;
            TFColorADJGreyMatter = 1f;
            TFColorADJWhiteMatter = 0.75f;
            TFColorADJMana = 1.25f;

        }
    }
}
