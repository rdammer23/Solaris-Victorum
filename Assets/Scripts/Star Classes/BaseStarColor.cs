using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class BaseStarColor
    {
        private string starName;
        private int starColorID;

        private float tFColorADJGas;
        private float tFColorADJCarbon;
        private float tFColorADJWater;
        private float tFColorADJOrganic;
        private float tFColorADJRock;
        private float tFColorADJWood;
        private float tFColorADJIron;
        private float tFColorADJSilver;
        private float tFColorADJGold;
        private float tFColorADJRuby;
        private float tFColorADJEmerald;
        private float tFColorADJTitanium;
        private float tFColorADJMithril;
        private float tFColorADJLiquidHydrogen;
        private float tFColorADJLiquidOxygen;
        private float tFColorADJLiquidNitrogen;
        private float tFColorADJPlatinum;
        private float tFColorADJDiamond;
        private float tFColorADJRadioactive;
        private float tFColorADJBlackMatter;
        private float tFColorADJRedMatter;
        private float tFColorADJGreyMatter;
        private float tFColorADJWhiteMatter;
        private float tFColorADJMana;

        #region GETS and SETS
        public string StarName
        {
            get
            {
                return starName;
            }

            set
            {
                starName = value;
            }
        }

        public int StarColorID
        {
            get
            {
                return starColorID;
            }

            set
            {
                starColorID = value;
            }
        }

        public float TFColorADJGas
        {
            get
            {
                return tFColorADJGas;
            }

            set
            {
                tFColorADJGas = value;
            }
        }

        public float TFColorADJCarbon
        {
            get
            {
                return tFColorADJCarbon;
            }

            set
            {
                tFColorADJCarbon = value;
            }
        }

        public float TFColorADJWater
        {
            get
            {
                return tFColorADJWater;
            }

            set
            {
                tFColorADJWater = value;
            }
        }

        public float TFColorADJOrganic
        {
            get
            {
                return tFColorADJOrganic;
            }

            set
            {
                tFColorADJOrganic = value;
            }
        }

        public float TFColorADJRock
        {
            get
            {
                return tFColorADJRock;
            }

            set
            {
                tFColorADJRock = value;
            }
        }

        public float TFColorADJWood
        {
            get
            {
                return tFColorADJWood;
            }

            set
            {
                tFColorADJWood = value;
            }
        }

        public float TFColorADJIron
        {
            get
            {
                return tFColorADJIron;
            }

            set
            {
                tFColorADJIron = value;
            }
        }

        public float TFColorADJSilver
        {
            get
            {
                return tFColorADJSilver;
            }

            set
            {
                tFColorADJSilver = value;
            }
        }

        public float TFColorADJGold
        {
            get
            {
                return tFColorADJGold;
            }

            set
            {
                tFColorADJGold = value;
            }
        }

        public float TFColorADJRuby
        {
            get
            {
                return tFColorADJRuby;
            }

            set
            {
                tFColorADJRuby = value;
            }
        }

        public float TFColorADJEmerald
        {
            get
            {
                return tFColorADJEmerald;
            }

            set
            {
                tFColorADJEmerald = value;
            }
        }

        public float TFColorADJTitanium
        {
            get
            {
                return tFColorADJTitanium;
            }

            set
            {
                tFColorADJTitanium = value;
            }
        }

        public float TFColorADJMithril
        {
            get
            {
                return tFColorADJMithril;
            }

            set
            {
                tFColorADJMithril = value;
            }
        }

        public float TFColorADJLiquidHydrogen
        {
            get
            {
                return tFColorADJLiquidHydrogen;
            }

            set
            {
                tFColorADJLiquidHydrogen = value;
            }
        }

        public float TFColorADJLiquidOxygen
        {
            get
            {
                return tFColorADJLiquidOxygen;
            }

            set
            {
                tFColorADJLiquidOxygen = value;
            }
        }

        public float TFColorADJLiquidNitrogen
        {
            get
            {
                return tFColorADJLiquidNitrogen;
            }

            set
            {
                tFColorADJLiquidNitrogen = value;
            }
        }

        public float TFColorADJPlatinum
        {
            get
            {
                return tFColorADJPlatinum;
            }

            set
            {
                tFColorADJPlatinum = value;
            }
        }

        public float TFColorADJDiamond
        {
            get
            {
                return tFColorADJDiamond;
            }

            set
            {
                tFColorADJDiamond = value;
            }
        }

        public float TFColorADJRadioactive
        {
            get
            {
                return tFColorADJRadioactive;
            }

            set
            {
                tFColorADJRadioactive = value;
            }
        }

        public float TFColorADJBlackMatter
        {
            get
            {
                return tFColorADJBlackMatter;
            }

            set
            {
                tFColorADJBlackMatter = value;
            }
        }

        public float TFColorADJRedMatter
        {
            get
            {
                return tFColorADJRedMatter;
            }

            set
            {
                tFColorADJRedMatter = value;
            }
        }

        public float TFColorADJGreyMatter
        {
            get
            {
                return tFColorADJGreyMatter;
            }

            set
            {
                tFColorADJGreyMatter = value;
            }
        }

        public float TFColorADJWhiteMatter
        {
            get
            {
                return tFColorADJWhiteMatter;
            }

            set
            {
                tFColorADJWhiteMatter = value;
            }
        }

        public float TFColorADJMana
        {
            get
            {
                return tFColorADJMana;
            }

            set
            {
                tFColorADJMana = value;
            }
        }
        #endregion
    }
}
