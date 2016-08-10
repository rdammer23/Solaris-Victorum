using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class DensityHighestPlanet:BasePlanet
    {
        public DensityHighestPlanet()
        {
            PlanetDensityHarvestRateAdjustment = 2.0f;
        }

        public float PlanetDensityHR()
        {
            return 2.0f;
        }
    }
}
