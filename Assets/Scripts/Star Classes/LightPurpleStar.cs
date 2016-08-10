using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class LightPurpleStar : BaseStarColor
    {
        public LightPurpleStar()
        {
            StarName = "Light Purple Star";
            StarColorID = 11;

            //Harvest Rate Adjustments
            TFColorADJGas = 1f;
            TFColorADJCarbon = 1f;
            TFColorADJWater = 1f;
            TFColorADJOrganic = 1f;
            TFColorADJRock = 0.75f;
            TFColorADJWood = 0.75f;
            TFColorADJIron = 2f;
            TFColorADJSilver = 0.75f;
            TFColorADJGold = 0.75f;
            TFColorADJRuby = 1f;
            TFColorADJEmerald = 1f;
            TFColorADJTitanium = 2f;
            TFColorADJMithril = 0.75f;
            TFColorADJLiquidHydrogen = 0.75f;
            TFColorADJLiquidOxygen = 0.75f;
            TFColorADJLiquidNitrogen = 0.75f;
            TFColorADJPlatinum = 1f;
            TFColorADJDiamond = 1f;
            TFColorADJRadioactive = 1f;
            TFColorADJBlackMatter = 1f;
            TFColorADJRedMatter = 1f;
            TFColorADJGreyMatter = 1f;
            TFColorADJWhiteMatter = 1.75f;
            TFColorADJMana = 0.25f;

        }
    }
}
