using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Star_Classes
{
    [System.Serializable]
    class BaseStar
    {
        private string starName;
        private BaseStarColor starColorAdjustments;
        private BaseStarAge starAgeAdjustments;

        private float harvestRateStarGas;
        private float harvestRateStarCarbon;
        private float harvestRateStarWater;
        private float harvestRateStarOrganic;
        private float harvestRateStarRock;
        private float harvestRateStarWood;
        private float harvestRateStarIron;
        private float harvestRateStarSilver;
        private float harvestRateStarGold;
        private float harvestRateStarRuby;
        private float harvestRateStarEmerald;
        private float harvestRateStarTitanium;
        private float harvestRateStarMithril;
        private float harvestRateStarLiquidHydrogen;
        private float harvestRateStarLiquidOxygen;
        private float harvestRateStarLiquidNitrogen;
        private float harvestRateStarPlatinum;
        private float harvestRateStarDiamond;
        private float harvestRateStarRadioactive;
        private float harvestRateStarBlackMatter;
        private float harvestRateStarRedMatter;
        private float harvestRateStarGreyMatter;
        private float harvestRateStarWhiteMatter;
        private float harvestRateStarMana;


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

        internal BaseStarColor StarColorAdjustments
        {
            get
            {
                return starColorAdjustments;
            }

            set
            {
                starColorAdjustments = value;
            }
        }

        internal BaseStarAge StarAgeAdjustments
        {
            get
            {
                return starAgeAdjustments;
            }

            set
            {
                starAgeAdjustments = value;
            }
        }

        public float HarvestRateStarGas
        {
            get
            {
                return harvestRateStarGas;
            }

            set
            {
                harvestRateStarGas = value;
            }
        }

        public float HarvestRateStarCarbon
        {
            get
            {
                return harvestRateStarCarbon;
            }

            set
            {
                harvestRateStarCarbon = value;
            }
        }

        public float HarvestRateStarWater
        {
            get
            {
                return harvestRateStarWater;
            }

            set
            {
                harvestRateStarWater = value;
            }
        }

        public float HarvestRateStarOrganic
        {
            get
            {
                return harvestRateStarOrganic;
            }

            set
            {
                harvestRateStarOrganic = value;
            }
        }

        public float HarvestRateStarRock
        {
            get
            {
                return harvestRateStarRock;
            }

            set
            {
                harvestRateStarRock = value;
            }
        }

        public float HarvestRateStarWood
        {
            get
            {
                return harvestRateStarWood;
            }

            set
            {
                harvestRateStarWood = value;
            }
        }

        public float HarvestRateStarIron
        {
            get
            {
                return harvestRateStarIron;
            }

            set
            {
                harvestRateStarIron = value;
            }
        }

        public float HarvestRateStarSilver
        {
            get
            {
                return harvestRateStarSilver;
            }

            set
            {
                harvestRateStarSilver = value;
            }
        }

        public float HarvestRateStarGold
        {
            get
            {
                return harvestRateStarGold;
            }

            set
            {
                harvestRateStarGold = value;
            }
        }

        public float HarvestRateStarRuby
        {
            get
            {
                return harvestRateStarRuby;
            }

            set
            {
                harvestRateStarRuby = value;
            }
        }

        public float HarvestRateStarEmerald
        {
            get
            {
                return harvestRateStarEmerald;
            }

            set
            {
                harvestRateStarEmerald = value;
            }
        }

        public float HarvestRateStarTitanium
        {
            get
            {
                return harvestRateStarTitanium;
            }

            set
            {
                harvestRateStarTitanium = value;
            }
        }

        public float HarvestRateStarMithril
        {
            get
            {
                return harvestRateStarMithril;
            }

            set
            {
                harvestRateStarMithril = value;
            }
        }

        public float HarvestRateStarLiquidHydrogen
        {
            get
            {
                return harvestRateStarLiquidHydrogen;
            }

            set
            {
                harvestRateStarLiquidHydrogen = value;
            }
        }

        public float HarvestRateStarLiquidOxygen
        {
            get
            {
                return harvestRateStarLiquidOxygen;
            }

            set
            {
                harvestRateStarLiquidOxygen = value;
            }
        }

        public float HarvestRateStarLiquidNitrogen
        {
            get
            {
                return harvestRateStarLiquidNitrogen;
            }

            set
            {
                harvestRateStarLiquidNitrogen = value;
            }
        }

        public float HarvestRateStarPlatinum
        {
            get
            {
                return harvestRateStarPlatinum;
            }

            set
            {
                harvestRateStarPlatinum = value;
            }
        }

        public float HarvestRateStarDiamond
        {
            get
            {
                return harvestRateStarDiamond;
            }

            set
            {
                harvestRateStarDiamond = value;
            }
        }

        public float HarvestRateStarRadioactive
        {
            get
            {
                return harvestRateStarRadioactive;
            }

            set
            {
                harvestRateStarRadioactive = value;
            }
        }

        public float HarvestRateStarBlackMatter
        {
            get
            {
                return harvestRateStarBlackMatter;
            }

            set
            {
                harvestRateStarBlackMatter = value;
            }
        }

        public float HarvestRateStarRedMatter
        {
            get
            {
                return harvestRateStarRedMatter;
            }

            set
            {
                harvestRateStarRedMatter = value;
            }
        }

        public float HarvestRateStarGreyMatter
        {
            get
            {
                return harvestRateStarGreyMatter;
            }

            set
            {
                harvestRateStarGreyMatter = value;
            }
        }

        public float HarvestRateStarWhiteMatter
        {
            get
            {
                return harvestRateStarWhiteMatter;
            }

            set
            {
                harvestRateStarWhiteMatter = value;
            }
        }

        public float HarvestRateStarMana
        {
            get
            {
                return harvestRateStarMana;
            }

            set
            {
                harvestRateStarMana = value;
            }
        }
        #endregion
    }
}
