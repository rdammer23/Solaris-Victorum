using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]

    class BasePlanet
    {
        private int planetID;
        private int planetSize;
        private int planetDensity;
        private int planetLevel;
        private double planetCurrentTFValue;
        private long planetTFValueNeeded;
        private double planetPopulation;
        private double maxPopulation;
        private int planetOriginalOwnerRace;
        private bool planetPlayerOwned;
        private float planetStartLocationX;
        private float planetStartLocationY;
        private float planetStartLocationZ;
        private float populationIncreaseRate;

        private float planetSizeHarvestRateAdjustment;
        private float planetDensityHarvestRateAdjustment;

        /* Old Variable for Individual Resources
private float harvestRatePlanetGas;
private float harvestRatePlanetCarbon;
private float harvestRatePlanetWater;
private float harvestRatePlanetOrganic;
private float harvestRatePlanetRock;
private float harvestRatePlanetWood;
private float harvestRatePlanetIron;
private float harvestRatePlanetSilver;
private float harvestRatePlanetGold;
private float harvestRatePlanetRuby;
private float harvestRatePlanetEmerald;
private float harvestRatePlanetTitanium;
private float harvestRatePlanetMithril;
private float harvestRatePlanetLiquidHydrogen;
private float harvestRatePlanetLiquidOxygen;
private float harvestRatePlanetLiquidNitrogen;
private float harvestRatePlanetPlatinum;
private float harvestRatePlanetDiamond;
private float harvestRatePlanetRadioactive;
private float harvestRatePlanetBlackMatter;
private float harvestRatePlanetRedMatter;
private float harvestRatePlanetGreyMatter;
private float harvestRatePlanetWhiteMatter;
private float harvestRatePlanetMana;
*/

        #region GETS and SETS
        public int PlanetID
        {
            get
            {
                return planetID;
            }

            set
            {
                planetID = value;
            }
        }

        public int PlanetSize
        {
            get
            {
                return planetSize;
            }

            set
            {
                planetSize = value;
            }
        }

        public int PlanetDensity
        {
            get
            {
                return planetDensity;
            }

            set
            {
                planetDensity = value;
            }
        }

        public int PlanetLevel
        {
            get
            {
                return planetLevel;
            }

            set
            {
                planetLevel = value;
            }
        }

        public double PlanetCurrentTFValue
        {
            get
            {
                return planetCurrentTFValue;
            }

            set
            {
                planetCurrentTFValue = value;
            }
        }

        public long PlanetTFValueNeeded
        {
            get
            {
                return planetTFValueNeeded;
            }

            set
            {
                planetTFValueNeeded = value;
            }
        }

        public double PlanetPopulation
        {
            get
            {
                return planetPopulation;
            }

            set
            {
                planetPopulation = value;
            }
        }

        public double MaxPopulation
        {
            get
            {
                return maxPopulation;
            }

            set
            {
                maxPopulation = value;
            }
        }

        public int PlanetOriginalOwnerRace
        {
            get
            {
                return planetOriginalOwnerRace;
            }

            set
            {
                planetOriginalOwnerRace = value;
            }
        }

        public bool PlanetPlayerOwned
        {
            get
            {
                return planetPlayerOwned;
            }

            set
            {
                planetPlayerOwned = value;
            }
        }

        public float PlanetStartLocationX
        {
            get
            {
                return planetStartLocationX;
            }

            set
            {
                planetStartLocationX = value;
            }
        }

        public float PlanetStartLocationY
        {
            get
            {
                return planetStartLocationY;
            }

            set
            {
                planetStartLocationY = value;
            }
        }

        public float PlanetStartLocationZ
        {
            get
            {
                return planetStartLocationZ;
            }

            set
            {
                planetStartLocationZ = value;
            }
        }

        public float PopulationIncreaseRate
        {
            get
            {
                return populationIncreaseRate;
            }

            set
            {
                populationIncreaseRate = value;
            }
        }

        public float PlanetSizeHarvestRateAdjustment
        {
            get
            {
                return planetSizeHarvestRateAdjustment;
            }

            set
            {
                planetSizeHarvestRateAdjustment = value;
            }
        }

        public float PlanetDensityHarvestRateAdjustment
        {
            get
            {
                return planetDensityHarvestRateAdjustment;
            }

            set
            {
                planetDensityHarvestRateAdjustment = value;
            }
        }
        #endregion
    }
}
