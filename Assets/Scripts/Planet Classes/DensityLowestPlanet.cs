using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class DensityLowestPlanet : BasePlanet
    {
        public DensityLowestPlanet()
        {
            PlanetDensityHarvestRateAdjustment = .5f;
        }

        public float PlanetDensityHR()
        {
            return .5f;
        }
    }
}
