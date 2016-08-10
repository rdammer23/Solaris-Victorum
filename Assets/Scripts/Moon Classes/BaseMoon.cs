using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Moon_Classes
{
    /*
    Very Similar to planets
    Add Moon Type
    All Sizes Stay Same but are 1/4 the population of planet of same size type

    */

    [System.Serializable]

    class BaseMoon
    {
        private int moonID;
        private int moonPlanetID;
        private int moonSize;
        private int moonDensity;
        private int moonLevel;
        private double moonCurrentTFValue;
        private long moonTFValueNeeded;
        private double moonPopulation;
        private double maxPopulation;
        private int moonOriginalOwnerRace;
        private int moonType;
        private bool moonPlayerOwned;
        private float moonStartLocationX;
        private float moonStartLocationY;
        private float moonStartLocationZ;
        private float populationIncreaseRate;

        private float moonSizeHarvestRateAdjustment;
        private float moonDensityHarvestRateAdjustment;

        public int MoonID
        {
            get
            {
                return moonID;
            }

            set
            {
                moonID = value;
            }
        }

        public int MoonPlanetID
        {
            get
            {
                return moonPlanetID;
            }

            set
            {
                moonPlanetID = value;
            }
        }

        public int MoonSize
        {
            get
            {
                return moonSize;
            }

            set
            {
                moonSize = value;
            }
        }

        public int MoonDensity
        {
            get
            {
                return moonDensity;
            }

            set
            {
                moonDensity = value;
            }
        }

        public int MoonLevel
        {
            get
            {
                return moonLevel;
            }

            set
            {
                moonLevel = value;
            }
        }

        public double MoonCurrentTFValue
        {
            get
            {
                return moonCurrentTFValue;
            }

            set
            {
                moonCurrentTFValue = value;
            }
        }

        public long MoonTFValueNeeded
        {
            get
            {
                return moonTFValueNeeded;
            }

            set
            {
                moonTFValueNeeded = value;
            }
        }

        public double MoonPopulation
        {
            get
            {
                return moonPopulation;
            }

            set
            {
                moonPopulation = value;
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

        public int MoonOriginalOwnerRace
        {
            get
            {
                return moonOriginalOwnerRace;
            }

            set
            {
                moonOriginalOwnerRace = value;
            }
        }

        public int MoonType
        {
            get
            {
                return moonType;
            }

            set
            {
                moonType = value;
            }
        }

        public bool MoonPlayerOwned
        {
            get
            {
                return moonPlayerOwned;
            }

            set
            {
                moonPlayerOwned = value;
            }
        }

        public float MoonStartLocationX
        {
            get
            {
                return moonStartLocationX;
            }

            set
            {
                moonStartLocationX = value;
            }
        }

        public float MoonStartLocationY
        {
            get
            {
                return moonStartLocationY;
            }

            set
            {
                moonStartLocationY = value;
            }
        }

        public float MoonStartLocationZ
        {
            get
            {
                return moonStartLocationZ;
            }

            set
            {
                moonStartLocationZ = value;
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

        public float MoonSizeHarvestRateAdjustment
        {
            get
            {
                return moonSizeHarvestRateAdjustment;
            }

            set
            {
                moonSizeHarvestRateAdjustment = value;
            }
        }

        public float MoonDensityHarvestRateAdjustment
        {
            get
            {
                return moonDensityHarvestRateAdjustment;
            }

            set
            {
                moonDensityHarvestRateAdjustment = value;
            }
        }
    }
}
