using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]

    class BaseStarAge
    {
        private int starAge;

        private float tFStarAgeADJGas;
        private float tFStarAgeADJCarbon;
        private float tFStarAgeADJWater;
        private float tFStarAgeADJOrganic;
        private float tFStarAgeADJRock;
        private float tFStarAgeADJWood;
        private float tFStarAgeADJIron;
        private float tFStarAgeADJSilver;
        private float tFStarAgeADJGold;
        private float tFStarAgeADJRuby;
        private float tFStarAgeADJEmerald;
        private float tFStarAgeADJTitanium;
        private float tFStarAgeADJMithril;
        private float tFStarAgeADJLiquidHydrogen;
        private float tFStarAgeADJLiquidOxygen;
        private float tFStarAgeADJLiquidNitrogen;
        private float tFStarAgeADJPlatinum;
        private float tFStarAgeADJDiamond;
        private float tFStarAgeADJRadioactive;
        private float tFStarAgeADJBlackMatter;
        private float tFStarAgeADJRedMatter;
        private float tFStarAgeADJGreyMatter;
        private float tFStarAgeADJWhiteMatter;
        private float tFStarAgeADJMana;

        #region GETS and SETS
        public int StarAge
        {
            get
            {
                return starAge;
            }

            set
            {
                starAge = value;
            }
        }

        public float TFStarAgeADJGas
        {
            get
            {
                return tFStarAgeADJGas;
            }

            set
            {
                tFStarAgeADJGas = value;
            }
        }

        public float TFStarAgeADJCarbon
        {
            get
            {
                return tFStarAgeADJCarbon;
            }

            set
            {
                tFStarAgeADJCarbon = value;
            }
        }

        public float TFStarAgeADJWater
        {
            get
            {
                return tFStarAgeADJWater;
            }

            set
            {
                tFStarAgeADJWater = value;
            }
        }

        public float TFStarAgeADJOrganic
        {
            get
            {
                return tFStarAgeADJOrganic;
            }

            set
            {
                tFStarAgeADJOrganic = value;
            }
        }

        public float TFStarAgeADJRock
        {
            get
            {
                return tFStarAgeADJRock;
            }

            set
            {
                tFStarAgeADJRock = value;
            }
        }

        public float TFStarAgeADJWood
        {
            get
            {
                return tFStarAgeADJWood;
            }

            set
            {
                tFStarAgeADJWood = value;
            }
        }

        public float TFStarAgeADJIron
        {
            get
            {
                return tFStarAgeADJIron;
            }

            set
            {
                tFStarAgeADJIron = value;
            }
        }

        public float TFStarAgeADJSilver
        {
            get
            {
                return tFStarAgeADJSilver;
            }

            set
            {
                tFStarAgeADJSilver = value;
            }
        }

        public float TFStarAgeADJGold
        {
            get
            {
                return tFStarAgeADJGold;
            }

            set
            {
                tFStarAgeADJGold = value;
            }
        }

        public float TFStarAgeADJRuby
        {
            get
            {
                return tFStarAgeADJRuby;
            }

            set
            {
                tFStarAgeADJRuby = value;
            }
        }

        public float TFStarAgeADJEmerald
        {
            get
            {
                return tFStarAgeADJEmerald;
            }

            set
            {
                tFStarAgeADJEmerald = value;
            }
        }

        public float TFStarAgeADJTitanium
        {
            get
            {
                return tFStarAgeADJTitanium;
            }

            set
            {
                tFStarAgeADJTitanium = value;
            }
        }

        public float TFStarAgeADJMithril
        {
            get
            {
                return tFStarAgeADJMithril;
            }

            set
            {
                tFStarAgeADJMithril = value;
            }
        }

        public float TFStarAgeADJLiquidHydrogen
        {
            get
            {
                return tFStarAgeADJLiquidHydrogen;
            }

            set
            {
                tFStarAgeADJLiquidHydrogen = value;
            }
        }

        public float TFStarAgeADJLiquidOxygen
        {
            get
            {
                return tFStarAgeADJLiquidOxygen;
            }

            set
            {
                tFStarAgeADJLiquidOxygen = value;
            }
        }

        public float TFStarAgeADJLiquidNitrogen
        {
            get
            {
                return tFStarAgeADJLiquidNitrogen;
            }

            set
            {
                tFStarAgeADJLiquidNitrogen = value;
            }
        }

        public float TFStarAgeADJPlatinum
        {
            get
            {
                return tFStarAgeADJPlatinum;
            }

            set
            {
                tFStarAgeADJPlatinum = value;
            }
        }

        public float TFStarAgeADJDiamond
        {
            get
            {
                return tFStarAgeADJDiamond;
            }

            set
            {
                tFStarAgeADJDiamond = value;
            }
        }

        public float TFStarAgeADJRadioactive
        {
            get
            {
                return tFStarAgeADJRadioactive;
            }

            set
            {
                tFStarAgeADJRadioactive = value;
            }
        }

        public float TFStarAgeADJBlackMatter
        {
            get
            {
                return tFStarAgeADJBlackMatter;
            }

            set
            {
                tFStarAgeADJBlackMatter = value;
            }
        }

        public float TFStarAgeADJRedMatter
        {
            get
            {
                return tFStarAgeADJRedMatter;
            }

            set
            {
                tFStarAgeADJRedMatter = value;
            }
        }

        public float TFStarAgeADJGreyMatter
        {
            get
            {
                return tFStarAgeADJGreyMatter;
            }

            set
            {
                tFStarAgeADJGreyMatter = value;
            }
        }

        public float TFStarAgeADJWhiteMatter
        {
            get
            {
                return tFStarAgeADJWhiteMatter;
            }

            set
            {
                tFStarAgeADJWhiteMatter = value;
            }
        }

        public float TFStarAgeADJMana
        {
            get
            {
                return tFStarAgeADJMana;
            }

            set
            {
                tFStarAgeADJMana = value;
            }
        }
        #endregion
    }
}
