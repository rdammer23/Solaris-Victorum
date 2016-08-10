using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class YellowStar:BaseStarColor
    {
        public YellowStar()
        {
            StarName = "Yellow Star";
            StarColorID = 1;

            //Harvest Rate Adjustments
            TFColorADJGas = 1f;
            TFColorADJCarbon = 1f;
            TFColorADJWater = 1f;
            TFColorADJOrganic = 2f;
            TFColorADJRock = 1f;
            TFColorADJWood = 1f;
            TFColorADJIron = 0.75f;
            TFColorADJSilver = 0.75f;
            TFColorADJGold = 0.75f;
            TFColorADJRuby = 0.75f;
            TFColorADJEmerald = 1.9f;
            TFColorADJTitanium = 1.75f;
            TFColorADJMithril = 1.5f;
            TFColorADJLiquidHydrogen = 1.25f;
            TFColorADJLiquidOxygen = 1f;
            TFColorADJLiquidNitrogen = 1f;
            TFColorADJPlatinum = 0.75f;
            TFColorADJDiamond = 0.5f;
            TFColorADJRadioactive = 0.25f;
            TFColorADJBlackMatter = 0.1f;
            TFColorADJRedMatter = 2f;
            TFColorADJGreyMatter = 0.75f;
            TFColorADJWhiteMatter = 0.75f;
            TFColorADJMana = 0.5f;
        }
    }
}
